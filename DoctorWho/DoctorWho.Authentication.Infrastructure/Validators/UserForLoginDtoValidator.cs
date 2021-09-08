using DoctorWho.Authentication.Db.Models;
using DoctorWho.Authentication.Infrastructure.Repositories;
using DoctorWho.Authentication.Infrastructure.Models;
using FluentValidation;
using Microsoft.AspNetCore.Identity;
using System;

namespace DoctorWho.Authentication.Infrastructure.Validators
{
    public class UserForLoginDtoValidator : AbstractValidator<UserForLoginDto>
    {
        private readonly IApplicationUserRepository _authenticateHelpers;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserForLoginDtoValidator(IApplicationUserRepository authenticateHelprs,
            UserManager<ApplicationUser> userManager)
        {
            _authenticateHelpers = authenticateHelprs ??
                throw new ArgumentNullException(nameof(authenticateHelprs));

            _userManager = userManager ??
                throw new ArgumentNullException(nameof(userManager));

            RuleFor(user => user.Username)
                .NotEmpty()
                .MustAsync(async (username, token) => (await _authenticateHelpers.IsUserExist(username)))
                .WithMessage("Incorrect username or password");

            // Check password correctness
            RuleFor(user => user)
                .NotEmpty()
                .MustAsync(async (user, token) =>
                {
                    var userFromDb = await _userManager.FindByNameAsync(user.Username);

                    return await _userManager.CheckPasswordAsync(userFromDb, user.Password);
                })
                .WithMessage("Incorrect username or password");
        }
    }
}
