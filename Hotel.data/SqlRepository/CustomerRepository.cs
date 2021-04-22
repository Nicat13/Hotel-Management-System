using Hotel.data.IRepository;
using Hotel.data.StructModel;
using Hotel.entity.DAL;
using Hotel.entity.Models;
using Hotel.entity.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.data.SqlRepository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly HotelDB _context;
        public CustomerRepository()
        {
            _context = new HotelDB();
        }
        public AddUpdateResponseModel AddCustomer(Customer customer)
        {
            Customer appcustomer = _context.Customers.FirstOrDefault(x => x.FIN == customer.FIN);
            if (appcustomer == null)
            {
                if (_context.Customers.Any(x => x.FIN != customer.FIN && x.Email == customer.Email))
                {
                    return new AddUpdateResponseModel { Message = "Email Already Exist", Status = false };
                }
                else if (_context.Customers.Any(x => x.FIN != customer.FIN && x.PhoneNumber == customer.PhoneNumber))
                {
                    return new AddUpdateResponseModel { Message = "Phonenumber Already Exist", Status = false };
                }

                _context.Customers.Add(customer);
                _context.SaveChanges();
                return new AddUpdateResponseModel { Message = "ok", Status = true };
            }
            return new AddUpdateResponseModel { Message = "FIN Already Exist", Status = false };
        }

        public bool DeleteCustomer(int customerId)
        {
            Customer customer = _context.Customers.FirstOrDefault(x => x.Id == customerId);
            if (customer != null)
            {
                List<CustomerServices> customerServices = _context.CustomerServices.Where(x => x.CustomerId == customerId).ToList();
                List<Reservation> reservations = _context.Reservations.Where(x => x.CustomerId == customerId).ToList();
                if (customerServices.Count != 0)
                {
                    _context.CustomerServices.RemoveRange(customerServices);
                }
                if (reservations.Count != 0)
                {
                    _context.Reservations.RemoveRange(reservations);
                }
                _context.Customers.Remove(customer);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetCustomerbyId(int id)
        {
            return _context.Customers.Find(id);
        }

        public List<Customer> SearchCustomer(string searchquery)
        {
            return _context.Customers.Where(x => x.FIN.Contains(searchquery) || x.Name.Contains(searchquery) || x.Surname.Contains(searchquery) || (x.Name+" "+x.Surname).Contains(searchquery)).ToList();
        }

        public AddUpdateResponseModel UpdateCustomer(Customer customer)
        {
            try
            {
                Customer appcustomer = _context.Customers.FirstOrDefault(x => x.FIN == customer.FIN);
                if (appcustomer != null)
                {
                    if (_context.Customers.Any(x => x.FIN != customer.FIN && x.Email == customer.Email))
                    {
                        return new AddUpdateResponseModel { Message = "Email Already Exist", Status = false };
                    }
                    else if (_context.Customers.Any(x => x.FIN != customer.FIN && x.PhoneNumber == customer.PhoneNumber))
                    {
                        return new AddUpdateResponseModel { Message = "Phonenumber Already Exist", Status = false };
                    }
                    appcustomer.Name = customer.Name;
                    appcustomer.Surname = customer.Surname;
                    appcustomer.Email = customer.Email;
                    appcustomer.PhoneNumber = customer.PhoneNumber;
                    _context.SaveChanges();
                    return new AddUpdateResponseModel { Message = "ok", Status = true };
                }
                return new AddUpdateResponseModel { Message = "Customer not found", Status = false };
            }
            catch (Exception ex)
            {
                return new AddUpdateResponseModel { Message = ex.Message, Status = false };
            }
        }
    }
}
