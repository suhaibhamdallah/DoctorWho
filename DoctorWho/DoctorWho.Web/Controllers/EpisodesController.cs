using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
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

        public EpisodesController(IEpisodeService episodeService)
        {
            _episodeService = episodeService ??
                throw new ArgumentNullException(nameof(episodeService));
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
    }
}
