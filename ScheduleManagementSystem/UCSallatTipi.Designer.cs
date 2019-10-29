namespace ScheduleManagementSystem
{
    partial class UCSallatTipi
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
            this.btnShto = new System.Windows.Forms.Button();
            this.txtLlojiSalles = new System.Windows.Forms.TextBox();
            this.lblLlojiSalles = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShto
            // 
            this.btnShto.BackColor = System.Drawing.Color.DarkGreen;
            this.btnShto.ForeColor = System.Drawing.Color.Transparent;
            this.btnShto.Location = new System.Drawing.Point(287, 119);
            this.btnShto.Name = "btnShto";
            this.btnShto.Size = new System.Drawing.Size(102, 32);
            this.btnShto.TabIndex = 5;
            this.btnShto.Text = "Add";
            this.btnShto.UseVisualStyleBackColor = false;
            this.btnShto.Click += new System.EventHandler(this.btnShto_Click);
            // 
            // txtLlojiSalles
            // 
            this.txtLlojiSalles.Location = new System.Drawing.Point(230, 75);
            this.txtLlojiSalles.Name = "txtLlojiSalles";
            this.txtLlojiSalles.Size = new System.Drawing.Size(159, 20);
            this.txtLlojiSalles.TabIndex = 4;
            // 
            // lblLlojiSalles
            // 
            this.lblLlojiSalles.AutoSize = true;
            this.lblLlojiSalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLlojiSalles.Location = new System.Drawing.Point(143, 75);
            this.lblLlojiSalles.Name = "lblLlojiSalles";
            this.lblLlojiSalles.Size = new System.Drawing.Size(81, 18);
            this.lblLlojiSalles.TabIndex = 3;
            this.lblLlojiSalles.Text = "TypeOfHall";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(211, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Register";
            // 
            // UCSallatTipi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShto);
            this.Controls.Add(this.txtLlojiSalles);
            this.Controls.Add(this.lblLlojiSalles);
            this.Name = "UCSallatTipi";
            this.Size = new System.Drawing.Size(499, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShto;
        private System.Windows.Forms.TextBox txtLlojiSalles;
        private System.Windows.Forms.Label lblLlojiSalles;
        private System.Windows.Forms.Label label1;
    }
}
