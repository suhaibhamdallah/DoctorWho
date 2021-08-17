using AutoMapper;
using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using DoctorWho.Web.Models;
using System;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IRepository<Author, Author, int> _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(IRepository<Author, Author, int> authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository ??
                throw new ArgumentNullException(nameof(authorRepository));
            _mapper = mapper ??
                throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Update Author
        /// </summary>
        /// <param name="author"></param>
        /// <returns></returns>
        public AuthorDto UpdateAuthor(AuthorDto author)
        {
            var authorToUpdate = _mapper.Map<Author>(author);

            var updatedAuthor = _authorRepository.Update(authorToUpdate);

            var updatedAuthorToReturn = _mapper.Map<AuthorDto>(updatedAuthor);

            return updatedAuthorToReturn;
        }

        /// <summary>
        /// Get Author By id
        /// </summary>
        /// <param name="authorId"></param>
        /// <returns></returns>
        public async Task<AuthorDto> GetAuthor(int authorId)
        {
            var authorFromRepo = await _authorRepository.FindById(authorId);

            var authorToReturn = _mapper.Map<AuthorDto>(authorFromRepo);

            return authorToReturn;
        }

        /// <summary>
        /// Check if author is exist
        /// </summary>
        /// <param name="authorId"></param>
        /// <returns></returns>
        public bool IsAuthorExist(int authorId)
        {

            return !(GetAuthor(authorId).Result is null);
        }
    }
}
