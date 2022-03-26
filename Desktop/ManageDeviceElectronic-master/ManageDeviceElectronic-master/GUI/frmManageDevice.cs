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
    public partial class frmManageDevice : Form
    {
        DeviceBLL deviceBLL = new DeviceBLL();
        RoomBLL roomBLL = new RoomBLL();
        DeviceTypeBLL typeBLL = new DeviceTypeBLL();
        public frmManageDevice()
        {
            InitializeComponent();
        }
        public void ShowGridView()
        {
            cbxDeviceType.ValueMember = "TypeID";
            cbxDeviceType.DisplayMember = "Name";
            cbxDeviceType.DataSource = typeBLL.SelectAllDeviceType();
            cbxRoomName.ValueMember = "RoomID";
            cbxRoomName.DisplayMember = "Name";
            cbxRoomName.DataSource = roomBLL.SelectAllRoom();
            dgvManage.DataSource = deviceBLL.SelectAllDevice();
        }

        private void frmManageDevice_Load(object sender, EventArgs e)
        {
            ShowGridView();
        }

        private void dgvManage_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvManage.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvManage.CurrentRow;
                string deviceID = dgvRow.Cells["txtDeviceID"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDeviceID"].Value.ToString();
                string deviceName = dgvRow.Cells["txtDeviceName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDeviceName"].Value.ToString();
                string imagePath = dgvRow.Cells["txtImagePath"].Value == DBNull.Value ? "" : dgvRow.Cells["txtImagePath"].Value.ToString();
                int type = int.Parse(dgvRow.Cells["cbxDeviceType"].Value.ToString());
                int power = int.Parse(dgvRow.Cells["txtPower"].Value.ToString());
                string roomID = dgvRow.Cells["cbxRoomName"].Value == DBNull.Value ? "" : dgvRow.Cells["cbxRoomName"].Value.ToString();
                Device device = new Device(deviceID, deviceName, imagePath, type, power, roomID);
                deviceBLL.UpdateDevice(device);
            }
        }
        private void dgvManage_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvManage.CurrentRow.Cells["txtDeviceID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure to delete this record?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    deviceBLL.DeleteDevice(dgvManage.CurrentRow.Cells["txtDeviceID"].Value.ToString());
                    ShowGridView();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmAddDevice frmAddDevice = new frmAddDevice();
            if (frmAddDevice.ShowDialog() == DialogResult.OK)
            {
                ShowGridView();
            }
        }

        private void dgvManage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                OpenFileDialog v = new OpenFileDialog();
                v.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
                if (v.ShowDialog() == DialogResult.OK)
                {
                    DataGridViewRow dgvRow = dgvManage.CurrentRow;
                    dgvRow.Cells["txtImagePath"].Value = v.FileName;
                }
            }
        }
    }
}
