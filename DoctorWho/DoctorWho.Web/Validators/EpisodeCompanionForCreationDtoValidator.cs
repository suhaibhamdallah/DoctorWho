using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using FluentValidation;
using System;
using System.Threading.Tasks;

namespace DoctorWho.Web.Validators
{
    public class EpisodeCompanionForCreationDtoValidator : AbstractValidator<EpisodeCompanionForCreationDto>
    {
        private readonly IEpisodeService _episodeService;
        private readonly ICompanionService _companionService;
        private readonly IEpisodeCompanionService _episodeCompanionService;

        public EpisodeCompanionForCreationDtoValidator(IEpisodeService episodeService,
            ICompanionService companionService,
            IEpisodeCompanionService episodeCompanionService)
        {
            _episodeService = episodeService ??
                throw new ArgumentNullException(nameof(episodeService));

            _companionService = companionService ??
                throw new ArgumentNullException(nameof(companionService));

            _episodeCompanionService = episodeCompanionService ??
                throw new ArgumentNullException(nameof(episodeCompanionService));

            RuleFor(episodeCompanion => episodeCompanion.EpisodeId)
                .MustAsync((episodeId, token) => CheckEpisodeId(episodeId))
                .WithMessage("Invalid episode id");

            RuleFor(episodeCompanion => episodeCompanion.CompanionId)
                .MustAsync((companionId, token) => CheckCompanionId(companionId))
                .WithMessage("Invalid companion id");

            RuleFor(episodeCompanion => episodeCompanion)
                .MustAsync((episodeCompanion, token) => CheckIfEpisodeCompanionDuplicated(episodeCompanion))
                .WithMessage("Duplicated record");
        }

        /// <summary>
        /// Check if the episode exist or not
        /// </summary>
        /// <param name="episodeId"></param>
        /// <returns></returns>
        private async Task<bool> CheckEpisodeId(int episodeId)
        {

            return _episodeService.IsEpisodeExist(episodeId);
        }

        /// <summary>
        /// Check if companion exist
        /// </summary>
        /// <param name="companionId"></param>
        /// <returns></returns>
        private async Task<bool> CheckCompanionId(int companionId)
        {

            return _companionService.IsCompanionExist(companionId);
        }

        private async Task<bool> CheckIfEpisodeCompanionDuplicated(EpisodeCompanionForCreationDto episodeCompanion)
        {

            return await _episodeCompanionService.IsEpisodeCompanionDublicated(episodeCompanion);
        }
    }
}
