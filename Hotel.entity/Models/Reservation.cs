using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.entity.Models
{
   public class Reservation
    {
        public Reservation()
        {
            CustomerServices = new HashSet<CustomerServices>();
            Transactions = new HashSet<Transactions>();
        }
        public int Id { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public int CustomerId { get; set; }
        public int RoomId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }
        public virtual ICollection<CustomerServices> CustomerServices { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }

    }
}
