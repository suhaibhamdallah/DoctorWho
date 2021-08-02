using DoctorWho.Db.Models;
using System.Linq;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository : Repository<Enemy, int>
    {
        public EnemyRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
