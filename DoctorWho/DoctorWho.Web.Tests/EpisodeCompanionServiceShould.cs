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
    public class EpisodeCompanionServiceShould
    {
        private readonly Mock<IRepository<EpisodeCompanion, EpisodeCompanion, int>> _episodeCompanionRepository;
        private IEpisodeCompanionService _episodeCompanionService;
        private readonly IMapper _mapper;

        public EpisodeCompanionServiceShould()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new EpisodeCompanionProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }

            _episodeCompanionRepository = new Mock<IRepository<EpisodeCompanion, EpisodeCompanion, int>>();
        }

        [Fact]
        public async void CreateEpisodeCompanion()
        {
            //-- Arrange
            var episodeCompanionToReturn = new EpisodeCompanion()
            {
                Id = 1,
                CompanionId = 1,
                EpisodeId = 1
            };

            _episodeCompanionRepository.Setup(p => p.Create(episodeCompanionToReturn)).ReturnsAsync(episodeCompanionToReturn);

            _episodeCompanionService = new EpisodeCompanionService(_episodeCompanionRepository.Object, _mapper);

            //-- Act
            var actualDoctor = await _episodeCompanionService.CreateEpisodeCompanion(_mapper.Map<EpisodeCompanionForCreationDto>(episodeCompanionToReturn));
            var expectedDoctor = _mapper.Map<EpisodeCompanionDto>(episodeCompanionToReturn);

            //-- Assert
            Assert.NotStrictEqual(expectedDoctor, actualDoctor);
        }
    }
}
