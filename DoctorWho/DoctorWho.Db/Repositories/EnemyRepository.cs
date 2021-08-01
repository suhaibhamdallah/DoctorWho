using DoctorWho.Db.Models;
using System.Linq;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository : Repository<Enemy>
    {
        public EnemyRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
