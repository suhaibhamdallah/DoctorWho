using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db.Models
{
    public class Author : IModel<int>
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string AuthorName { get; set; }
    }
}
