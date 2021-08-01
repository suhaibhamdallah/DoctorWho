using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class AuthorRepository : GenericRepository<Author>
    {
        public AuthorRepository(DoctorWhoCoreDbContext context) : base(context)
        {
        }
    }
}
