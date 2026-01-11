using CManager.Presentation.ConsoleApp.Interface;
using CManager.Presentation.ConsoleApp.Models;

namespace CManager.Presentation.ConsoleApp.Controller;

internal class CustomerController
{

    private readonly ICustomerService _customerService;

    public CustomerController(ICustomerService service)
    {
        _customerService = service;
    }
    public void Run()
    {

        bool running = true;

        while (running)
        {
            Console.WriteLine("=== MENU ===");
            Console.WriteLine("1. Create Customer");
            Console.WriteLine("2. Show Customers");
            Console.WriteLine("3. Show Specific Customer");
            Console.WriteLine("4. Delete Customer With E-mail");
            Console.Write("Make a choice to progress: ");


            string? input = Console.ReadLine();
            Console.WriteLine();


            if (input == "1")
            {
                Console.WriteLine("*** Create User ***");

                Console.WriteLine("Enter First Name:");
                string? firstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name:");
                string? lastName = Console.ReadLine();

                Console.WriteLine("Enter E-mail:");
                string? email = Console.ReadLine();

                Console.WriteLine("Enter Phone Number:");
                string? phoneNumber = Console.ReadLine();

                Console.WriteLine("Enter Address:");
                string? address = Console.ReadLine();

                Console.WriteLine("Enter Postal Code:");
                string? postalCode = Console.ReadLine();

                Console.WriteLine("Enter Town:");
                string? town = Console.ReadLine();

                var customerObject = new Customer();

                customerObject.FirstName = firstName;
                customerObject.LastName = lastName;
                customerObject.Email = email;
                customerObject.Phone = phoneNumber;
                customerObject.Address = address;
                customerObject.PostalCode = postalCode;
                customerObject.Town = town;

                _customerService.Create(customerObject);

            }
            else if (input == "2")
            {
                Console.WriteLine("*** Show Customers ***");

                var customerList =  _customerService.GetAll();

                foreach (var customer in customerList)
                {
                    Console.WriteLine(customer.FirstName + customer.LastName + customer.Email);
                }

            }
            else if (input == "3")
            {
                Console.WriteLine("*** Show Specific Customer ***");

                var customers = _customerService.GetAll();

                Console.WriteLine("Enter E-mail:");
                string? email = Console.ReadLine();

                var specificCustomer = customers.FirstOrDefault(customer => customer.Email == email);

                if (specificCustomer == null)
                {
                    Console.WriteLine("Customer does not exist");
                }
                else
                {
                    Console.WriteLine($"First Name: {specificCustomer.FirstName}");
                    Console.WriteLine($"Last Name: {specificCustomer.LastName}");
                    Console.WriteLine($"E-mail: {specificCustomer.Email}");
                    Console.WriteLine($"Phone: {specificCustomer.Phone}");
                    Console.WriteLine($"Address: {specificCustomer.Address}");
                    Console.WriteLine($"Postal Code: {specificCustomer.PostalCode}");
                    Console.WriteLine($"Town: {specificCustomer.Town}");
                };

            }
            else if (input == "4")
            {
                Console.WriteLine("*** Delete Customer With E-mail ***");

            };

        }

        Console.ReadKey();
    }
}