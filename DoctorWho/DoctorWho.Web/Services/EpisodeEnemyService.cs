using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
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

        public async Task<EpisodeEnemyDto> CreateEpisodeEnemy(EpisodeEnemyForCreationDto episode)
        {
            var episodeEnemyToAdd = _mapper.Map<EpisodeEnemy>(episode);

            var addedEpisodeEnemy = await _episdoeEnemyRepository.Create(episodeEnemyToAdd);

            var episodeEnemyToReturn = _mapper.Map<EpisodeEnemyDto>(addedEpisodeEnemy);

            return episodeEnemyToReturn;
        }
    }
}
