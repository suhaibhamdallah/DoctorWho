using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DoctorWho.Web.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;
        private readonly IValidator<AuthorDto> _authorValidator;

        public AuthorsController(IAuthorService authorService, IValidator<AuthorDto> authorValidator)
        {
            _authorService = authorService ??
                throw new ArgumentNullException(nameof(authorService));

            _authorValidator = authorValidator ??
                throw new ArgumentNullException(nameof(authorValidator));
        }

        /// <summary>
        /// Update Author
        /// </summary>
        /// <param name="authorId"></param>
        /// <param name="author"></param>
        /// <returns></returns>
        [HttpPut("{authorId}", Name = "PutAuthor")]
        public ActionResult<AuthorDto> UpdateAuthor([FromRoute] int authorId, [FromBody] AuthorDto authorToUpdate)
        {
            authorToUpdate.Id = authorId;

            var authorValidatorResult = _authorValidator.Validate(authorToUpdate);

            if (!authorValidatorResult.IsValid)
            {

                return BadRequest(authorValidatorResult.Errors);
            }

            var updatedAuthor = _authorService.UpdateAuthor(authorToUpdate);

            return Ok(updatedAuthor);
        }
    }
}
