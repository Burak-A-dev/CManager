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

        string toJson = serializedList;

        File.WriteAllText(filePath, toJson);
    }

    public List<Customer> GetCustomersFromFile()
    {
        string fromFile = File.ReadAllText(filePath);

        // Copilot föreslog denna ändring från det tidigare 'List<Customer> deSerializedFile = JsonSerializer.Deserialize(fromFile);
        // Det jag förstår från detta är att koden inte vet vad Json filen ska Deserialiseras till om '<List<Customer>>' inte finns med.
        // Kort sagt så behövs en typ som den vill konvertera till, detta skiljer från Serialize vilket inte behöver någon typ.
        List<Customer> deSerializedFile = JsonSerializer.Deserialize<List<Customer>>(fromFile);

        // behöver lägga till en if sats för att se om filen är tom eller inte.

        return deSerializedFile;
    }
}