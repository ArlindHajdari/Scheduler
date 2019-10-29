namespace ScheduleManagementSystem
{
    partial class UCSallatRE
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
            this.cmbLlojiSalles = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblLlojiSalles = new System.Windows.Forms.Label();
            this.txtKapaciteti = new System.Windows.Forms.TextBox();
            this.lblKapaciteti = new System.Windows.Forms.Label();
            this.txtSalla = new System.Windows.Forms.TextBox();
            this.lblSalla = new System.Windows.Forms.Label();
            this.Regjistrohu = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbLlojiSalles
            // 
            this.cmbLlojiSalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLlojiSalles.FormattingEnabled = true;
            this.cmbLlojiSalles.Location = new System.Drawing.Point(226, 143);
            this.cmbLlojiSalles.Name = "cmbLlojiSalles";
            this.cmbLlojiSalles.Size = new System.Drawing.Size(168, 21);
            this.cmbLlojiSalles.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(288, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 32);
            this.button1.TabIndex = 59;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblLlojiSalles
            // 
            this.lblLlojiSalles.AutoSize = true;
            this.lblLlojiSalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblLlojiSalles.Location = new System.Drawing.Point(139, 144);
            this.lblLlojiSalles.Name = "lblLlojiSalles";
            this.lblLlojiSalles.Size = new System.Drawing.Size(81, 18);
            this.lblLlojiSalles.TabIndex = 58;
            this.lblLlojiSalles.Text = "TypeOfHall";
            // 
            // txtKapaciteti
            // 
            this.txtKapaciteti.Location = new System.Drawing.Point(226, 108);
            this.txtKapaciteti.Name = "txtKapaciteti";
            this.txtKapaciteti.Size = new System.Drawing.Size(168, 20);
            this.txtKapaciteti.TabIndex = 57;
            // 
            // lblKapaciteti
            // 
            this.lblKapaciteti.AutoSize = true;
            this.lblKapaciteti.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblKapaciteti.Location = new System.Drawing.Point(155, 107);
            this.lblKapaciteti.Name = "lblKapaciteti";
            this.lblKapaciteti.Size = new System.Drawing.Size(65, 18);
            this.lblKapaciteti.TabIndex = 56;
            this.lblKapaciteti.Text = "Capacity";
            // 
            // txtSalla
            // 
            this.txtSalla.Location = new System.Drawing.Point(226, 71);
            this.txtSalla.Name = "txtSalla";
            this.txtSalla.Size = new System.Drawing.Size(168, 20);
            this.txtSalla.TabIndex = 55;
            // 
            // lblSalla
            // 
            this.lblSalla.AutoSize = true;
            this.lblSalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSalla.Location = new System.Drawing.Point(187, 70);
            this.lblSalla.Name = "lblSalla";
            this.lblSalla.Size = new System.Drawing.Size(33, 18);
            this.lblSalla.TabIndex = 54;
            this.lblSalla.Text = "Hall";
            // 
            // Regjistrohu
            // 
            this.Regjistrohu.AutoSize = true;
            this.Regjistrohu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regjistrohu.Location = new System.Drawing.Point(211, 32);
            this.Regjistrohu.Name = "Regjistrohu";
            this.Regjistrohu.Size = new System.Drawing.Size(69, 20);
            this.Regjistrohu.TabIndex = 53;
            this.Regjistrohu.Text = "Register";
            // 
            // UCSallatRE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbLlojiSalles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblLlojiSalles);
            this.Controls.Add(this.txtKapaciteti);
            this.Controls.Add(this.lblKapaciteti);
            this.Controls.Add(this.txtSalla);
            this.Controls.Add(this.lblSalla);
            this.Controls.Add(this.Regjistrohu);
            this.Name = "UCSallatRE";
            this.Size = new System.Drawing.Size(499, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbLlojiSalles;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblLlojiSalles;
        private System.Windows.Forms.TextBox txtKapaciteti;
        private System.Windows.Forms.Label lblKapaciteti;
        private System.Windows.Forms.TextBox txtSalla;
        private System.Windows.Forms.Label lblSalla;
        private System.Windows.Forms.Label Regjistrohu;
    }
}
