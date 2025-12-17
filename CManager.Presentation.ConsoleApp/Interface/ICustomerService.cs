using CManager.Presentation.ConsoleApp.Models;
using System.Collections.Generic;

namespace CManager.Presentation.ConsoleApp.Interface;

public interface ICustomerService
{
    // Skapa en ny kund med unikt GUID (finns i CustomerModel)
    void Create(Customer customer);

    // Hämta alla kunder
    IEnumerable<Customer> GetAll();

    // Hämta specifik kund
    Customer? GetById(string id);

    // Ta bort specifik kund
    void DeleteById(string id);

    // Updatera kund om det skulle behövas senare
    // void Update(Customer customer);
}
