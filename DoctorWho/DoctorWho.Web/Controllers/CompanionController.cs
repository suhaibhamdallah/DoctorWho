using DoctorWho.Web.Filters;
using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorWho.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanionController : ControllerBase
    {
        private readonly ICompanionService _companionService;

        public CompanionController(ICompanionService companionService)
        {
            _companionService = companionService ??
                throw new ArgumentNullException(nameof(companionService));
        }

        /// <summary>
        /// Get Companions
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Roles = "user")]
        [TypeFilter(typeof(CheckInformationRequestsFilter))]
        public async Task<ActionResult<IEnumerable<CompanionDto>>> GetCompanions()
        {
            var companions = await _companionService.GetCompanions();

            return Ok(companions);
        }
    }
}
