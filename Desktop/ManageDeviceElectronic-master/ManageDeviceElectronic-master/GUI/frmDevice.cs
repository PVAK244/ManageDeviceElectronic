using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
using GUI.Properties;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Suite;

namespace GUI
{
    public partial class frmDevice : Form
    {
        DeviceBLL deviceBLL = new DeviceBLL();
        RoomBLL roomBLL = new RoomBLL();
        UsageHistoryBLL usageBLL = new UsageHistoryBLL();
        public frmDevice()
        {
            InitializeComponent();
        }

        private void frmDevice_Load(object sender, EventArgs e)
        {
            cboRoom.ValueMember = "RoomID";
            cboRoom.DisplayMember = "Name";

            cboRoom.DataSource = roomBLL.SelectAllRoom();

        }


        private void ChangeRoom(List<Device> listDevice)
        {
            flowLayoutPanel1.Controls.Clear();
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmDevice));
            flowLayoutPanel1.AutoScroll = true;
            foreach (var item in listDevice)
            {
                Guna2ImageButton guna2ImageButton1 = new Guna2ImageButton();
                guna2ImageButton1.CheckedState.ImageSize = new Size(64, 64);
                guna2ImageButton1.HoverState.ImageSize = new Size(64, 64);
                try
                {
                    guna2ImageButton1.Image = Image.FromFile(item.ImagePath);

                }
                catch
                {
                    DeviceTypeBLL d = new DeviceTypeBLL();
                    guna2ImageButton1.Image = Image.FromFile(d.GetDefaultImage(item.Type));
                }
                guna2ImageButton1.ImageOffset = new Point(0, 0);
                guna2ImageButton1.ImageRotate = 0F;
                guna2ImageButton1.BackColor = Color.Gray;
                guna2ImageButton1.Name = item.DeviceID;
                guna2ImageButton1.PressedState.ImageSize = new Size(64, 64);
                guna2ImageButton1.Size = new Size(64, 54);
                guna2ImageButton1.TabIndex = 0;
                guna2ImageButton1.Location = new Point(4, 19);
                guna2ImageButton1.Click += onClickImage;


                Guna2CustomRadioButton guna2CustomRadioButton1 = new Guna2CustomRadioButton();
                guna2CustomRadioButton1.CheckedState.BorderColor = Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
                guna2CustomRadioButton1.CheckedState.BorderThickness = 0;
                guna2CustomRadioButton1.CheckedState.FillColor = Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
                guna2CustomRadioButton1.CheckedState.InnerColor = Color.White;
                guna2CustomRadioButton1.Location = new Point(27, 74);
                guna2CustomRadioButton1.Name = item.DeviceID;
                guna2CustomRadioButton1.Size = new Size(20, 20);
                guna2CustomRadioButton1.TabIndex = 1;
                guna2CustomRadioButton1.Text = item.status.ToString();
                guna2CustomRadioButton1.UncheckedState.BorderColor = Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
                guna2CustomRadioButton1.UncheckedState.BorderThickness = 2;
                guna2CustomRadioButton1.UncheckedState.FillColor = Color.Transparent;
                guna2CustomRadioButton1.UncheckedState.InnerColor = Color.Transparent;
                guna2CustomRadioButton1.Checked = item.status;
                guna2CustomRadioButton1.Click += onClickOnOffDevice;

                GroupBox groupBox1 = new GroupBox();
                groupBox1.SuspendLayout();
                groupBox1.Controls.Add(guna2ImageButton1);
                groupBox1.Controls.Add(guna2CustomRadioButton1);
                groupBox1.Name = item.DeviceID;
                groupBox1.Size = new Size(73, 100);
                groupBox1.TabIndex = 0;
                groupBox1.TabStop = false;
                groupBox1.Text = item.DeviceName;

                flowLayoutPanel1.Controls.Add(groupBox1);
                groupBox1.ResumeLayout(false);

            }
        }

        private void cboRoom_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<Device> listDevice = deviceBLL.SelectDevicesByRoomName(cboRoom.SelectedValue.ToString());
            ChangeRoom(listDevice);
            grBox.Text = cboRoom.Text;
        }

        private void onClickOnOffDevice(object sender, EventArgs e)
        {
            Guna2CustomRadioButton radioButton = (Guna2CustomRadioButton)sender;
            grBox.Text = radioButton.Text;
            DateTime now = DateTime.Now;
            Device device = deviceBLL.SelectDeviceById(radioButton.Name);
            UsageHistory usageHistory = usageBLL.SelectAllUsageHistory().SingleOrDefault(pro => pro.DeviceID == radioButton.Text && pro.LastTimeOn.Month == now.Month);
            deviceBLL.TurnOnOffDevice(radioButton.Name, !bool.Parse(radioButton.Text), usageHistory, device.status);
            List<Device> listDevice = deviceBLL.SelectDevicesByRoomName(cboRoom.SelectedValue.ToString());
            ChangeRoom(listDevice);
        }

        private void onClickImage(object sender, EventArgs e)
        {

            Guna2ImageButton btn = (Guna2ImageButton)sender;
            frmDeviceDetail f = new frmDeviceDetail()
            {
                DeviceId = btn.Name
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                List<Device> listDevice = deviceBLL.SelectDevicesByRoomName(cboRoom.SelectedValue.ToString());
                ChangeRoom(listDevice);
            }
        }
    }
}
