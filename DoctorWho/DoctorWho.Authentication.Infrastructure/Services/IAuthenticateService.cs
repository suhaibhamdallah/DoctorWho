using DoctorWho.Authentication.Infrastructure.Models;
using System.Threading.Tasks;

namespace DoctorWho.Authentication.Infrastructure.Services
{
    public interface IAuthenticateService
    {
        public Task<Response> RegisterUser(UserForCreationDto user);
        public Task<Response> RegisterAdmin(UserForCreationDto user);
        public Task<SuccessfullLoginResponse> Login(UserForLoginDto user);
    }
}
