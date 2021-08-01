using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository : GenericRepository<Enemy>
    {
        public EnemyRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
