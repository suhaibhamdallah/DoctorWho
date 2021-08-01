using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class EpisodeEnemyRepository
    {
        private readonly DoctorWhoCoreDbContext _context;

        public EpisodeEnemyRepository()
        {
            _context = new DoctorWhoCoreDbContext();
        }

        /// <summary>
        /// Add enemy to episode
        /// </summary>
        /// <param name="episodeEnemy"></param>
        /// <returns></returns>
        public EpisodeEnemy Add(EpisodeEnemy episodeEnemy)
        {

            return _context
                .Add(episodeEnemy)
                .Entity;
        }
    }
}
