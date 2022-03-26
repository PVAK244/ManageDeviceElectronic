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
    public partial class frmManageDeviceType : Form
    {
        DeviceTypeBLL typeBLL = new DeviceTypeBLL();
        public frmManageDeviceType()
        {
            InitializeComponent();
        }
        public void ShowGridView()
        {
            dgvManageDeviceType.DataSource = typeBLL.SelectAllDeviceType();
        }
        private void frmManageDeviceType_Load(object sender, EventArgs e)
        {
            ShowGridView();
        }

        private void dgvManageDeviceType_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvManageDeviceType.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvManageDeviceType.CurrentRow;
                int typeID = int.Parse(dgvRow.Cells["txtTypeID"].Value.ToString());
                string name = dgvRow.Cells["txtName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtName"].Value.ToString();
                string defaultImage = dgvRow.Cells["txtDefaultImage"].Value == DBNull.Value ? "" : dgvRow.Cells["txtDefaultImage"].Value.ToString();
                DeviceType type = new DeviceType(typeID, name, defaultImage);
                typeBLL.UpdateDeviceType(type);
            }
        }

        private void dgvManageDeviceType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvManageDeviceType.CurrentRow.Cells["txtTypeID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure to delete this record?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    typeBLL.DeleteDeviceType(dgvManageDeviceType.CurrentRow.Cells["txtTypeID"].Value.ToString());
                    ShowGridView();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            OpenFileDialog v = new OpenFileDialog();
            v.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (v.ShowDialog() == DialogResult.OK)
            {
                DeviceType type = new DeviceType("", v.FileName);
                typeBLL.InsertDeviceType(type);
                ShowGridView();
            }
        }

        private void dgvManageDeviceType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                OpenFileDialog v = new OpenFileDialog();
                v.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
                if (v.ShowDialog() == DialogResult.OK)
                {
                    DataGridViewRow dgvRow = dgvManageDeviceType.CurrentRow;
                    dgvRow.Cells["txtDefaultImage"].Value = v.FileName;
                }
            }
        }
    }
}
