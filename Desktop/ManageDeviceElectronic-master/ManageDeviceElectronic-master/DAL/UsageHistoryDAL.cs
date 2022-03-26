using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class UsageHistoryDAL:DatabaseAccess
    {
        public List<UsageHistory> SelectAllUsageHistory()
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("select * from [usageHistory]", conn);
            SqlDataReader reader = command.ExecuteReader();
            List<UsageHistory> usages = new List<UsageHistory>();
            while (reader.Read())
            {
                string id = reader.GetString(0);
                string deviceID = reader.GetString(1);
                DateTime lastTimeOn = reader.GetDateTime(2);
                double totalTimeOn = reader.GetDouble(3);
                usages.Add(new UsageHistory(id, deviceID, lastTimeOn, totalTimeOn));
            }
            reader.Close();
            CloseConnection();
            return usages;
        }

        public bool UpdateUsageHistory(UsageHistory usage)
        {
            try
            {
                OpenConnection();
                string sql = $"update UsageHistory set [lastTimeOn]= '{usage.LastTimeOn}', [totalTimeOn] = {usage.TotalTimeOn}" +
                    $"where [usageHistoryId] = '{usage.ID}'";
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
