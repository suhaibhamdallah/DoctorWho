using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public class EpisodeCompanionService : IEpisodeCompanionService
    {
        private readonly IRepository<EpisodeCompanion, EpisodeCompanion, int> _episodeCompanionRepository;
        private readonly IMapper _mapper;

        public EpisodeCompanionService(IRepository<EpisodeCompanion, EpisodeCompanion, int> episodeCompanionRepository, IMapper mapper)
        {
            _episodeCompanionRepository = episodeCompanionRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Add companion to episode
        /// </summary>
        /// <param name="episodeCompanion"></param>
        /// <returns></returns>
        public async Task<EpisodeCompanionDto> CreateEpisodeCompanion(EpisodeCompanionForCreationDto episodeCompanion)
        {
            var episodeCompanionToAdd = _mapper.Map<EpisodeCompanion>(episodeCompanion);

            var addedEpisodeCompanion = await _episodeCompanionRepository.Create(episodeCompanionToAdd);

            var episodeCompanionToReturn = _mapper.Map<EpisodeCompanionDto>(addedEpisodeCompanion);

            return episodeCompanionToReturn;
        }

        /// <summary>
        /// Check if new episodeCompanion duplicated
        /// </summary>
        /// <param name="episodeCompanionForCreation"></param>
        /// <returns></returns>
        public async Task<bool> IsEpisodeCompanionDublicated(EpisodeCompanionForCreationDto episodeCompanionForCreation)
        {
            var episodeCompanions = await _episodeCompanionRepository.FindAll();

            return !episodeCompanions
                .Where(episodeCompanion =>
                episodeCompanion.EpisodeId == episodeCompanionForCreation.EpisodeId &&
                episodeCompanion.CompanionId == episodeCompanionForCreation.CompanionId)
                .Any();
        }
    }
}
