using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
using System;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public class CompanionService : ICompanionService
    {
        private readonly IRepository<Companion, Companion, int> _companionRepository;
        private readonly IMapper _mapper;

        public CompanionService(IRepository<Companion, Companion, int> companionRepository, IMapper mapper)
        {
            _companionRepository = companionRepository ??
                throw new ArgumentNullException(nameof(companionRepository)); ;

            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper)); ;
        }

        /// <summary>
        /// Get companion by id
        /// </summary>
        /// <param name="companionId"></param>
        /// <returns></returns>
        public async Task<CompanionDto> GetCompanion(int companionId)
        {
            var companionFromRepo = await _companionRepository.FindById(companionId);

            var companionToReturn = _mapper.Map<CompanionDto>(companionFromRepo);

            return companionToReturn;
        }

        /// <summary>
        /// Check if companion exist
        /// </summary>
        /// <param name="comanionId"></param>
        /// <returns></returns>
        public bool IsCompanionExist(int comanionId)
        {

            return !(GetCompanion(comanionId).Result is null);
        }
    }
}
