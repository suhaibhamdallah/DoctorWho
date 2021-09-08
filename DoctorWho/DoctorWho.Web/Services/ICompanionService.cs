using DoctorWho.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public interface ICompanionService
    {
        public Task<IEnumerable<CompanionDto>> GetCompanions();
        public Task<CompanionDto> GetCompanion(int companionId);
        public bool IsCompanionExist(int comanionId);
    }
}
