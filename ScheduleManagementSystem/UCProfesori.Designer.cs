namespace ScheduleManagementSystem
{
    partial class UCProfesori
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
            this.lblProf = new System.Windows.Forms.Label();
            this.cmbWednesdayFrom = new System.Windows.Forms.ComboBox();
            this.cmbWednesdayTo = new System.Windows.Forms.ComboBox();
            this.Monday = new System.Windows.Forms.Label();
            this.Tuesday = new System.Windows.Forms.Label();
            this.Wednesday = new System.Windows.Forms.Label();
            this.Thursday = new System.Windows.Forms.Label();
            this.Friday = new System.Windows.Forms.Label();
            this.Saturday = new System.Windows.Forms.Label();
            this.cmbThursdayTo = new System.Windows.Forms.ComboBox();
            this.cmbThursdayFrom = new System.Windows.Forms.ComboBox();
            this.cmbFridayTo = new System.Windows.Forms.ComboBox();
            this.cmbFridayFrom = new System.Windows.Forms.ComboBox();
            this.cmbTuesdayTo = new System.Windows.Forms.ComboBox();
            this.cmbTuesdayFrom = new System.Windows.Forms.ComboBox();
            this.cmbMondayTo = new System.Windows.Forms.ComboBox();
            this.cmbMondayFrom = new System.Windows.Forms.ComboBox();
            this.cmbSaturdayFrom = new System.Windows.Forms.ComboBox();
            this.cmbSaturdayTo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listRezultati = new System.Windows.Forms.ListBox();
            this.btnMonday = new System.Windows.Forms.Button();
            this.btnTuesday = new System.Windows.Forms.Button();
            this.btnWednesday = new System.Windows.Forms.Button();
            this.btnThursday = new System.Windows.Forms.Button();
            this.btnFriday = new System.Windows.Forms.Button();
            this.btnSaturday = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProf
            // 
            this.lblProf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProf.AutoEllipsis = true;
            this.lblProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProf.Location = new System.Drawing.Point(3, 0);
            this.lblProf.Name = "lblProf";
            this.lblProf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProf.Size = new System.Drawing.Size(496, 17);
            this.lblProf.TabIndex = 0;
            // 
            // cmbWednesdayFrom
            // 
            this.cmbWednesdayFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWednesdayFrom.FormattingEnabled = true;
            this.cmbWednesdayFrom.Location = new System.Drawing.Point(75, 119);
            this.cmbWednesdayFrom.Name = "cmbWednesdayFrom";
            this.cmbWednesdayFrom.Size = new System.Drawing.Size(62, 21);
            this.cmbWednesdayFrom.TabIndex = 2;
            this.cmbWednesdayFrom.SelectedIndexChanged += new System.EventHandler(this.cmbWednesdayFrom_SelectedIndexChanged);
            // 
            // cmbWednesdayTo
            // 
            this.cmbWednesdayTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWednesdayTo.FormattingEnabled = true;
            this.cmbWednesdayTo.Location = new System.Drawing.Point(143, 119);
            this.cmbWednesdayTo.Name = "cmbWednesdayTo";
            this.cmbWednesdayTo.Size = new System.Drawing.Size(62, 21);
            this.cmbWednesdayTo.TabIndex = 4;
            this.cmbWednesdayTo.SelectedIndexChanged += new System.EventHandler(this.cmbWednesdayTo_SelectedIndexChanged);
            // 
            // Monday
            // 
            this.Monday.AutoSize = true;
            this.Monday.Location = new System.Drawing.Point(22, 69);
            this.Monday.Name = "Monday";
            this.Monday.Size = new System.Drawing.Size(47, 13);
            this.Monday.TabIndex = 5;
            this.Monday.Text = "E HËNË";
            // 
            // Tuesday
            // 
            this.Tuesday.AutoSize = true;
            this.Tuesday.Location = new System.Drawing.Point(17, 95);
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.Size = new System.Drawing.Size(55, 13);
            this.Tuesday.TabIndex = 6;
            this.Tuesday.Text = "E MARTË";
            // 
            // Wednesday
            // 
            this.Wednesday.AutoSize = true;
            this.Wednesday.Location = new System.Drawing.Point(-2, 122);
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.Size = new System.Drawing.Size(71, 13);
            this.Wednesday.TabIndex = 7;
            this.Wednesday.Text = "E MËRKURË";
            // 
            // Thursday
            // 
            this.Thursday.AutoSize = true;
            this.Thursday.Location = new System.Drawing.Point(18, 153);
            this.Thursday.Name = "Thursday";
            this.Thursday.Size = new System.Drawing.Size(51, 13);
            this.Thursday.TabIndex = 8;
            this.Thursday.Text = "E ENJTE";
            // 
            // Friday
            // 
            this.Friday.AutoSize = true;
            this.Friday.Location = new System.Drawing.Point(10, 184);
            this.Friday.Name = "Friday";
            this.Friday.Size = new System.Drawing.Size(62, 13);
            this.Friday.TabIndex = 9;
            this.Friday.Text = "E PREMTE";
            // 
            // Saturday
            // 
            this.Saturday.AutoSize = true;
            this.Saturday.Location = new System.Drawing.Point(10, 217);
            this.Saturday.Name = "Saturday";
            this.Saturday.Size = new System.Drawing.Size(62, 13);
            this.Saturday.TabIndex = 10;
            this.Saturday.Text = "E SHTUNË";
            // 
            // cmbThursdayTo
            // 
            this.cmbThursdayTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThursdayTo.FormattingEnabled = true;
            this.cmbThursdayTo.Location = new System.Drawing.Point(143, 150);
            this.cmbThursdayTo.Name = "cmbThursdayTo";
            this.cmbThursdayTo.Size = new System.Drawing.Size(62, 21);
            this.cmbThursdayTo.TabIndex = 12;
            this.cmbThursdayTo.SelectedIndexChanged += new System.EventHandler(this.cmbThursdayTo_SelectedIndexChanged);
            // 
            // cmbThursdayFrom
            // 
            this.cmbThursdayFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThursdayFrom.FormattingEnabled = true;
            this.cmbThursdayFrom.Location = new System.Drawing.Point(75, 150);
            this.cmbThursdayFrom.Name = "cmbThursdayFrom";
            this.cmbThursdayFrom.Size = new System.Drawing.Size(62, 21);
            this.cmbThursdayFrom.TabIndex = 11;
            this.cmbThursdayFrom.SelectedIndexChanged += new System.EventHandler(this.cmbThursdayFrom_SelectedIndexChanged);
            // 
            // cmbFridayTo
            // 
            this.cmbFridayTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFridayTo.FormattingEnabled = true;
            this.cmbFridayTo.Location = new System.Drawing.Point(143, 181);
            this.cmbFridayTo.Name = "cmbFridayTo";
            this.cmbFridayTo.Size = new System.Drawing.Size(62, 21);
            this.cmbFridayTo.TabIndex = 14;
            this.cmbFridayTo.SelectedIndexChanged += new System.EventHandler(this.cmbFridayTo_SelectedIndexChanged);
            // 
            // cmbFridayFrom
            // 
            this.cmbFridayFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFridayFrom.FormattingEnabled = true;
            this.cmbFridayFrom.Location = new System.Drawing.Point(75, 181);
            this.cmbFridayFrom.Name = "cmbFridayFrom";
            this.cmbFridayFrom.Size = new System.Drawing.Size(62, 21);
            this.cmbFridayFrom.TabIndex = 13;
            this.cmbFridayFrom.SelectedIndexChanged += new System.EventHandler(this.cmbFridayFrom_SelectedIndexChanged);
            // 
            // cmbTuesdayTo
            // 
            this.cmbTuesdayTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTuesdayTo.FormattingEnabled = true;
            this.cmbTuesdayTo.Location = new System.Drawing.Point(143, 92);
            this.cmbTuesdayTo.Name = "cmbTuesdayTo";
            this.cmbTuesdayTo.Size = new System.Drawing.Size(62, 21);
            this.cmbTuesdayTo.TabIndex = 18;
            this.cmbTuesdayTo.SelectedIndexChanged += new System.EventHandler(this.cmbTuesdayTo_SelectedIndexChanged);
            // 
            // cmbTuesdayFrom
            // 
            this.cmbTuesdayFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTuesdayFrom.FormattingEnabled = true;
            this.cmbTuesdayFrom.Location = new System.Drawing.Point(75, 92);
            this.cmbTuesdayFrom.Name = "cmbTuesdayFrom";
            this.cmbTuesdayFrom.Size = new System.Drawing.Size(62, 21);
            this.cmbTuesdayFrom.TabIndex = 17;
            this.cmbTuesdayFrom.SelectedIndexChanged += new System.EventHandler(this.cmbTuesdayFrom_SelectedIndexChanged);
            // 
            // cmbMondayTo
            // 
            this.cmbMondayTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMondayTo.FormattingEnabled = true;
            this.cmbMondayTo.Location = new System.Drawing.Point(143, 64);
            this.cmbMondayTo.Name = "cmbMondayTo";
            this.cmbMondayTo.Size = new System.Drawing.Size(62, 21);
            this.cmbMondayTo.TabIndex = 20;
            this.cmbMondayTo.SelectedIndexChanged += new System.EventHandler(this.cmbMondayTo_SelectedIndexChanged);
            // 
            // cmbMondayFrom
            // 
            this.cmbMondayFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMondayFrom.FormattingEnabled = true;
            this.cmbMondayFrom.Location = new System.Drawing.Point(75, 64);
            this.cmbMondayFrom.Name = "cmbMondayFrom";
            this.cmbMondayFrom.Size = new System.Drawing.Size(62, 21);
            this.cmbMondayFrom.TabIndex = 19;
            this.cmbMondayFrom.SelectedIndexChanged += new System.EventHandler(this.cmbMondayFrom_SelectedIndexChanged);
            // 
            // cmbSaturdayFrom
            // 
            this.cmbSaturdayFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaturdayFrom.FormattingEnabled = true;
            this.cmbSaturdayFrom.Location = new System.Drawing.Point(75, 214);
            this.cmbSaturdayFrom.Name = "cmbSaturdayFrom";
            this.cmbSaturdayFrom.Size = new System.Drawing.Size(62, 21);
            this.cmbSaturdayFrom.TabIndex = 15;
            this.cmbSaturdayFrom.SelectedIndexChanged += new System.EventHandler(this.cmbSaturdayFrom_SelectedIndexChanged);
            // 
            // cmbSaturdayTo
            // 
            this.cmbSaturdayTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSaturdayTo.FormattingEnabled = true;
            this.cmbSaturdayTo.Location = new System.Drawing.Point(143, 214);
            this.cmbSaturdayTo.Name = "cmbSaturdayTo";
            this.cmbSaturdayTo.Size = new System.Drawing.Size(62, 21);
            this.cmbSaturdayTo.TabIndex = 16;
            this.cmbSaturdayTo.SelectedIndexChanged += new System.EventHandler(this.cmbSaturdayTo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "From";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(140, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "To";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(394, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 32);
            this.button1.TabIndex = 23;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listRezultati
            // 
            this.listRezultati.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRezultati.FormattingEnabled = true;
            this.listRezultati.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listRezultati.ItemHeight = 24;
            this.listRezultati.Location = new System.Drawing.Point(252, 62);
            this.listRezultati.Name = "listRezultati";
            this.listRezultati.Size = new System.Drawing.Size(244, 172);
            this.listRezultati.TabIndex = 24;
            // 
            // btnMonday
            // 
            this.btnMonday.Location = new System.Drawing.Point(211, 64);
            this.btnMonday.Name = "btnMonday";
            this.btnMonday.Size = new System.Drawing.Size(35, 23);
            this.btnMonday.TabIndex = 25;
            this.btnMonday.Text = "+";
            this.btnMonday.UseVisualStyleBackColor = true;
            this.btnMonday.Click += new System.EventHandler(this.btnInsertToResult);
            // 
            // btnTuesday
            // 
            this.btnTuesday.Location = new System.Drawing.Point(211, 92);
            this.btnTuesday.Name = "btnTuesday";
            this.btnTuesday.Size = new System.Drawing.Size(35, 23);
            this.btnTuesday.TabIndex = 26;
            this.btnTuesday.Text = "+";
            this.btnTuesday.UseVisualStyleBackColor = true;
            this.btnTuesday.Click += new System.EventHandler(this.btnInsertToResult);
            // 
            // btnWednesday
            // 
            this.btnWednesday.Location = new System.Drawing.Point(211, 121);
            this.btnWednesday.Name = "btnWednesday";
            this.btnWednesday.Size = new System.Drawing.Size(35, 23);
            this.btnWednesday.TabIndex = 27;
            this.btnWednesday.Text = "+";
            this.btnWednesday.UseVisualStyleBackColor = true;
            this.btnWednesday.Click += new System.EventHandler(this.btnInsertToResult);
            // 
            // btnThursday
            // 
            this.btnThursday.Location = new System.Drawing.Point(211, 148);
            this.btnThursday.Name = "btnThursday";
            this.btnThursday.Size = new System.Drawing.Size(35, 23);
            this.btnThursday.TabIndex = 28;
            this.btnThursday.Text = "+";
            this.btnThursday.UseVisualStyleBackColor = true;
            this.btnThursday.Click += new System.EventHandler(this.btnInsertToResult);
            // 
            // btnFriday
            // 
            this.btnFriday.Location = new System.Drawing.Point(211, 179);
            this.btnFriday.Name = "btnFriday";
            this.btnFriday.Size = new System.Drawing.Size(35, 23);
            this.btnFriday.TabIndex = 28;
            this.btnFriday.Text = "+";
            this.btnFriday.UseVisualStyleBackColor = true;
            this.btnFriday.Click += new System.EventHandler(this.btnInsertToResult);
            // 
            // btnSaturday
            // 
            this.btnSaturday.Location = new System.Drawing.Point(211, 212);
            this.btnSaturday.Name = "btnSaturday";
            this.btnSaturday.Size = new System.Drawing.Size(35, 23);
            this.btnSaturday.TabIndex = 28;
            this.btnSaturday.Text = "+";
            this.btnSaturday.UseVisualStyleBackColor = true;
            this.btnSaturday.Click += new System.EventHandler(this.btnInsertToResult);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(286, 263);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(102, 32);
            this.btnRemove.TabIndex = 29;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // UCProfesori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSaturday);
            this.Controls.Add(this.btnFriday);
            this.Controls.Add(this.btnThursday);
            this.Controls.Add(this.btnWednesday);
            this.Controls.Add(this.btnTuesday);
            this.Controls.Add(this.btnMonday);
            this.Controls.Add(this.listRezultati);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbMondayTo);
            this.Controls.Add(this.cmbMondayFrom);
            this.Controls.Add(this.cmbTuesdayTo);
            this.Controls.Add(this.cmbTuesdayFrom);
            this.Controls.Add(this.cmbSaturdayTo);
            this.Controls.Add(this.cmbSaturdayFrom);
            this.Controls.Add(this.cmbFridayTo);
            this.Controls.Add(this.cmbFridayFrom);
            this.Controls.Add(this.cmbThursdayTo);
            this.Controls.Add(this.cmbThursdayFrom);
            this.Controls.Add(this.Saturday);
            this.Controls.Add(this.Friday);
            this.Controls.Add(this.Thursday);
            this.Controls.Add(this.Wednesday);
            this.Controls.Add(this.Tuesday);
            this.Controls.Add(this.Monday);
            this.Controls.Add(this.cmbWednesdayTo);
            this.Controls.Add(this.cmbWednesdayFrom);
            this.Controls.Add(this.lblProf);
            this.Name = "UCProfesori";
            this.Size = new System.Drawing.Size(499, 309);
            this.Load += new System.EventHandler(this.UCProfesori_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.ComboBox cmbWednesdayFrom;
        private System.Windows.Forms.ComboBox cmbWednesdayTo;
        private System.Windows.Forms.Label Monday;
        private System.Windows.Forms.Label Tuesday;
        private System.Windows.Forms.Label Wednesday;
        private System.Windows.Forms.Label Thursday;
        private System.Windows.Forms.Label Friday;
        private System.Windows.Forms.Label Saturday;
        private System.Windows.Forms.ComboBox cmbThursdayTo;
        private System.Windows.Forms.ComboBox cmbThursdayFrom;
        private System.Windows.Forms.ComboBox cmbFridayTo;
        private System.Windows.Forms.ComboBox cmbFridayFrom;
        private System.Windows.Forms.ComboBox cmbTuesdayTo;
        private System.Windows.Forms.ComboBox cmbTuesdayFrom;
        private System.Windows.Forms.ComboBox cmbMondayTo;
        private System.Windows.Forms.ComboBox cmbMondayFrom;
        private System.Windows.Forms.ComboBox cmbSaturdayFrom;
        private System.Windows.Forms.ComboBox cmbSaturdayTo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listRezultati;
        private System.Windows.Forms.Button btnMonday;
        private System.Windows.Forms.Button btnTuesday;
        private System.Windows.Forms.Button btnWednesday;
        private System.Windows.Forms.Button btnThursday;
        private System.Windows.Forms.Button btnFriday;
        private System.Windows.Forms.Button btnSaturday;
        private System.Windows.Forms.Button btnRemove;
    }
}
