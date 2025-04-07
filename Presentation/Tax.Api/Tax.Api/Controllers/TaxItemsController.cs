using MediatR;
using Microsoft.AspNetCore.Mvc;
using Tax.Application.Commands;
using Tax.Application.Queries;

namespace Tax.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TaxItemsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TaxItemsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetTaxItems([FromQuery] int pageNumber = 1, [FromQuery] int pageSize = 10)
        {
            var query = new GetTaxItemsQuery(pageNumber, pageSize);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost("{id}/confirm")]
        public async Task<IActionResult> ConfirmTaxItem(int id)
        {
            var command = new ConfirmTaxItemCommand(id);
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
