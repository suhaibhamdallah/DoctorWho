using DoctorWho.Db.Models;
using System.Linq;

namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository : Repository<Companion, Companion, int>
    {
        public CompanionRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
