using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
using System;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public class InformationRequestService : IInformationRequestService
    {
        private readonly IRepository<InformationRequest, InformationRequest, string> _informationRequestRepository;
        private readonly IMapper _mapper;

        public InformationRequestService(IRepository<InformationRequest, InformationRequest, string> informationRequestRepository,
            IMapper mapper)
        {
            _informationRequestRepository = informationRequestRepository ??
                throw new ArgumentNullException(nameof(informationRequestRepository));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Create now information request
        /// </summary>
        /// <param name="informationRequest"></param>
        /// <returns></returns>
        public async Task<InformationRequestDto> CreateInformationRequest(InformationRequestForCreationDto informationRequest)
        {
            var informationRequestToCreate = _mapper.Map<InformationRequest>(informationRequest);
            informationRequestToCreate.Id = Guid.NewGuid().ToString();

            var informationRequestCreated = await _informationRequestRepository.Create(informationRequestToCreate);

            var informationRequestToReturn = _mapper.Map<InformationRequestDto>(informationRequestCreated);

            return informationRequestToReturn;
        }
    }
}
