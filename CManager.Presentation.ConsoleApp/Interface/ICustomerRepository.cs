namespace CManager.Presentation.ConsoleApp.Interface;

public interface ICustomerRepository
{
    string Address { get; set; }
    string Email { get; set; }
    string FirstName { get; set; }
    int ID { get; set; }
    string LastName { get; set; }
    string Phone { get; set; }
    string PostalCode { get; set; }
    string Town { get; set; }
}




/* string Address { get; set; }
    string Email { get; set; }
    string FirstName { get; set; }
    int ID { get; set; }
    string LastName { get; set; }
    string Phone { get; set; }
    string PostalCode { get; set; }
    string Town { get; set; }*/