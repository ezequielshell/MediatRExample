using MediatR;
using MediatRExample.Domain.Commands.Requests;
using MediatRExample.Infrastructure.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MediatRExample.Controllers
{
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ISender _mediator;

        public CustomerController(ISender mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("customers")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                return Ok(_mediator.Send(new GetAllCustomerRequest()));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpGet("customer")]
        public async Task<IActionResult> Get([FromBody] GetByIdCustomerRequest request)
        {
            try
            {
                return Ok(await _mediator.Send(request));
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPost("customer")]
        public async Task<IActionResult> Create([FromBody] CreateCustomerRequest request)
        {
            try
            {
                await _mediator.Send(request);
                return Created();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpPut("customer")]
        public async Task<IActionResult> Update([FromBody] UpdateCustomerRequest request)
        {
            try
            {
            await _mediator.Send(request);
            return Ok();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        [HttpDelete("customer")]
        public async Task<IActionResult> Delete(DeleteCustomerRequest request)
        {
            try
            {
            await _mediator.Send(request);
            return NoContent();
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}
