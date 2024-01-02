using Library.Application.Commands.CreateLoan;
using Library.Application.Commands.ReturnBook;
using Library.Application.Queries.GetLoanById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Library.Api.Controllers
{

    [Route("api/Loan")]
    public class LoanController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LoanController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Post([FromBody] CreateLoanCommand command)
        {
            try
            {

                var id = await _mediator.Send(command);

                return CreatedAtAction(nameof(GetById), new { id = id }, command);

            }
            catch (Exception ex)
            {
                return StatusCode(409, ex.Message);
            }
        }

        [HttpPut("{id}/returnBook")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> ReturnBook(int id)
        {
            try
            {
                var command = new ReturnBookCommand(id);

                var idResult = await _mediator.Send(command);

                return CreatedAtAction(nameof(GetById), new { id = idResult }, command);

            }
            catch (Exception ex)
            {
                return StatusCode(409, ex.Message);
            }
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> GetById(int id)
        {
            var query = new GetLoansByIdQuery(id);

            var loan = await _mediator.Send(query);

            if (loan == null)
            {
                return NotFound();
            }

            return Ok(loan);
        }

    }
}
