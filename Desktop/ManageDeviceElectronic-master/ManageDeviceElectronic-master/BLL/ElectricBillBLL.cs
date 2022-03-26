using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class ElectricBillBLL
    {
        ElectricBillDAL electricBillDAL = new ElectricBillDAL();
        public List<ElectricBill> SelectAllBill()
        {
            return electricBillDAL.SelectAllBill();
        }
        public bool InsertBill(ElectricBill bill)
        {
            return electricBillDAL.InsertBill(bill);
        }
    }
}
