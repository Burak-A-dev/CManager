using CManager.Presentation.ConsoleApp.Interface;
using CManager.Presentation.ConsoleApp.Models;
using System.Text.Json;

namespace CManager.Presentation.ConsoleApp.Repository;

internal class CustomerRepository : ICustomerRepository
{
    private string filePath = "customers.json";
    public void SaveCustomersToJsonFile(List<Customer> customers)
    {
        string serializedList = JsonSerializer.Serialize(customers);

        File.WriteAllText(filePath, serializedList);
    }

    public List<Customer> GetCustomersFromFile()
    {
        throw new NotImplementedException();
    }
}