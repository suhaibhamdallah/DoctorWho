using DoctorWho.Web.Models;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public interface ICompanionService
    {
        public Task<CompanionDto> GetCompanion(int companionId);
        public bool IsCompanionExist(int comanionId);
    }
}
