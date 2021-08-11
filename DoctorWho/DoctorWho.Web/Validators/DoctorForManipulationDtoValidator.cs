using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using FluentValidation;
using System;
using System.Threading.Tasks;

namespace DoctorWho.Web.Validators
{
    public class DoctorForManipulationDtoValidator : AbstractValidator<DoctorForManipulationDto>
    {
        private readonly IDoctorService _doctorService;

        public DoctorForManipulationDtoValidator(IDoctorService doctorService)
        {
            _doctorService = doctorService ??
                throw new ArgumentNullException(nameof(doctorService));

            RuleFor(doctor => doctor.Id)
                .MustAsync((doctorId, token) => CheckDoctorId(doctorId))
                .WithMessage("Invalid Id");

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

        private async Task<bool> CheckDoctorId(int? doctorId)
        {

            return !(doctorId != null && !_doctorService.DoctorExist(doctorId));
        }
    }
}
