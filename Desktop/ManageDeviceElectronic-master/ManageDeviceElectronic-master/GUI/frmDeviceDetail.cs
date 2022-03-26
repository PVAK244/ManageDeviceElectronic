using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class frmDeviceDetail : Form
    {

        public string DeviceId { get; set; }

        public frmDeviceDetail()
        {
            InitializeComponent();
        }

        static DeviceBLL deviceBLL = new DeviceBLL();
        static RoomBLL roomBLL = new RoomBLL();
        static DeviceTypeBLL deviceTypeBLL = new DeviceTypeBLL();
        static UsageHistoryBLL usageBLL = new UsageHistoryBLL();
        List<Room> rooms = roomBLL.SelectAllRoom();
        List<DeviceType> types = deviceTypeBLL.SelectAllDeviceType();
        private void frmDeviceDetail_Load(object sender, EventArgs e)
        {
            Device device = deviceBLL.SelectDeviceById(DeviceId);
            txtId.Text = device.DeviceID;
            txtName.Text = device.DeviceName;
            try
            {
                img.Image = Image.FromFile(device.ImagePath);

            }
            catch
            {
                DeviceTypeBLL d = new DeviceTypeBLL();
                img.Image = Image.FromFile(d.GetDefaultImage(device.Type));
            }


            cbRoom.DataSource = rooms;
            cbType.DataSource = types;

            foreach (var item in rooms)
            {
                if (item.RoomID == device.RoomID)
                {
                    cbRoom.Text = item.Name;
                    break;
                }
            }

            foreach (var item in types)
            {
                if (item.TypeID == device.Type)
                {
                    cbType.Text = item.Name;
                    break;
                }
            }
            cbStatus.Text = device.status ? "On" : "Off";

            txtPower.Text = device.Power.ToString();

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //string deviceID, string deviceName, int type, int power, string roomID, bool status

            int type = -1;
            foreach (var item in types)
            {
                if (item.Name.Equals(cbType.Text))
                {
                    type = item.TypeID;
                    break;
                }
            }

            string roomId = "";

            foreach (var item in rooms)
            {
                if (item.Name.Equals(cbRoom.Text))
                {
                    roomId = item.RoomID;
                    break;
                }
            }
            DateTime now = DateTime.Now;
            Device device = deviceBLL.SelectDeviceById(txtId.Text);
            UsageHistory usageHistory = usageBLL.SelectAllUsageHistory().SingleOrDefault(pro => pro.DeviceID == txtId.Text && pro.LastTimeOn.Month == now.Month);
            deviceBLL.UpdateDeviceAllProp(new Device(txtId.Text, txtName.Text, type, int.Parse(txtPower.Text), roomId, cbStatus.Text.Equals("On")), usageHistory, device.status);
            Close();
        }
    }
}
