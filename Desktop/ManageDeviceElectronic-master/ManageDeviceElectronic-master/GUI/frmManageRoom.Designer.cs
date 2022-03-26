namespace GUI
{
    partial class frmManageRoom
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
            this.dgvManageRoom = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtRoomID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtRoomName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageRoom)).BeginInit();
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
            this.guna2Panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Room";
            // 
            // dgvManageRoom
            // 
            this.dgvManageRoom.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtRoomID,
            this.txtRoomName});
            this.dgvManageRoom.Location = new System.Drawing.Point(46, 91);
            this.dgvManageRoom.Name = "dgvManageRoom";
            this.dgvManageRoom.Size = new System.Drawing.Size(702, 326);
            this.dgvManageRoom.TabIndex = 3;
            this.dgvManageRoom.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageRoom_CellDoubleClick);
            this.dgvManageRoom.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageRoom_CellValueChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(46, 423);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // txtRoomID
            // 
            this.txtRoomID.DataPropertyName = "RoomID";
            this.txtRoomID.HeaderText = "RoomID";
            this.txtRoomID.Name = "txtRoomID";
            this.txtRoomID.Visible = false;
            // 
            // txtRoomName
            // 
            this.txtRoomName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtRoomName.DataPropertyName = "Name";
            this.txtRoomName.HeaderText = "RoomName";
            this.txtRoomName.Name = "txtRoomName";
            // 
            // frmManageRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvManageRoom);
            this.Controls.Add(this.btnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageRoom";
            this.Text = "frmManageRoom";
            this.Load += new System.EventHandler(this.frmManageRoom_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageRoom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvManageRoom;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRoomID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtRoomName;
    }
}