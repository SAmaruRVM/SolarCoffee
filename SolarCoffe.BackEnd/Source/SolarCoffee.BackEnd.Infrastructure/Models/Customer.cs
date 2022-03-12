
namespace SolarCoffee.BackEnd.Infrastructure.Models;

public class Customer
{
    public int Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public ICollection<Address> Addresses { get; init; } = new List<Address>();
}
