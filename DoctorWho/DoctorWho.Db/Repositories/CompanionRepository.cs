using DoctorWho.Db.Models;
using System.Linq;

namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository : Repository<Companion>
    {
        public CompanionRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
