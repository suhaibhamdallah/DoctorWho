using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public class DoctorService : IDoctorService
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

        /// <summary>
        /// Get all doctors
        /// </summary>
        /// <returns>Collection of doctors</returns>
        public async Task<IEnumerable<DoctorDto>> GetDoctors()
        {
            var doctorsFromRepo = await _doctorRepository.FindAll();

            return _mapper.Map<IEnumerable<DoctorDto>>(doctorsFromRepo);
        }

        /// <summary>
        /// Get doctor by id 
        /// </summary>
        /// <param name="doctorId">Doctor Id</param>
        /// <returns>The desired doctor</returns>
        public async Task<DoctorDto> GetDoctor(int doctorId)
        {
            var doctorFromRepo = await _doctorRepository.FindById(doctorId);

            return _mapper.Map<DoctorDto>(doctorFromRepo);
        }

        /// <summary>
        /// Add new doctor to the database
        /// </summary>
        /// <param name="doctor">Doctor to add</param>
        /// <returns>The added doctor</returns>
        public async Task<DoctorDto> AddDoctor(DoctorForManipulationDto doctor)
        {
            var doctorToAdd = _mapper.Map<Doctor>(doctor);

            var doctorAdded = await _doctorRepository.Create(doctorToAdd);

            return _mapper.Map<DoctorDto>(doctorAdded);
        }

        /// <summary>
        /// Update existence doctor 
        /// </summary>
        /// <param name="doctor"></param>
        /// <returns></returns>
        public DoctorDto UpdateDoctor(DoctorForManipulationDto doctor)
        {
            var doctorToUpdate = _mapper.Map<Doctor>(doctor);

            var doctorUpdated = _doctorRepository.Update(doctorToUpdate);

            return _mapper.Map<DoctorDto>(doctorUpdated);
        }

        /// <summary>
        /// Upsert doctor
        /// </summary>
        /// <param name="doctor"></param>
        /// <returns></returns>
        public async Task<DoctorDto> UpsertDoctor(DoctorForManipulationDto doctor)
        {
            if (doctor.Id is null)
            {
                var doctorAdded = await AddDoctor(doctor);

                return doctorAdded;
            }

            var doctorUpdated = UpdateDoctor(doctor);

            return doctorUpdated;
        }

        /// <summary>
        /// Check if the doctor exist in the database
        /// </summary>
        /// <param name="doctorId"></param>
        /// <returns></returns>
        public bool DoctorExist(int? doctorId)
        {
            if (GetDoctor((int)doctorId).Result is null)
            {
                return false;
            }

            return true;
        }
    }
}
