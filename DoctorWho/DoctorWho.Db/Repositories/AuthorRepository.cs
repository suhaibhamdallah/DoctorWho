using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository : Repository<Author, int>
    {
        public AuthorRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
