using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace DAL
{
    public class DeviceDAL : DatabaseAccess
    {
        public List<Device> SelectAllDevice()
        {
            OpenConnection();
            SqlCommand command = new SqlCommand("select * from device", conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Device> devices = new List<Device>();
            while (reader.Read())
            {
                string deviceID = reader.GetString(0);
                string deviceName = reader.GetString(1);
                string imagePath = reader.GetString(2);
                int type = reader.GetInt32(3);
                bool status = reader.GetBoolean(4);
                int power = reader.GetInt32(5);
                string roomID = reader.GetString(6);
                devices.Add(new Device(deviceID, deviceName, imagePath, type, power, roomID, status));
            }
            reader.Close();
            CloseConnection();
            return devices;
        }
        public List<Device> SelectDevicesByRoomName(string roomName)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand($"select * from device where [roomID] = '{roomName}'", conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Device> devices = new List<Device>();
            while (reader.Read())
            {
                string deviceID = reader.GetString(0);
                string deviceName = reader.GetString(1);
                string imagePath = reader.GetString(2);
                int type = reader.GetInt32(3);
                Boolean status = reader.GetBoolean(4);
                int power = reader.GetInt32(5);
                string roomID = reader.GetString(6);
                devices.Add(new Device(deviceID, deviceName, imagePath, type, power, roomID, status));
            }
            reader.Close();
            CloseConnection();
            return devices;
        }
        public bool InsertDevice(Device device)
        {
            try
            {
                OpenConnection();
                string sql = $"insert into Device values ('{device.DeviceID}','{device.DeviceName}','{device.ImagePath}','{device.Type}',0,'{device.Power}','{device.RoomID}')";
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
        public bool UpdateDevice(Device device)
        {
            try
            {
                OpenConnection();
                string sql = $"update Device set [name]= '{device.DeviceName}', [imagePath] = '{device.ImagePath}',[deviceTypeId] = {device.Type}, [power] = {device.Power}, [roomID]='{device.RoomID}'" +
                    $"where[deviceId] = '{device.DeviceID}'";
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
        public bool DeleteDevice(string deviceID)
        {
            try
            {
                OpenConnection();
                string sql = $"delete from Device where [deviceId]='{deviceID}'";
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

        public bool TurnOnOffDevice(string deviceID, bool status, UsageHistory usage, bool statusNow)
        {
            try
            {
                OpenConnection();
                string sql = "";
                if (status && !statusNow)
                {
                    if (usage != null)
                    {
                        sql = $"update Device [status] = {status} where[deviceId] = '{deviceID}'" +
                            $"update [usageHistory] set [lastTimeOn] = '{DateTime.Now}' where [usageHistoryId] = '{usage.ID}'";
                    }
                    else
                    {
                        usage = new UsageHistory(deviceID, DateTime.Now);
                        sql = $"update Device set [status]='{status} where [deviceId]='{deviceID}'" +
                            $"insert into [UsageHistory] values('{usage.ID}', '{usage.DeviceID}', '{usage.LastTimeOn}', 0)";
                    }
                }
                else if (!status && statusNow)
                {
                    TimeSpan time = DateTime.Now - usage.LastTimeOn;
                    double total = usage.TotalTimeOn + time.TotalHours;
                    sql = $"update Device set [status]='{status} where [deviceId]='{deviceID}'" +
                       $"update [usageHistory] set [totalTimeOn] = {total} where [usageHistoryId] = '{usage.ID}'";
                }
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

        public Device SelectDeviceById(string id)
        {
            OpenConnection();
            SqlCommand command = new SqlCommand($"select * from device where [deviceId] = '{id}'", conn);
            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                string deviceID = reader.GetString(0);
                string deviceName = reader.GetString(1);
                string imagePath = reader.GetString(2);
                int type = reader.GetInt32(3);
                Boolean status = reader.GetBoolean(4);
                int power = reader.GetInt32(5);
                string roomID = reader.GetString(6);
                reader.Close();
                CloseConnection();
                return new Device(deviceID, deviceName, imagePath, type, power, roomID, status);
            }
            reader.Close();
            CloseConnection();
            return null;
        }

        public bool UpdateDeviceAllProp(Device device, UsageHistory usage, bool statusNow)
        {
            try
            {
                OpenConnection();
                int status = device.status ? 1 : 0;
                string sql;
                if (status == 1 && !statusNow)
                {
                    if (usage != null)
                    {
                        sql = $"update Device set [name]= '{device.DeviceName}',[deviceTypeId] = {device.Type}, [power] = {device.Power},[status] = {status}, [roomID]='{device.RoomID}' where[deviceId] = '{device.DeviceID}'" +
                            $"update [usageHistory] set [lastTimeOn] = '{DateTime.Now}' where [usageHistoryId] = '{usage.ID}'";
                    }
                    else
                    {
                        usage = new UsageHistory(device.DeviceID, DateTime.Now);
                        sql = $"update Device set [name]= '{device.DeviceName}',[deviceTypeId] = {device.Type}, [power] = {device.Power},[status] = {status}, [roomID]='{device.RoomID}' where [deviceId] = '{device.DeviceID}'" +
                            $"insert into [UsageHistory] values('{usage.ID}', '{usage.DeviceID}', '{usage.LastTimeOn}', 0)";
                    }
                }
                else if (status == 0 && statusNow) 
                {
                    TimeSpan time = DateTime.Now - usage.LastTimeOn;
                    double total = usage.TotalTimeOn + time.TotalHours;
                    sql = $"update Device set [name]= '{device.DeviceName}',[deviceTypeId] = {device.Type}, [power] = {device.Power},[status] = {status}, [roomID]='{device.RoomID}' where[deviceId] = '{device.DeviceID}'" +
                       $"update [usageHistory] set [totalTimeOn] = {total} where [usageHistoryId] = '{usage.ID}'";
                }else

                sql = $"update Device set [name]= '{device.DeviceName}',[deviceTypeId] = {device.Type}, [power] = {device.Power},[status] = {status}, [roomID]='{device.RoomID}' where[deviceId] = '{device.DeviceID}'";
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
