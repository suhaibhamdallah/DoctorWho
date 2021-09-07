using DoctorWho.Db.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorWho.Db.Repositories
{
    public interface IInformationRequestRepository<TEntity, VEntity, TId> : IRepository<TEntity, VEntity, TId>
    {
        public Task<IEnumerable<InformationRequest>> FindByIdAndApprovalStatus(string id, int approvalStatus);
    }
}
