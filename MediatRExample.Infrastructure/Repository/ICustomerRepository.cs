using MediatRExample.Domain.Entity;

namespace MediatRExample.Infrastructure.Repository
{
    public interface ICustomerRepository
    {
        Task Create(Customer customer);
        Task<Customer> GetById(int id);
        void Update(Customer customer);
        Task Delete(Customer customer);
        Task<IList<Customer>> GetAll();
    }
}
