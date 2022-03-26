using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class DatabaseAccess
    {
        protected string connectString = "Data Source=localhost;Initial Catalog=ManageDeviceElectronic;User ID=sa;Password=123456";
        protected SqlConnection conn;
        public void OpenConnection()
        {
            if (conn == null) conn = new SqlConnection(connectString);
            if (conn.State == ConnectionState.Closed) conn.Open();
        }
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open) conn.Close();
        }
    }
}
