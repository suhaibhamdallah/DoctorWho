using DoctorWho.Authentication.Infrastructure.Repositories;
using DoctorWho.Authentication.Infrastructure.Models;
using FluentValidation;
using System;

namespace DoctorWho.Authentication.Infrastructure.Validators
{
    public class UserForCreationDtoValidator : AbstractValidator<UserForCreationDto>
    {
        private readonly IApplicationUserRepository _authenticateHelpers;

        public UserForCreationDtoValidator(IApplicationUserRepository authenticateHelprs)
        {
            _authenticateHelpers = authenticateHelprs ??
                throw new ArgumentNullException(nameof(authenticateHelprs));

            RuleFor(user => user.Username)
                .NotEmpty()
                .WithMessage("Username is required");

            RuleFor(user => user.Username)
                .MustAsync(async (username, token) => !(await _authenticateHelpers.IsUserExist(username)))
                .WithMessage("Username is already exist");

            RuleFor(user => user.Email)
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Email is required");

            RuleFor(user => user.Password)
                .NotEmpty()
                .WithMessage("Password is required");
        }
    }
}
