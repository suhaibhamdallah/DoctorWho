using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public class EpisodeEnemyService : IEpisodeEnemyService
    {
        private readonly IRepository<EpisodeEnemy, EpisodeEnemy, int> _episdoeEnemyRepository;
        private readonly IMapper _mapper;

        public EpisodeEnemyService(IRepository<EpisodeEnemy, EpisodeEnemy, int> episdoeEnemyRepository, IMapper mapper)
        {
            _episdoeEnemyRepository = episdoeEnemyRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// Add enemy to episode
        /// </summary>
        /// <param name="episodeEnemy"></param>
        /// <returns></returns>
        public async Task<EpisodeEnemyDto> CreateEpisodeEnemy(EpisodeEnemyForCreationDto episodeEnemy)
        {
            var episodeEnemyToAdd = _mapper.Map<EpisodeEnemy>(episodeEnemy);

            var addedEpisodeEnemy = await _episdoeEnemyRepository.Create(episodeEnemyToAdd);

            var episodeEnemyToReturn = _mapper.Map<EpisodeEnemyDto>(addedEpisodeEnemy);

            return episodeEnemyToReturn;
        }

        /// <summary>
        /// Check if new episodeEnemyForCreation object is exist in the database
        /// </summary>
        /// <param name="episodeEnemyForCreation"></param>
        /// <returns></returns>
        public async Task<bool> IsEpisodeEnemyDublicated(EpisodeEnemyForCreationDto episodeEnemyForCreation)
        {
            var episodeEnemies = await _episdoeEnemyRepository.FindAll();

            var result = episodeEnemies
                .Where(episodeEnemy =>
                episodeEnemy.EpisodeId == episodeEnemyForCreation.EpisodeId &&
                episodeEnemy.EnemyId == episodeEnemyForCreation.EnemyId)
                .FirstOrDefault();

            return result is null;
        }
    }
}
