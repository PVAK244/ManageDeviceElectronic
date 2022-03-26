using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmManageDeviceElectronic : Form
    {
        public frmManageDeviceElectronic()
        {
            InitializeComponent();
            customizeDesing();
        }

        public void customizeDesing()
        {
            panelManage.Visible = false;
        }
        
        public void hideSubMenu()
        {
            if (panelManage.Visible == true)
            {
                panelManage.Visible = false;
            }
        }

        public void showSubMenu(Panel subMenu)
        {
            if (panelManage.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        public void loadForm(object Form)
        {
            if (panelMain.Controls.Count > 0) panelMain.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            panelMain.Controls.Add(f);
            panelMain.Tag = f;
            f.Show();
        }

        private void btnDevice_Click(object sender, EventArgs e)
        {
            loadForm(new frmDevice());
            btnDevice.BackColor = Color.DarkGray;
            btnManage.BackColor = Color.DimGray;
            btnReport.BackColor = Color.DimGray;
            btnManageRoom.BackColor = Color.Gray;
            btnManageRoom.ForeColor = Color.White;
            btnManageDeviceType.BackColor = Color.Gray;
            btnManageDeviceType.ForeColor = Color.White;
            btnManageDevice.BackColor = Color.Gray;
            btnManageDevice.ForeColor = Color.White;
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            btnDevice.BackColor = Color.DimGray;
            btnReport.BackColor = Color.DimGray;
            btnManage.BackColor = Color.DarkGray;
            showSubMenu(panelManage);
        }

        private void btnManageRoom_Click(object sender, EventArgs e)
        {
            loadForm(new frmManageRoom());
            btnManageRoom.BackColor = Color.White;
            btnManageRoom.ForeColor = Color.Black;
            btnManageDeviceType.BackColor = Color.Gray;
            btnManageDeviceType.ForeColor = Color.White;
            btnManageDevice.BackColor = Color.Gray;
            btnManageDevice.ForeColor = Color.White;
        }

        private void btnManageDevice_Click(object sender, EventArgs e)
        {
            loadForm(new frmManageDevice());
            btnManageRoom.BackColor = Color.Gray;
            btnManageRoom.ForeColor = Color.White;
            btnManageDeviceType.BackColor = Color.Gray;
            btnManageDeviceType.ForeColor = Color.White;
            btnManageDevice.BackColor = Color.White;
            btnManageDevice.ForeColor = Color.Black;
        }

        private void btnManageDeviceType_Click(object sender, EventArgs e)
        {
            loadForm(new frmManageDeviceType());
            btnManageRoom.BackColor = Color.Gray;
            btnManageRoom.ForeColor = Color.White;
            btnManageDeviceType.BackColor = Color.White;
            btnManageDeviceType.ForeColor = Color.Black;
            btnManageDevice.BackColor = Color.Gray;
            btnManageDevice.ForeColor = Color.White;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            loadForm(new frmReports());
            btnDevice.BackColor = Color.DimGray;
            btnManage.BackColor = Color.DimGray;
            btnReport.BackColor = Color.DarkGray;
            btnManageRoom.BackColor = Color.Gray;
            btnManageRoom.ForeColor = Color.White;
            btnManageDeviceType.BackColor = Color.Gray;
            btnManageDeviceType.ForeColor = Color.White;
            btnManageDevice.BackColor = Color.Gray;
            btnManageDevice.ForeColor = Color.White;
        }
    }
}
