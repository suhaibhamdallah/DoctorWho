using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeCompanionRepository
    {
        private readonly DoctorWhoCoreDbContext _context;

        public EpisodeCompanionRepository()
        {
            _context = new DoctorWhoCoreDbContext();
        }

        /// <summary>
        /// Add companion to episode
        /// </summary>
        /// <param name="episodeCompanion"></param>
        /// <returns></returns>
        public EpisodeCompanion Add(EpisodeCompanion episodeCompanion)
        {

            return _context
                .Add(episodeCompanion)
                .Entity;
        }
    }
}
