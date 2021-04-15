using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.entity.Models
{
    public class Customer
    {
        public Customer()
        {
            Addresses = new HashSet<Address>();
            CustomerServices = new HashSet<CustomerServices>();
            Reservations = new HashSet<Reservation>();
            Transactions = new HashSet<Transactions>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Img { get; set; }
        public char Gender { get; set; }
        public string PhoneNumber { get; set; }
        [StringLength(7), Required]
        public string FIN { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Address> Addresses { get; set; }
        public virtual ICollection<CustomerServices> CustomerServices { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }



    }
}
