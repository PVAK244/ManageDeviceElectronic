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
    public partial class frmReports : Form
    {
        DeviceBLL deviceBLL = new DeviceBLL();
        RoomBLL roomBLL = new RoomBLL();
        DeviceTypeBLL typeBLL = new DeviceTypeBLL();
        UsageHistoryBLL usageBLL = new UsageHistoryBLL();
        ElectricBillBLL billBLL = new ElectricBillBLL();
        public frmReports()
        {
            InitializeComponent();
        }
        public void ShowGridView()
        {
            dgvReport.DataSource = billBLL.SelectAllBill();
        }
        private void frmReports_Load(object sender, EventArgs e)
        {
            ShowGridView();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            double totalKWH = 0;
            foreach (Device device in deviceBLL.SelectAllDevice())
            {
                DateTime now = DateTime.Now;
                UsageHistory usageHistory = usageBLL.SelectAllUsageHistory().SingleOrDefault(pro => pro.DeviceID == device.DeviceID && pro.LastTimeOn.Month == now.Month);
                int totalTimeOn = 0;  
                if (device.status == true)
                {
                    TimeSpan time = now - usageHistory.LastTimeOn;
                    usageHistory.TotalTimeOn = time.TotalHours;
                    usageBLL.UpdateUsageHistory(usageHistory);
                }
                totalKWH += usageHistory.TotalTimeOn * device.Power / 1000; 
            }
            decimal money = (decimal) totalKWH * 3000;
            ElectricBill bill = new ElectricBill(totalKWH, money);
            billBLL.InsertBill(bill);
            frmReport frmReport = new frmReport();
            frmReport.ShowDialog();
            foreach (UsageHistory usageHistory in usageBLL.SelectAllUsageHistory())
            {
                usageHistory.TotalTimeOn = 0;
                usageBLL.UpdateUsageHistory(usageHistory);
            }
            ShowGridView();
        }
    }
}
