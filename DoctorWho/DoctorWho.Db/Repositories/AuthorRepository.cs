using DoctorWho.Db.Entities;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository : Repository<Author, Author, int>
    {
        public AuthorRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
