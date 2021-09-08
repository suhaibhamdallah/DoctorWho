using DoctorWho.Authentication.Db.Models;
using DoctorWho.Authentication.Infrastructure.Enumeration;
using Microsoft.AspNetCore.Identity;
using System;
using System.Threading.Tasks;

namespace DoctorWho.Authentication.Infrastructure.Repositories
{
    public class ApplicationUserRepository : IApplicationUserRepository
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public ApplicationUserRepository(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager ??
                throw new ArgumentNullException(nameof(userManager));

            _roleManager = roleManager ??
                throw new ArgumentNullException(nameof(roleManager));
        }

        /// <summary>
        /// Add roles to user
        /// </summary>
        /// <param name="user"></param>
        /// <param name="role"></param>
        /// <returns></returns>
        public async Task AddRoleToUser(ApplicationUser user, UserRoles role)
        {
            if (!await _roleManager.RoleExistsAsync(role.ToString()))
            {
                await _roleManager.CreateAsync(new IdentityRole(role.ToString()));
            }

            if (await _roleManager.RoleExistsAsync(role.ToString()))
            {
                await _userManager.AddToRoleAsync(user, role.ToString());
            }
        }

        /// <summary>
        /// Check if user does not exist
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public async Task<bool> IsUserExist(string userName)
        {
            return (await _userManager.FindByNameAsync(userName)) != null;
        }
    }
}
