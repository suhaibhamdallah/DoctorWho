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
    }
}
