using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.data.StructModel
{
    public class ReservationViewModel
    {
        public int Id { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string FIN { get; set; }
        public string RoomNo { get; set; }

    }
}
