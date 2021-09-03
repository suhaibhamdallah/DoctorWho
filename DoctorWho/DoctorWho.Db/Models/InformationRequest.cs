using System;
using System.ComponentModel.DataAnnotations;

namespace DoctorWho.Db.Models
{
    public class InformationRequest : IModel<string>
    {
        public string Id { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public int ApprovalStatus { get; set; }

        [Required]
        public int AccessLevel { get; set; }

        public string ModifiedBy { get; set; }
    }
}
