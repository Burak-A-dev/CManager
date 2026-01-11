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
        mockOfRepository.Setup(repository => repository.GetCustomersFromFile()).Returns(testCustomers);

        var service = new CustomerService(mockOfRepository.Object);

        var result = service.GetAll().ToList();

        Assert.Equal(testCustomers.Count, result.Count);
        Assert.Contains(result, customer => customer.FirstName == "Burak");
        Assert.Contains(result, customer => customer.FirstName == "oskar");
    }
}