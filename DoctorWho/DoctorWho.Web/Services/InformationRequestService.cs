using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Enums;
using DoctorWho.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public class InformationRequestService : IInformationRequestService
    {
        private readonly IInformationRequestRepository<InformationRequest, InformationRequest, string> _informationRequestRepository;
        private readonly IMapper _mapper;

        public InformationRequestService(IInformationRequestRepository<InformationRequest, InformationRequest, string> informationRequestRepository,
            IMapper mapper)
        {
            _informationRequestRepository = informationRequestRepository ??
                throw new ArgumentNullException(nameof(informationRequestRepository));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Approve Information request
        /// </summary>
        /// <param name="requestId"></param>
        /// <returns></returns>
        public async Task<InformationRequestDto> ApproveInformationRequest(string requestId)
        {
            var informationRequestToApprove = await _informationRequestRepository.FindById(requestId);
            informationRequestToApprove.ApprovalStatus = (int)ApprovalStatus.Approved;

            var approvedInformationRequest = _informationRequestRepository.Update(informationRequestToApprove);

            var approvedInformationRequestToReturn = _mapper.Map<InformationRequestDto>(approvedInformationRequest);

            return approvedInformationRequestToReturn;
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

        /// <summary>
        /// Get user's approved request
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<InformationRequestDto>> GetActiveApprovedInformationRequests(string userId)
        {
            var currentDateTime = DateTime.Now;

            var userApprovedInformationRequests = (await GetInformationRequestsByApprovalStatus(userId, ApprovalStatus.Approved))
                .Where(informationRequest =>
                informationRequest.StartTime < currentDateTime &&
                informationRequest.EndTime > currentDateTime);

            var userApprovedInformationRequestsToReturn = _mapper
                .Map<IEnumerable<InformationRequestDto>>(userApprovedInformationRequests);

            return userApprovedInformationRequestsToReturn;
        }

        /// <summary>
        /// Get user's pending request
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<InformationRequestDto>> GetActivePendingInformationRequests(string userId)
        {
            var currentDateTime = DateTime.Now;

            var userPendingInformationRequests = (await GetInformationRequestsByApprovalStatus(userId, ApprovalStatus.Unknown))
                .Where(informationRequest =>
                informationRequest.StartTime < currentDateTime &&
                informationRequest.EndTime > currentDateTime); ;

            var userPendingInformationRequestsToReturn = _mapper
                .Map<IEnumerable<InformationRequestDto>>(userPendingInformationRequests);

            return userPendingInformationRequestsToReturn;
        }

        /// <summary>
        /// Get all pending information requests
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<InformationRequestDto>> GetActivePendingInformationRequests()
        {
            var pendingInformationRequests = await _informationRequestRepository.FindAll();

            var pendingInformationRequestsToReturn = _mapper
                .Map<IEnumerable<InformationRequestDto>>(pendingInformationRequests);

            return pendingInformationRequestsToReturn;
        }

        /// <summary>
        /// Get information request by approvalstatus
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="approvalStatus"></param>
        /// <returns></returns>
        private async Task<IEnumerable<InformationRequestDto>> GetInformationRequestsByApprovalStatus(string userId, ApprovalStatus approvalStatus)
        {
            var userInformationRequests = await _informationRequestRepository
                .FindByIdAndApprovalStatus(userId, (int)approvalStatus);

            var userInformationRequestsToReturn = _mapper
                .Map<IEnumerable<InformationRequestDto>>(userInformationRequests);

            return userInformationRequestsToReturn;
        }
    }
}
