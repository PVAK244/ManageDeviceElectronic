using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class DeviceTypeBLL
    {
        DeviceTypeDAL deviceTypeDAL = new DeviceTypeDAL();
        public List<DeviceType> SelectAllDeviceType()
        {
            return deviceTypeDAL.SelectAllDeviceType();
        }
        public bool InsertDeviceType(DeviceType type)
        {
            return deviceTypeDAL.InsertDeviceType(type);
        }
        public bool UpdateDeviceType(DeviceType type)
        {
            return deviceTypeDAL.UpdateDeviceType(type);
        }
        public bool DeleteDeviceType(string typeID)
        {
            return deviceTypeDAL.DeleteDeviceType(typeID);
        }
        public string GetDefaultImage(int typeID)
        {
            return deviceTypeDAL.GetDefaultImage(typeID);
        }
    }
}
