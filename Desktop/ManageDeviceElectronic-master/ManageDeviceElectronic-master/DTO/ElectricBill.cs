using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ElectricBill
    {
        public string ElectricBillID { get; set; }
        public double TotalKWH { get; set; }
        public decimal Money { get; set; }

        public ElectricBill(string electricBillID, double totalKWH, decimal money)
        {
            ElectricBillID = electricBillID;
            TotalKWH = totalKWH;
            Money = money;
        }

        public ElectricBill(double totalKWH, decimal money)
        {
            Guid myuuid = Guid.NewGuid();
            ElectricBillID = myuuid.ToString();
            TotalKWH = totalKWH;
            Money = money;
        }
    }
}
