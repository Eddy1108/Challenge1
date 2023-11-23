using Challenge1.Models;

namespace Challenge1.ViewModels;

public class HomeModel
{
    public IEnumerable<Customer> Customers { get; set; } = new List<Customer>();
}