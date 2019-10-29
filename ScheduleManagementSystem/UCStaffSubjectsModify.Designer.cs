namespace ScheduleManagementSystem
{
    partial class UCStaffSubjectsModify
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
            this.lblSuject = new System.Windows.Forms.Label();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.lblAssistent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.cmbProf = new System.Windows.Forms.ComboBox();
            this.cmbAss = new System.Windows.Forms.ComboBox();
            this.btnModifySS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSuject
            // 
            this.lblSuject.AutoSize = true;
            this.lblSuject.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblSuject.Location = new System.Drawing.Point(122, 83);
            this.lblSuject.Name = "lblSuject";
            this.lblSuject.Size = new System.Drawing.Size(51, 20);
            this.lblSuject.TabIndex = 0;
            this.lblSuject.Text = "Subject";
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblProfessor.Location = new System.Drawing.Point(112, 136);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(61, 20);
            this.lblProfessor.TabIndex = 1;
            this.lblProfessor.Text = "Professor";
            // 
            // lblAssistent
            // 
            this.lblAssistent.AutoSize = true;
            this.lblAssistent.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblAssistent.Location = new System.Drawing.Point(116, 187);
            this.lblAssistent.Name = "lblAssistent";
            this.lblAssistent.Size = new System.Drawing.Size(57, 20);
            this.lblAssistent.TabIndex = 2;
            this.lblAssistent.Text = "Assistent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(154, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Modify subject per professor";
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(179, 83);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(199, 21);
            this.cmbSubject.TabIndex = 4;
            this.cmbSubject.SelectionChangeCommitted += new System.EventHandler(this.cmbSubject_SelectionChangeCommitted);
            // 
            // cmbProf
            // 
            this.cmbProf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProf.FormattingEnabled = true;
            this.cmbProf.Location = new System.Drawing.Point(179, 135);
            this.cmbProf.Name = "cmbProf";
            this.cmbProf.Size = new System.Drawing.Size(199, 21);
            this.cmbProf.TabIndex = 4;
            // 
            // cmbAss
            // 
            this.cmbAss.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAss.FormattingEnabled = true;
            this.cmbAss.Location = new System.Drawing.Point(179, 186);
            this.cmbAss.Name = "cmbAss";
            this.cmbAss.Size = new System.Drawing.Size(199, 21);
            this.cmbAss.TabIndex = 4;
            // 
            // btnModifySS
            // 
            this.btnModifySS.BackColor = System.Drawing.Color.ForestGreen;
            this.btnModifySS.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModifySS.Location = new System.Drawing.Point(276, 235);
            this.btnModifySS.Name = "btnModifySS";
            this.btnModifySS.Size = new System.Drawing.Size(102, 32);
            this.btnModifySS.TabIndex = 56;
            this.btnModifySS.Text = "Modify";
            this.btnModifySS.UseVisualStyleBackColor = false;
            this.btnModifySS.Click += new System.EventHandler(this.btnModifySS_Click);
            // 
            // UCStaffSubjectsModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModifySS);
            this.Controls.Add(this.cmbAss);
            this.Controls.Add(this.cmbProf);
            this.Controls.Add(this.cmbSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAssistent);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.lblSuject);
            this.Name = "UCStaffSubjectsModify";
            this.Size = new System.Drawing.Size(499, 309);
            this.Load += new System.EventHandler(this.UCStaffSubjectsModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuject;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.Label lblAssistent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbProf;
        private System.Windows.Forms.ComboBox cmbAss;
        private System.Windows.Forms.Button btnModifySS;
    }
}
