using MediatR;
using MediatRExample.Domain.Commands.Requests;
using MediatRExample.Domain.Entity;
using MediatRExample.Infrastructure.Repository;

namespace MediatRExample.Infrastructure.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest>
    {

        private readonly ICustomerRepository _repository;

        public CreateCustomerHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var customer = new Customer
            {
                Email = request.Email,
                Name = request.Name,
            };

            await _repository.Create(customer);
            return Unit.Value;
        }
    }
}
