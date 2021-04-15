using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.entity.Models
{
    public class AdditionalServices
    {
        public AdditionalServices()
        {
            Services = new HashSet<CustomerServices>();
        }
        public int Id { get; set; }
        [Required]
        public string ServiceName { get; set; }
        [Required]
        public decimal ServiceCost { get; set; }
        public int? Discount { get; set; }
        public virtual ICollection<CustomerServices> Services { get; set; }
    }
}
