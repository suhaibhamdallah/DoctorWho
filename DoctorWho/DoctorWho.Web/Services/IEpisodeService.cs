using DoctorWho.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public interface IEpisodeService
    {
        public Task<IEnumerable<EpisodeDto>> GetEpisodes();
        public Task<EpisodeDto> GetEpisode(int episodeId);
        public Task<EpisodeDto> CreateEpisode(EpisodeForCreationDto episode);
        public bool IsEpisodeExist(int episodeId);
    }
}
