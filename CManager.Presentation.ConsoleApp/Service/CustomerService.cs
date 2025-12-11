

using CManager.Presentation.ConsoleApp.Interface;
using CManager.Presentation.ConsoleApp.Models;

namespace CManager.Presentation.ConsoleApp.Service;

internal class CustomerService : ICustomerService

{
    public void Create(CustomerModel customer)
    {
        var Customer = new CustomerModel
        {
            Id = CustomerModel.Create()
        };
    }

    public void DeleteById(string id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<CustomerModel> GetAll()
    {
        throw new NotImplementedException();
    }

    public CustomerModel GetById(string id)
    {
        throw new NotImplementedException();
    }
}
