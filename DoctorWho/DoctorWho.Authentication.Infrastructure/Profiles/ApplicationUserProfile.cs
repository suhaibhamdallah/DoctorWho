using AutoMapper;
using DoctorWho.Authentication.Db.Models;
using DoctorWho.Authentication.Infrastructure.Models;

namespace DoctorWho.Authentication.Infrastructure.Profiles
{
    public class ApplicationUserProfile : Profile
    {
        public ApplicationUserProfile()
        {
            CreateMap<UserForCreationDto, ApplicationUser>();
        }
    }
}
