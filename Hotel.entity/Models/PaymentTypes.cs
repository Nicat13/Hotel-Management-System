using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.entity.Models
{
    public class PaymentTypes
    {
        public PaymentTypes()
        {
            Transactions = new HashSet<Transactions>();
        }
        public int Id { get; set; }
        [Required]
        public string TypeName { get; set; }
        public virtual ICollection<Transactions> Transactions { get; set; }

    }
}
