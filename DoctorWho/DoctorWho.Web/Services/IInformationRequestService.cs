using DoctorWho.Web.Models;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public interface IInformationRequestService
    {
        public Task<InformationRequestDto> CreateInformationRequest(InformationRequestForCreationDto informationRequest);
    }
}
