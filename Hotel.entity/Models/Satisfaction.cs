using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.entity.Models
{
    public class Satisfaction
    {
        public int Id { get; set; }
        public int? SatisfactionLevel { get; set; }
        public int TransactionsId { get; set; }
        public virtual Transactions Transactions { get; set; }
    }
}
