using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using FluentValidation;
using System;
using System.Threading.Tasks;

namespace DoctorWho.Web.Validators
{
    public class EpisodeEnemyForCreationDtoValidator : AbstractValidator<EpisodeEnemyForCreationDto>
    {
        private readonly IEpisodeService _episodeService;
        private readonly IEnemyService _enemyService;

        public EpisodeEnemyForCreationDtoValidator(IEpisodeService episodeService, IEnemyService enemyService)
        {
            _episodeService = episodeService ??
                throw new ArgumentNullException(nameof(episodeService));

            _enemyService = enemyService ??
                throw new ArgumentNullException(nameof(enemyService));

            RuleFor(episodeEnemy => episodeEnemy.EpisodeId)
                .MustAsync((episodeId, token) => CheckEpisodeId(episodeId))
                .WithMessage("Invalid episode id");

            RuleFor(episodeEnemy => episodeEnemy.EnemyId)
                .MustAsync((enemyId, token) => CheckEnemyId(enemyId))
                .WithMessage("Invalid enemy id");
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
        /// Check if the enemy exist or not
        /// </summary>
        /// <param name="enemyId"></param>
        /// <returns></returns>
        private async Task<bool> CheckEnemyId(int enemyId)
        {

            return _enemyService.IsEnemyExist(enemyId);
        }
    }
}
