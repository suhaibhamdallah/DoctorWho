using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
using System;
using System.Collections.Generic;

namespace DoctorWho.Web.Services
{
    public class DoctorService : IService<DoctorDto>
    {
        private readonly IRepository<Doctor, Doctor, int> _doctorRepository;
        private readonly IMapper _mapper;

        public DoctorService(IRepository<Doctor, Doctor, int> doctorRepository, IMapper mapper)
        {
            _doctorRepository = doctorRepository ??
                throw new ArgumentNullException(nameof(doctorRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        public IEnumerable<DoctorDto> GetAll()
        {
            var doctorsFromRepo = _doctorRepository.FindAll();

            return _mapper.Map<IEnumerable<DoctorDto>>(doctorsFromRepo);
        }
    }
}
