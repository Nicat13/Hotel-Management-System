using Hotel.data.IRepository;
using Hotel.entity.DAL;
using Hotel.entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.data.SqlRepository
{
    public class RoomRepository : IRoomRepository
    {
        private readonly HotelDB _context;
        public RoomRepository()
        {
            _context = new HotelDB();
        }

        public void AddRoom(Room room)
        {
            if (room != null)
            {
                _context.Rooms.Add(room);
                _context.SaveChanges();
            }
        }

        public void AddRoomType(string typeName)
        {
            RoomTypes roomType = new RoomTypes()
            {
                TypeName = typeName
            };
            _context.RoomTypes.Add(roomType);
            _context.SaveChanges();
        }

        public bool CheckRoomStatus(int id)
        {
            Room room = _context.Rooms.Find(id);

            if (room.RoomStatusId != 2)
            {
                return false;
            }
            return true;
        }

        public void DeleteRoom(int id)
        {
            Room room = _context.Rooms.Find(id);
            _context.Rooms.Remove(room);
            _context.SaveChanges();
        }

        public void DeleteRoomType(int id)
        {
            RoomTypes roomType = _context.RoomTypes.Find(id);
            _context.RoomTypes.Remove(roomType);
            _context.SaveChanges();
        }

        public void EditRoom(Room room)
        {
            Room r = _context.Rooms.Find(room.Id);
            r.RoomNo = room.RoomNo;
            r.NumberOfBeds = room.NumberOfBeds;
            r.NumberOfChildBeds = room.NumberOfChildBeds;
            r.RoomPrice = room.RoomPrice;
            r.Discount = room.Discount;
            r.FloorNumber = room.FloorNumber;
            r.Img = room.Img;
            r.RoomTypesId = room.RoomTypesId;
            r.RoomStatusId = room.RoomStatusId;
            _context.SaveChanges();
        }

        public void EditRoomType(int id, string typeName)
        {
            RoomTypes roomType = _context.RoomTypes.Find(id);
            if (roomType != null)
            {
                roomType.TypeName = typeName;
                _context.SaveChanges();
            }
        }

        public List<Room> GetAllRooms()
        {
            return (from r in _context.Rooms.ToList()
                    from t in _context.RoomTypes.ToList()
                    from s in _context.RoomStatuses.ToList()
                    where t.Id == r.RoomTypesId && s.Id == r.RoomStatusId
                    select new Room
                    {
                        Id = r.Id,
                        RoomNo = r.RoomNo,
                        NumberOfBeds = r.NumberOfBeds,
                        NumberOfChildBeds = r.NumberOfChildBeds,
                        RoomPrice = r.RoomPrice,
                        Discount = r.Discount,
                        FloorNumber = r.FloorNumber,
                        Img = r.Img,
                        Type = t.TypeName,
                        Status = s.StatusName
                    }

                    ).ToList();

        }

        public List<RoomStatus> GetAllRoomStatusses()
        {
            return _context.RoomStatuses.ToList();
        }

        public List<RoomTypes> GetAllRoomTypes()
        {
            return _context.RoomTypes.ToList();
        }

        public Room GetRoom(int id)
        {
            return _context.Rooms.Find(id);
        }

        public RoomTypes GetRoomType(int id)
        {
            return _context.RoomTypes.Find(id);
        }
    }
}
