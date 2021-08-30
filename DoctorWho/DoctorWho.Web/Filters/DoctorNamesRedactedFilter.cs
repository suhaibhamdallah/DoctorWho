using DoctorWho.Web.Enums;
using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoctorWho.Web.Filters
{
    public class DoctorNamesRedactedFilter : ActionFilterAttribute
    {
        private readonly IInformationRequestService _informationRequestService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public DoctorNamesRedactedFilter(IInformationRequestService informationRequestService,
            IHttpContextAccessor httpContextAccessor)
        {
            _informationRequestService = informationRequestService ??
                throw new ArgumentNullException(nameof(informationRequestService));

            _httpContextAccessor = httpContextAccessor ??
                throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var currentUserId = _httpContextAccessor
               .HttpContext
               .User
               .Claims
               .FirstOrDefault()
               .Value;

            var userInformationRequest = _informationRequestService
                .GetApprovedInformationRequests(currentUserId)
                .Result
                .FirstOrDefault();

            var actionResult = (OkObjectResult)context.Result;
            var doctors = (IEnumerable<DoctorDto>)actionResult.Value;

            if (userInformationRequest.AccessLevel == (int)AccessLevel.Redacted &&
                userInformationRequest.NetworkType != (int)NetworkType.Internal)
            {
                foreach (var doctor in doctors)
                {
                    doctor.DoctorName = "Redacted";
                }
            }
        }
    }
}
