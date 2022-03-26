using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class frmAddDevice : Form
    {
        DeviceBLL deviceBLL = new DeviceBLL();
        RoomBLL roomBLL = new RoomBLL();
        DeviceTypeBLL typeBLL = new DeviceTypeBLL();
        public frmAddDevice()
        {
            InitializeComponent();
        }

        private void txtImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog v = new OpenFileDialog();
            v.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (v.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = v.FileName;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDeviceName.Text = "";
            txtImage.Text = "";
            cbxType.SelectedIndex = 0;
            txtPower.Text = "";
            cbxRoom.SelectedIndex = 0;
        }

        private void frmAddDevice_Load(object sender, EventArgs e)
        {
            cbxType.ValueMember = "TypeID";
            cbxType.DisplayMember = "Name";
            cbxType.DataSource = typeBLL.SelectAllDeviceType();
            cbxRoom.ValueMember = "RoomID";
            cbxRoom.DisplayMember = "Name";
            cbxRoom.DataSource = roomBLL.SelectAllRoom();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string deviceName = txtDeviceName.Text;
                string image = txtImage.Text;
                int type = int.Parse(cbxType.SelectedValue.ToString());
                int power = int.Parse(txtPower.Text);
                string roomID = cbxRoom.SelectedValue.ToString();
                if (image == "") image = typeBLL.SelectAllDeviceType().SingleOrDefault(pro => pro.TypeID == type).DefaultImage;
                Device device = new Device(deviceName, image, type, power, roomID);
                deviceBLL.InsertDevice(device);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Insert");
            }
        }
    }
}
