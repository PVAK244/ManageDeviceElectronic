namespace GUI
{
    partial class frmManageDeviceElectronic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageDeviceElectronic));
            this.panelHide = new Guna.UI2.WinForms.Guna2Panel();
            this.panelManage = new Guna.UI2.WinForms.Guna2Panel();
            this.panelLogo = new Guna.UI2.WinForms.Guna2Panel();
            this.panelMain = new Guna.UI2.WinForms.Guna2Panel();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnManageDevice = new System.Windows.Forms.Button();
            this.btnManageDeviceType = new System.Windows.Forms.Button();
            this.btnManageRoom = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnDevice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelHide.SuspendLayout();
            this.panelManage.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHide
            // 
            this.panelHide.BackColor = System.Drawing.Color.DimGray;
            this.panelHide.Controls.Add(this.btnReport);
            this.panelHide.Controls.Add(this.panelManage);
            this.panelHide.Controls.Add(this.btnManage);
            this.panelHide.Controls.Add(this.btnDevice);
            this.panelHide.Controls.Add(this.panelLogo);
            this.panelHide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHide.Location = new System.Drawing.Point(0, 0);
            this.panelHide.Name = "panelHide";
            this.panelHide.Size = new System.Drawing.Size(200, 450);
            this.panelHide.TabIndex = 0;
            // 
            // panelManage
            // 
            this.panelManage.BackColor = System.Drawing.Color.Gray;
            this.panelManage.Controls.Add(this.btnManageDevice);
            this.panelManage.Controls.Add(this.btnManageDeviceType);
            this.panelManage.Controls.Add(this.btnManageRoom);
            this.panelManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelManage.Location = new System.Drawing.Point(0, 160);
            this.panelManage.Name = "panelManage";
            this.panelManage.Size = new System.Drawing.Size(200, 93);
            this.panelManage.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 1;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(775, 450);
            this.panelMain.TabIndex = 2;
            // 
            // btnReport
            // 
            this.btnReport.BackColor = System.Drawing.Color.DimGray;
            this.btnReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReport.FlatAppearance.BorderSize = 0;
            this.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReport.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReport.ForeColor = System.Drawing.Color.White;
            this.btnReport.Image = ((System.Drawing.Image)(resources.GetObject("btnReport.Image")));
            this.btnReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReport.Location = new System.Drawing.Point(0, 253);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(200, 30);
            this.btnReport.TabIndex = 0;
            this.btnReport.Text = "REPORTS";
            this.btnReport.UseVisualStyleBackColor = false;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnManageDevice
            // 
            this.btnManageDevice.BackColor = System.Drawing.Color.Gray;
            this.btnManageDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageDevice.FlatAppearance.BorderSize = 0;
            this.btnManageDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageDevice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDevice.ForeColor = System.Drawing.Color.White;
            this.btnManageDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnManageDevice.Image")));
            this.btnManageDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageDevice.Location = new System.Drawing.Point(0, 60);
            this.btnManageDevice.Name = "btnManageDevice";
            this.btnManageDevice.Padding = new System.Windows.Forms.Padding(5);
            this.btnManageDevice.Size = new System.Drawing.Size(200, 30);
            this.btnManageDevice.TabIndex = 2;
            this.btnManageDevice.Text = "DEVICE";
            this.btnManageDevice.UseVisualStyleBackColor = false;
            this.btnManageDevice.Click += new System.EventHandler(this.btnManageDevice_Click);
            // 
            // btnManageDeviceType
            // 
            this.btnManageDeviceType.BackColor = System.Drawing.Color.Gray;
            this.btnManageDeviceType.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageDeviceType.FlatAppearance.BorderSize = 0;
            this.btnManageDeviceType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageDeviceType.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageDeviceType.ForeColor = System.Drawing.Color.White;
            this.btnManageDeviceType.Image = ((System.Drawing.Image)(resources.GetObject("btnManageDeviceType.Image")));
            this.btnManageDeviceType.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageDeviceType.Location = new System.Drawing.Point(0, 30);
            this.btnManageDeviceType.Name = "btnManageDeviceType";
            this.btnManageDeviceType.Padding = new System.Windows.Forms.Padding(5);
            this.btnManageDeviceType.Size = new System.Drawing.Size(200, 30);
            this.btnManageDeviceType.TabIndex = 2;
            this.btnManageDeviceType.Text = "DEVICE TYPE";
            this.btnManageDeviceType.UseVisualStyleBackColor = false;
            this.btnManageDeviceType.Click += new System.EventHandler(this.btnManageDeviceType_Click);
            // 
            // btnManageRoom
            // 
            this.btnManageRoom.BackColor = System.Drawing.Color.Gray;
            this.btnManageRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManageRoom.FlatAppearance.BorderSize = 0;
            this.btnManageRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageRoom.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageRoom.ForeColor = System.Drawing.Color.White;
            this.btnManageRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnManageRoom.Image")));
            this.btnManageRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManageRoom.Location = new System.Drawing.Point(0, 0);
            this.btnManageRoom.Name = "btnManageRoom";
            this.btnManageRoom.Padding = new System.Windows.Forms.Padding(5);
            this.btnManageRoom.Size = new System.Drawing.Size(200, 30);
            this.btnManageRoom.TabIndex = 1;
            this.btnManageRoom.Text = "ROOM";
            this.btnManageRoom.UseVisualStyleBackColor = false;
            this.btnManageRoom.Click += new System.EventHandler(this.btnManageRoom_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.Color.DimGray;
            this.btnManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnManage.FlatAppearance.BorderSize = 0;
            this.btnManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.Color.White;
            this.btnManage.Image = ((System.Drawing.Image)(resources.GetObject("btnManage.Image")));
            this.btnManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManage.Location = new System.Drawing.Point(0, 130);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(200, 30);
            this.btnManage.TabIndex = 0;
            this.btnManage.Text = "MANAGE";
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnDevice
            // 
            this.btnDevice.BackColor = System.Drawing.Color.DimGray;
            this.btnDevice.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDevice.FlatAppearance.BorderSize = 0;
            this.btnDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevice.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevice.ForeColor = System.Drawing.Color.White;
            this.btnDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnDevice.Image")));
            this.btnDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevice.Location = new System.Drawing.Point(0, 100);
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.Size = new System.Drawing.Size(200, 30);
            this.btnDevice.TabIndex = 0;
            this.btnDevice.Text = "DEVICE";
            this.btnDevice.UseVisualStyleBackColor = false;
            this.btnDevice.Click += new System.EventHandler(this.btnDevice_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmManageDeviceElectronic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(975, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHide);
            this.Name = "frmManageDeviceElectronic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmManageDeviceElectronic";
            this.Text = "Manage Device Electronic";
            this.panelHide.ResumeLayout(false);
            this.panelManage.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHide;
        private Guna.UI2.WinForms.Guna2Panel panelMain;
        private System.Windows.Forms.Button btnDevice;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel panelManage;
        private System.Windows.Forms.Button btnManageDevice;
        private System.Windows.Forms.Button btnManageRoom;
        private Guna.UI2.WinForms.Guna2Panel panelLogo;
        private System.Windows.Forms.Button btnManageDeviceType;
    }
}