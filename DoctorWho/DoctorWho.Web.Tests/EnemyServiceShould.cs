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
    public class EnemyServiceShould
    {
        private readonly Mock<IRepository<Enemy, Enemy, int>> _enemyRepository;
        private IEnemyService _enemyService;
        private readonly IMapper _mapper;

        public EnemyServiceShould()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new EnemyProfile());;
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }

            _enemyRepository = new Mock<IRepository<Enemy, Enemy, int>>();
        }

        [Fact]
        public async void GetEnemy()
        {
            //-- Arrange
            var enemyForReturn = new Enemy()
            {
                Id = 1,
                EnemyName = "Fiasal",
                Description = "bla bla bla"
            };

            _enemyRepository.Setup(p => p.FindById(1)).ReturnsAsync(enemyForReturn);

            _enemyService = new EnemyService(_enemyRepository.Object, _mapper);

            //-- Act
            var actualEnemy = await _enemyService.GetEnemy(1);
            var expectedEnemy = _mapper.Map<EnemytDto>(enemyForReturn);

            //-- Assert
            Assert.NotStrictEqual(expectedEnemy, actualEnemy);
        }
    }
}
