using Hotel.data.IRepository;
using Hotel.data.StructModel;
using Hotel.entity.DAL;
using Hotel.entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.data.SqlRepository
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly HotelDB _context;
        public ReservationRepository()
        {
            _context = new HotelDB();
        }

        public void AddReservation(Reservation model, string FIN)
        {
            if (model!=null)
            {
                model.CustomerId = _context.Customers.FirstOrDefault(c => c.FIN == FIN).Id;
                Room room = _context.Rooms.Find(model.RoomId);
                room.RoomStatusId = 1;
                _context.Reservations.Add(model);
                _context.SaveChanges();
            }
        }

        public bool CheckFin(string fin)
        {
            return _context.Customers.Any(x => x.FIN == fin);
        }

        public List<Room> GetReadyRooms()
        {
            return _context.Rooms.Where(r => r.RoomStatusId == 2).ToList();
        }

        public ReservationViewModel GetReservationById(int Id)
        {
            return (from res in _context.Reservations
                    from c in _context.Customers
                    where res.Id == Id && c.Id == res.CustomerId

                    select new ReservationViewModel
                    {
                        Id = res.Id,
                        CheckInDate = res.CheckInDate,
                        CheckOutDate = res.CheckOutDate,
                        FIN = c.FIN,
                        RoomNo = res.RoomId.ToString()
                    }
                                                ).FirstOrDefault();
        }

        public List<ReservationViewModel> GetReservations()
        {
            List<ReservationViewModel> model = (from res in _context.Reservations
                                                from c in _context.Customers
                                                from r in _context.Rooms
                                                where c.Id == res.CustomerId && r.Id == res.RoomId

                                                select new ReservationViewModel
                                                {
                                                    Id = res.Id,
                                                    CheckInDate = res.CheckInDate,
                                                    CheckOutDate = res.CheckOutDate,
                                                    CustomerName = c.Name,
                                                    CustomerSurname = c.Surname,
                                                    FIN = c.FIN,
                                                    RoomNo = r.RoomNo
                                                }
                                              ).ToList();

            return model;
        }

        public void UpdateReservation(Reservation model)
        {
            Reservation reservation = _context.Reservations.Find(model.Id);

            if (model.RoomId!=0)
            {
                Room room = _context.Rooms.Find(reservation.RoomId);
                room.RoomStatusId = 2;
                Room newroom = _context.Rooms.Find(model.RoomId);
                newroom.RoomStatusId = 1;
            }
            reservation.CheckInDate = model.CheckInDate;
            reservation.CheckOutDate = model.CheckOutDate;
            reservation.RoomId = model.RoomId!=0?model.RoomId:reservation.RoomId;
            _context.SaveChanges();
        }
    }
}
