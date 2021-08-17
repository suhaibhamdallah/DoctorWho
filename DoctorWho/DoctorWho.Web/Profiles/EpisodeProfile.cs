using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Profiles
{
    public class EpisodeProfile : Profile
    {
        public EpisodeProfile()
        {
            CreateMap<EpisodesView, EpisodeDto>();
            CreateMap<EpisodeForCreationDto, Episode>();
            CreateMap<Episode, EpisodeDto>();
        }
    }
}
