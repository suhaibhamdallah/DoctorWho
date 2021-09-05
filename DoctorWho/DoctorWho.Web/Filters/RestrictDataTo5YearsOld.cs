using DoctorWho.Authentication.Infrastructure.Enumeration;
using DoctorWho.Db.Models;
using DoctorWho.Web.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DoctorWho.Web.Filters
{
    public class RestrictDataTo5YearsOld : ActionFilterAttribute
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public RestrictDataTo5YearsOld(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor ??
                throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            var currentUserNetworkType = _httpContextAccessor.GetGurrentUserNetworkType();

            if (currentUserNetworkType == (int)NetworkType.External)
            {
                var actionResult = (OkObjectResult)context.Result;
                var results = actionResult.Value;
                var dateTimeBefore5years = (DateTime.Now).AddYears(-5);

                if (results is IEnumerable<BaseModel> iEnumerableResults)
                {
                    actionResult.Value = iEnumerableResults.Where(result => result.ModifiedAt > dateTimeBefore5years)
                        .ToList();
                }
                else if (results is BaseModel contextResult &&
                    contextResult.ModifiedAt < dateTimeBefore5years)
                {

                    context.Result = new ForbidResult();
                }
            }
        }
    }
}

