using DoctorWho.Web.Models;
using System.Collections.Generic;

namespace DoctorWho.Web.Services
{
    public interface IDoctorService
    {
        IEnumerable<DoctorDto> GetDoctors();
    }
}
