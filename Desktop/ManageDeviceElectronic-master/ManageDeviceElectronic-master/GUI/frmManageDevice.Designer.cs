namespace GUI
{
    partial class frmManageDevice
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvManage = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtDeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtImagePath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxDeviceType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.txtPower = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxRoomName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.DimGray;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 50);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Device";
            // 
            // dgvManage
            // 
            this.dgvManage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtDeviceID,
            this.txtDeviceName,
            this.txtImagePath,
            this.cbxDeviceType,
            this.txtPower,
            this.cbxRoomName});
            this.dgvManage.Location = new System.Drawing.Point(46, 86);
            this.dgvManage.Name = "dgvManage";
            this.dgvManage.Size = new System.Drawing.Size(702, 326);
            this.dgvManage.TabIndex = 0;
            this.dgvManage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManage_CellClick);
            this.dgvManage.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManage_CellDoubleClick);
            this.dgvManage.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManage_CellValueChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(46, 418);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtDeviceID
            // 
            this.txtDeviceID.DataPropertyName = "DeviceID";
            this.txtDeviceID.HeaderText = "DeviceID";
            this.txtDeviceID.Name = "txtDeviceID";
            this.txtDeviceID.Visible = false;
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.DataPropertyName = "DeviceName";
            this.txtDeviceName.HeaderText = "DeviceName";
            this.txtDeviceName.Name = "txtDeviceName";
            // 
            // txtImagePath
            // 
            this.txtImagePath.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtImagePath.DataPropertyName = "ImagePath";
            this.txtImagePath.HeaderText = "ImagePath";
            this.txtImagePath.Name = "txtImagePath";
            this.txtImagePath.ReadOnly = true;
            // 
            // cbxDeviceType
            // 
            this.cbxDeviceType.DataPropertyName = "Type";
            this.cbxDeviceType.HeaderText = "DeviceType";
            this.cbxDeviceType.Name = "cbxDeviceType";
            // 
            // txtPower
            // 
            this.txtPower.DataPropertyName = "Power";
            this.txtPower.HeaderText = "Power";
            this.txtPower.Name = "txtPower";
            // 
            // cbxRoomName
            // 
            this.cbxRoomName.DataPropertyName = "RoomID";
            this.cbxRoomName.HeaderText = "RoomName";
            this.cbxRoomName.Name = "cbxRoomName";
            // 
            // frmManageDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dgvManage);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageDevice";
            this.Text = "frmManageDevice";
            this.Load += new System.EventHandler(this.frmManageDevice_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.DataGridView dgvManage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDeviceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDeviceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtImagePath;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxDeviceType;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtPower;
        private System.Windows.Forms.DataGridViewComboBoxColumn cbxRoomName;
    }
}