using MediatR;
using MediatRExample.Domain.Entity;

namespace MediatRExample.Domain.Commands.Requests
{
    public class GetAllCustomerRequest : IRequest<IList<Customer>>
    {
    }
}
