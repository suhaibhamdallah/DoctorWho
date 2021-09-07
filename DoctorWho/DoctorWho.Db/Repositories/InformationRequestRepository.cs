﻿using DoctorWho.Db.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DoctorWho.Db.Repositories
{
    public class InformationRequestRepository : Repository<InformationRequest, InformationRequest, string>, 
        IInformationRequestRepository<InformationRequest, InformationRequest, string>
    {
        public InformationRequestRepository(DoctorWhoCoreDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<InformationRequest>> FindByIdAndApprovalStatus(string id, int approvalStatus)
        {

            return await context.Set<InformationRequest>()
                .Where(request => request.UserId == id && request.ApprovalStatus == approvalStatus)
                .ToListAsync();
        }
    }
}
