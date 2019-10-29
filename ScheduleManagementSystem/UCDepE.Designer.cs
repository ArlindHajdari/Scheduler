namespace ScheduleManagementSystem
{
    partial class UCDepE
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
            this.cmbDepE = new System.Windows.Forms.ComboBox();
            this.lblDep = new System.Windows.Forms.Label();
            this.txtEmriD = new System.Windows.Forms.TextBox();
            this.lblNameD = new System.Windows.Forms.Label();
            this.ModifyS = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.chFaculty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(288, 178);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 32);
            this.btnEdit.TabIndex = 79;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbDepE
            // 
            this.cmbDepE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepE.FormattingEnabled = true;
            this.cmbDepE.Location = new System.Drawing.Point(222, 71);
            this.cmbDepE.Name = "cmbDepE";
            this.cmbDepE.Size = new System.Drawing.Size(168, 21);
            this.cmbDepE.TabIndex = 78;
            this.cmbDepE.SelectedIndexChanged += new System.EventHandler(this.cmbDepE_SelectedIndexChanged);
            // 
            // lblDep
            // 
            this.lblDep.AutoSize = true;
            this.lblDep.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDep.Location = new System.Drawing.Point(96, 69);
            this.lblDep.Name = "lblDep";
            this.lblDep.Size = new System.Drawing.Size(120, 20);
            this.lblDep.TabIndex = 77;
            this.lblDep.Text = "Choose Department";
            // 
            // txtEmriD
            // 
            this.txtEmriD.Location = new System.Drawing.Point(222, 108);
            this.txtEmriD.Name = "txtEmriD";
            this.txtEmriD.Size = new System.Drawing.Size(168, 20);
            this.txtEmriD.TabIndex = 76;
            // 
            // lblNameD
            // 
            this.lblNameD.AutoSize = true;
            this.lblNameD.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameD.Location = new System.Drawing.Point(142, 106);
            this.lblNameD.Name = "lblNameD";
            this.lblNameD.Size = new System.Drawing.Size(74, 20);
            this.lblNameD.TabIndex = 75;
            this.lblNameD.Text = "Department";
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
            // cmbFaculty
            // 
            this.cmbFaculty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(222, 143);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(168, 21);
            this.cmbFaculty.TabIndex = 81;
            // 
            // chFaculty
            // 
            this.chFaculty.AutoSize = true;
            this.chFaculty.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chFaculty.Location = new System.Drawing.Point(121, 141);
            this.chFaculty.Name = "chFaculty";
            this.chFaculty.Size = new System.Drawing.Size(95, 20);
            this.chFaculty.TabIndex = 80;
            this.chFaculty.Text = "Choose Faculty";
            // 
            // UCDepE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.chFaculty);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cmbDepE);
            this.Controls.Add(this.lblDep);
            this.Controls.Add(this.txtEmriD);
            this.Controls.Add(this.lblNameD);
            this.Controls.Add(this.ModifyS);
            this.Name = "UCDepE";
            this.Size = new System.Drawing.Size(499, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cmbDepE;
        private System.Windows.Forms.Label lblDep;
        private System.Windows.Forms.TextBox txtEmriD;
        private System.Windows.Forms.Label lblNameD;
        private System.Windows.Forms.Label ModifyS;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Label chFaculty;
    }
}
