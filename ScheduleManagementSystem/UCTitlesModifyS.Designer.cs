namespace ScheduleManagementSystem
{
    partial class UCTitlesModifyS
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
            this.btnModifyT = new System.Windows.Forms.Button();
            this.txtTitleM = new System.Windows.Forms.TextBox();
            this.lblTitleAM = new System.Windows.Forms.Label();
            this.lblModify = new System.Windows.Forms.Label();
            this.lblTitleBM = new System.Windows.Forms.Label();
            this.cmbTitleS = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnModifyT
            // 
            this.btnModifyT.BackColor = System.Drawing.Color.ForestGreen;
            this.btnModifyT.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnModifyT.Location = new System.Drawing.Point(286, 160);
            this.btnModifyT.Name = "btnModifyT";
            this.btnModifyT.Size = new System.Drawing.Size(102, 32);
            this.btnModifyT.TabIndex = 55;
            this.btnModifyT.Text = "Modify";
            this.btnModifyT.UseVisualStyleBackColor = false;
            this.btnModifyT.Click += new System.EventHandler(this.btnModifyT_Click);
            // 
            // txtTitleM
            // 
            this.txtTitleM.Location = new System.Drawing.Point(220, 114);
            this.txtTitleM.Name = "txtTitleM";
            this.txtTitleM.Size = new System.Drawing.Size(168, 20);
            this.txtTitleM.TabIndex = 54;
            // 
            // lblTitleAM
            // 
            this.lblTitleAM.AutoSize = true;
            this.lblTitleAM.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAM.Location = new System.Drawing.Point(186, 112);
            this.lblTitleAM.Name = "lblTitleAM";
            this.lblTitleAM.Size = new System.Drawing.Size(28, 20);
            this.lblTitleAM.TabIndex = 53;
            this.lblTitleAM.Text = "To:";
            // 
            // lblModify
            // 
            this.lblModify.AutoSize = true;
            this.lblModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModify.Location = new System.Drawing.Point(207, 32);
            this.lblModify.Name = "lblModify";
            this.lblModify.Size = new System.Drawing.Size(55, 20);
            this.lblModify.TabIndex = 52;
            this.lblModify.Text = "Modify";
            // 
            // lblTitleBM
            // 
            this.lblTitleBM.AutoSize = true;
            this.lblTitleBM.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleBM.Location = new System.Drawing.Point(149, 69);
            this.lblTitleBM.Name = "lblTitleBM";
            this.lblTitleBM.Size = new System.Drawing.Size(65, 20);
            this.lblTitleBM.TabIndex = 56;
            this.lblTitleBM.Text = "Title from:";
            // 
            // cmbTitleS
            // 
            this.cmbTitleS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTitleS.FormattingEnabled = true;
            this.cmbTitleS.Location = new System.Drawing.Point(220, 71);
            this.cmbTitleS.Name = "cmbTitleS";
            this.cmbTitleS.Size = new System.Drawing.Size(168, 21);
            this.cmbTitleS.TabIndex = 57;
            this.cmbTitleS.SelectedIndexChanged += new System.EventHandler(this.cmbTitleS_SelectedIndexChanged);
            // 
            // UCTitlesModifyS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbTitleS);
            this.Controls.Add(this.lblTitleBM);
            this.Controls.Add(this.btnModifyT);
            this.Controls.Add(this.txtTitleM);
            this.Controls.Add(this.lblTitleAM);
            this.Controls.Add(this.lblModify);
            this.Name = "UCTitlesModifyS";
            this.Size = new System.Drawing.Size(499, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnModifyT;
        private System.Windows.Forms.TextBox txtTitleM;
        private System.Windows.Forms.Label lblTitleAM;
        private System.Windows.Forms.Label lblModify;
        private System.Windows.Forms.Label lblTitleBM;
        private System.Windows.Forms.ComboBox cmbTitleS;
    }
}
