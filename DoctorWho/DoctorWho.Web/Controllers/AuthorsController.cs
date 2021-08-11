using DoctorWho.Web.Models;
using DoctorWho.Web.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DoctorWho.Web.Controllers
{
    [ApiController]
    [Route("api/authors")]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService _authorService;

        public AuthorsController(IAuthorService authorService)
        {
            _authorService = authorService ??
                throw new ArgumentNullException(nameof(authorService));
        }

        /// <summary>
        /// Update Author
        /// </summary>
        /// <param name="authorId"></param>
        /// <param name="author"></param>
        /// <returns></returns>
        [HttpPut("{authorId}", Name = "PutAuthor")]
        public ActionResult<AuthorDto> UpdateAuthor([FromRoute] int authorId,
            [FromBody] AuthorForUpdateDto author)
        {
            if (!_authorService.IsAuthorExist(authorId))
            {

                return BadRequest();
            }

            var updatedAuthor = _authorService.UpdateAuthor(authorId, author);

            return Ok(updatedAuthor);
        }
    }
}
