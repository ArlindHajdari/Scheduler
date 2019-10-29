namespace ScheduleManagementSystem
{
    partial class UCOrari
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCOrari));
            this.dGVOrari = new System.Windows.Forms.DataGridView();
            this.ObZg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LMA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tuesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Wednesday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Thursday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Friday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saturday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSemestri = new System.Windows.Forms.Label();
            this.lblDepartamenti = new System.Windows.Forms.Label();
            this.lblSalla = new System.Windows.Forms.Label();
            this.lblOra = new System.Windows.Forms.Label();
            this.cmbSemestri = new System.Windows.Forms.ComboBox();
            this.cmbDepartamenti = new System.Windows.Forms.ComboBox();
            this.cmbSalla = new System.Windows.Forms.ComboBox();
            this.cmbOraPrej = new System.Windows.Forms.ComboBox();
            this.cmbOraDeri = new System.Windows.Forms.ComboBox();
            this.Separate = new System.Windows.Forms.Label();
            this.lblFakulteti = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblGrupi = new System.Windows.Forms.Label();
            this.rbLigjerate = new System.Windows.Forms.RadioButton();
            this.rbUshtrime = new System.Windows.Forms.RadioButton();
            this.cmbGrupi = new System.Windows.Forms.ComboBox();
            this.btnDeleteO = new System.Windows.Forms.Button();
            this.cmbCellInfo = new System.Windows.Forms.ComboBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printOrari = new System.Drawing.Printing.PrintDocument();
            this.printPreviewOrari = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrari)).BeginInit();
            this.SuspendLayout();
            // 
            // dGVOrari
            // 
            this.dGVOrari.BackgroundColor = System.Drawing.Color.White;
            this.dGVOrari.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVOrari.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle22;
            this.dGVOrari.ColumnHeadersHeight = 35;
            this.dGVOrari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dGVOrari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ObZg,
            this.LMA,
            this.Monday,
            this.Tuesday,
            this.Wednesday,
            this.Thursday,
            this.Friday,
            this.Saturday});
            this.dGVOrari.Location = new System.Drawing.Point(3, 117);
            this.dGVOrari.Name = "dGVOrari";
            this.dGVOrari.RowHeadersVisible = false;
            this.dGVOrari.RowHeadersWidth = 40;
            this.dGVOrari.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVOrari.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dGVOrari.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVOrari.Size = new System.Drawing.Size(1133, 573);
            this.dGVOrari.TabIndex = 0;
            this.dGVOrari.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGVOrari_CellClick);
            this.dGVOrari.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dGVOrari_CellStateChanged);
            this.dGVOrari.Resize += new System.EventHandler(this.dGVOrari_Resize);
            // 
            // ObZg
            // 
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObZg.DefaultCellStyle = dataGridViewCellStyle23;
            this.ObZg.Frozen = true;
            this.ObZg.HeaderText = "O/Z";
            this.ObZg.Name = "ObZg";
            this.ObZg.ReadOnly = true;
            this.ObZg.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ObZg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ObZg.Width = 40;
            // 
            // LMA
            // 
            this.LMA.HeaderText = "LËNDËT/MËSIMDHËNËSI/ASISTENTI";
            this.LMA.Name = "LMA";
            this.LMA.ReadOnly = true;
            this.LMA.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.LMA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.LMA.Width = 240;
            // 
            // Monday
            // 
            this.Monday.HeaderText = "E HËNË";
            this.Monday.Name = "Monday";
            this.Monday.ReadOnly = true;
            this.Monday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Monday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Monday.Width = 142;
            // 
            // Tuesday
            // 
            this.Tuesday.HeaderText = "E MARTË";
            this.Tuesday.Name = "Tuesday";
            this.Tuesday.ReadOnly = true;
            this.Tuesday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tuesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Tuesday.Width = 142;
            // 
            // Wednesday
            // 
            this.Wednesday.HeaderText = "E MËRKURË";
            this.Wednesday.Name = "Wednesday";
            this.Wednesday.ReadOnly = true;
            this.Wednesday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Wednesday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Wednesday.Width = 142;
            // 
            // Thursday
            // 
            this.Thursday.HeaderText = "E ENJTE";
            this.Thursday.Name = "Thursday";
            this.Thursday.ReadOnly = true;
            this.Thursday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Thursday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Thursday.Width = 142;
            // 
            // Friday
            // 
            this.Friday.HeaderText = "E PREMTE";
            this.Friday.Name = "Friday";
            this.Friday.ReadOnly = true;
            this.Friday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Friday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Friday.Width = 142;
            // 
            // Saturday
            // 
            this.Saturday.HeaderText = "E SHTUNË";
            this.Saturday.Name = "Saturday";
            this.Saturday.ReadOnly = true;
            this.Saturday.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Saturday.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Saturday.Width = 142;
            // 
            // lblSemestri
            // 
            this.lblSemestri.AutoSize = true;
            this.lblSemestri.Location = new System.Drawing.Point(38, 52);
            this.lblSemestri.Name = "lblSemestri";
            this.lblSemestri.Size = new System.Drawing.Size(47, 13);
            this.lblSemestri.TabIndex = 3;
            this.lblSemestri.Text = "Semestri";
            // 
            // lblDepartamenti
            // 
            this.lblDepartamenti.AutoSize = true;
            this.lblDepartamenti.Location = new System.Drawing.Point(148, 52);
            this.lblDepartamenti.Name = "lblDepartamenti";
            this.lblDepartamenti.Size = new System.Drawing.Size(70, 13);
            this.lblDepartamenti.TabIndex = 4;
            this.lblDepartamenti.Text = "Departamenti";
            // 
            // lblSalla
            // 
            this.lblSalla.AutoSize = true;
            this.lblSalla.Location = new System.Drawing.Point(279, 52);
            this.lblSalla.Name = "lblSalla";
            this.lblSalla.Size = new System.Drawing.Size(34, 13);
            this.lblSalla.TabIndex = 5;
            this.lblSalla.Text = "Salla*";
            // 
            // lblOra
            // 
            this.lblOra.AutoSize = true;
            this.lblOra.Location = new System.Drawing.Point(386, 52);
            this.lblOra.Name = "lblOra";
            this.lblOra.Size = new System.Drawing.Size(28, 13);
            this.lblOra.TabIndex = 6;
            this.lblOra.Text = "Ora*";
            // 
            // cmbSemestri
            // 
            this.cmbSemestri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemestri.FormattingEnabled = true;
            this.cmbSemestri.Location = new System.Drawing.Point(41, 71);
            this.cmbSemestri.Name = "cmbSemestri";
            this.cmbSemestri.Size = new System.Drawing.Size(69, 21);
            this.cmbSemestri.TabIndex = 7;
            this.cmbSemestri.SelectionChangeCommitted += new System.EventHandler(this.cmbSemestri_SelectionChangeCommitted);
            // 
            // cmbDepartamenti
            // 
            this.cmbDepartamenti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamenti.FormattingEnabled = true;
            this.cmbDepartamenti.Location = new System.Drawing.Point(151, 71);
            this.cmbDepartamenti.Name = "cmbDepartamenti";
            this.cmbDepartamenti.Size = new System.Drawing.Size(92, 21);
            this.cmbDepartamenti.TabIndex = 8;
            this.cmbDepartamenti.SelectionChangeCommitted += new System.EventHandler(this.cmbDepartamenti_SelectionChangeCommitted);
            // 
            // cmbSalla
            // 
            this.cmbSalla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalla.FormattingEnabled = true;
            this.cmbSalla.Location = new System.Drawing.Point(282, 71);
            this.cmbSalla.Name = "cmbSalla";
            this.cmbSalla.Size = new System.Drawing.Size(73, 21);
            this.cmbSalla.TabIndex = 9;
            // 
            // cmbOraPrej
            // 
            this.cmbOraPrej.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOraPrej.FormattingEnabled = true;
            this.cmbOraPrej.Location = new System.Drawing.Point(389, 71);
            this.cmbOraPrej.Name = "cmbOraPrej";
            this.cmbOraPrej.Size = new System.Drawing.Size(64, 21);
            this.cmbOraPrej.TabIndex = 10;
            this.cmbOraPrej.SelectionChangeCommitted += new System.EventHandler(this.cmbOraPrej_SelectionChangeCommitted);
            // 
            // cmbOraDeri
            // 
            this.cmbOraDeri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOraDeri.FormattingEnabled = true;
            this.cmbOraDeri.Location = new System.Drawing.Point(475, 71);
            this.cmbOraDeri.Name = "cmbOraDeri";
            this.cmbOraDeri.Size = new System.Drawing.Size(53, 21);
            this.cmbOraDeri.TabIndex = 11;
            // 
            // Separate
            // 
            this.Separate.AutoSize = true;
            this.Separate.Location = new System.Drawing.Point(459, 74);
            this.Separate.Name = "Separate";
            this.Separate.Size = new System.Drawing.Size(10, 13);
            this.Separate.TabIndex = 12;
            this.Separate.Text = "-";
            // 
            // lblFakulteti
            // 
            this.lblFakulteti.AutoSize = true;
            this.lblFakulteti.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFakulteti.Location = new System.Drawing.Point(441, 10);
            this.lblFakulteti.Name = "lblFakulteti";
            this.lblFakulteti.Size = new System.Drawing.Size(302, 24);
            this.lblFakulteti.TabIndex = 13;
            this.lblFakulteti.Text = "Fakulteti i Shkencave Kompjuterike";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(750, 69);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 14;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.lblSubmit_Click);
            // 
            // lblGrupi
            // 
            this.lblGrupi.AutoSize = true;
            this.lblGrupi.Location = new System.Drawing.Point(641, 52);
            this.lblGrupi.Name = "lblGrupi";
            this.lblGrupi.Size = new System.Drawing.Size(32, 13);
            this.lblGrupi.TabIndex = 16;
            this.lblGrupi.Text = "Grupi";
            // 
            // rbLigjerate
            // 
            this.rbLigjerate.AutoSize = true;
            this.rbLigjerate.Location = new System.Drawing.Point(553, 56);
            this.rbLigjerate.Name = "rbLigjerate";
            this.rbLigjerate.Size = new System.Drawing.Size(65, 17);
            this.rbLigjerate.TabIndex = 17;
            this.rbLigjerate.TabStop = true;
            this.rbLigjerate.Text = "Ligjeratë";
            this.rbLigjerate.UseVisualStyleBackColor = true;
            // 
            // rbUshtrime
            // 
            this.rbUshtrime.AutoSize = true;
            this.rbUshtrime.Location = new System.Drawing.Point(553, 88);
            this.rbUshtrime.Name = "rbUshtrime";
            this.rbUshtrime.Size = new System.Drawing.Size(66, 17);
            this.rbUshtrime.TabIndex = 18;
            this.rbUshtrime.TabStop = true;
            this.rbUshtrime.Text = "Ushtrime";
            this.rbUshtrime.UseVisualStyleBackColor = true;
            // 
            // cmbGrupi
            // 
            this.cmbGrupi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGrupi.FormattingEnabled = true;
            this.cmbGrupi.Location = new System.Drawing.Point(644, 71);
            this.cmbGrupi.Name = "cmbGrupi";
            this.cmbGrupi.Size = new System.Drawing.Size(72, 21);
            this.cmbGrupi.TabIndex = 19;
            // 
            // btnDeleteO
            // 
            this.btnDeleteO.Location = new System.Drawing.Point(1054, 69);
            this.btnDeleteO.Name = "btnDeleteO";
            this.btnDeleteO.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteO.TabIndex = 20;
            this.btnDeleteO.Text = "Delete";
            this.btnDeleteO.UseVisualStyleBackColor = true;
            this.btnDeleteO.Visible = false;
            this.btnDeleteO.Click += new System.EventHandler(this.btnDeleteO_Click);
            // 
            // cmbCellInfo
            // 
            this.cmbCellInfo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCellInfo.FormattingEnabled = true;
            this.cmbCellInfo.Location = new System.Drawing.Point(868, 71);
            this.cmbCellInfo.Name = "cmbCellInfo";
            this.cmbCellInfo.Size = new System.Drawing.Size(157, 21);
            this.cmbCellInfo.TabIndex = 21;
            this.cmbCellInfo.Visible = false;
            this.cmbCellInfo.SelectionChangeCommitted += new System.EventHandler(this.cmbCellInfo_SelectionChangeCommitted);
            // 
            // btnPrint
            // 
            this.btnPrint.Enabled = false;
            this.btnPrint.Location = new System.Drawing.Point(1054, 30);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
            this.btnPrint.TabIndex = 22;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printOrari
            // 
            // 
            // printPreviewOrari
            // 
            this.printPreviewOrari.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewOrari.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewOrari.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewOrari.Enabled = true;
            this.printPreviewOrari.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewOrari.Icon")));
            this.printPreviewOrari.Name = "printPreviewOrari";
            this.printPreviewOrari.Visible = false;
            // 
            // UCOrari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.cmbCellInfo);
            this.Controls.Add(this.btnDeleteO);
            this.Controls.Add(this.cmbGrupi);
            this.Controls.Add(this.rbUshtrime);
            this.Controls.Add(this.rbLigjerate);
            this.Controls.Add(this.lblGrupi);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblFakulteti);
            this.Controls.Add(this.Separate);
            this.Controls.Add(this.cmbOraDeri);
            this.Controls.Add(this.cmbOraPrej);
            this.Controls.Add(this.cmbSalla);
            this.Controls.Add(this.cmbDepartamenti);
            this.Controls.Add(this.cmbSemestri);
            this.Controls.Add(this.lblOra);
            this.Controls.Add(this.lblSalla);
            this.Controls.Add(this.lblDepartamenti);
            this.Controls.Add(this.lblSemestri);
            this.Controls.Add(this.dGVOrari);
            this.Name = "UCOrari";
            this.Size = new System.Drawing.Size(1139, 693);
            this.Load += new System.EventHandler(this.UCOrari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGVOrari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dGVOrari;
        private System.Windows.Forms.Label lblSemestri;
        private System.Windows.Forms.Label lblDepartamenti;
        private System.Windows.Forms.Label lblSalla;
        private System.Windows.Forms.Label lblOra;
        private System.Windows.Forms.ComboBox cmbSemestri;
        private System.Windows.Forms.ComboBox cmbDepartamenti;
        private System.Windows.Forms.ComboBox cmbSalla;
        private System.Windows.Forms.ComboBox cmbOraPrej;
        private System.Windows.Forms.ComboBox cmbOraDeri;
        private System.Windows.Forms.Label Separate;
        private System.Windows.Forms.Label lblFakulteti;
        private System.Windows.Forms.DataGridViewTextBoxColumn ObZg;
        private System.Windows.Forms.DataGridViewTextBoxColumn LMA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tuesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Wednesday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Thursday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Friday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saturday;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblGrupi;
        private System.Windows.Forms.RadioButton rbLigjerate;
        private System.Windows.Forms.RadioButton rbUshtrime;
        private System.Windows.Forms.ComboBox cmbGrupi;
        private System.Windows.Forms.Button btnDeleteO;
        private System.Windows.Forms.ComboBox cmbCellInfo;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printOrari;
        private System.Windows.Forms.PrintPreviewDialog printPreviewOrari;
    }
}
