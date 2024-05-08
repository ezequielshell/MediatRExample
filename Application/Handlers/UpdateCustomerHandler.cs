using MediatR;
using MediatRExample.Domain.Commands.Requests;
using MediatRExample.Infrastructure.Repository;

namespace MediatRExample.Application.Handlers
{
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerRequest>
    {

        private readonly ICustomerRepository _repository;

        public UpdateCustomerHandler(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public async Task<Unit> Handle(UpdateCustomerRequest request, CancellationToken cancellationToken)
        {
            var customer = await _repository.GetById(request.Id);
            customer.Name = request.Name;
            customer.Email = request.Email;
            _repository.Update(customer);
            return Unit.Value;
        }
    }
}
