using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
using DoctorWho.Web.Profiles;
using DoctorWho.Web.Services;
using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace DoctorWho.Web.Tests
{
    public class DoctorServiceShould
    {
        private readonly Mock<IRepository<Doctor, Doctor, int>> _doctorRepository;
        private IDoctorService _doctorService;
        private readonly IMapper _mapper;

        public DoctorServiceShould()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new DoctorsProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }

            _doctorRepository = new Mock<IRepository<Doctor, Doctor, int>>();
        }

        [Fact]
        public async void GetDoctors()
        {
            // -- Arrange 
            var collectionOfDoctorsShouldReturn = new List<Doctor>
            {
                new Doctor
                {
                    Id = 1,
                    DoctorNumber = 1,
                    DoctorName = "Suhaib Hamdallah",
                    BithDate = new DateTime(1999, 3, 11, 0, 0, 0),
                    FirstEpisodeDate = new DateTime(2017, 3, 11, 0, 0, 0),
                    LastEpisodeDate = new DateTime(2020, 3, 11, 0, 0, 0)
                },
                new Doctor
                {
                    Id = 2,
                    DoctorNumber = 2,
                    DoctorName = "Anas Zakarneh",
                    BithDate = new DateTime(1999, 3, 11, 0, 0, 0),
                    FirstEpisodeDate = new DateTime(2017, 3, 11, 0, 0, 0),
                    LastEpisodeDate = new DateTime(2020, 3, 11, 0, 0, 0)
                }
            };

            _doctorRepository.Setup(p => p.FindAll()).ReturnsAsync(collectionOfDoctorsShouldReturn);

            _doctorService = new DoctorService(_doctorRepository.Object, _mapper);

            // -- Act
            var actualCollectionOfDoctors = await _doctorService.GetDoctors();
            var expectedCollectionOfDoctors = _mapper.Map<IEnumerable<DoctorDto>>(collectionOfDoctorsShouldReturn);

            // -- Assert 
            Assert.NotStrictEqual(expectedCollectionOfDoctors, actualCollectionOfDoctors);
        }

        [Fact]
        public async void GetDoctor()
        {
            //-- Arrange
            var doctorToReturn = new Doctor()
            {
                Id = 1,
                DoctorNumber = 1,
                DoctorName = "Suhaib Hamdallah",
                BithDate = new DateTime(1999, 3, 11, 0, 0, 0),
                FirstEpisodeDate = new DateTime(2017, 3, 11, 0, 0, 0),
                LastEpisodeDate = new DateTime(2020, 3, 11, 0, 0, 0)
            };

            _doctorRepository.Setup(p => p.FindById(1)).ReturnsAsync(doctorToReturn);

            _doctorService = new DoctorService(_doctorRepository.Object, _mapper);

            //-- Act
            var actualDoctor = await _doctorService.GetDoctor(1);
            var expectedDoctor = _mapper.Map<DoctorDto>(doctorToReturn);

            //-- Assert
            Assert.NotStrictEqual(expectedDoctor, actualDoctor);
        }

        [Fact]
        public async void AddDoctor()
        {
            //-- Arrange
            var doctorToReturn = new Doctor()
            {
                Id = 1,
                DoctorNumber = 1,
                DoctorName = "Suhaib Hamdallah",
                BithDate = new DateTime(1999, 3, 11, 0, 0, 0),
                FirstEpisodeDate = new DateTime(2017, 3, 11, 0, 0, 0),
                LastEpisodeDate = new DateTime(2020, 3, 11, 0, 0, 0)
            };

            _doctorRepository.Setup(p => p.Create(doctorToReturn)).ReturnsAsync(doctorToReturn);

            _doctorService = new DoctorService(_doctorRepository.Object, _mapper);

            //-- Act
            var actualDoctor = await _doctorService.AddDoctor(_mapper.Map<DoctorForManipulationDto>(doctorToReturn));
            var expectedDoctor = _mapper.Map<DoctorDto>(doctorToReturn);

            //-- Assert
            Assert.NotStrictEqual(expectedDoctor, actualDoctor);
        }

        [Fact]
        public void UpdateDoctor()
        {
            //-- Arrange
            var doctorToUpdate = new Doctor()
            {
                Id = 1,
                DoctorNumber = 1,
                DoctorName = "Suhaib",
                BithDate = new DateTime(1999, 3, 11, 0, 0, 0),
                FirstEpisodeDate = new DateTime(2017, 3, 11, 0, 0, 0),
                LastEpisodeDate = new DateTime(2020, 3, 11, 0, 0, 0)
            };

            _doctorRepository.Setup(p => p.Update(doctorToUpdate)).Returns(doctorToUpdate);

            _doctorService = new DoctorService(_doctorRepository.Object, _mapper);

            //-- Act
            var actualDoctor = _doctorService.UpdateDoctor(_mapper.Map<DoctorForManipulationDto>(doctorToUpdate));
            var expectedDoctor = _mapper.Map<DoctorDto>(doctorToUpdate);

            //-- Assert
            Assert.NotStrictEqual(expectedDoctor, actualDoctor);
        }

        [Fact]
        public async void UpsertDoctor()
        {
            //-- Arrange
            var doctorToUpsert = new Doctor()
            {
                Id = 1,
                DoctorName = "Suhaib HAM"
            };

            _doctorRepository.Setup(p => p.Update(doctorToUpsert)).Returns(doctorToUpsert);

            _doctorService = new DoctorService(_doctorRepository.Object, _mapper);

            //-- Act
            var actualDoctor = await _doctorService.UpsertDoctor(_mapper.Map<DoctorForManipulationDto>(doctorToUpsert));
            var expectedDoctor = _mapper.Map<DoctorDto>(doctorToUpsert);

            //-- Assert
            Assert.NotStrictEqual(expectedDoctor, actualDoctor);
        }

        [Fact]
        public async void DeleteDoctor()
        {
            //-- Arrange
            var doctorToDelete = new Doctor()
            {
                Id = 1,
                DoctorNumber = 1,
                DoctorName = "Suhaib",
                BithDate = new DateTime(1999, 3, 11, 0, 0, 0),
                FirstEpisodeDate = new DateTime(2017, 3, 11, 0, 0, 0),
                LastEpisodeDate = new DateTime(2020, 3, 11, 0, 0, 0)
            };

            _doctorRepository.Setup(p => p.Delete(doctorToDelete)).Returns(doctorToDelete);

            _doctorService = new DoctorService(_doctorRepository.Object, _mapper);

            //-- Act
            var actualDoctor = await _doctorService.DeleteDoctor(1);
            var expectedDoctor = _mapper.Map<DoctorDto>(doctorToDelete);

            //-- Assert
            Assert.NotStrictEqual(expectedDoctor, actualDoctor);
        }
    }
}
