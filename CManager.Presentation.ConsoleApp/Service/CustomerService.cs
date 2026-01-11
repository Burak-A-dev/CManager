using CManager.Presentation.ConsoleApp.Interface;
using CManager.Presentation.ConsoleApp.Models;
using CManager.Presentation.ConsoleApp.Repository;
namespace CManager.Presentation.ConsoleApp.Services;

public class CustomerService : ICustomerService
{
    private readonly ICustomerRepository _customerRepository;

    public CustomerService(ICustomerRepository repository)
    {
        _customerRepository = repository;
    }

    public void Create(Customer customer)
    {
        var customers = _customerRepository.GetCustomersFromFile();

        var customerGuid = Guid.NewGuid().ToString();

        customer.Id = customerGuid;

        customers.Add(customer);

        _customerRepository.SaveCustomersToJsonFile(customers);
    }

    public IEnumerable<Customer> GetAll()
    {
        var customers = _customerRepository.GetCustomersFromFile();

        return customers;
    }

    public Customer? GetById(string id)
    {
        var customers = _customerRepository.GetCustomersFromFile();

        return customers.FirstOrDefault(customer => customer.Id == id);
    }

    public void DeleteById(string id)
    {
        var customers = _customerRepository.GetCustomersFromFile();

        Customer? customerToRemove = null;

        foreach (var customer in customers)
        {
            if (customer.Id == id)
            {
                customerToRemove = customer;
                break;
            }
        }

        if (customerToRemove == null)
        {
            return;
        }

        customers.Remove(customerToRemove);
        _customerRepository.SaveCustomersToJsonFile(customers);
    }

}