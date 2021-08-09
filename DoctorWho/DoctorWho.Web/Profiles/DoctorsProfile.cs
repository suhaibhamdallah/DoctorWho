using AutoMapper;
using DoctorWho.Web.Models;
using DoctorWho.Db.Entities;

namespace DoctorWho.Web.Profiles
{
    public class DoctorsProfile : Profile
    {
        public DoctorsProfile()
        {
            CreateMap<Doctor, DoctorDto>();
        }
    }
}
