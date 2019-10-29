namespace ScheduleManagementSystem
{
    partial class UCSallaDete
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
            this.btnFshirja = new System.Windows.Forms.Button();
            this.lblFshirja = new System.Windows.Forms.Label();
            this.cmbSalla = new System.Windows.Forms.ComboBox();
            this.lblSalla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFshirja
            // 
            this.btnFshirja.BackColor = System.Drawing.Color.DarkRed;
            this.btnFshirja.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFshirja.Location = new System.Drawing.Point(289, 119);
            this.btnFshirja.Name = "btnFshirja";
            this.btnFshirja.Size = new System.Drawing.Size(102, 32);
            this.btnFshirja.TabIndex = 80;
            this.btnFshirja.Text = "Delete";
            this.btnFshirja.UseVisualStyleBackColor = false;
            this.btnFshirja.Click += new System.EventHandler(this.btnFshirja_Click);
            // 
            // lblFshirja
            // 
            this.lblFshirja.AutoSize = true;
            this.lblFshirja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFshirja.Location = new System.Drawing.Point(207, 32);
            this.lblFshirja.Name = "lblFshirja";
            this.lblFshirja.Size = new System.Drawing.Size(56, 20);
            this.lblFshirja.TabIndex = 79;
            this.lblFshirja.Text = "Delete";
            // 
            // cmbSalla
            // 
            this.cmbSalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalla.FormattingEnabled = true;
            this.cmbSalla.Location = new System.Drawing.Point(223, 72);
            this.cmbSalla.Name = "cmbSalla";
            this.cmbSalla.Size = new System.Drawing.Size(168, 21);
            this.cmbSalla.TabIndex = 78;
            // 
            // lblSalla
            // 
            this.lblSalla.AutoSize = true;
            this.lblSalla.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblSalla.Location = new System.Drawing.Point(186, 70);
            this.lblSalla.Name = "lblSalla";
            this.lblSalla.Size = new System.Drawing.Size(33, 18);
            this.lblSalla.TabIndex = 77;
            this.lblSalla.Text = "Hall";
            // 
            // UCSallaDete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFshirja);
            this.Controls.Add(this.lblFshirja);
            this.Controls.Add(this.cmbSalla);
            this.Controls.Add(this.lblSalla);
            this.Name = "UCSallaDete";
            this.Size = new System.Drawing.Size(499, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFshirja;
        private System.Windows.Forms.Label lblFshirja;
        private System.Windows.Forms.ComboBox cmbSalla;
        private System.Windows.Forms.Label lblSalla;
    }
}
