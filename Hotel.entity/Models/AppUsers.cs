using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.entity.Models
{
    public class AppUsers
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        [StringLength(7), Required]
        public string FIN { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        [NotMapped]
        public string RoleName { get; set; }
        public int rolesId { get; set; }
        public virtual Roles roles { get; set; }
    }
    public class Roles
    {
        public Roles()
        {
            Users = new HashSet<AppUsers>();
        }
        public int Id { get; set; }
        [Required]
        public string RoleName { get; set; }
        public virtual ICollection<AppUsers> Users { get; set; }

    }
}
