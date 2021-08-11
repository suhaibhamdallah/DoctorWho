using DoctorWho.Db.Models;
using DoctorWho.Web.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public interface IDoctorService
    {
        public Task<IEnumerable<DoctorDto>> GetDoctors();
        public Task<DoctorDto> GetDoctor(int doctorId);
        public Task<DoctorDto> AddDoctor(DoctorForManipulationDto doctor);
        public DoctorDto UpdateDoctor(DoctorForManipulationDto doctor);
        public Task<DoctorDto> UpsertDoctor(DoctorForManipulationDto doctor);
        public bool DoctorExist(int? doctorId);
    }
}
