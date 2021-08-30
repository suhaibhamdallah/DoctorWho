using DoctorWho.Web.Enums;
using DoctorWho.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Linq;

namespace DoctorWho.Web.Filters
{
    public class CheckInformationRequestsFilter : ActionFilterAttribute
    {
        private readonly IInformationRequestService _informationRequestService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CheckInformationRequestsFilter(IInformationRequestService informationRequestService,
            IHttpContextAccessor httpContextAccessor)
        {
            _informationRequestService = informationRequestService ??
                throw new ArgumentNullException(nameof(informationRequestService));

            _httpContextAccessor = httpContextAccessor ??
                throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var currentUserId = _httpContextAccessor
               .HttpContext
               .User
               .Claims
               .FirstOrDefault()
               .Value;

            var userInformationRequest = _informationRequestService.GetApprovedInformationRequests(currentUserId);

            var currentDateTime = DateTime.Now;

            var IsAnyApprovedRequest = userInformationRequest
                .Result
                .Any(request => request.ApprovalStatus == (int)ApprovalStatus.Approved &&
                request.StartTime < currentDateTime &&
                request.EndTime > currentDateTime);

            if (!IsAnyApprovedRequest)
            {
                context.Result = new UnauthorizedObjectResult("No Approved Information Request");
            }
        }
    }
}
