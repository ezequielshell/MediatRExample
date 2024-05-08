using MediatR;
using MediatRExample.Domain.Commands.Requests;
using MediatRExample.Domain.Entity;
using MediatRExample.Infrastructure.Repository;

namespace MediatRExample.Application.Handlers
{
    public class GetAllCustomerHandler : IRequestHandler<GetAllCustomerRequest, IList<Customer>>
    {

        private readonly ICustomerRepository _repository;

        public GetAllCustomerHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<IList<Customer>> Handle(GetAllCustomerRequest request, CancellationToken cancellationToken)
        {
            return await _repository.GetAll();
        }

    }
}
