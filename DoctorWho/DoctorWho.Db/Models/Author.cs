using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DoctorWho.Db.Models
{
    public class Author : BaseModel, IModel<int>
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string AuthorName { get; set; }
    }
}
