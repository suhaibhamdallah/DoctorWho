using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public class EpisodeService : IEpisodeService
    {
        private readonly IRepository<Episode, EpisodesView, int> _episodeRepository;
        private readonly IMapper _mapper;

        public EpisodeService(IRepository<Episode, EpisodesView, int> doctorRepository, IMapper mapper)
        {
            _episodeRepository = doctorRepository ??
                throw new ArgumentNullException(nameof(doctorRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<IEnumerable<EpisodeDto>> GetEpisodes()
        {
            var episodesFromRepo = await _episodeRepository.FindAll();

            return _mapper.Map<IEnumerable<EpisodeDto>>(episodesFromRepo);
        }
    }
}
