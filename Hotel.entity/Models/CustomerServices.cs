using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.entity.Models
{
   public class CustomerServices
    {
        public int Id { get; set; }
        public int ServiceQuantity { get; set; }
        public int CustomerId { get; set; }
        public int ServicesId { get; set; }
        public int ReservationId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual AdditionalServices Services { get; set; }
        public virtual Reservation Reservation { get; set; }

    }
}
