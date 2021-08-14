using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Profiles
{
    public class CompanionProfile : Profile
    {
        public CompanionProfile()
        {
            CreateMap<Companion, CompanionDto>();
        }
    }
}
