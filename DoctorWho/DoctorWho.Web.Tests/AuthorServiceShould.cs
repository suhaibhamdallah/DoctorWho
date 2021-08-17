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
    public class AuthorServiceShould
    {
        private readonly Mock<IRepository<Author, Author, int>> _authorRepository;
        private IAuthorService _authorService;
        private readonly IMapper _mapper;

        public AuthorServiceShould()
        {
            if (_mapper == null)
            {
                var mappingConfig = new MapperConfiguration(mc =>
                {
                    mc.AddProfile(new AuthorsProfile());
                });
                IMapper mapper = mappingConfig.CreateMapper();
                _mapper = mapper;
            }

            _authorRepository = new Mock<IRepository<Author, Author, int>>();
        }

        [Fact]
        public async void GetAuthor()
        {
            //-- Arrange
            var AuthorToReturn = new Author()
            {
                Id = 1,
                AuthorName = "Suhaib Hamdallah"
            };

            _authorRepository.Setup(p => p.FindById(1)).ReturnsAsync(AuthorToReturn);

            _authorService = new AuthorService(_authorRepository.Object, _mapper);

            //-- Act
            var actualDoctor = await _authorService.GetAuthor(1);
            var expectedDoctor = _mapper.Map<AuthorDto>(AuthorToReturn);

            //-- Assert
            Assert.NotStrictEqual(expectedDoctor, actualDoctor);
        }

        [Fact]
        public void UpdateAuthor()
        {
            //-- Arrange
            var authorToUpdate = new Author()
            {
                Id = 1,
                AuthorName = "Suhaib Hamdallah"
            };

            _authorRepository.Setup(p => p.Update(authorToUpdate)).Returns(authorToUpdate);

            _authorService = new AuthorService(_authorRepository.Object, _mapper);

            //-- Act
            var actualAuthor = _authorService.UpdateAuthor(_mapper.Map<AuthorDto>(authorToUpdate));
            var expectedAuthor = _mapper.Map<AuthorDto>(authorToUpdate);

            //-- Assert
            Assert.NotStrictEqual(expectedAuthor, actualAuthor);
        }
    }
}
