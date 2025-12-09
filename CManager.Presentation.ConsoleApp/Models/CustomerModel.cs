


using CManager.Presentation.ConsoleApp.Interface;

namespace CManager.Presentation.ConsoleApp.Models;

public class CustomerModel
{
    public int ID { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string Town { get; set; } = string.Empty;

}
