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
        private readonly IService<DoctorDto> _doctorService;

        public DoctorsController(IService<DoctorDto> doctorService)
        {
            _doctorService = doctorService ??
                throw new ArgumentNullException(nameof(doctorService));
        }

        [HttpGet]
        public ActionResult<IEnumerable<DoctorDto>> GetDoctors()
        {
            var doctors = _doctorService.GetAll();

            return Ok(doctors);
        }
    }
}
