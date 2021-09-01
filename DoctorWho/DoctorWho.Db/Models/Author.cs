using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.Db.Models
{
    public class Author : IModel<int>
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string AuthorName { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedAt { get; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime ModifiedAt { get; } = DateTime.Now;
    }
}
