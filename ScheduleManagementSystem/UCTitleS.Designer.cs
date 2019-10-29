namespace ScheduleManagementSystem
{
    partial class UCTitleS
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtTitleR = new System.Windows.Forms.TextBox();
            this.lblNameR = new System.Windows.Forms.Label();
            this.lblRegisterT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(287, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 51;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTitleR
            // 
            this.txtTitleR.Location = new System.Drawing.Point(221, 69);
            this.txtTitleR.Name = "txtTitleR";
            this.txtTitleR.Size = new System.Drawing.Size(168, 20);
            this.txtTitleR.TabIndex = 44;
            // 
            // lblNameR
            // 
            this.lblNameR.AutoSize = true;
            this.lblNameR.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lblNameR.Location = new System.Drawing.Point(180, 68);
            this.lblNameR.Name = "lblNameR";
            this.lblNameR.Size = new System.Drawing.Size(35, 18);
            this.lblNameR.TabIndex = 43;
            this.lblNameR.Text = "Title";
            // 
            // lblRegisterT
            // 
            this.lblRegisterT.AutoSize = true;
            this.lblRegisterT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterT.Location = new System.Drawing.Point(206, 30);
            this.lblRegisterT.Name = "lblRegisterT";
            this.lblRegisterT.Size = new System.Drawing.Size(69, 20);
            this.lblRegisterT.TabIndex = 42;
            this.lblRegisterT.Text = "Register";
            // 
            // UCTitleS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTitleR);
            this.Controls.Add(this.lblNameR);
            this.Controls.Add(this.lblRegisterT);
            this.Name = "UCTitleS";
            this.Size = new System.Drawing.Size(499, 309);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtTitleR;
        private System.Windows.Forms.Label lblNameR;
        private System.Windows.Forms.Label lblRegisterT;
    }
}
