namespace ScheduleManagementSystem
{
    partial class UCFacultiesR
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
            this.btnRegisterR = new System.Windows.Forms.Button();
            this.txtEmriF = new System.Windows.Forms.TextBox();
            this.lblNameF = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegisterR
            // 
            this.btnRegisterR.BackColor = System.Drawing.Color.ForestGreen;
            this.btnRegisterR.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRegisterR.Location = new System.Drawing.Point(291, 105);
            this.btnRegisterR.Name = "btnRegisterR";
            this.btnRegisterR.Size = new System.Drawing.Size(102, 32);
            this.btnRegisterR.TabIndex = 57;
            this.btnRegisterR.Text = "Add";
            this.btnRegisterR.UseVisualStyleBackColor = false;
            this.btnRegisterR.Click += new System.EventHandler(this.btnRegisterR_Click);
            // 
            // txtEmriF
            // 
            this.txtEmriF.Location = new System.Drawing.Point(225, 68);
            this.txtEmriF.Name = "txtEmriF";
            this.txtEmriF.Size = new System.Drawing.Size(168, 20);
            this.txtEmriF.TabIndex = 54;
            //this.txtEmriF.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmriF_Validating);
            // 
            // lblNameF
            // 
            this.lblNameF.AutoSize = true;
            this.lblNameF.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameF.Location = new System.Drawing.Point(176, 66);
            this.lblNameF.Name = "lblNameF";
            this.lblNameF.Size = new System.Drawing.Size(43, 20);
            this.lblNameF.TabIndex = 53;
            this.lblNameF.Text = "Name";
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
            // UCFacultiesR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRegisterR);
            this.Controls.Add(this.txtEmriF);
            this.Controls.Add(this.lblNameF);
            this.Controls.Add(this.lblRegister);
            this.Name = "UCFacultiesR";
            this.Size = new System.Drawing.Size(499, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterR;
        private System.Windows.Forms.TextBox txtEmriF;
        private System.Windows.Forms.Label lblNameF;
        private System.Windows.Forms.Label lblRegister;
    }
}
