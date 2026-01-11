namespace CManager.Tests;

using Xunit;
using Moq;
using CManager.Presentation.ConsoleApp.Services;
using CManager.Presentation.ConsoleApp.Interface;
using CManager.Presentation.ConsoleApp.Models;
using System.Collections.Generic;
using System.Linq;

public class CustomerServiceTests
{
    [Fact]
    public void GetAll()
    {
        var mockOfRepository = new Mock<ICustomerRepository>();

        var testCustomers = new List<Customer>
        {
            new Customer { Id = "1", FirstName = "Burak", LastName = "", Email = "burak@email.com" },
            new Customer { Id = "2", FirstName = "Oskar", LastName = "", Email = "oskar@email.com" }
        };

        // Fått hjälp av ChatGPT
        // Här säger jag till mocken att när vi frågar efter kunder
        // så ska den ge tillbaka listan med testkunder.
        mockOfRepository.Setup(repository => repository.GetCustomersFromFile()).Returns(testCustomers);

        // Fått hjälp av ChatGPT 
        // Här skapar jag CustomerService och ger den mocken
        // så att den använder låtsas-databasen istället för riktiga filer.
        var service = new CustomerService(mockOfRepository.Object);

        var result = service.GetAll().ToList();

        Assert.Equal(testCustomers.Count, result.Count);
        Assert.Contains(result, customer => customer.FirstName == "Burak");
        Assert.Contains(result, customer => customer.FirstName == "oskar");
    }
}