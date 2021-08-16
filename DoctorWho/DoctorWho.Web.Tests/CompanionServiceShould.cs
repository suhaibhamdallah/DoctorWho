using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
using DoctorWho.Web.Profiles;
using DoctorWho.Web.Services;
using Moq;
using Xunit;

namespace DoctorWho.Web.Tests
{
    public class CompanionServiceShould
    {
        private readonly Mock<IRepository<Companion, Companion, int>> _companionRepository;
        private ICompanionService _companionService;
        private readonly IMapper _mapper;

        public CompanionServiceShould()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new CompanionProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }

            _companionRepository = new Mock<IRepository<Companion, Companion, int>>();
        }

        [Fact]
        public async void GetCompanion()
        {
            //-- Arrange
            var CompanionToReturn = new Companion()
            {
                Id = 1,
                CompanionName = "Suhaib",
                WhoPlayed = "bla bla"
            };

            _companionRepository.Setup(p => p.FindById(1)).ReturnsAsync(CompanionToReturn);

            _companionService = new CompanionService(_companionRepository.Object, _mapper);

            //-- Act
            var actualCompanion = await _companionService.GetCompanion(1);
            var expectedCompanion = _mapper.Map<CompanionDto>(CompanionToReturn);

            //-- Assert
            Assert.NotStrictEqual(expectedCompanion, actualCompanion);
        }
    }
}
