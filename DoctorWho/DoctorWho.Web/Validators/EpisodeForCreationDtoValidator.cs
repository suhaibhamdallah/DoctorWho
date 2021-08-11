using DoctorWho.Web.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorWho.Web.Validators
{
    public class EpisodeForCreationDtoValidator : AbstractValidator<EpisodeForCreationDto>
    {
        public EpisodeForCreationDtoValidator()
        {
            RuleFor(episode => episode.AuthorId)
                .NotEmpty();

            RuleFor(episode => episode.DoctorId)
                .NotEmpty();

            RuleFor(episode => episode.EpisodeNumber)
                .GreaterThan(0);
        }
    }
}
