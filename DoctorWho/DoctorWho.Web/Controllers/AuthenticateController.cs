using DoctorWho.Authentication.Infrastructure.Models;
using DoctorWho.Authentication.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace DoctorWho.Web.Controllers
{
    [Route("api/auth")]
    [ApiController]
    public class AuthenticateController : ControllerBase
    {
        private readonly IAuthenticateService _authenticateService;

        public AuthenticateController(IAuthenticateService authenticateService)
        {
            _authenticateService = authenticateService ?? 
                throw new ArgumentNullException(nameof(authenticateService));
        }

        /// <summary>
        /// Register normal user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("user")]
        public async Task<IActionResult> RegisterUser([FromBody] UserForCreationDto user)
        {
            var registrationResult = await _authenticateService.RegisterUser(user);

            return new ObjectResult(registrationResult)
            { 
                StatusCode = registrationResult.StatusCode
            };
        }

        /// <summary>
        /// Register admin
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("admin")]
        public async Task<IActionResult> RegisterAdmin([FromBody] UserForCreationDto user)
        {
            var registrationResult = await _authenticateService.RegisterAdmin(user);

            return new ObjectResult(registrationResult)
            {
                StatusCode = registrationResult.StatusCode
            };
        }

        /// <summary>
        /// Login api
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] UserForLoginDto user)
        {
            var result = await _authenticateService.Login(user);

            return new ObjectResult(result)
            {
                StatusCode = result.StatusCode
            };
        }
    }
}
