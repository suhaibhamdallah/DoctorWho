using DoctorWho.Web.Enums;
using DoctorWho.Web.Extensions;
using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorWho.Web.Controllers
{
    [Route("api/InformationRequest")]
    [ApiController]
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
        [Authorize(Roles = "User")]
        public async Task<ActionResult<InformationRequestDto>> CreateInformationRequest(
            [FromBody] InformationRequestForCreationDto informationRequest)
        {
            var currentUserId = _httpContextAccessor.GetCurrentUserId();

            informationRequest.UserId = currentUserId;
            informationRequest.ApprovalStatus = ((int)ApprovalStatus.Unknown);

            var informationRequestCreated = await _informationRequestService.CreateInformationRequest(informationRequest);

            return Created("", informationRequestCreated);
        }

        /// <summary>
        /// Get user's pending information requests
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        [Authorize(Roles = "User")]
        public async Task<ActionResult<IEnumerable<InformationRequestDto>>> GetPendingInformationRequests()
        {
            var currentUserId = _httpContextAccessor.GetCurrentUserId();

            var userPendingInformationRequests = await _informationRequestService.GetActivePendingInformationRequests(currentUserId);

            return Ok(userPendingInformationRequests);
        }

        /// <summary>
        /// Approve pending information requests
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        [HttpPut]
        [Authorize(Roles = "Admin")]
        public async Task<InformationRequestDto> ApproveInformationRequest([FromQuery] string requestId)
        {
            var approvedInformationRequest = await _informationRequestService.ApproveInformationRequest(requestId);

            return approvedInformationRequest;
        }

        /// <summary>
        /// Get all pending information requests
        /// </summary>
        /// <returns></returns>
        [HttpGet("all")]
        [Authorize(Roles = "Admin")]
        public async Task<IEnumerable<InformationRequestDto>> GetAllPendingInformationRequests()
        {
            var pendingInformationRequests = await _informationRequestService.GetActivePendingInformationRequests();

            return pendingInformationRequests;
        }
    }
}
