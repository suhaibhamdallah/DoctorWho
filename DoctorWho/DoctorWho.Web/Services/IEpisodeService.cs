using DoctorWho.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public interface IEpisodeService
    {
        public Task<IEnumerable<EpisodeDto>> GetEpisodes();
    }
}
