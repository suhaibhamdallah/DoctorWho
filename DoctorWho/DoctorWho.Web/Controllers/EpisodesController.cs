using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using DoctorWho.Web.Validators;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorWho.Web.Controllers
{
    [ApiController]
    [Route("api/episodes")]
    public class EpisodesController : ControllerBase
    {
        private readonly IEpisodeService _episodeService;
        private readonly IEpisodeEnemyService _episodeEnemyService;
        private readonly IEpisodeCompanionService _episodeCompanionService;
        private readonly IEnemyService _enemyService;
        private readonly ICompanionService _companionService;
        private readonly IValidator<EpisodeEnemyForCreationDto> _episodeEnemyValidator;
        private readonly IValidator<EpisodeCompanionForCreationDto> _episodeCompanionValidator;

        public EpisodesController(IEpisodeService episodeService,
            IEpisodeEnemyService episodeEnemyService,
            IEpisodeCompanionService episodeCompanionService,
            IEnemyService enemyService,
            ICompanionService companionService,
            IValidator<EpisodeEnemyForCreationDto> episodeEnemyValidator,
            IValidator<EpisodeCompanionForCreationDto> episodeCompanionValidator)
        {
            _episodeService = episodeService ??
                throw new ArgumentNullException(nameof(episodeService));

            _episodeEnemyService = episodeEnemyService ??
                throw new ArgumentNullException(nameof(episodeEnemyService));

            _episodeCompanionService = episodeCompanionService ??
                throw new ArgumentNullException(nameof(episodeCompanionService));

            _enemyService = enemyService ??
                throw new ArgumentNullException(nameof(enemyService));

            _companionService = companionService ??
                throw new ArgumentNullException(nameof(companionService));

            _episodeEnemyValidator = episodeEnemyValidator ??
                throw new ArgumentNullException(nameof(episodeEnemyValidator));

            _episodeCompanionValidator = episodeCompanionValidator ??
                throw new ArgumentNullException(nameof(episodeCompanionValidator));
        }

        /// <summary>
        ///  Get episodes collection
        /// </summary>
        /// <returns></returns>
        [HttpGet(Name = "GetEpisodes")]
        public async Task<ActionResult<IEnumerable<EpisodeDto>>> GetEpisodes()
        {
            var episodesFromService = await _episodeService.GetEpisodes();

            return Ok(episodesFromService);
        }

        /// <summary>
        /// Create new episode
        /// </summary>
        /// <returns>The new episode id</returns>
        [HttpPost(Name = "CreateEpisode")]
        public async Task<IActionResult> CreateEpisode([FromBody] EpisodeForCreationDto episode)
        {
            if (!ModelState.IsValid)
            {

                return BadRequest();
            }

            var addedEpisode = await _episodeService.CreateEpisode(episode);

            return Created("", new { Id = addedEpisode.Id });
        }

        /// <summary>
        /// Add enemy to episode
        /// </summary>
        /// <param name="episodeId"></param>
        /// <param name="enemyId"></param>
        /// <returns></returns>
        [HttpPost("{episodeId}/enemies/{enemyId}", Name = "AddEnemyToEpisode")]
        public async Task<ActionResult<EpisodeEnemyDto>> AddEnemyToEpisode([FromRoute] int episodeId,
            [FromRoute] int enemyId)
        {
            var episodeEnemyToAdd = new EpisodeEnemyForCreationDto
            {
                EpisodeId = episodeId,
                EnemyId = enemyId
            };

            var episodeEnemyValidatorResult = _episodeEnemyValidator.Validate(episodeEnemyToAdd);

            if (!episodeEnemyValidatorResult.IsValid)
            {

                return BadRequest(episodeEnemyValidatorResult.Errors);
            } 

            var episodeEnemyAdded = await _episodeEnemyService.CreateEpisodeEnemy(episodeEnemyToAdd);

            return Ok(episodeEnemyAdded);
        }

        /// <summary>
        /// Add companion to episode
        /// </summary>
        /// <param name="episodeCompanion"></param>
        /// <returns></returns>
        [HttpPost("{episodeId}/companions/{companionId}", Name = nameof(AddCompanionToEpisode))]
        public async Task<ActionResult<EpisodeCompanionDto>> AddCompanionToEpisode(
            [FromRoute] int episodeId,
            [FromRoute] int companionId)
        {
            var episodeCompanionToAdd = new EpisodeCompanionForCreationDto {
                EpisodeId = episodeId,
                CompanionId = companionId
            };

            var episodeCompanionValidatorResult = _episodeCompanionValidator.Validate(episodeCompanionToAdd);

            if (!episodeCompanionValidatorResult.IsValid)
            {

                return BadRequest(episodeCompanionValidatorResult.Errors);
            }

            var episodeCompanionAdded = await _episodeCompanionService.CreateEpisodeCompanion(episodeCompanionToAdd);

            return Ok(episodeCompanionAdded);
        }
    }
}
