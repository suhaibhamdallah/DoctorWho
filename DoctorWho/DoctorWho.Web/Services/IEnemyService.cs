using DoctorWho.Web.Models;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public interface IEnemyService
    {
        public Task<EnemytDto> GetEnemy(int enemyId);
        public bool IsEnemyExist(int enemyId);
    }
}
