using DoctorWho.Db.Models;

namespace DoctorWho.Db.Repositories
{
    public class InformationRequestRepository : Repository<InformationRequest, InformationRequest, string>
    {
        public InformationRequestRepository(DoctorWhoCoreDbContext context) : base(context)
        {

        }
    }
}
