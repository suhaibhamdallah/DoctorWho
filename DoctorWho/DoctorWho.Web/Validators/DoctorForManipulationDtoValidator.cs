using DoctorWho.Web.Models;
using FluentValidation;

namespace DoctorWho.Web.Validators
{
    public class DoctorForManipulationDtoValidator : AbstractValidator<DoctorForManipulationDto>
    {
        public DoctorForManipulationDtoValidator()
        {
            RuleFor(doctor => doctor.DoctorName)
                .NotEmpty();

            RuleFor(doctor => doctor.DoctorNumber)
                .NotEmpty();

            RuleFor(doctor => doctor.LastEpisodeDate)
                .Null()
                .When(doctor => doctor.FirstEpisodeDate == null);

            RuleFor(doctor => doctor.LastEpisodeDate)
                .GreaterThanOrEqualTo(doctor => doctor.FirstEpisodeDate);
        }
    }
}
