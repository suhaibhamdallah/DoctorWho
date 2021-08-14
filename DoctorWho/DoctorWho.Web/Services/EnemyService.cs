using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
using System;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public class EnemyService : IEnemyService
    {
        private readonly IRepository<Enemy, Enemy, int> _enemyRepository;
        private readonly IMapper _mapper;

        public EnemyService(IRepository<Enemy, Enemy, int> enemyRepository, IMapper mapper)
        {
            _enemyRepository = enemyRepository ??
                throw new ArgumentNullException(nameof(enemyRepository));

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        public async Task<EnemytDto> GetEnemy(int enemyId)
        {
            var enemyFromRepo = await _enemyRepository.FindById(enemyId);

            var enemyToReturn = _mapper.Map<EnemytDto>(enemyFromRepo);

            return enemyToReturn;
        }

        public bool IsEnemyExist(int enemyId)
        {
            return !(GetEnemy(enemyId).Result is null);
        }
    }
}
