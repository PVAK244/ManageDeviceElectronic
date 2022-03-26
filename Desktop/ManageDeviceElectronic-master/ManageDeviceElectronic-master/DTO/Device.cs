using System;

namespace DTO
{
    public class Device
    {
        public string DeviceID { get; set; }
        public string DeviceName { get; set; }
        public string ImagePath { get; set; }
        public int Type { get; set; }
        public int Power { get; set; }
        public string RoomID { get; set; }
        public Boolean status { get; set; }

        public Device(string deviceID, string deviceName, int type, int power, string roomID, bool status)
        {
            DeviceID = deviceID;
            DeviceName = deviceName;
            Type = type;
            Power = power;
            RoomID = roomID;
            this.status = status;
        }

        public Device(string deviceID, string deviceName, string imagePath, int type, int power, string roomID, bool status) : this(deviceID, deviceName, imagePath, type, power, roomID)
        {
            this.status = status;
        }

        public Device(string deviceID, string deviceName, string imagePath, int type, int power, string roomID)
        {
            DeviceID = deviceID;
            DeviceName = deviceName;
            ImagePath = imagePath;
            Type = type;
            Power = power;
            RoomID = roomID;
        }

        public Device(string deviceName, string imagePath, int type, int power, string roomID)
        {
            Guid myuuid = Guid.NewGuid();
            DeviceID = myuuid.ToString();
            DeviceName = deviceName;
            ImagePath = imagePath;
            Type = type;
            Power = power;
            RoomID = roomID;
        }

        public Device()
        {
        }

        public override string ToString()
        {
            return $"{DeviceName}";
        }
    }
}
