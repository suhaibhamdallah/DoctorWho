using DoctorWho.Db.Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository : GenericRepository<Doctor>, IAllRetrievable
    {
        public DoctorRepository(DoctorWhoCoreDbContext context) : base(context)
        { 
        }

        public IEnumerable All()
        {
            return context
                .Set<Doctor>()
                .ToList();
        }
    }
}
