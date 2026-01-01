using CManager.Presentation.ConsoleApp.Interface;
using CManager.Presentation.ConsoleApp.Models;
namespace CManager.Presentation.ConsoleApp.Services;

public class CustomerService : ICustomerService
{
    private static List<Customer> customers = new();

    public void Create(Customer customer) 
    {
        customers.Add(customer);
        Console.WriteLine($"Kunden {customer.FirstName} {customer.LastName} har lagts till.");
    }

    public IEnumerable<Customer> GetAll()
    {
        return customers;
    }

    public Customer? GetById(string id)
    {
        return customers.FirstOrDefault(customer => customer.Id == id);
    }

    public void DeleteById(string id)
    {
        var customer = GetById(id);

        if (customer == null)
        {
            Console.WriteLine($"Kunden med ID {id} finns inte.");
        }
        else
        {
            customers.Remove(customer);
            Console.WriteLine($"Kunden med ID {id} har tagits bort.");
        }
    }
}
