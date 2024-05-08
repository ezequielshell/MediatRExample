using MediatR;

namespace MediatRExample.Domain.Commands.Requests
{
    public class DeleteCustomerRequest : IRequest
    {
        public int Id { get; set; }
    }
}
