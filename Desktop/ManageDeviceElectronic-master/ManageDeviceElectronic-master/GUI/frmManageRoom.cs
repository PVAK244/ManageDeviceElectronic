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
    public partial class frmManageRoom : Form
    {
        RoomBLL roomBLL = new RoomBLL();
        public frmManageRoom()
        {
            InitializeComponent();
        }

        public void ShowGridView()
        {
            dgvManageRoom.DataSource = roomBLL.SelectAllRoom();
        }

        private void frmManageRoom_Load(object sender, EventArgs e)
        {
            ShowGridView();
        }

        private void dgvManageRoom_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvManageRoom.CurrentRow != null)
            {
                DataGridViewRow dgvRow = dgvManageRoom.CurrentRow;
                string roomID = dgvRow.Cells["txtRoomID"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRoomID"].Value.ToString();
                string roomName = dgvRow.Cells["txtRoomName"].Value == DBNull.Value ? "" : dgvRow.Cells["txtRoomName"].Value.ToString();
                Room room = new Room(roomID, roomName);
                roomBLL.UpdateRoom(room);
            }
        }

        private void dgvManageRoom_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvManageRoom.CurrentRow.Cells["txtRoomID"].Value != DBNull.Value)
            {
                if (MessageBox.Show("Are you sure to delete this record?", "DataGridView", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    roomBLL.DeleteRoom(dgvManageRoom.CurrentRow.Cells["txtRoomID"].Value.ToString());
                    ShowGridView();
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Room room = new Room("");
            roomBLL.InsertRoom(room);
            ShowGridView();
        }
    }
}
