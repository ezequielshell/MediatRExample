using MediatR;
using MediatRExample.Domain.Commands.Requests;
using MediatRExample.Infrastructure.Repository;

namespace MediatRExample.Application.Handlers
{

    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerRequest>
    {
    private readonly ICustomerRepository _repository;

    public DeleteCustomerHandler(ICustomerRepository repository)
    {
        _repository = repository;
    }
        public async Task<Unit> Handle(DeleteCustomerRequest request, CancellationToken cancellationToken)
        {
            var customer = await _repository.GetById(request.Id);
            await _repository.Delete(customer);
            return Unit.Value;
        }
    }
}
