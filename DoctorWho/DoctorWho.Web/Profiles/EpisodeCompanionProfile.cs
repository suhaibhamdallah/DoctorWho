using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorWho.Web.Profiles
{
    public class EpisodeCompanionProfile : Profile
    {
        public EpisodeCompanionProfile()
        {
            CreateMap<EpisodeCompanionForCreationDto, EpisodeCompanion>();
            CreateMap<EpisodeCompanion, EpisodeCompanionForCreationDto>();
            CreateMap<EpisodeCompanion, EpisodeCompanionDto>();
        }
    }
}
