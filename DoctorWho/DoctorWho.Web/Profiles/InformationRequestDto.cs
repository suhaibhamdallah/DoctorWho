using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Profiles
{
    public class InformationRequestDtoProfile : Profile
    {
        public InformationRequestDtoProfile()
        {
            CreateMap<InformationRequestForCreationDto, InformationRequest>();
            CreateMap<InformationRequest, InformationRequestDto>();
        }
    }
}
