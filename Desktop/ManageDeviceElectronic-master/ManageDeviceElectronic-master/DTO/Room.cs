using System;

namespace DTO
{

    public class Room
    {
        public string RoomID { get;}
        public string Name { get;set; }

        public Room(string roomID, string name)
        {
            RoomID = roomID;
            Name = name;
        }

        public Room(string name)
        {
            Guid myuuid = Guid.NewGuid();
            RoomID = myuuid.ToString();
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
