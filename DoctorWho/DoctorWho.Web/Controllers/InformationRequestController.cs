using DoctorWho.Web.Enums;
using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace DoctorWho.Web.Controllers
{
    [Route("api/InformationRequest")]
    [ApiController]
    [Authorize(Roles = "User")]
    public class InformationRequestController : ControllerBase
    {
        private readonly IInformationRequestService _informationRequestService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public InformationRequestController(IInformationRequestService informationRequestService,
            IHttpContextAccessor httpContextAccessor)
        {
            _informationRequestService = informationRequestService ??
                throw new ArgumentNullException(nameof(informationRequestService));

            _httpContextAccessor = httpContextAccessor ??
                throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        /// <summary>
        /// Create Information Request
        /// </summary>
        /// <param name="informationRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<InformationRequestDto>> CreateInformationRequest(
            [FromBody] InformationRequestForCreationDto informationRequest)
        {
            var currentUserId = _httpContextAccessor
                .HttpContext
                .User
                .Claims
                .FirstOrDefault()
                .Value;

            informationRequest.UserId = currentUserId;
            informationRequest.ApprovalStatus = ((int)ApprovalStatus.Unknown);

            var informationRequestCreated = await _informationRequestService.CreateInformationRequest(informationRequest);

            return Created("", informationRequestCreated);
        }
    }
}
