using DoctorWho.Web.Filters;
using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using FluentValidation;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorWho.Web.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    [Authorize]
    public class DoctorsController : ControllerBase
    {
        private readonly IDoctorService _doctorService;
        private readonly IValidator<DoctorForManipulationDto> _doctorValidator;

        public DoctorsController(IDoctorService doctorService,
            IValidator<DoctorForManipulationDto> doctorValidator)
        {
            _doctorService = doctorService ??
                throw new ArgumentNullException(nameof(doctorService));

            _doctorValidator = doctorValidator ??
                throw new ArgumentNullException(nameof(doctorValidator));
        }

        /// <summary>
        /// Get all doctors
        /// </summary>
        /// <returns>Collection of doctors</returns>
        [HttpGet(Name = "GetDoctors")]
        [TypeFilter(typeof(CheckInformationRequestsFilter))]
        [TypeFilter(typeof(DoctorNamesRedactedFilter))]
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

            var result = await _doctorService.UpsertDoctor(doctor);

            return Ok(result);
        }

        /// <summary>
        /// Delete doctor by id
        /// </summary>
        /// <param name="doctorId"></param>
        /// <returns></returns>
        [HttpDelete("{doctorId}", Name = "Delete Doctor")]
        public async Task<ActionResult<DoctorDto>> DeleteDoctor([FromRoute] int doctorId)
        {
            var doctorToDelete = new DoctorForManipulationDto
            {
                Id = doctorId
            };

            var doctorValidatorResult = _doctorValidator.Validate(doctorToDelete,
                options =>
            {
                options.IncludeRuleSets("IdValidation");
            });

            if (!doctorValidatorResult.IsValid)
            {

                return BadRequest(doctorValidatorResult.Errors);
            }

            var doctorDeleted = await _doctorService.DeleteDoctor(doctorId);

            return Ok(doctorDeleted);
        }
    }
}
