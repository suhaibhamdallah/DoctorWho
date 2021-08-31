using System;

namespace DoctorWho.Web.Models
{
    public class InformationRequestForCreationDto
    {
        public string UserId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int ApprovalStatus { get; set; }
        public int AccessLevel { get; set; }
    }
}
