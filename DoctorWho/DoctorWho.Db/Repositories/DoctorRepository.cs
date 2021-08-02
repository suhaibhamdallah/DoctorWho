using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class DoctorRepository : Repository<Doctor, int>
    {
        public DoctorRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
