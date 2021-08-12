using DoctorWho.Web.Models;
using System.Threading.Tasks;

namespace DoctorWho.Web.Services
{
    public interface IAuthorService
    {
        public AuthorDto UpdateAuthor(AuthorDto author);
        public Task<AuthorDto> GetAuthor(int authorId);
        public bool IsAuthorExist(int authorId);
    }
}
