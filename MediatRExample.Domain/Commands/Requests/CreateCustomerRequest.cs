using MediatR;

namespace MediatRExample.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
