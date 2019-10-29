namespace ScheduleManagementSystem
{
    partial class UCTipiEdit
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
            this.txtSalla = new System.Windows.Forms.TextBox();
            this.cmbLlojiSalles = new System.Windows.Forms.ComboBox();
            this.lblSalla = new System.Windows.Forms.Label();
            this.LblSallaNew = new System.Windows.Forms.Label();
            this.ModifyS = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEdit.ForeColor = System.Drawing.Color.Transparent;
            this.btnEdit.Location = new System.Drawing.Point(291, 162);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 32);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtSalla
            // 
            this.txtSalla.Location = new System.Drawing.Point(225, 117);
            this.txtSalla.Name = "txtSalla";
            this.txtSalla.Size = new System.Drawing.Size(168, 20);
            this.txtSalla.TabIndex = 7;
            // 
            // cmbLlojiSalles
            // 
            this.cmbLlojiSalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLlojiSalles.FormattingEnabled = true;
            this.cmbLlojiSalles.Location = new System.Drawing.Point(225, 75);
            this.cmbLlojiSalles.Name = "cmbLlojiSalles";
            this.cmbLlojiSalles.Size = new System.Drawing.Size(168, 21);
            this.cmbLlojiSalles.TabIndex = 6;
            this.cmbLlojiSalles.SelectedIndexChanged += new System.EventHandler(this.cmbLlojiSalles_SelectedIndexChanged);
            // 
            // lblSalla
            // 
            this.lblSalla.AutoSize = true;
            this.lblSalla.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.lblSalla.Location = new System.Drawing.Point(147, 73);
            this.lblSalla.Name = "lblSalla";
            this.lblSalla.Size = new System.Drawing.Size(73, 20);
            this.lblSalla.TabIndex = 4;
            this.lblSalla.Text = "Type of hall";
            // 
            // LblSallaNew
            // 
            this.LblSallaNew.AutoSize = true;
            this.LblSallaNew.Font = new System.Drawing.Font("Arial Narrow", 11.25F);
            this.LblSallaNew.Location = new System.Drawing.Point(188, 115);
            this.LblSallaNew.Name = "LblSallaNew";
            this.LblSallaNew.Size = new System.Drawing.Size(31, 20);
            this.LblSallaNew.TabIndex = 5;
            this.LblSallaNew.Text = "Hall";
            // 
            // ModifyS
            // 
            this.ModifyS.AutoSize = true;
            this.ModifyS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyS.Location = new System.Drawing.Point(210, 36);
            this.ModifyS.Name = "ModifyS";
            this.ModifyS.Size = new System.Drawing.Size(55, 20);
            this.ModifyS.TabIndex = 63;
            this.ModifyS.Text = "Modify";
            // 
            // UCTipiEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ModifyS);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtSalla);
            this.Controls.Add(this.cmbLlojiSalles);
            this.Controls.Add(this.lblSalla);
            this.Controls.Add(this.LblSallaNew);
            this.Name = "UCTipiEdit";
            this.Size = new System.Drawing.Size(499, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtSalla;
        private System.Windows.Forms.ComboBox cmbLlojiSalles;
        private System.Windows.Forms.Label lblSalla;
        private System.Windows.Forms.Label LblSallaNew;
        private System.Windows.Forms.Label ModifyS;
    }
}
