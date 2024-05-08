using MediatR;
using MediatRExample.Domain.Commands.Requests;
using MediatRExample.Domain.Entity;
using MediatRExample.Infrastructure.Repository;

namespace MediatRExample.Application.Handlers
{
    public class GetByIdCustomerHandler : IRequestHandler<GetByIdCustomerRequest, Customer>
    {
        private readonly ICustomerRepository _repository;

        public GetByIdCustomerHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Customer> Handle(GetByIdCustomerRequest request, CancellationToken cancellationToken)
        {
            return await _repository.GetById(request.Id);
        }
    }
}
