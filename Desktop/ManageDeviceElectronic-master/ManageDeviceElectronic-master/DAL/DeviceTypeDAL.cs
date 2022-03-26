using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;

namespace DAL
{
    public class DeviceTypeDAL : DatabaseAccess
    {
        public List<DeviceType> SelectAllDeviceType()
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("select * from DeviceType", conn);
            SqlDataReader reader = command.ExecuteReader();
            List<DeviceType> types = new List<DeviceType>();
            while (reader.Read())
            {
                int typeID = reader.GetInt32(0);
                string nameType = reader.GetString(1);
                string defaultImage = reader.GetString(2);
                types.Add(new DeviceType(typeID, nameType, defaultImage));
            }
            reader.Close();
            CloseConnection();
            return types;
        }

        public bool InsertDeviceType(DeviceType type)
        {
            try
            {
                OpenConnection();
                string sql = $"insert into DeviceType values ('{type.Name}','{type.DefaultImage}')";
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
        public bool UpdateDeviceType(DeviceType type)
        {
            try
            {
                OpenConnection();
                string sql = $"update DeviceType set [nameType] = '{type.Name}', [defaultImage] = '{type.DefaultImage}'" +
                    $"where [deviceTypeID] ='{type.TypeID}'";
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
        public bool DeleteDeviceType(string typeID)
        {
            try
            {
                OpenConnection();
                string sql = $"delete from Device where deviceTypeID='{typeID}'" +
                    $"delete from DeviceType where deviceTypeID='{typeID}'";
                SqlCommand command = new SqlCommand(sql, conn);
                if (command.ExecuteNonQuery() > 0) return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public string GetDefaultImage(int type)
        {
            {
                OpenConnection();
                SqlCommand command = new SqlCommand($"select defaultImage from DeviceType where deviceTypeId ={type}", conn);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    return reader.GetString(0);
                }
                reader.Close();
                CloseConnection();
                return null;
            }
        }
    }
}
