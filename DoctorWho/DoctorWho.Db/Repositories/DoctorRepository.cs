using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository : Repository<Doctor>
    {
        public DoctorRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
