using MediatR;
using MediatRExample.Domain.Commands.Responses;

namespace MediatRExample.Domain.Commands.Requests
{
    public class CreateCustomerRequest : IRequest<CreateCustomerResponse>
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
    }
}
