namespace ScheduleManagementSystem
{
    partial class UCProfSubject
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
            this.lblStafi = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.cmbProf = new System.Windows.Forms.ComboBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.btnAddTS = new System.Windows.Forms.Button();
            this.cmbAssistent = new System.Windows.Forms.ComboBox();
            this.lblAssistent = new System.Windows.Forms.Label();
            this.lblEmri = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblStafi
            // 
            this.lblStafi.AutoSize = true;
            this.lblStafi.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStafi.Location = new System.Drawing.Point(92, 61);
            this.lblStafi.Name = "lblStafi";
            this.lblStafi.Size = new System.Drawing.Size(61, 20);
            this.lblStafi.TabIndex = 0;
            this.lblStafi.Text = "Professor";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(102, 148);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(51, 20);
            this.lblSubject.TabIndex = 1;
            this.lblSubject.Text = "Subject";
            // 
            // cmbProf
            // 
            this.cmbProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProf.FormattingEnabled = true;
            this.cmbProf.Location = new System.Drawing.Point(159, 63);
            this.cmbProf.Name = "cmbProf";
            this.cmbProf.Size = new System.Drawing.Size(231, 21);
            this.cmbProf.TabIndex = 2;
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(159, 150);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(231, 21);
            this.cmbSubject.TabIndex = 3;
            // 
            // btnAddTS
            // 
            this.btnAddTS.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAddTS.ForeColor = System.Drawing.Color.White;
            this.btnAddTS.Location = new System.Drawing.Point(288, 199);
            this.btnAddTS.Name = "btnAddTS";
            this.btnAddTS.Size = new System.Drawing.Size(102, 32);
            this.btnAddTS.TabIndex = 4;
            this.btnAddTS.Text = "Add";
            this.btnAddTS.UseVisualStyleBackColor = false;
            this.btnAddTS.Click += new System.EventHandler(this.btnAddTS_Click);
            // 
            // cmbAssistent
            // 
            this.cmbAssistent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAssistent.FormattingEnabled = true;
            this.cmbAssistent.Location = new System.Drawing.Point(159, 105);
            this.cmbAssistent.Name = "cmbAssistent";
            this.cmbAssistent.Size = new System.Drawing.Size(231, 21);
            this.cmbAssistent.TabIndex = 6;
            // 
            // lblAssistent
            // 
            this.lblAssistent.AutoSize = true;
            this.lblAssistent.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssistent.Location = new System.Drawing.Point(96, 103);
            this.lblAssistent.Name = "lblAssistent";
            this.lblAssistent.Size = new System.Drawing.Size(57, 20);
            this.lblAssistent.TabIndex = 5;
            this.lblAssistent.Text = "Assistent";
            // 
            // lblEmri
            // 
            this.lblEmri.AutoSize = true;
            this.lblEmri.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmri.Location = new System.Drawing.Point(218, 20);
            this.lblEmri.Name = "lblEmri";
            this.lblEmri.Size = new System.Drawing.Size(69, 20);
            this.lblEmri.TabIndex = 7;
            this.lblEmri.Text = "Register";
            // 
            // UCProfSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEmri);
            this.Controls.Add(this.cmbAssistent);
            this.Controls.Add(this.lblAssistent);
            this.Controls.Add(this.btnAddTS);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.cmbProf);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.lblStafi);
            this.Name = "UCProfSubject";
            this.Size = new System.Drawing.Size(499, 309);
            this.Load += new System.EventHandler(this.UCProfSubject_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStafi;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.ComboBox cmbProf;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Button btnAddTS;
        private System.Windows.Forms.ComboBox cmbAssistent;
        private System.Windows.Forms.Label lblAssistent;
        private System.Windows.Forms.Label lblEmri;
    }
}
