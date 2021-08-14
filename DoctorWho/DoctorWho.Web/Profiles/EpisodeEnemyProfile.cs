using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Profiles
{
    public class EpisodeEnemyProfile : Profile
    {
        public EpisodeEnemyProfile()
        {
            CreateMap<EpisodeEnemyForCreationDto, EpisodeEnemy>();
            CreateMap<EpisodeEnemy, EpisodeEnemyDto>();
        }
    }
}
