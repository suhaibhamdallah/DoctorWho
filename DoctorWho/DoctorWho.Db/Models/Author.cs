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

        public DateTime ModifiedAt { get; set; } = DateTime.Now;
    }
}
