using AutoMapper;
using DoctorWho.Db.Entities;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace DoctorWho.Web.Controllers
{
    [ApiController]
    [Route("api/doctors")]
    public class DoctorsController : ControllerBase
    {
        private readonly IRepository<Doctor, Doctor, int> _doctorRepository;
        private readonly IMapper _mapper;

        public DoctorsController(IRepository<Doctor, Doctor, int> doctorRepository, IMapper mapper)
        {
            _doctorRepository = doctorRepository ??
                throw new ArgumentNullException(nameof(doctorRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public ActionResult<IEnumerable<DoctorDto>> GetDoctors()
        {
            var doctorsFromRepo = _doctorRepository.FindAll();

            return Ok(_mapper.Map<IEnumerable<DoctorDto>>(doctorsFromRepo));
        }
    }
}
