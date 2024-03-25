using Challenge1.ViewModels;

namespace Challenge1;

public interface ICustomerService
{
    Task<List<CustomerDTO>> GetCustomers();
}