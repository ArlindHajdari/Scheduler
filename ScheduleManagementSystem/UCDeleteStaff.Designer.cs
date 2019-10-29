namespace ScheduleManagementSystem
{
    partial class UCDeleteStaff
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbStaffD = new System.Windows.Forms.ComboBox();
            this.lblStaff = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pbProf = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbProf)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStaffD
            // 
            this.cmbStaffD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStaffD.FormattingEnabled = true;
            this.cmbStaffD.Location = new System.Drawing.Point(222, 71);
            this.cmbStaffD.Name = "cmbStaffD";
            this.cmbStaffD.Size = new System.Drawing.Size(168, 21);
            this.cmbStaffD.TabIndex = 63;
            this.cmbStaffD.SelectionChangeCommitted += new System.EventHandler(this.cmbStaffD_SelectionChangeCommitted);
            // 
            // lblStaff
            // 
            this.lblStaff.AutoSize = true;
            this.lblStaff.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaff.Location = new System.Drawing.Point(160, 69);
            this.lblStaff.Name = "lblStaff";
            this.lblStaff.Size = new System.Drawing.Size(56, 20);
            this.lblStaff.TabIndex = 62;
            this.lblStaff.Text = "Member";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(207, 32);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(56, 20);
            this.lblDelete.TabIndex = 61;
            this.lblDelete.Text = "Delete";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkRed;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(288, 123);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 32);
            this.btnEdit.TabIndex = 64;
            this.btnEdit.Text = "Delete";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pbProf
            // 
            this.pbProf.Location = new System.Drawing.Point(4, 71);
            this.pbProf.Name = "pbProf";
            this.pbProf.Size = new System.Drawing.Size(150, 149);
            this.pbProf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProf.TabIndex = 65;
            this.pbProf.TabStop = false;
            // 
            // UCDeleteStaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbProf);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cmbStaffD);
            this.Controls.Add(this.lblStaff);
            this.Controls.Add(this.lblDelete);
            this.Name = "UCDeleteStaff";
            this.Size = new System.Drawing.Size(499, 309);
            ((System.ComponentModel.ISupportInitialize)(this.pbProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbStaffD;
        private System.Windows.Forms.Label lblStaff;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.PictureBox pbProf;
    }
}
