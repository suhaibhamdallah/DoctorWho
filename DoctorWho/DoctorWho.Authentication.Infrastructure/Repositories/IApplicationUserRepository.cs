using DoctorWho.Authentication.Db.Models;
using DoctorWho.Authentication.Infrastructure.Enumeration;
using System.Threading.Tasks;

namespace DoctorWho.Authentication.Infrastructure.Repositories
{
    public interface IApplicationUserRepository
    {
        public Task AddRoleToUser(ApplicationUser user, UserRoles role);
        public Task<bool> IsUserExist(string userName);
    }
}
