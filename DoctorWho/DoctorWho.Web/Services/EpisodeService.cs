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

        public EpisodeService(IRepository<Episode, EpisodesView, int> doctorRepository,
            IMapper mapper)
        {
            _episodeRepository = doctorRepository ??
                throw new ArgumentNullException(nameof(doctorRepository));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Add new episode to the database
        /// </summary>
        /// <param name="episode"></param>
        /// <returns></returns>
        public async Task<EpisodeDto> CreateEpisode(EpisodeForCreationDto episode)
        {
            var episodeToCreate = _mapper.Map<Episode>(episode);

            var createdEpisode = await _episodeRepository.Create(episodeToCreate);

            var createdEpisodeToReturn = _mapper.Map<EpisodeDto>(createdEpisode);

            return createdEpisodeToReturn;
        }

        /// <summary>
        /// Get episode by id
        /// </summary>
        /// <param name="episodeId"></param>
        /// <returns></returns>
        public async Task<EpisodeDto> GetEpisode(int episodeId)
        {
            var episodeFromRepo = await _episodeRepository.FindById(episodeId);

            var episodeToReturn = _mapper.Map<EpisodeDto>(episodeFromRepo);

            return episodeToReturn;
        }

        /// <summary>
        /// Get episodes collection from database
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<EpisodeDto>> GetEpisodes()
        {
            var episodesFromRepo = await _episodeRepository.FindAll();

            return _mapper.Map<IEnumerable<EpisodeDto>>(episodesFromRepo);
        }

        /// <summary>
        /// Check if the episode exist or not
        /// </summary>
        /// <param name="episodeId"></param>
        /// <returns></returns>
        public bool IsEpisodeExist(int episodeId)
        {

            return !(GetEpisode(episodeId).Result is null);
        }
    }
}
