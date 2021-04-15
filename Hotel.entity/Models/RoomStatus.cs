using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.entity.Models
{
    public class RoomStatus
    {
        public RoomStatus()
        {
            Rooms = new HashSet<Room>();
        }
        public int Id { get; set; }
        [Required]
        public string StatusName { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
