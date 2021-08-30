﻿using AutoMapper;
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
        /// Get user's pending request
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public async Task<IEnumerable<InformationRequestDto>> GetPendingInformationRequests(string userId)
        {
            var userPendingInformationRequests = _informationRequestRepository
                .FindAll()
                .Result
                .Where(informationRequest =>
                informationRequest.ApprovalStatus == (int)ApprovalStatus.Unknown &&
                informationRequest.UserId == userId);

            var userPendingInformationRequestsToReturn = _mapper
                .Map<IEnumerable<InformationRequestDto>>(userPendingInformationRequests);

            return userPendingInformationRequestsToReturn;
        }
    }
}