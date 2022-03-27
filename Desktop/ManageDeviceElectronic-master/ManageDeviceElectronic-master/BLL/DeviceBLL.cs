using DAL;
using DTO;
using System.Collections.Generic;

namespace BLL
{
    public class DeviceBLL
    {
        DeviceDAL deviceDAL = new DeviceDAL();
        public List<Device> SelectAllDevice()
        {
            return deviceDAL.SelectAllDevice();
        }
        public List<Device> SelectDevicesByRoomName(string roomName)
        {
            return deviceDAL.SelectDevicesByRoomName(roomName);
        }
        public bool InsertDevice(Device device)
        {
            return deviceDAL.InsertDevice(device);
        }
        public bool UpdateDevice(Device device)
        {
            return deviceDAL.UpdateDevice(device);
        }
        public bool DeleteDevice(string deviceID)
        {
            return deviceDAL.DeleteDevice(deviceID);
        }

        public bool TurnOnOffDevice(string deviceId, bool status, UsageHistory usage) => deviceDAL.TurnOnOffDevice(deviceId, status, usage);


        public Device SelectDeviceById(string id) => deviceDAL.SelectDeviceById(id);

        public bool UpdateDeviceAllProp(Device device, UsageHistory usage, bool status) => deviceDAL.UpdateDeviceAllProp(device, usage, status);
    }
}
