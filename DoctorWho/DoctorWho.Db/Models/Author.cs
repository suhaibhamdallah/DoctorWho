using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db.Models
{
    public class Author
    {
        public int AuthorId { get; set; }

        [MaxLength(50)]
        [Required]
        public string AuthorName { get; set; }
    }
}
