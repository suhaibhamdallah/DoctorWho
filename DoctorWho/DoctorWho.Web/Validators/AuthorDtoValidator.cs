using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using FluentValidation;
using System;
using System.Threading.Tasks;

namespace DoctorWho.Web.Validators
{
    public class AuthorDtoValidator : AbstractValidator<AuthorDto>
    {
        private readonly IAuthorService _authorService;

        public AuthorDtoValidator(IAuthorService authorService)
        {
            _authorService = authorService ??
                throw new ArgumentNullException(nameof(authorService));

            RuleFor(author => author.Id)
                .MustAsync((authorId, token) => CheckAuthorId(authorId))
                .WithMessage("Invalid Id");
        }

        private async Task<bool> CheckAuthorId(int authorId)
        {

            return _authorService.IsAuthorExist(authorId);
        }
    }
}
