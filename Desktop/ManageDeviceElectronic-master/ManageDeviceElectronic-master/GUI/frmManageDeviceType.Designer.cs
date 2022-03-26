namespace GUI
{
    partial class frmManageDeviceType
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
            this.dgvManageDeviceType = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.txtTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDefaultImage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageDeviceType)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Device Type";
            // 
            // dgvManageDeviceType
            // 
            this.dgvManageDeviceType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtTypeID,
            this.txtName,
            this.txtDefaultImage});
            this.dgvManageDeviceType.Location = new System.Drawing.Point(46, 91);
            this.dgvManageDeviceType.Name = "dgvManageDeviceType";
            this.dgvManageDeviceType.Size = new System.Drawing.Size(702, 326);
            this.dgvManageDeviceType.TabIndex = 3;
            this.dgvManageDeviceType.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageDeviceType_CellClick);
            this.dgvManageDeviceType.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageDeviceType_CellDoubleClick);
            this.dgvManageDeviceType.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvManageDeviceType_CellValueChanged);
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
            // txtTypeID
            // 
            this.txtTypeID.DataPropertyName = "TypeID";
            this.txtTypeID.HeaderText = "TypeID";
            this.txtTypeID.Name = "txtTypeID";
            this.txtTypeID.Visible = false;
            // 
            // txtName
            // 
            this.txtName.DataPropertyName = "Name";
            this.txtName.HeaderText = "Name";
            this.txtName.Name = "txtName";
            // 
            // txtDefaultImage
            // 
            this.txtDefaultImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.txtDefaultImage.DataPropertyName = "DefaultImage";
            this.txtDefaultImage.HeaderText = "DefaultImage";
            this.txtDefaultImage.Name = "txtDefaultImage";
            this.txtDefaultImage.ReadOnly = true;
            this.txtDefaultImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // frmManageDeviceType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.dgvManageDeviceType);
            this.Controls.Add(this.btnNew);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageDeviceType";
            this.Text = "frmManageDeviceType";
            this.Load += new System.EventHandler(this.frmManageDeviceType_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvManageDeviceType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvManageDeviceType;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtName;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtDefaultImage;
    }
}