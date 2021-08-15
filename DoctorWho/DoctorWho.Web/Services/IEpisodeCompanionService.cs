using DoctorWho.Web.Models;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public interface IEpisodeCompanionService
    {
        public Task<EpisodeCompanionDto> CreateEpisodeCompanion(EpisodeCompanionForCreationDto episodeCompanion);
        public Task<bool> IsEpisodeCompanionDublicated(EpisodeCompanionForCreationDto episodeCompanionForCreation);
    }
}
