namespace ScheduleManagementSystem
{
    partial class UCDepR
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
            this.btnRegisterD = new System.Windows.Forms.Button();
            this.txtEmriD = new System.Windows.Forms.TextBox();
            this.lblNameD = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.cmbFac = new System.Windows.Forms.ComboBox();
            this.lblD = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegisterD
            // 
            this.btnRegisterD.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegisterD.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegisterD.Location = new System.Drawing.Point(291, 143);
            this.btnRegisterD.Name = "btnRegisterD";
            this.btnRegisterD.Size = new System.Drawing.Size(102, 32);
            this.btnRegisterD.TabIndex = 55;
            this.btnRegisterD.Text = "Add";
            this.btnRegisterD.UseVisualStyleBackColor = false;
            this.btnRegisterD.Click += new System.EventHandler(this.btnRegisterD_Click);
            // 
            // txtEmriD
            // 
            this.txtEmriD.Location = new System.Drawing.Point(225, 68);
            this.txtEmriD.Name = "txtEmriD";
            this.txtEmriD.Size = new System.Drawing.Size(168, 20);
            this.txtEmriD.TabIndex = 54;
            // 
            // lblNameD
            // 
            this.lblNameD.AutoSize = true;
            this.lblNameD.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameD.Location = new System.Drawing.Point(176, 66);
            this.lblNameD.Name = "lblNameD";
            this.lblNameD.Size = new System.Drawing.Size(43, 20);
            this.lblNameD.TabIndex = 53;
            this.lblNameD.Text = "Name";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.Location = new System.Drawing.Point(210, 29);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(69, 20);
            this.lblRegister.TabIndex = 52;
            this.lblRegister.Text = "Register";
            // 
            // cmbFac
            // 
            this.cmbFac.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFac.FormattingEnabled = true;
            this.cmbFac.IntegralHeight = false;
            this.cmbFac.Location = new System.Drawing.Point(225, 104);
            this.cmbFac.Name = "cmbFac";
            this.cmbFac.Size = new System.Drawing.Size(168, 21);
            this.cmbFac.TabIndex = 58;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblD.Location = new System.Drawing.Point(132, 102);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(87, 20);
            this.lblD.TabIndex = 57;
            this.lblD.Text = "Select Faculty";
            // 
            // UCDepR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbFac);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.btnRegisterD);
            this.Controls.Add(this.txtEmriD);
            this.Controls.Add(this.lblNameD);
            this.Controls.Add(this.lblRegister);
            this.Name = "UCDepR";
            this.Size = new System.Drawing.Size(499, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterD;
        private System.Windows.Forms.TextBox txtEmriD;
        private System.Windows.Forms.Label lblNameD;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.ComboBox cmbFac;
        private System.Windows.Forms.Label lblD;
    }
}
