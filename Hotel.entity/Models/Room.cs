using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.entity.Models
{
   public class Room
    {
        public Room()
        {
            Reservations = new HashSet<Reservation>();
            RoomImages = new HashSet<RoomImages>();
        }
        public int Id { get; set; }
        public string RoomNo { get; set; }
        public int? NumberOfBeds { get; set; }
        public int? NumberOfChildBeds { get; set; }
        public decimal RoomPrice { get; set; }
        public int? Discount { get; set; }
        public int? FloorNumber { get; set; }
        public string Img { get; set; }
        public int RoomTypesId { get; set; }
        public int RoomStatusId { get; set; }
        public virtual RoomTypes RoomTypes { get; set; }
        public virtual RoomStatus RoomStatus { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
        public virtual ICollection<RoomImages> RoomImages { get; set; }
        [NotMapped]
        public string Type { get; set; }
        [NotMapped]
        public string Status { get; set; }

    }
}
