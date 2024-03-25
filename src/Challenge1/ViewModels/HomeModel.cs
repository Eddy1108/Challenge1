namespace Challenge1.ViewModels;

public class HomeModel
{
    public IEnumerable<CustomerDTO> Customers { get; set; } = new List<CustomerDTO>();
}