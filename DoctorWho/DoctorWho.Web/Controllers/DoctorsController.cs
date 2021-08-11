using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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

        /// <summary>
        /// Get all doctors
        /// </summary>
        /// <returns>Collection of doctors</returns>
        [HttpGet(Name = "GetDoctors")]
        public async Task<ActionResult<IEnumerable<DoctorDto>>> GetDoctors()
        {
            var doctors = await _doctorService.GetDoctors();

            return Ok(doctors);
        }

        /// <summary>
        /// Get doctor by id
        /// </summary>
        /// <param name="doctorId"></param>
        /// <param name="doctor"></param>
        /// <returns></returns>
        [HttpGet("{doctorId}", Name = "GetDoctor")]
        public async Task<ActionResult<DoctorDto>> GetDoctor([FromRoute] int doctorId)
        {
            var doctorFromService = await _doctorService.GetDoctor(doctorId);

            if (doctorFromService is null)
            {

                return NotFound();
            }

            return Ok(doctorFromService);
        }

        /// <summary>
        /// Upsert doctor
        /// </summary>
        /// <returns></returns>
        [HttpPost(Name = "UpsertDoctor")]
        public async Task<ActionResult<DoctorDto>> UpsertDoctor([FromBody] DoctorForManipulationDto doctor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            if (doctor.Id != null && !_doctorService.DoctorExist(doctor.Id))
            {
                return Problem(statusCode: 400, title: "Invalid Id");
            }

            var result = await _doctorService.UpsertDoctor(doctor);

            return Ok(result);
        }
    }
}
