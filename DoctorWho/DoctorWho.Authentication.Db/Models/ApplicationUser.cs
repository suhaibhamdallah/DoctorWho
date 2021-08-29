using Microsoft.AspNetCore.Identity;

namespace DoctorWho.Authentication.Db.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ImageUri { get; set; }
    }
}
