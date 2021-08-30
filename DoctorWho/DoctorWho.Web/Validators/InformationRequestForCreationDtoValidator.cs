using DoctorWho.Web.Enums;
using DoctorWho.Web.Models;
using FluentValidation;
using System;

namespace DoctorWho.Web.Validators
{
    public class InformationRequestForCreationDtoValidator : AbstractValidator<InformationRequestForCreationDto>
    {
        public InformationRequestForCreationDtoValidator()
        {
            RuleFor(informationRequest => informationRequest.StartTime)
                .NotEmpty()
                .WithMessage("Invalid start time");

            RuleFor(informationRequest => informationRequest.EndTime)
                .NotEmpty()
                .WithMessage("Invalid end time");

            RuleFor(informationRequest => informationRequest.EndTime)
                .GreaterThan(informationRequest => informationRequest.StartTime)
                .WithMessage("Invalid time interval");

            RuleFor(informationRequest => informationRequest.AccessLevel)
               .InclusiveBetween(0, Enum.GetNames(typeof(AccessLevel)).Length - 1)
               .WithMessage("Invalid Access Level");

            RuleFor(informationRequest => informationRequest.NetworkType)
               .InclusiveBetween(0, Enum.GetNames(typeof(NetworkType)).Length - 1)
               .WithMessage("Invalid Network Type");
        }
    }
}
