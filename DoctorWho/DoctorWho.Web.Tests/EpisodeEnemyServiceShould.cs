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
    public class EpisodeEnemyServiceShould
    {
        private readonly Mock<IRepository<EpisodeEnemy, EpisodeEnemy, int>> _episodeEnemyRepository;
        private IEpisodeEnemyService _episodeEnemyService;
        private readonly IMapper _mapper;

        public EpisodeEnemyServiceShould()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new EpisodeEnemyProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }

            _episodeEnemyRepository = new Mock<IRepository<EpisodeEnemy, EpisodeEnemy, int>>();
        }

        [Fact]
        public async void CreateEpisodeEnemy()
        {
            //-- Arrange
            var episodeEnemyToReturn = new EpisodeEnemy()
            {
                Id = 1,
                EnemyId = 1,
                EpisodeId = 1
            };

            _episodeEnemyRepository.Setup(p => p.Create(episodeEnemyToReturn)).ReturnsAsync(episodeEnemyToReturn);

            _episodeEnemyService = new EpisodeEnemyService(_episodeEnemyRepository.Object, _mapper);

            //-- Act
            var actualDoctor = await _episodeEnemyService.CreateEpisodeEnemy(_mapper.Map<EpisodeEnemyForCreationDto>(episodeEnemyToReturn));
            var expectedDoctor = _mapper.Map<EpisodeEnemyDto>(episodeEnemyToReturn);

            //-- Assert
            Assert.NotStrictEqual(expectedDoctor, actualDoctor);
        }
    }
}
