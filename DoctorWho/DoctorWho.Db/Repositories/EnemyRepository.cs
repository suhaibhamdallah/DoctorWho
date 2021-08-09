using DoctorWho.Db.Models;
using System.Linq;

namespace DoctorWho.Db.Repositories
{
    public class EnemyRepository : Repository<Enemy, Enemy, int>
    {
        public EnemyRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
