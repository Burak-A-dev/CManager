using CManager.Presentation.ConsoleApp.Interface;
using CManager.Presentation.ConsoleApp.Models;


namespace CManager.Presentation.ConsoleApp.Repository;

internal class CustomerRepository : ICustomerRepository
{
    private List<Customer> customers = new List<Customer>();

    public void AddCustomer(Customer customer)
    {
        customers.Add(customer);
    }

    public List<Customer> GetAll()
    {
        throw new NotImplementedException();
    }

    public Customer GetById(string id)
    {
        throw new NotImplementedException();
    }

    public List<Customer> GetCustomersFromFile(string filePath)
    {
        throw new NotImplementedException();
    }

    public void SaveCustomerToJson(string filePath)
    {
        throw new NotImplementedException();
    }
}
