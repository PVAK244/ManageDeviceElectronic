using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class RoomDAL:DatabaseAccess
    {
        public List<Room> SelectAllRoom()
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("select * from Room", conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Room> rooms = new List<Room>();
            while (reader.Read())
            {
                string roomID = reader.GetString(0);
                string roomName = reader.GetString(1);
                rooms.Add(new Room(roomID, roomName));
            }
            reader.Close();
            CloseConnection();
            return rooms;
        }
        public bool InsertRoom(Room room)
        {
            try
            {
                OpenConnection();
                string sql = $"insert into Room values ('{room.RoomID}','{room.Name}')";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }
        public bool UpdateRoom(Room room)
        {
            try
            {
                OpenConnection();
                string sql = $"update room set [roomName] = '{room.Name}'" +
                    $"where [roomID] ='{room.RoomID}'";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return false;
        }
        public bool DeleteRoom(string roomID)
        {
            try
            {
                OpenConnection();
                string sql = $"delete from Device where roomID='{roomID}'" +
                    $"delete from Room where roomID='{roomID}'";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
