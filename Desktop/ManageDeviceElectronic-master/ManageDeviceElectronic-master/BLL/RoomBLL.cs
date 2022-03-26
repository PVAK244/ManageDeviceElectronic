using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class RoomBLL
    {
        RoomDAL roomDAL = new RoomDAL();
        public List<Room> SelectAllRoom()
        {
            return roomDAL.SelectAllRoom();
        }
        public bool InsertRoom(Room room)
        {
            return roomDAL.InsertRoom(room);
        }
        public bool UpdateRoom(Room room)
        {
            return roomDAL.UpdateRoom(room);
        }
        public bool DeleteRoom(string roomID)
        {
            return roomDAL.DeleteRoom(roomID);
        }
    }
}
