using AutoMapper;
using DoctorWho.Web.Models;
using DoctorWho.Db.Models;

namespace DoctorWho.Web.Profiles
{
    public class DoctorsProfile : Profile
    {
        public DoctorsProfile()
        {
            CreateMap<Doctor, DoctorDto>();
            CreateMap<DoctorForManipulationDto, Doctor>();
            CreateMap<Doctor, DoctorForManipulationDto>();
        }
    }
}
