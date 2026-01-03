using CManager.Presentation.ConsoleApp.Models;

namespace CManager.Presentation.ConsoleApp.Interface;

internal interface ICustomerRepository
{
    // Spara en lista av kunder till en JSON-fil.
    List<Customer> GetAll();

    Customer GetById(string id);    

    void AddCustomer(Customer customer);    

    void SaveCustomerToJson(string filePath);

    // Hämta kunder från fil och lägga dem i en lista.
    List<Customer> GetCustomersFromFile(string filePath);

}