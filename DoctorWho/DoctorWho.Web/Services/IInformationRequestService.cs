﻿using DoctorWho.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public interface IInformationRequestService
    {
        public Task<InformationRequestDto> CreateInformationRequest(InformationRequestForCreationDto informationRequest);
        public Task<IEnumerable<InformationRequestDto>> GetPendingInformationRequests(string userId);
        public Task<IEnumerable<InformationRequestDto>> GetPendingInformationRequests();
        public Task<InformationRequestDto> ApproveInformationRequest(string requestId);
        public Task<IEnumerable<InformationRequestDto>> GetApprovedInformationRequests(string userId);
    }
}
