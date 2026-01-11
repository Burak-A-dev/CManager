using CManager.Presentation.ConsoleApp.Controller;
using CManager.Presentation.ConsoleApp.Interface;
using CManager.Presentation.ConsoleApp.Repository;
using CManager.Presentation.ConsoleApp.Services;

namespace CManager.Presentation.ConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        ICustomerRepository customerRepository = new CustomerRepository();

        ICustomerService customerService = new CustomerService(customerRepository);

        CustomerController customerController = new CustomerController(customerService);

        customerController.Run();
    }
}
