namespace GUI
{
    partial class frmDevice
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
            this.cboRoom = new Guna.UI2.WinForms.Guna2ComboBox();
            this.grBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // cboRoom
            // 
            this.cboRoom.BackColor = System.Drawing.Color.Transparent;
            this.cboRoom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRoom.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboRoom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboRoom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cboRoom.ItemHeight = 30;
            this.cboRoom.Location = new System.Drawing.Point(74, 48);
            this.cboRoom.Name = "cboRoom";
            this.cboRoom.Size = new System.Drawing.Size(140, 36);
            this.cboRoom.TabIndex = 1;
            this.cboRoom.SelectedIndexChanged += new System.EventHandler(this.cboRoom_SelectedIndexChanged);
            // 
            // grBox
            // 
            this.grBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.grBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.grBox.Location = new System.Drawing.Point(74, 106);
            this.grBox.Name = "grBox";
            this.grBox.Size = new System.Drawing.Size(683, 321);
            this.grBox.TabIndex = 2;
            this.grBox.Text = "guna2GroupBox1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(77, 153);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(677, 271);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // frmDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.grBox);
            this.Controls.Add(this.cboRoom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDevice";
            this.Text = "frmDevice";
            this.Load += new System.EventHandler(this.frmDevice_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ComboBox cboRoom;
        private Guna.UI2.WinForms.Guna2GroupBox grBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}