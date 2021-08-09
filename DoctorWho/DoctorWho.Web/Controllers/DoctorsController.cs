using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DoctorWho.Web.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;

        public DoctorsController(IDoctorService doctorService)
        {
            _doctorService = doctorService ??
                throw new ArgumentNullException(nameof(doctorService));
        }

        [HttpGet(Name = "GetDoctors")]
        public ActionResult<IEnumerable<DoctorDto>> GetDoctors()
        {
            var doctors = _doctorService.GetDoctors();

            return Ok(doctors);
        }
    }
}
