using DoctorWho.Web.Models;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public interface IEpisodeEnemyService
    {
        public Task<EpisodeEnemyDto> CreateEpisodeEnemy(EpisodeEnemyForCreationDto episodeEnemy);
        public Task<bool> IsEpisodeEnemyDublicated(EpisodeEnemyForCreationDto episodeEnemyForCreation);
    }
}
