using Hotel.data.StructModel;
using Hotel.entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.data.IRepository
{
   public interface IReservationRepository
    {
        bool CheckFin(string fin);
        List<Room> GetReadyRooms();
        List<ReservationViewModel> GetReservations();
        ReservationViewModel GetReservationById(int Id);
        void UpdateReservation(Reservation model);
        void AddReservation(Reservation model,string FIN);
    }
}
