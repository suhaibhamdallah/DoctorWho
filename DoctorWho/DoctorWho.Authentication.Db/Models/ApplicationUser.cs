using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Authentication.Db.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ImageUri { get; set; }

        [Required]
        public int NetworkType { get; set; }
    }
}
