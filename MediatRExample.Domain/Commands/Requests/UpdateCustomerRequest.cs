using MediatR;

namespace MediatRExample.Domain.Commands.Requests
{
    public class UpdateCustomerRequest : IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
    }
}
