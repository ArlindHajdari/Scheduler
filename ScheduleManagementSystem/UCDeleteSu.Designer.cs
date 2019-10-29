namespace ScheduleManagementSystem
{
    partial class UCDeleteSu
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
            this.btnDeleteSu = new System.Windows.Forms.Button();
            this.cmbSubjectD = new System.Windows.Forms.ComboBox();
            this.lblSubjectD = new System.Windows.Forms.Label();
            this.lblDeleteSu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDeleteSu
            // 
            this.btnDeleteSu.BackColor = System.Drawing.Color.DarkRed;
            this.btnDeleteSu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteSu.Location = new System.Drawing.Point(286, 115);
            this.btnDeleteSu.Name = "btnDeleteSu";
            this.btnDeleteSu.Size = new System.Drawing.Size(102, 32);
            this.btnDeleteSu.TabIndex = 68;
            this.btnDeleteSu.Text = "Delete";
            this.btnDeleteSu.UseVisualStyleBackColor = false;
            this.btnDeleteSu.Click += new System.EventHandler(this.btnDeleteSu_Click);
            // 
            // cmbSubjectD
            // 
            this.cmbSubjectD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubjectD.FormattingEnabled = true;
            this.cmbSubjectD.Location = new System.Drawing.Point(220, 70);
            this.cmbSubjectD.Name = "cmbSubjectD";
            this.cmbSubjectD.Size = new System.Drawing.Size(168, 21);
            this.cmbSubjectD.TabIndex = 67;
            // 
            // lblSubjectD
            // 
            this.lblSubjectD.AutoSize = true;
            this.lblSubjectD.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubjectD.Location = new System.Drawing.Point(163, 68);
            this.lblSubjectD.Name = "lblSubjectD";
            this.lblSubjectD.Size = new System.Drawing.Size(51, 20);
            this.lblSubjectD.TabIndex = 66;
            this.lblSubjectD.Text = "Subject";
            // 
            // lblDeleteSu
            // 
            this.lblDeleteSu.AutoSize = true;
            this.lblDeleteSu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteSu.Location = new System.Drawing.Point(205, 31);
            this.lblDeleteSu.Name = "lblDeleteSu";
            this.lblDeleteSu.Size = new System.Drawing.Size(56, 20);
            this.lblDeleteSu.TabIndex = 65;
            this.lblDeleteSu.Text = "Delete";
            // 
            // UCDeleteSu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDeleteSu);
            this.Controls.Add(this.cmbSubjectD);
            this.Controls.Add(this.lblSubjectD);
            this.Controls.Add(this.lblDeleteSu);
            this.Name = "UCDeleteSu";
            this.Size = new System.Drawing.Size(499, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteSu;
        private System.Windows.Forms.ComboBox cmbSubjectD;
        private System.Windows.Forms.Label lblSubjectD;
        private System.Windows.Forms.Label lblDeleteSu;
    }
}
