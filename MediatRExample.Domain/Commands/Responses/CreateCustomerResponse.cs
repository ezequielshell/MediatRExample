namespace MediatRExample.Domain.Commands.Responses
{
    public class CreateCustomerResponse
    {
        public Guid id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }

    }
}
