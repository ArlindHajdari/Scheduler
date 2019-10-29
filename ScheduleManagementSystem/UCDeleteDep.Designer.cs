namespace ScheduleManagementSystem
{
    partial class UCDeleteDep
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
            this.btnDel = new System.Windows.Forms.Button();
            this.cmbDepD = new System.Windows.Forms.ComboBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.lblDelete = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.DarkRed;
            this.btnDel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDel.Location = new System.Drawing.Point(288, 116);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(102, 32);
            this.btnDel.TabIndex = 72;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cmbDepD
            // 
            this.cmbDepD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepD.FormattingEnabled = true;
            this.cmbDepD.Location = new System.Drawing.Point(222, 71);
            this.cmbDepD.Name = "cmbDepD";
            this.cmbDepD.Size = new System.Drawing.Size(168, 21);
            this.cmbDepD.TabIndex = 71;
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.Location = new System.Drawing.Point(96, 69);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(120, 20);
            this.lblDep.TabIndex = 70;
            this.lblDep.Text = "Choose Department";
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(207, 32);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(56, 20);
            this.lblDelete.TabIndex = 69;
            this.lblDelete.Text = "Delete";
            // 
            // UCDeleteDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.cmbDepD);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.lblDelete);
            this.Name = "UCDeleteDep";
            this.Size = new System.Drawing.Size(499, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ComboBox cmbDepD;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.Label lblDelete;
    }
}
