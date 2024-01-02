using Library.Application.Commands.CreateBook;
using Library.Application.Commands.DeleteBook;
using Library.Application.Queries.GetAllBooks;
using Library.Application.Queries.GetBookById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers
{
    [Route("api/books")]
    public class BooksController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BooksController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> GetAll()
        {
            var getAllProjectsQuery = new GetAllBooksQuery();

            var projects = await _mediator.Send(getAllProjectsQuery);

            return Ok(projects);
        }

        // api/projects/2
        [HttpGet("{id}")]
        [Authorize(Roles = "admin, user")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetBooksByIdQuery(id);

            var project = await _mediator.Send(query);

            if (project == null)
            {
                return NotFound();
            }

            return Ok(project);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Post([FromBody] CreateBookCommand command)
        {
            var id = await _mediator.Send(command);

            return CreatedAtAction(nameof(GetById), new { id = id }, command);
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Delete(int id)
        {
            var command = new DeleteBookCommand(id);

            await _mediator.Send(command);

            return NoContent();
        }
    }
}
