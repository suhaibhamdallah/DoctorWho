using DoctorWho.Db.Models;
using System.Linq;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository : GenericRepository<Enemy>, IQueryable<Enemy>
    {
        public EnemyRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Get one enemy by id from database table
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public Enemy FindById(int entityId)
        {

            return context
                .Enemies
                .Where(enemy => enemy.EnemyId == entityId)
                .SingleOrDefault();
        }
    }
}
