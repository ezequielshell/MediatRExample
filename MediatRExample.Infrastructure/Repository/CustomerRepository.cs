using MediatRExample.Domain.Data;
using MediatRExample.Domain.Entity;
using Microsoft.EntityFrameworkCore;

namespace MediatRExample.Infrastructure.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IList<Customer>> GetAll()
        {
            return await _context.Customer.ToListAsync();
        }

        public async Task<Customer> GetById(int id)
        {
            return await _context.Customer.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Create(Customer customer)
        {
            await _context.Customer.AddAsync(customer);
            await _context.SaveChangesAsync();
        }

        public void Update(Customer customer)
        {
            _context.Customer.Update(customer);
            _context.SaveChanges();
        }

        public async Task Delete (Customer customer)
        {
            _context.Customer.Remove(customer);
            await _context.SaveChangesAsync();
        }
    }
}
