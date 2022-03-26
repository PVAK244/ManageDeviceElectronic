using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class UsageHistory
    {
        public string ID { get; set; }
        public string DeviceID { get; set; }
        public DateTime LastTimeOn { get; set; }
        public double TotalTimeOn { get; set; }

        public UsageHistory(string iD, string deviceID, DateTime lastTimeOn, double totalTimeOn)
        {
            ID = iD;
            DeviceID = deviceID;
            LastTimeOn = lastTimeOn;
            TotalTimeOn = totalTimeOn;
        }

        public UsageHistory(string deviceID, DateTime lastTimeOn)
        {
            Guid myuuid = Guid.NewGuid();
            ID = myuuid.ToString();
            DeviceID = deviceID;
            LastTimeOn = lastTimeOn;
            TotalTimeOn = 0;
        }
    }
}
