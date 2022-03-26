using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DTO;
namespace DAL
{
    public class ElectricBillDAL:DatabaseAccess
    {
        public List<ElectricBill> SelectAllBill()
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("select * from [ElectricBill]", conn);
            SqlDataReader reader = command.ExecuteReader();
            List<ElectricBill> bills = new List<ElectricBill>();
            while (reader.Read())
            {
                string billID = reader.GetString(0);
                double totalKWH = reader.GetDouble(1);
                decimal bill = reader.GetDecimal(2);
                bills.Add(new ElectricBill(billID, totalKWH, bill));
            }
            reader.Close();
            CloseConnection();
            return bills;
        }

        public bool InsertBill(ElectricBill bill)
        {
            try
            {
                OpenConnection();
                string sql = $"insert into ElectricBill values ('{bill.ElectricBillID}',{bill.TotalKWH},{bill.Money})";
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
    }
}
