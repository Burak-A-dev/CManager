



namespace CManager.Presentation.ConsoleApp.Models;

public class CustomerModel
{
    public string Id { get; set; } = Guid.NewGuid().ToString();
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Address { get; set; } = string.Empty;
    public string PostalCode { get; set; } = string.Empty;
    public string Town { get; set; } = string.Empty;


    public static CustomerModel Create(CustomerModel customer)
    {
        var NewCustomer = new CustomerModel
        {
            Id = customer.Id,
            FirstName = customer.FirstName,
            LastName = customer.LastName,
            Email = customer.Email,
            Phone = customer.Phone,
            Address = customer.Address,
            PostalCode= customer.PostalCode,
            Town = customer.Town
        };
        return new CustomerModel();
    }

    public static CustomerModel GetAll(CustomerModel customerList)
    {
        var CustomerList = new List<CustomerModel> [];
        {   
        };
        return new CustomerModel();
    }
}
