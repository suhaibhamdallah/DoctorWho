using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository : Repository<Author>
    {
        public AuthorRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
