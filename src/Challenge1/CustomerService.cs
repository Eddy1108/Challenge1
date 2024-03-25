using Challenge1.Data;
using Challenge1.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Challenge1
{
    public class CustomerService(TheAppContext appContext)
    {
        public async Task<List<CustomerDTO>> GetCustomers()
        {
            return await appContext.Customers.
                Select(c => new CustomerDTO(){FirstName = c.FirstName, LastName = c.LastName, Id = c.Id})
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
