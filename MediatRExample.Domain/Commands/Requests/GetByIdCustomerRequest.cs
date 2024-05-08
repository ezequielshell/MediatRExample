using MediatR;
using MediatRExample.Domain.Entity;

namespace MediatRExample.Domain.Commands.Requests
{
    public class GetByIdCustomerRequest : IRequest<Customer>
    {
        public int Id { get; set; }
    }
}
