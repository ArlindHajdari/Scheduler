namespace ScheduleManagementSystem
{
    partial class UCTipiDelete
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
            this.cmbSalla = new System.Windows.Forms.ComboBox();
            this.lblTypeOfHall = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDeleteT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbSalla
            // 
            this.cmbSalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalla.FormattingEnabled = true;
            this.cmbSalla.Location = new System.Drawing.Point(232, 71);
            this.cmbSalla.Name = "cmbSalla";
            this.cmbSalla.Size = new System.Drawing.Size(156, 21);
            this.cmbSalla.TabIndex = 0;
            // 
            // lblTypeOfHall
            // 
            this.lblTypeOfHall.AutoSize = true;
            this.lblTypeOfHall.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeOfHall.Location = new System.Drawing.Point(143, 71);
            this.lblTypeOfHall.Name = "lblTypeOfHall";
            this.lblTypeOfHall.Size = new System.Drawing.Size(83, 18);
            this.lblTypeOfHall.TabIndex = 1;
            this.lblTypeOfHall.Text = "Type of hall";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DarkRed;
            this.btnDelete.ForeColor = System.Drawing.Color.Transparent;
            this.btnDelete.Location = new System.Drawing.Point(286, 120);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(102, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDeleteT
            // 
            this.lblDeleteT.AutoSize = true;
            this.lblDeleteT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteT.Location = new System.Drawing.Point(205, 33);
            this.lblDeleteT.Name = "lblDeleteT";
            this.lblDeleteT.Size = new System.Drawing.Size(56, 20);
            this.lblDeleteT.TabIndex = 66;
            this.lblDeleteT.Text = "Delete";
            // 
            // UCTipiDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDeleteT);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblTypeOfHall);
            this.Controls.Add(this.cmbSalla);
            this.Name = "UCTipiDelete";
            this.Size = new System.Drawing.Size(499, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSalla;
        private System.Windows.Forms.Label lblTypeOfHall;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblDeleteT;
    }
}
