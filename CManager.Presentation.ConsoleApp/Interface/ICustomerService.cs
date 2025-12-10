using CManager.Presentation.ConsoleApp.Models;

namespace CManager.Presentation.ConsoleApp.Interface;

public interface ICustomerService
{
    // Skapa en ny kund med GUID som unikt ID.
    void Create(CustomerModel customer);
    // void Create(CustomerModel customer);

    // Hämta alla kunder
    IEnumerable<CustomerModel> GetAll();

    // Hämta specifik kund
    CustomerModel GetById(string id);


    // Ta bort specifik kund
    void DeleteById(string id);

    // Updatera kund om det skulle behövas senare
    // void Update(CustomerModel customer);
}