using DoctorWho.Db.Models;
using System.Linq;

namespace DoctorWho.Db.Repositories
{
    public class CompanionRepository : GenericRepository<Companion>, IQueryable<Companion>
    {
        public CompanionRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }

        /// <summary>
        /// Get companion by id from database table
        /// </summary>
        /// <param name="entityId"></param>
        /// <returns></returns>
        public Companion FindById(int entityId)
        {

            return context
                .Companions
                .Where(companion => companion.CompanionId == entityId)
                .SingleOrDefault();
        }
    }
}
