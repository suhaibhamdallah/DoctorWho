using DoctorWho.Db.Models;
using DoctorWho.Db.Repositories;
using System.Linq;
using Xunit;

namespace DoctorWho.Db.Tests
{
    public class AuthorRepositoryShould
    {
        [Fact]
        public void AuthorShouldCreate()
        {
            // -- Arrange
            AuthorRepository authorRepository = new AuthorRepository(new DoctorWhoCoreDbContext());
            Author author = new Author()
            {
                AuthorName = "Suhaib Hamdallah"
            };

            var actualAuthor = authorRepository.Create(author).Result;

            // -- Act
            var expectedAuthorRepositoryRowsNum = authorRepository.FindAll().Result.ToList().Count;
            var expectedAuthorId = authorRepository.FindAll().Result.Last().Id; ;
            var expectedAuthorName = "Suhaib Hamdallah";

            var actualAuthorId = actualAuthor.Id;
            var actualAuthorName = actualAuthor.AuthorName;

            //-- Assert
            Assert.Equal(expectedAuthorRepositoryRowsNum, authorRepository.FindAll().Result.ToList().Count());
            Assert.Equal(expectedAuthorId, actualAuthorId);
            Assert.Equal(expectedAuthorName, actualAuthorName);
        }

        [Fact]
        public void AuthorShouldUpdate()
        {
            // -- Arrange
            AuthorRepository authorRepository = new AuthorRepository(new DoctorWhoCoreDbContext());
            Author author = new Author()
            {
                Id = 1,
                AuthorName = "Suhaib Zeyad"
            };

            var actualAuthor = authorRepository.Update(author);

            // -- Act
            var expectedAuthorName = "Suhaib Zeyad";
            var actualAuthorName = actualAuthor.AuthorName;

            //-- Assert
            Assert.Equal(expectedAuthorName, actualAuthorName);
        }

        [Fact]
        public void AuthorShouldDelete()
        {
            // -- Arrange
            AuthorRepository authorRepository = new AuthorRepository(new DoctorWhoCoreDbContext());
            Author obseleteAuthor = authorRepository.FindById(24).Result;

            authorRepository.Delete(obseleteAuthor);
            var expectedAuthorRepositoryRowsNum = authorRepository.FindAll().Result.ToList().Count() - 1;

            //-- Assert
            Assert.Equal(expectedAuthorRepositoryRowsNum, authorRepository.FindAll().Result.ToList().Count());
        }

        [Fact]
        public void AuthorShouldFindById()
        {
            // -- Arrange
            AuthorRepository authorRepository = new AuthorRepository(new DoctorWhoCoreDbContext());

            // -- Act
            Author expectedAuthor = new Author()
            {
                Id = 1,
                AuthorName = "Suhaib Zeyad"
            };

            var actualAuthor = authorRepository.FindById(1).Result;

            //-- Assert
            Assert.Equal(expectedAuthor.Id, actualAuthor.Id);
            Assert.Equal(expectedAuthor.AuthorName, actualAuthor.AuthorName);
        }

        [Fact]
        public void AuthorShouldFindAll()
        {
            // -- Arrange
            AuthorRepository authorRepository = new AuthorRepository(new DoctorWhoCoreDbContext());

            // -- Act
            var expectedAuthorRepositoryRowsNum = authorRepository.FindAll().Result.ToList().Count();
            var actualAuthorRepositoryRowsNum = authorRepository.FindAll().Result.ToList().Count();

            //-- Assert
            Assert.Equal(expectedAuthorRepositoryRowsNum, actualAuthorRepositoryRowsNum);
        }
    }
}
