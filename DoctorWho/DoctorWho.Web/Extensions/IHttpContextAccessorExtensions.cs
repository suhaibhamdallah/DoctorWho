using Microsoft.AspNetCore.Http;
using System;
using System.Linq;

namespace DoctorWho.Web.Extensions
{
    public static class IHttpContextAccessorExtensions
    {
        public static string GetCurrentUserId(this IHttpContextAccessor httpContextAccessor)
        {
            var currentUserId = httpContextAccessor
               .HttpContext
               .User
               .Claims
               .FirstOrDefault(claim => claim.Type == "Id")
               .Value;

            return currentUserId ??
                throw new UnauthorizedAccessException();
        }
    }
}
