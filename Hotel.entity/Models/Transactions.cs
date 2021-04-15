using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.entity.Models
{
    public class Transactions
    {
        public Transactions()
        {
            Satisfactions = new HashSet<Satisfaction>();
        }
        public int Id { get; set; }
        public DateTime PaymentTime { get; set; }
        public int PaymentTypesId { get; set; }
        public int CustomerId { get; set; }
        public int ReservationId { get; set; }
        public virtual PaymentTypes PaymentTypes { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Reservation Reservation { get; set; }
        public virtual ICollection<Satisfaction> Satisfactions { get; set; }
    }
}
