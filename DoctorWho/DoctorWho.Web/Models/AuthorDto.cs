using System;

namespace DoctorWho.Web.Models
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime ModifiedAt { get; set; }
    }
}
