using CManager.Presentation.ConsoleApp.Models;

namespace CManager.Presentation.ConsoleApp.Interface;

public interface ICustomerRepository
{
    // Spara en lista av kunder till en JSON-fil.
    void SaveCustomersToJsonFile(List<Customer> customers);


    // Hämta kunder från fil och lägga dem i en lista.
    List<Customer> GetCustomersFromFile();
}