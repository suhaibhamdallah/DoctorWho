using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Web.Models;

namespace DoctorWho.Web.Profiles
{
    public class EnemyProfile : Profile
    {
        public EnemyProfile()
        {
            CreateMap<Enemy, EnemytDto>();
        }
    }
}
