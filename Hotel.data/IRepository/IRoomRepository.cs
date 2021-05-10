using Hotel.entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.data.IRepository
{
    public interface IRoomRepository
    {
        void AddRoomType(string typeName);
        void EditRoomType(int id,string typeName);
        void DeleteRoomType(int id);
        RoomTypes GetRoomType(int id);
        List<RoomTypes> GetAllRoomTypes();
        List<Room> GetAllRooms();
        List<RoomStatus> GetAllRoomStatusses();
        void DeleteRoom(int id);
        void AddRoom(Room room);
        void EditRoom(Room room);
        Room GetRoom(int id);
        bool CheckRoomStatus(int id);
    }
}
