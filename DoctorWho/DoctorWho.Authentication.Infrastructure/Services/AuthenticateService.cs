using AutoMapper;
using DoctorWho.Authentication.Db.Models;
using DoctorWho.Authentication.Infrastructure.Enumeration;
using DoctorWho.Authentication.Infrastructure.Models;
using DoctorWho.Authentication.Infrastructure.Repositories;
using DoctorWho.Notification.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DoctorWho.Authentication.Infrastructure.Services
{
    public class AuthenticateService : IAuthenticateService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IConfiguration _configuration;
        private readonly IApplicationUserRepository _authenticateHelpers;
        private readonly IMapper _mapper;
        private readonly IEmailSenderService _emailSenderService;

        public AuthenticateService(UserManager<ApplicationUser> userManager,
            IConfiguration configuration,
            IMapper mapper,
            IApplicationUserRepository authenticateHelpers,
            IEmailSenderService emailSenderService)
        {
            _userManager = userManager ??
                throw new ArgumentNullException(nameof(userManager));

            _configuration = configuration ??
                throw new ArgumentNullException(nameof(configuration));

            _authenticateHelpers = authenticateHelpers ??
                throw new ArgumentNullException(nameof(authenticateHelpers));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));

            _emailSenderService = emailSenderService ??
                throw new ArgumentNullException(nameof(emailSenderService));
        }

        /// <summary>
        /// Register new normal user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<Response> RegisterUser(UserForCreationDto user)
        {
            var userToRegister = _mapper.Map<ApplicationUser>(user);

            var creationUserResult = await _userManager.CreateAsync(userToRegister, user.Password);

            if (!creationUserResult.Succeeded)
            {

                return new Response(StatusCodes.Status400BadRequest, creationUserResult.Errors.ElementAt(0).Description);
            }

            await _authenticateHelpers.AddRoleToUser(userToRegister, UserRoles.User);

            var userCreated = await _userManager.FindByEmailAsync(userToRegister.Email);

            var emailConfirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(userCreated);
            var encodedEmailConfirmationToken = HttpUtility.UrlEncode(emailConfirmationToken);

            await _emailSenderService.SendEmailAsync(userToRegister.Email,
                "Confirm Your Email Address",
                $"http://localhost:25785/api/auth/confirmEmail?token={encodedEmailConfirmationToken}&email={user.Email}",
                false);

            return new Response(StatusCodes.Status201Created, "User creation process done successfully");
        }

        /// <summary>
        /// Register admin
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<Response> RegisterAdmin(UserForCreationDto user)
        {
            var userToRegister = _mapper.Map<ApplicationUser>(user);

            var creationUserResult = await _userManager.CreateAsync(userToRegister, user.Password);

            if (!creationUserResult.Succeeded)
            {

                return new Response(StatusCodes.Status400BadRequest, creationUserResult.Errors.ElementAt(0).Description);
            }

            await _authenticateHelpers.AddRoleToUser(userToRegister, UserRoles.User);
            await _authenticateHelpers.AddRoleToUser(userToRegister, UserRoles.Admin);

            return new Response(StatusCodes.Status201Created, "Admin creation process done successfully");
        }

        /// <summary>
        /// Login users with different roles 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public async Task<SuccessfullLoginResponse> Login(UserForLoginDto user)
        {
            var userFromDb = await _userManager.FindByNameAsync(user.Username);

            var userRoles = await _userManager.GetRolesAsync(userFromDb);

            var authClaims = new List<Claim>
            {
                new Claim("Id", userFromDb.Id),
                new Claim(ClaimTypes.Name, userFromDb.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(typeof(NetworkType).Name, userFromDb.NetworkType.ToString())
            }.Union(userRoles.Select(userRole => new Claim(ClaimTypes.Role, userRole)));

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(3),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256));

            return new SuccessfullLoginResponse(StatusCodes.Status200OK,
                "Login process success",
                new JwtSecurityTokenHandler().WriteToken(token),
                token.ValidTo);
        }

        /// <summary>
        /// Confirm user email
        /// </summary>
        /// <param name="token"></param>
        /// <param name="email"></param>
        /// <returns></returns>
        public async Task<Response> ConfirmEmail(string token, string email)
        {
            var user = await _userManager.FindByEmailAsync(email);

            if (user is null)
            {

                return new Response(StatusCodes.Status404NotFound, "User not found");
            }

            var confirmationResult = await _userManager.ConfirmEmailAsync(user, token);

            if (confirmationResult.Succeeded)
            {

                return new Response(StatusCodes.Status200OK, "Confirmation Success");
            }
            else
            {

                return new Response(StatusCodes.Status400BadRequest, "Invalid confirmation token");
            }
        }
    }
}
