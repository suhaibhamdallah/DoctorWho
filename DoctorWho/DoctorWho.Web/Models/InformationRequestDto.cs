using System;

namespace DoctorWho.Web.Models
{
    public class InformationRequestDto
    {
        public string Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int ApprovalStatus { get; set; }
        public int AccessLevel { get; set; }
        public int NetworkType { get; set; }
        public string ModifiedBy { get; set; }
    }
}
