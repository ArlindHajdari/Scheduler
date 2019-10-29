namespace ScheduleManagementSystem
{
    partial class UCDeleteTitles
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.cmbTitleD = new System.Windows.Forms.ComboBox();
            this.lblTitleD = new System.Windows.Forms.Label();
            this.lblDeleteT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkRed;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(287, 117);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 32);
            this.btnEdit.TabIndex = 68;
            this.btnEdit.Text = "Delete";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbTitleD
            // 
            this.cmbTitleD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitleD.FormattingEnabled = true;
            this.cmbTitleD.Location = new System.Drawing.Point(221, 72);
            this.cmbTitleD.Name = "cmbTitleD";
            this.cmbTitleD.Size = new System.Drawing.Size(168, 21);
            this.cmbTitleD.TabIndex = 67;
            // 
            // lblTitleD
            // 
            this.lblTitleD.AutoSize = true;
            this.lblTitleD.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleD.Location = new System.Drawing.Point(110, 70);
            this.lblTitleD.Name = "lblTitleD";
            this.lblTitleD.Size = new System.Drawing.Size(34, 20);
            this.lblTitleD.TabIndex = 66;
            this.lblTitleD.Text = "Title";
            // 
            // lblDeleteT
            // 
            this.lblDeleteT.AutoSize = true;
            this.lblDeleteT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteT.Location = new System.Drawing.Point(206, 33);
            this.lblDeleteT.Name = "lblDeleteT";
            this.lblDeleteT.Size = new System.Drawing.Size(56, 20);
            this.lblDeleteT.TabIndex = 65;
            this.lblDeleteT.Text = "Delete";
            // 
            // UCDeleteTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cmbTitleD);
            this.Controls.Add(this.lblTitleD);
            this.Controls.Add(this.lblDeleteT);
            this.Name = "UCDeleteTitles";
            this.Size = new System.Drawing.Size(499, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cmbTitleD;
        private System.Windows.Forms.Label lblTitleD;
        private System.Windows.Forms.Label lblDeleteT;
    }
}
