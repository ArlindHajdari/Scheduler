namespace ScheduleManagementSystem
{
    partial class UCSallaEditimi
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
            this.cmbSalla = new System.Windows.Forms.ComboBox();
            this.lblHall = new System.Windows.Forms.Label();
            this.cmbLlojiSalles = new System.Windows.Forms.ComboBox();
            this.lblTypeofHall = new System.Windows.Forms.Label();
            this.txtKapaciteti = new System.Windows.Forms.TextBox();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.Location = new System.Drawing.Point(261, 209);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(102, 32);
            this.btnEdit.TabIndex = 81;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cmbSalla
            // 
            this.cmbSalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalla.FormattingEnabled = true;
            this.cmbSalla.Location = new System.Drawing.Point(195, 90);
            this.cmbSalla.Name = "cmbSalla";
            this.cmbSalla.Size = new System.Drawing.Size(168, 21);
            this.cmbSalla.TabIndex = 80;
            this.cmbSalla.SelectedIndexChanged += new System.EventHandler(this.cmbSalla_SelectedIndexChanged);
            // 
            // lblHall
            // 
            this.lblHall.AutoSize = true;
            this.lblHall.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHall.Location = new System.Drawing.Point(158, 88);
            this.lblHall.Name = "lblHall";
            this.lblHall.Size = new System.Drawing.Size(31, 20);
            this.lblHall.TabIndex = 79;
            this.lblHall.Text = "Hall";
            // 
            // cmbLlojiSalles
            // 
            this.cmbLlojiSalles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLlojiSalles.Enabled = false;
            this.cmbLlojiSalles.FormattingEnabled = true;
            this.cmbLlojiSalles.Location = new System.Drawing.Point(195, 166);
            this.cmbLlojiSalles.Name = "cmbLlojiSalles";
            this.cmbLlojiSalles.Size = new System.Drawing.Size(168, 21);
            this.cmbLlojiSalles.TabIndex = 78;
            // 
            // lblTypeofHall
            // 
            this.lblTypeofHall.AutoSize = true;
            this.lblTypeofHall.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeofHall.Location = new System.Drawing.Point(120, 164);
            this.lblTypeofHall.Name = "lblTypeofHall";
            this.lblTypeofHall.Size = new System.Drawing.Size(69, 20);
            this.lblTypeofHall.TabIndex = 77;
            this.lblTypeofHall.Text = "TypeofHall";
            // 
            // txtKapaciteti
            // 
            this.txtKapaciteti.Enabled = false;
            this.txtKapaciteti.Location = new System.Drawing.Point(195, 127);
            this.txtKapaciteti.Name = "txtKapaciteti";
            this.txtKapaciteti.Size = new System.Drawing.Size(168, 20);
            this.txtKapaciteti.TabIndex = 76;
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCapacity.Location = new System.Drawing.Point(132, 125);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(57, 20);
            this.lblCapacity.TabIndex = 75;
            this.lblCapacity.Text = "Capacity";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEdit.Location = new System.Drawing.Point(180, 51);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(55, 20);
            this.lblEdit.TabIndex = 74;
            this.lblEdit.Text = "Modify";
            // 
            // UCSallaEditimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cmbSalla);
            this.Controls.Add(this.lblHall);
            this.Controls.Add(this.cmbLlojiSalles);
            this.Controls.Add(this.lblTypeofHall);
            this.Controls.Add(this.txtKapaciteti);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblEdit);
            this.Name = "UCSallaEditimi";
            this.Size = new System.Drawing.Size(499, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ComboBox cmbSalla;
        private System.Windows.Forms.Label lblHall;
        private System.Windows.Forms.ComboBox cmbLlojiSalles;
        private System.Windows.Forms.Label lblTypeofHall;
        private System.Windows.Forms.TextBox txtKapaciteti;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblEdit;
    }
}
