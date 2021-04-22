using Hotel.data.StructModel;
using Hotel.entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.data.IRepository
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
        AddUpdateResponseModel UpdateCustomer(Customer customer);
        AddUpdateResponseModel AddCustomer(Customer customer);
        List<Customer> SearchCustomer(string searchquery);
        bool DeleteCustomer(int customerId);
        Customer GetCustomerbyId(int id);
    }
}
