using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using DoctorWho.Web.Validators;
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

        public EpisodesController(IEpisodeService episodeService,
            IEpisodeEnemyService episodeEnemyService,
            IEpisodeCompanionService episodeCompanionService,
            IEnemyService enemyService)
        {
            _episodeService = episodeService ??
                throw new ArgumentNullException(nameof(episodeService));

            _episodeEnemyService = episodeEnemyService ??
                throw new ArgumentNullException(nameof(episodeEnemyService));

            _episodeCompanionService = episodeCompanionService ??
                throw new ArgumentNullException(nameof(episodeCompanionService));

            _enemyService = enemyService ??
                throw new ArgumentNullException(nameof(enemyService));
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
            var episodeEnemyToAdd = new EpisodeEnemyForCreationDto();
            episodeEnemyToAdd.EpisodeId = episodeId;
            episodeEnemyToAdd.EnemyId = enemyId;

            var validator = new EpisodeEnemyForCreationDtoValidator(
                episodeEnemyToAdd,
                _episodeService,
                _enemyService,
                _episodeEnemyService);
            var validatorResult = validator.Validate(episodeEnemyToAdd);

            if (!validatorResult.IsValid)
            {

                return BadRequest(validatorResult.Errors);
            } 

            var episodeEnemyAdded = await _episodeEnemyService.CreateEpisodeEnemy(episodeEnemyToAdd);

            return Ok(episodeEnemyAdded);
        }

        /// <summary>
        /// Add companion to episode
        /// </summary>
        /// <param name="episodeCompanion"></param>
        /// <returns></returns>
        [HttpPost("companions", Name = nameof(AddCompanionToEpisode))]
        public async Task<ActionResult<EpisodeCompanionDto>> AddCompanionToEpisode(
            [FromBody] EpisodeCompanionForCreationDto episodeCompanion)
        {
            var episodeCompanionAdded = await _episodeCompanionService.CreateEpisodeCompanion(episodeCompanion);

            return Ok(episodeCompanionAdded);
        }
    }
}
