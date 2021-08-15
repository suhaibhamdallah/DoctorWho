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
        private readonly IEpisodeEnemyService _episodeEnemyService;

        public EpisodeEnemyForCreationDtoValidator(EpisodeEnemyForCreationDto episodeEnemyForCreation,
            IEpisodeService episodeService,
            IEnemyService enemyService,
            IEpisodeEnemyService episodeEnemyService)
        {
            _episodeService = episodeService ??
                throw new ArgumentNullException(nameof(episodeService));

            _enemyService = enemyService ??
                throw new ArgumentNullException(nameof(enemyService));

            _episodeEnemyService = episodeEnemyService ??
                throw new ArgumentNullException(nameof(episodeEnemyService));

            RuleFor(episodeEnemy => episodeEnemy.EpisodeId)
                .MustAsync((episodeId, token) => CheckEpisodeId(episodeEnemyForCreation.EpisodeId))
                .WithMessage("Invalid episode id");

            RuleFor(episodeEnemy => episodeEnemy.EnemyId)
                .MustAsync((enemyId, token) => CheckEnemyId(episodeEnemyForCreation.EnemyId))
                .WithMessage("Invalid enemy id");

            RuleFor(episodeEnemy => episodeEnemy)
                .MustAsync((episodeEnemy, token) => CheckIfEpisodeEnemyDuplicated(episodeEnemy))
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
        /// Check if the enemy exist or not
        /// </summary>
        /// <param name="enemyId"></param>
        /// <returns></returns>
        private async Task<bool> CheckEnemyId(int enemyId)
        {

            return _enemyService.IsEnemyExist(enemyId);
        }

        /// <summary>
        /// Check if new episodeEnemyForCreation object is exist in the database
        /// </summary>
        /// <param name="episodeEnemy"></param>
        /// <returns></returns>
        private async Task<bool> CheckIfEpisodeEnemyDuplicated(EpisodeEnemyForCreationDto episodeEnemy)
        {

            return await _episodeEnemyService.IsEpisodeEnemyDublicated(episodeEnemy);
        }
    }
}
