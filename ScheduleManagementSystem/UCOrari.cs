using System;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Threading;
using DGVPrinterHelper;
using System.Drawing.Printing;

namespace ScheduleManagementSystem
{
    public partial class UCOrari : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader reader;
        SqlDataAdapter da;
        private int selectedCellRow = 0;
        private int selectedCellColumn = 0;

        public UCOrari()
        {
            InitializeComponent();
        }

        private void UCOrari_Load(object sender, EventArgs e)
        {
            if (!(Log.id != null && Log.role == "Admin"))
            {
                method.hideControlls(lblOra, lblSalla, cmbOraDeri, cmbOraPrej, cmbSalla, rbLigjerate, rbUshtrime,cmbGrupi, lblGrupi, btnSubmit);
                method.disableControlls(lblOra, lblSalla, cmbOraDeri, cmbOraPrej, cmbSalla, rbLigjerate, rbUshtrime, cmbGrupi, lblGrupi, btnSubmit);
                dGVOrari.ReadOnly = true;
            }
            method.disableControlls(cmbDepartamenti,cmbOraDeri,cmbOraPrej, cmbSalla, cmbGrupi, rbUshtrime,rbLigjerate, btnDeleteO);
            
            try
            {
                conn.Open();
                var dt = new DataTable();
                using (da = new SqlDataAdapter("SELECT DISTINCT Semestri FROM Lendet ORDER BY Semestri ASC ", conn))
                {
                    da.Fill(dt);

                    var row = dt.NewRow();
                    row[dt.Columns[0].ToString()] = "Select...";
                    dt.Rows.InsertAt(row, 0);

                    cmbSemestri.DataSource = dt;
                    cmbSemestri.DisplayMember = dt.Columns[0].ToString();
                }

                method.setRadioButonTag(rbLigjerate);
                method.setRadioButonTag(rbUshtrime);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                method.closeConnection(conn);
            }

            dGVOrari.EnableHeadersVisualStyles = false;
            dGVOrari.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(23, 55, 110);
            dGVOrari.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(220, 220, 220);
            dGVOrari.ColumnHeadersDefaultCellStyle.Font = new Font(dGVOrari.Font, FontStyle.Bold);
            dGVOrari.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dGVOrari.AllowUserToResizeColumns = false;
            dGVOrari.AllowUserToResizeRows = false;
            dGVOrari.AllowUserToAddRows = false;
            dGVOrari.MultiSelect = false;
    }

        private void cmbSemestri_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (method.enableOnIndexChange(cmbSemestri, cmbDepartamenti,btnPrint))
            {
                method.disableControlls(cmbSalla, cmbOraDeri, cmbOraPrej, cmbGrupi, rbLigjerate, rbUshtrime);
                dGVOrari.Rows.Clear();
                dGVOrari.Refresh();
                
                if (cmbDepartamenti.Enabled == true)
                {
                    try
                    {
                        conn.Open();
                        var dt = new DataTable();
                        using (da = new SqlDataAdapter("sp_depFromSemester", conn))
                        {
                            da.SelectCommand.CommandType = CommandType.StoredProcedure;
                            da.SelectCommand.Parameters.AddWithValue("@semestri", cmbSemestri.Text);
                            da.Fill(dt);
                        }

                        var row = dt.NewRow();
                        row[dt.Columns[0].ToString()] = DBNull.Value;
                        row[dt.Columns[1].ToString()] = "Select...";
                        dt.Rows.InsertAt(row, 0);

                        cmbDepartamenti.DataSource = dt;
                        cmbDepartamenti.DisplayMember = dt.Columns[1].ToString();
                        cmbDepartamenti.ValueMember = dt.Columns[0].ToString();
                    }
                    catch (SqlException sqlEx)
                    {
                        MessageBox.Show(sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        method.closeConnection(conn);
                    }
                }else
                {
                    dGVOrari.Rows.Clear();
                    dGVOrari.Refresh();
                }
            }else
            {
                dGVOrari.Rows.Clear();
                dGVOrari.Refresh();
            }
        }

        private void dGVOrari_Resize(object sender, EventArgs e)
        {
            if (AutoSize)
            {
                var height = method.GetDataGridViewHeight(dGVOrari);
                dGVOrari.Height = height;
                dGVOrari.Height = height + dGVOrari.Padding.Top + dGVOrari.Padding.Bottom;
            }
        }

        private void dGVOrari_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            if (e.Cell == null || e.StateChanged != DataGridViewElementStates.Selected)
                return;

            //if Cell that changed state is to be selected you don't need to process
            //as event caused by 'unselectable' will select it again
            if (e.Cell.RowIndex == selectedCellRow && e.Cell.ColumnIndex == selectedCellColumn)
                return;

            //this condition is necessary if you want to reset your DataGridView
            if (!e.Cell.Selected)
                return;

            if (e.Cell.ColumnIndex == 0 || e.Cell.ColumnIndex == 1)
            {
                e.Cell.Selected = false;
                dGVOrari.Rows[selectedCellRow].Cells[selectedCellColumn].Selected = true;
            }
            else
            {
                selectedCellRow = e.Cell.RowIndex;
                selectedCellColumn = e.Cell.ColumnIndex;
            }
        }

        private void cmbDepartamenti_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbDepartamenti.Text != "Select..." && cmbDepartamenti.Enabled == true)
                {
                    selectedCellRow = 0;
                    selectedCellColumn = 0;
                    btnPrint.Enabled = true;
                    btnPrint.Visible = true;
                    method.disableControlls(cmbSalla, cmbOraDeri, cmbOraPrej);

                    int subjectNumber = 1;

                    conn.Open();
                    using (cmd = new SqlCommand("SELECT COUNT(*) AS nrsem FROM Lendet WHERE Semestri = @semestri", conn))
                    {
                        cmd.Parameters.AddWithValue("semestri", cmbSemestri.Text);
                        using (reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                subjectNumber = int.Parse(reader["nrsem"].ToString());
                            }
                        }
                    }

                    dGVOrari.Rows.Clear();
                    dGVOrari.Refresh();

                    using (cmd = new SqlCommand("getLendetFromSemestri", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@semestri", cmbSemestri.Text);
                        cmd.Parameters.AddWithValue("@dep", cmbDepartamenti.Text);
                        
                        using (reader = cmd.ExecuteReader())
                        {
                            int count = 0;
                            while (reader.Read() && count < subjectNumber)
                            {
                                dGVOrari.Rows.Add();
                                DataGridViewRow row = dGVOrari.Rows[count];
                                row.Cells[0].Value = reader[0].ToString()[0];
                                row.Cells[1].Value = $"{reader[1].ToString()}\r\n{method.getTeacher("Professor", reader[1].ToString())} (L)\r\n{method.getTeacher("Assistent", reader[1].ToString())} (U)";
                                count++;
                            }
                        }
                    }
                    method.setRowHeight(dGVOrari, 70);
                    method.setRowColor(dGVOrari, 0);
                    method.setRowColor(dGVOrari, 1);

                    method.fill_combo("Sallat", cmbSalla);

                    List<string> ora = new List<string>();
                    ora = method.fillList(8, 16, 30);

                    ora.Insert(0, "Select...");
                    cmbOraPrej.DataSource = ora;

                    List<string> groups = new List<string>();
                    groups.Add("Select...");
                    groups.Add("Gr I");
                    groups.Add("Gr II");
                    groups.Add("Gr III");
                    groups.Add("Gr IV");
                    groups.Add("Gr V");
                    cmbGrupi.DataSource = groups;

                    method.fillOrari(dGVOrari, cmbDepartamenti, cmbSemestri);
                }
                else
                {
                    dGVOrari.Rows.Clear();
                    dGVOrari.Refresh();
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, $"Error code.{sqlEx.ErrorCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                method.closeConnection(conn);
            }
        }

        private void dGVOrari_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (selectedCellColumn > 1 && selectedCellRow >= 0)
            {
                method.enableOnIndexChange(cmbDepartamenti, cmbSalla, cmbOraPrej, rbLigjerate, rbUshtrime, cmbGrupi);
                if (dGVOrari.Rows[selectedCellRow].Cells[selectedCellColumn].Value != null)
                {
                    if (!dGVOrari.Rows[selectedCellRow].Cells[selectedCellColumn].Value.Equals(""))
                    {
                        if (Log.role == "Admin")
                        {
                            cmbCellInfo.Visible = true;
                            cmbCellInfo.Enabled = true;
                            method.fillComboFromCell(dGVOrari.Rows[selectedCellRow].Cells[selectedCellColumn], cmbCellInfo);
                        }
                    }
                    else
                    {
                        cmbCellInfo.DataSource = null;
                        cmbCellInfo.Visible = false;
                        cmbCellInfo.Enabled = false;
                        btnDeleteO.Enabled = false;
                        btnDeleteO.Visible = false;
                    }
                }else
                {
                    cmbCellInfo.DataSource = null;
                    cmbCellInfo.Visible = false;
                    cmbCellInfo.Enabled = false;
                    btnDeleteO.Enabled = false;
                    btnDeleteO.Visible = false;
                }
            }
        }

        private void cmbOraPrej_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (method.enableOnIndexChange(cmbOraPrej, cmbOraDeri))
            {
                List<string> lista = new List<string>();
                try
                {
                    string[] koha = cmbOraPrej.Text.Split(':');
                    int ora = int.Parse(koha[0]);
                    int minutat = int.Parse(koha[1]);

                    if (minutat == 30)
                    {
                        int c = ora + 2;
                        ora = ora + 1;
                        minutat = 15;
                        lista.Add(ora.ToString() + ":" + minutat.ToString());
                        lista.Add(c.ToString() + ":00");
                        cmbOraDeri.DataSource = lista;
                    }
                    else if (minutat == 0)
                    {
                        int a = minutat + 30;
                        minutat = 45;
                        int orasm = ora;
                        ora += 1;
                        lista.Add(orasm.ToString() + ":" + minutat.ToString());
                        lista.Add(ora.ToString() + ":" + a.ToString());
                        cmbOraDeri.DataSource = lista;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lblSubmit_Click(object sender, EventArgs e)
        {
            string grupi = "", msg = "";
            int prof = -1,assis = -1, salla, departamenti;
            DataTable profAvailability;
            bool[] isAvailable;

            if (cmbSemestri.Text != "Select..." && cmbOraPrej.Text != "Select..." && cmbDepartamenti.Text != "Select..." && cmbSalla.Text != "Select..." && (rbLigjerate.Checked || rbUshtrime.Checked))
            {
                try
                {   
                    //Inico indeksin e rreshtit dhe kolones se klikuar
                    int selectedColumn = dGVOrari.SelectedCells[0].ColumnIndex;
                    int selectedRow = dGVOrari.SelectedCells[0].RowIndex;

                    //Ndaje tekstin e qelise se dyte te rreshtit te selektuar bazuar ne kryerresht
                    string[] subjectProfAss = dGVOrari.Rows[selectedRow].Cells[1].Value.ToString().Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

                    //Nese ComboBox-i cmbGrupi ka tekst te ndryshem nga 'Select...' atehere merre ate vlere dhe inico variablen grupi me ate vlere
                    if (cmbGrupi.Text != "Select...")
                    {
                        grupi = cmbGrupi.Text;
                    }

                    //Inico variablat assis ose prof varesisht nga RadioButton-i qe eshte klikuar
                    if (rbUshtrime.Checked)
                    {
                        assis = method.getTeacher(subjectProfAss[2].Remove(subjectProfAss[2].Length - 4, 4));
                    }
                    else if (rbLigjerate.Checked)
                    {
                        prof = method.getTeacher(subjectProfAss[1].Remove(subjectProfAss[1].Length - 4, 4));
                    }

                    //Shiko disponushmerine e prof/assistentit
                    if (prof != -1 && assis == -1)
                    {
                        profAvailability = method.checkProfAvailability(prof, cmbOraPrej.Text, cmbOraDeri.Text, dGVOrari.Columns[selectedColumn].HeaderText);
                        isAvailable = method.checkAvailability(cmbOraPrej.Text, cmbOraDeri.Text, prof, Convert.ToInt32(cmbSalla.SelectedValue), dGVOrari.Columns[selectedColumn].HeaderText);
                    }
                    else
                    {
                        profAvailability = method.checkProfAvailability(assis, cmbOraPrej.Text, cmbOraDeri.Text, dGVOrari.Columns[selectedColumn].HeaderText);
                        isAvailable = method.checkAvailability(cmbOraPrej.Text, cmbOraDeri.Text, assis, Convert.ToInt32(cmbSalla.SelectedValue), dGVOrari.Columns[selectedColumn].HeaderText);
                    }

                    //Provo te kthesh vleren e ComboBox-it cmbSalla rrespektivisht cmbDepartamenti ne vlere te plote numerike
                    bool isSalla = int.TryParse(cmbSalla.SelectedValue.ToString(), out salla);
                    bool isDep = int.TryParse(cmbDepartamenti.SelectedValue.ToString(), out departamenti);

                    if (prof != -1 || assis != -1)
                    {
                        //Shfaq mesazhe mbi disponueshmerine e mesimdheneseve ose sallave
                        if (isAvailable[0] == false)
                        {
                            MessageBox.Show("Teacher isn't available in this time!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (isAvailable[1] == false)
                        {
                            MessageBox.Show("Hall isn't available in this time!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            //Nese profesori nuk eshte i lire atehere profAvailability permban informacione mbi kohen kur ai eshte i lire
                            if (profAvailability != null && profAvailability.Columns.Count > 0 && profAvailability.Rows.Count > 0)
                            {
                                //Krijo mesazhin mbi informacione qe permban DataTable profAvailability
                                for (int i = 0; i < profAvailability.Rows.Count; i++)
                                {
                                    for (int j = 0; j < profAvailability.Columns.Count; j++)
                                    {
                                        msg += profAvailability.Rows[i][j].ToString();
                                        msg += " ";
                                    }
                                    msg += "\r\n";
                                }
                                //Shfaq nje paralajmrim per administratorin
                                if (MessageBox.Show($"Professor/Assistent isn't available in this time. He/She is available:\r\n{msg}\r\nDo you want to continue?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                                {
                                    if (isSalla && isDep)
                                    {
                                        //Nese klikohet butoni 'Yes' i paralajmrimit atehere provo te insertosh te dhenat ne baze te te dhenave
                                        if (method.insertOrar(cmbOraPrej.Text, cmbOraDeri.Text, salla, rbUshtrime.Checked ? int.Parse(rbUshtrime.Tag.ToString()) : int.Parse(rbLigjerate.Tag.ToString()), grupi, departamenti, method.getCPL(method.getTeacher((prof != -1) ? subjectProfAss[1].Remove(subjectProfAss[1].Length - 4, 4) : subjectProfAss[2].Remove(subjectProfAss[2].Length - 4, 4)), method.getSubjectID(subjectProfAss[0])), dGVOrari.Columns[selectedColumn].HeaderText))
                                        {
                                            //Nese te dhenat u futen me sukses atehere shfaqe nje mesazh per informim
                                            MessageBox.Show("The data has been inserted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            //Rifresko DataGridView dGVOrari-n
                                            method.clearOrari(dGVOrari, 2, dGVOrari.Columns.Count, dGVOrari.Rows.Count);
                                            method.fillOrari(dGVOrari, cmbDepartamenti, cmbSemestri);
                                            cmbCellInfo.DataSource = null;
                                            method.fillComboFromCell(dGVOrari.Rows[selectedCellRow].Cells[selectedCellColumn], cmbCellInfo);

                                        }
                                    }
                                }
                            }
                            else//Nese mesimdhenesi dhe salla jane te lira atehere inserto te dhenat ne baze te te dhenave
                            {
                                if (isSalla && isDep)
                                {
                                    //Nese klikohet butoni 'Yes' i paralajmrimit atehere provo te insertosh te dhenat ne baze te te dhenave
                                    if (method.insertOrar(cmbOraPrej.Text, cmbOraDeri.Text, salla, rbUshtrime.Checked ? int.Parse(rbUshtrime.Tag.ToString()) : int.Parse(rbLigjerate.Tag.ToString()), grupi, departamenti, method.getCPL(method.getTeacher((prof != -1) ? subjectProfAss[1].Remove(subjectProfAss[1].Length - 4, 4) : subjectProfAss[2].Remove(subjectProfAss[2].Length - 4, 4)), method.getSubjectID(subjectProfAss[0])), dGVOrari.Columns[selectedColumn].HeaderText))
                                    {
                                        //Nese te dhenat u futen me sukses atehere shfaqe nje mesazh per informim
                                        MessageBox.Show("The data has been inserted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        //Rifresko DataGridView dGVOrari-n
                                        //dGVOrari.Rows.Clear();
                                        method.clearOrari(dGVOrari, 2, dGVOrari.Columns.Count, dGVOrari.Rows.Count);
                                        method.fillOrari(dGVOrari, cmbDepartamenti, cmbSemestri);
                                        cmbCellInfo.DataSource = null;
                                        method.fillComboFromCell(dGVOrari.Rows[selectedCellRow].Cells[selectedCellColumn], cmbCellInfo);
                                    }
                                }
                            }
                        }
                    }else
                    {
                        MessageBox.Show("This subject doesn't have a teacher! Please choose a teacher for the subject!", "Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (SqlException sqlEx)
                {
                    MessageBox.Show(sqlEx.Message, $"Error code.{sqlEx.ErrorCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //method.closeConnection(conn);
                }
            }
            else
            {
                MessageBox.Show("Please fill out all required fields!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteO_Click(object sender, EventArgs e)
        {
            try
            {
                int selectedColumn = dGVOrari.SelectedCells[0].ColumnIndex;
                int selectedRow = dGVOrari.SelectedCells[0].RowIndex;

                //Ndaje tekstin e qelise se dyte te rreshtit te selektuar bazuar ne kryerresht
                string[] subjectProfAss = dGVOrari.Rows[selectedRow].Cells[1].Value.ToString().Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

                //Ndaje tekstin e ComboBox-it cmbCellInfo bazuar ne '-'
                string[] content = cmbCellInfo.Text.Split('-');
                content[content.Length-1] = content[content.Length-1].Substring(0,5);

                int dep, salla, cpl;
                bool isDep = int.TryParse(cmbDepartamenti.SelectedValue.ToString(), out dep);

                if (content[1].Replace(" ", string.Empty) == "L")
                {
                    cpl = method.getCPL(method.getTeacher(subjectProfAss[1].Remove(subjectProfAss[1].Length - 4, 4)), method.getSubjectID(subjectProfAss[0]));
                }
                else if (content[1].Replace(" ", string.Empty) == "U")
                {
                    cpl = method.getCPL(method.getTeacher(subjectProfAss[2].Remove(subjectProfAss[2].Length - 4, 4)), method.getSubjectID(subjectProfAss[0]));
                }else
                {
                    cpl = -1;
                }

                salla = method.getHallID(content[0]);

                conn.Open();

                if (isDep && cpl != -1)
                {
                    using (cmd = new SqlCommand("DELETE FROM Oraret WHERE FOres=@fores AND MOres=@mores AND ID_Salla=@salla AND ID_Dep=@dep AND ID_CPL = @idcpl AND DitaMbajtjes = @dita", conn))
                    {
                        cmd.Parameters.AddWithValue("fores", content[2]);
                        cmd.Parameters.AddWithValue("mores", content[3]);
                        cmd.Parameters.AddWithValue("salla", salla);
                        cmd.Parameters.AddWithValue("dep", dep);
                        cmd.Parameters.AddWithValue("idcpl", cpl);
                        cmd.Parameters.AddWithValue("dita", dGVOrari.Columns[selectedColumn].HeaderText);

                        if (MessageBox.Show("Are you sure you want to delete?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (cmd.ExecuteNonQuery() > 0)
                            {
                                if (MessageBox.Show("The data has been deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                                {
                                    method.clearOrari(dGVOrari, 2, dGVOrari.Columns.Count, dGVOrari.Rows.Count);
                                    method.fillOrari(dGVOrari, cmbDepartamenti, cmbSemestri);
                                    cmbCellInfo.DataSource = null;
                                    method.fillComboFromCell(dGVOrari.Rows[selectedCellRow].Cells[selectedCellColumn], cmbCellInfo);
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, $"Error code: {sqlEx.ErrorCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                method.closeConnection(conn);
            }
        }

        private void cmbCellInfo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            btnDeleteO.Visible = true;
            btnDeleteO.Enabled = true;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {   
            DGVPrinter printer = new DGVPrinter();
            printer.Title = lblFakulteti.Text;
            printer.TitleSpacing = 15;
            printer.SubTitle = $"Semestri: {cmbSemestri.Text}\nDepartamenti: {cmbDepartamenti.Text}";
            printer.SubTitleSpacing = 15;
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            printer.PageNumbers = false;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = false;
            PaperSize ps = new PaperSize("A4Rotated", 1300, 725);
            ps.PaperName = PaperKind.A4Rotated.ToString();
            printer.printDocument.DefaultPageSettings.PaperSize = ps;
            printer.RowHeight = (DGVPrinter.RowHeightSetting)70;
            printer.Footer = $"Provided by: Xhevahir Bajrami, Arlind Hajdari, Arlind Kryeziu, Florim Asani and Lentian Latifi.\r\nDate: {DateTime.Now.Date.ToString("MM/dd/yyyy")}\r\nAll rights reserved ©";
            printer.FooterSpacing = 15;
            printer.PrintDataGridView(dGVOrari);
        }
    }
}
