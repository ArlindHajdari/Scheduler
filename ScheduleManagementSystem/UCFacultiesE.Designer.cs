namespace ScheduleManagementSystem
{
    partial class UCFacultiesE
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
            this.cmbFakultetiE = new System.Windows.Forms.ComboBox();
            this.lblProfessor = new System.Windows.Forms.Label();
            this.txtEmriE = new System.Windows.Forms.TextBox();
            this.lblNameF = new System.Windows.Forms.Label();
            this.ModifyS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(290, 177);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 32);
            this.btnEdit.TabIndex = 81;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbFakultetiE
            // 
            this.cmbFakultetiE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFakultetiE.FormattingEnabled = true;
            this.cmbFakultetiE.Location = new System.Drawing.Point(222, 71);
            this.cmbFakultetiE.Name = "cmbFakultetiE";
            this.cmbFakultetiE.Size = new System.Drawing.Size(168, 21);
            this.cmbFakultetiE.TabIndex = 80;
            this.cmbFakultetiE.SelectedIndexChanged += new System.EventHandler(this.cmbFakultetiE_SelectedIndexChanged);
            // 
            // lblProfessor
            // 
            this.lblProfessor.AutoSize = true;
            this.lblProfessor.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessor.Location = new System.Drawing.Point(121, 69);
            this.lblProfessor.Name = "lblProfessor";
            this.lblProfessor.Size = new System.Drawing.Size(95, 20);
            this.lblProfessor.TabIndex = 79;
            this.lblProfessor.Text = "Choose Faculty";
            // 
            // txtEmriE
            // 
            this.txtEmriE.Location = new System.Drawing.Point(222, 108);
            this.txtEmriE.Name = "txtEmriE";
            this.txtEmriE.Size = new System.Drawing.Size(168, 20);
            this.txtEmriE.TabIndex = 76;
            // 
            // lblNameF
            // 
            this.lblNameF.AutoSize = true;
            this.lblNameF.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameF.Location = new System.Drawing.Point(167, 106);
            this.lblNameF.Name = "lblNameF";
            this.lblNameF.Size = new System.Drawing.Size(49, 20);
            this.lblNameF.TabIndex = 75;
            this.lblNameF.Text = "Faculty";
            // 
            // ModifyS
            // 
            this.ModifyS.AutoSize = true;
            this.ModifyS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyS.Location = new System.Drawing.Point(207, 32);
            this.ModifyS.Name = "ModifyS";
            this.ModifyS.Size = new System.Drawing.Size(55, 20);
            this.ModifyS.TabIndex = 74;
            this.ModifyS.Text = "Modify";
            // 
            // UCFacultiesE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cmbFakultetiE);
            this.Controls.Add(this.lblProfessor);
            this.Controls.Add(this.txtEmriE);
            this.Controls.Add(this.lblNameF);
            this.Controls.Add(this.ModifyS);
            this.Name = "UCFacultiesE";
            this.Size = new System.Drawing.Size(499, 309);
            this.Load += new System.EventHandler(this.UCFacultiesE_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cmbFakultetiE;
        private System.Windows.Forms.Label lblProfessor;
        private System.Windows.Forms.TextBox txtEmriE;
        private System.Windows.Forms.Label lblNameF;
        private System.Windows.Forms.Label ModifyS;
    }
}
