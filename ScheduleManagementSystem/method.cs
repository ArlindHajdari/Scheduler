using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace ScheduleManagementSystem
{
    public static class method
    {   
        //Klasa e cila permban te gjitha metodat per kodim me te lehte
        static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        static SqlDataAdapter da;
        static SqlCommand cmd;
        static SqlDataReader reader;
        static Form1 parentForm = (Form1)Application.OpenForms["Form1"];

        //Mbush ComboBox-in me te dhenat perkatese(sipas parametrave) nga baza e te dhenave.
        public static void fill_combo(string table, ComboBox cmb, string columns = "*", string condition = "")
        {
            try
            {
                var dt = new DataTable();

                using (da = new SqlDataAdapter($"SELECT {columns} FROM [{table}] {condition}", conn))
                {
                    da.Fill(dt);
                }
                
                var row = dt.NewRow();

                row[dt.Columns[0].ToString()] = DBNull.Value;
                row[dt.Columns[1].ToString()] = "Select...";

                dt.Rows.InsertAt(row, 0);

                cmb.DataSource = dt;
                cmb.ValueMember = dt.Columns[0].ToString();
                cmb.DisplayMember = dt.Columns[1].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                closeConnection(conn);
            }
        }

        public static void fill_combo(ComboBox cmb, string procName, string[] procParams, params object[] inputParams)
        {
            try
            {
                var dt = new DataTable();

                using (da = new SqlDataAdapter(procName, conn))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < procParams.Length; i++)
                    {
                        da.SelectCommand.Parameters.AddWithValue(procParams[i], inputParams[i]);
                    }
                    da.Fill(dt);
                }

                var row = dt.NewRow();
                row[dt.Columns[0].ToString()] = DBNull.Value;
                row[dt.Columns[1].ToString()] = "Select...";
                dt.Rows.InsertAt(row, 0);

                cmb.DataSource = dt;
                cmb.ValueMember = dt.Columns[0].ToString();
                cmb.DisplayMember = dt.Columns[1].ToString();
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                closeConnection(conn);
            }
        }

        public static void fill_combo(ComboBox cmb, string query)
        {
            try
            {
                var dt = new DataTable();

                using (da = new SqlDataAdapter(query, conn))
                {
                    da.Fill(dt);
                }

                var row = dt.NewRow();

                row[dt.Columns[0].ToString()] = DBNull.Value;
                row[dt.Columns[1].ToString()] = "Select...";

                dt.Rows.InsertAt(row, 0);

                cmb.DataSource = dt;
                cmb.ValueMember = dt.Columns[0].ToString();
                cmb.DisplayMember = dt.Columns[1].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                closeConnection(conn);
            }
        }

        //Kontrollon nese ne tekstin e TextBox-it te dhene si parameter nuk ka shkronje te madhe ne fillim te tekstit
        public static void Check_nameReg(TextBox txt, string stre, ErrorProvider error, ErrorProvider tick)
        {
            Regex str = new Regex(@"^(\p{Lu}\p{Ll}+)$");
            if (txt.Text == string.Empty)
            {
                error.SetError(txt, "Please fill this field!");
                tick.SetError(txt, "");

            }
            else if (str.IsMatch(txt.Text))
            {
                error.SetError(txt, "");
                tick.SetError(txt, "Correct!");
            }
            else
            {
                Match txtnumbers = Regex.Match(txt.Text, @"[\p{P}\p{S}\p{N}\s]");
                if (txtnumbers.Success)
                {
                    error.SetError(txt, stre + " can't contain numbers, special symbols or white spaces!");
                    tick.SetError(txt, "");

                }
                else
                {
                    error.SetError(txt, "Please start with a upper case!");
                    tick.SetError(txt, "");

                }
            }
        }
        //Kthe te dhenat e imazhit ne byte array
        public static byte[] ImageToByteArr(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        //Shfaqja e dritares per zgjedhjen e imazhit
        public static void openDialogImage(PictureBox p)
        {
            using (OpenFileDialog open = new OpenFileDialog() { Filter = "JPEG|*.jpg", ValidateNames = true, Multiselect = false })
            {
                if (open.ShowDialog() == DialogResult.OK)
                {
                    p.Image = Image.FromFile(open.FileName);
                    p.Tag = open.SafeFileName;
                    p.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
        }

        //Kontrollo TextBox-in qe te pranoje vetem numra
        public static void onlyNumbers(TextBox text)
        {
            if (Regex.IsMatch(text.Text, "[^0-9]"))
            {
                text.Text = "";
            }
        }

        //Kontrollon TextBox-in qe te validoje tekstin si email.
        public static void checkEmail(TextBox txt, ErrorProvider error, ErrorProvider tick)
        {
            Match match = Regex.Match(txt.Text, @"^[\w._]{6,30}@[\w]{2,}\.[\w]{2,}$");
            if (txt.Text == "")
            {
                error.SetError(txt, "Please fill this field!");
                tick.SetError(txt, "");
            }
            else if (match.Success)
            {
                tick.SetError(txt, "Correct");
                error.SetError(txt, "");
            }
            else
            {
                tick.SetError(txt, "");
                error.SetError(txt, "E.g. example@domain.com");

            }
        }

        //Kontrrollon TextBox-in qe te validoj fjalekalimin qe te pranoj se paku nje shkronje te madhe 
        //nje shkronje te vogel dhe nje numer.
        public static void checkPassword(TextBox txt, ErrorProvider error, ErrorProvider tick)
        {
            Match match = Regex.Match(txt.Text, @"^(?=.*\p{Lu})(?=.*\d)(?=.*\p{Ll}).+$");
            //Minimum 8 shkronja/numra
            if (match.Success && txt.Text.Length >= 8)
            {
                error.SetError(txt, "");
                tick.SetError(txt, "Correct!");
            }
            else
            {
                error.SetError(txt, "Password must contain atleast:\nOne upper case letter\nOne lower case letter\nOne digit\nHave minimum 8 characters");
                tick.SetError(txt, "");
            }
        }
        
        //Kontrrollon nese numri personal i shtypur gjendet ne databaze. Nese po shfaq error te ErrorProvider-i.
        public static void checkPersonalNumber(TextBox txt, ErrorProvider error, ErrorProvider tick)
        {
            bool exist = false;
            try
            {
                conn.Open();

                using (cmd = new SqlCommand("SELECT COUNT(*) FROM Stafi WHERE Numri_Personal = @Numri_Personal", conn))
                {
                    cmd.Parameters.AddWithValue("Numri_Personal", txt.Text);
                    exist = (int)cmd.ExecuteScalar() > 0;
                }

                if (exist)
                {
                    error.SetError(txt, "This personal number already exists!");
                    tick.SetError(txt, "");

                }
                else
                {
                    if (txt.Text.Length == 10)
                    {
                        error.SetError(txt, "");
                        tick.SetError(txt, "Correct!");
                    }
                    if (!exist && txt.Text.Length < 10)
                    {
                        error.SetError(txt, "Personal number must contain 10 digits!");
                        tick.SetError(txt, "");

                    }
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error no." + ex.ErrorCode, MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                closeConnection(conn);
            }
        }

        //Kontrollo nese te gjithe ErrorProviderat jane te barabarte me asgje.
        public static bool IsValid(ErrorProvider ep)
        {
            foreach (Control c in ep.ContainerControl.Controls)
                if (ep.GetError(c) != "")
                    return false;
            return true;
        }

        //Mbush TextBox-in e dhene si parameter me te dhenat e marra nga databaza.
        public static void fillTextBoxes(TextBox txt, ComboBox cmb, string table, string ID, string column = "*")
        {
            if (enableOnIndexChange(cmb, txt))
            {
                try
                {
                    int fid = int.Parse(cmb.SelectedValue.ToString());

                    conn.Open();

                    cmd = new SqlCommand($"SELECT {column} FROM [{table}] WHERE {ID}=@id", conn);
                    cmd.Parameters.AddWithValue("@id", fid);

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txt.Text = reader[0].ToString();
                        }
                    }
                }
                catch (SqlException ex1)
                {
                    MessageBox.Show(ex1.Message, "Error no." + ex1.ErrorCode, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    closeConnection(conn);
                }
            }
        }
        
        //I aktivizon kontrollat nese teksti tek ComboBox-i i dhene si parameter eshte i ndryshem
        //nga "Select..."
        public static bool enableOnIndexChange(ComboBox cmb, params Control[] control)
        {
            if (cmb.Text.Equals("Select..."))
            {
                foreach (var item in control)
                {
                    if (item is TextBox)
                    {
                        TextBox tb = item as TextBox;
                        tb.Clear();
                    }
                    else if (item is ComboBox)
                    {
                        ComboBox CB = item as ComboBox;
                        CB.SelectedIndex = -1;
                    }
                    else if (item is PictureBox)
                    {
                        PictureBox PB = item as PictureBox;
                        PB.Image = null;
                    }

                    item.Enabled = false;
                }
                return false;
            } else
            {
                foreach (var item in control)
                {
                    item.Enabled = true;
                }
                return true;
            }
        }

        //I deaktivizon kontrollat e dhena si parametra.
        public static void disableControlls(params Control[] contr)
        {
            foreach (var item in contr)
            {
                item.Enabled = false;
            }
        }

        public static void hideControlls(params Control[] contr)
        {
            foreach (var item in contr)
            {
                item.Visible = false;
            }
        }

        //Mbush listen me ore-n ne mes parametrave te dhene.
        public static List<string> fillList(int oraprej, int oraderi, int split = 60)
        {
            List<string> temp = new List<string>();

            for (int i = oraprej; i <= oraderi; i++)
            {
                for (int j = 0; j < 60; j += split)
                {
                    if (j == 0)
                    {
                        temp.Add($"{i}:00");
                    }
                    else
                    {
                        temp.Add($"{i}:{j}");
                    }
                }
            }
            return temp;
        }

        //Nese ora e cekur eshte maksimale atehere shfaq error.
        public static void resultOnCombobox(ComboBox c1, ComboBox c2)
        {
            string[] koha = c1.Text.Split(':');
            int ora = int.Parse(koha[0]);

            if (ora == 18)
            {
                MessageBox.Show("Invalid time chosen!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                c1.Text = "9:00";
            }
            else
            {
                c2.DataSource = fillList(ora+1,18);
            }
        }

        public static void resetTxt(params Control[] txtboxes)
        {
            foreach (var item in txtboxes)
            {
                item.Text = "";   
            }
        }

        public static void resetErrorProvider(ErrorProvider ep, params Control[] cont)
        {
            foreach (var item in cont)
            {
                ep.SetError(item, "");
            }
        }

        public static void setRowHeight(DataGridView dgv, int height)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                row.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                row.DefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
                row.Height = height;
            }
        }

        public static void setRowColor(DataGridView dgv, int column, int red=23, int green = 55, int blue = 110)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells[column].Style.BackColor = Color.FromArgb(red, green, blue);
                row.Cells[column].Style.ForeColor = Color.FromArgb(220, 220, 220);
            }
        }

        public static void increaseFormSize()
        {
            parentForm.Width = 1207;
            parentForm.Height = 710;
            parentForm.panel1.Width = 1139;
            parentForm.panel1.Height = 693;
            parentForm.btnLogOut.Left = parentForm.Width - parentForm.btnLogOut.Size.Width * 5 / 3;
            parentForm.lblProvided.Enabled = false;
            parentForm.lblProvided.Visible = false;
            if (Log.role == "User")
            {
                parentForm.btnAvailability.Left = parentForm.Width - 220;
                parentForm.btnChangePassword.Left = parentForm.Width - 345;
            }
        }

        public static void decreaseFormSize()
        {
            parentForm.Width = 566;
            parentForm.Height = 456;
            parentForm.panel1.Width = 499;
            parentForm.panel1.Height = 333;
            parentForm.btnLogOut.Left = parentForm.Width - parentForm.btnLogOut.Size.Width * 5 / 3;

            parentForm.lblProvided.Enabled = true;
            parentForm.lblProvided.Visible = true;

            if (Log.role == "User")
            {
                parentForm.btnAvailability.Left = parentForm.Width - 220;
                parentForm.btnChangePassword.Left = parentForm.Width - 345;
            }
        }

        public static void closeConnection(SqlConnection conn)
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public static int GetDataGridViewHeight(DataGridView dataGridView)
        {
            var sum = (dataGridView.ColumnHeadersVisible ? dataGridView.ColumnHeadersHeight : 0) +
                      dataGridView.Rows.OfType<DataGridViewRow>().Where(r => r.Visible).Sum(r => r.Height);

            return sum;
        }

        public static string getTeacher(string teacher, string subject)
        {
            string prof = "";
            try
            {
                conn.Open();
                using (cmd = new SqlCommand("sp_getTeacherPA", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("teacher", teacher);
                    cmd.Parameters.AddWithValue("subject", subject);

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        prof = reader[1].ToString();
                    }
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
                closeConnection(conn);
            }
            return prof;
        }

        public static int getTeacher(string teacher)
        {
            int id = -1;
            try
            {
                conn.Open();
                using (cmd = new SqlCommand("getTeacher",conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("teacher", teacher);

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        id = int.Parse(reader[0].ToString());
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
            }finally
            {
                closeConnection(conn);
            }
            return id;
        }

        public static int getCPL(int teacher, int subject)
        {
            int id = -1;
            try
            {
                conn.Open();
                using (cmd = new SqlCommand("getCPL", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("stafi", teacher);
                    cmd.Parameters.AddWithValue("lenda", subject);

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        id = int.Parse(reader[0].ToString());
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
                closeConnection(conn);
            }
            return id;
        }

        public static int getSubjectID(string subject)
        {
            int id = -1;
            try
            {
                conn.Open();
                using (cmd = new SqlCommand("getSubjectID", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("lenda", subject);

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        id = int.Parse(reader[0].ToString());
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
                closeConnection(conn);
            }
            return id;
        }

        public static void setRadioButonTag(RadioButton rb)
        {
            try
            {
                conn.Open();
                using (cmd = new SqlCommand("SELECT TOP 1 ID_LUSH FROM LUSH WHERE LUSH=@lush", conn))
                {
                    cmd.Parameters.AddWithValue("lush", rb.Text);
                    reader = cmd.ExecuteReader();
                    
                    while (reader.Read())
                    {
                        rb.Tag = reader[0].ToString();
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
            }finally
            {
                closeConnection(conn);
            }
        }

        public static int getRowFromItsContent(DataGridView dgv, string content)
        {
            int rowIndex = -1;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (row.Cells[1].Value.ToString().Contains(content))
                {
                    rowIndex = row.Index;
                }
            }
            return rowIndex;
        }

        public static int getColumnFromItsHeader(DataGridView dgv, string headerText)
        {
            int colIndex = -1;

            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.HeaderText == headerText)
                {
                    colIndex = col.Index;
                }
            }
            return colIndex;
        }

        public static bool[] checkAvailability(string oraP, string oraD, int stafiD, int salla, string dita)
        {
            bool[] Availability = new bool[2];
            
            try
            {
                conn.Open();
                using (cmd = new SqlCommand("checkAvailability", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("oraP", oraP);
                    cmd.Parameters.AddWithValue("oraD", oraD);
                    cmd.Parameters.AddWithValue("stafiD", stafiD);
                    cmd.Parameters.AddWithValue("salla", salla);
                    cmd.Parameters.AddWithValue("dita", dita);

                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Availability[0] = Convert.ToBoolean(reader[0]);
                        Availability[1] = Convert.ToBoolean(reader[1]);
                    }
                }
            }
            catch (SqlException sqlEx)
            {

                MessageBox.Show(sqlEx.Message, $"Error code:{sqlEx.ErrorCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection(conn);
            }
            return Availability;
        }

        public static DataTable checkProfAvailability(int profi, string oraP, string oraD, string dita)
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.Open();

                using (da = new SqlDataAdapter("checkProfAvailability", conn))
                {
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("profi", profi);
                    da.SelectCommand.Parameters.AddWithValue("oraP", oraP);
                    da.SelectCommand.Parameters.AddWithValue("oraD", oraD);
                    da.SelectCommand.Parameters.AddWithValue("dita", dita);

                    da.Fill(dataTable);
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
                closeConnection(conn);
            }
            return dataTable;
        }

        public static bool insertOrar(string fOres, string mOres, int idSalla, int idLush, string grupi, int idDep, int idCPL, string ditaMbajtjes)
        {
            bool result = false;
            try
            {
                conn.Open();

                using (cmd = new SqlCommand("INSERT INTO Oraret VALUES(@fores,@mores,@idsalla,@idlush,@grupi,@idep,@idcpl,@datambajtjes)",conn))
                {
                    cmd.Parameters.AddWithValue("fores", fOres);
                    cmd.Parameters.AddWithValue("mores", mOres);
                    cmd.Parameters.AddWithValue("idsalla", idSalla);
                    cmd.Parameters.AddWithValue("idlush", idLush);
                    cmd.Parameters.AddWithValue("grupi", grupi);
                    cmd.Parameters.AddWithValue("idep", idDep);
                    cmd.Parameters.AddWithValue("idcpl", idCPL);
                    cmd.Parameters.AddWithValue("datambajtjes", ditaMbajtjes);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        result = true;
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
                closeConnection(conn);
            }
            return result;
        }

        public static void fillOrari(DataGridView dgv, ComboBox cmb, ComboBox cmb1)
        {
            int dep, semestri;
            try
            {
                bool isDep = int.TryParse(cmb.SelectedValue.ToString(), out dep);
                bool isSemestri = int.TryParse(cmb1.Text, out semestri);
                conn.Open();
                if (isDep && isSemestri)
                {
                    using (cmd = new SqlCommand("sp_getOrari", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("idep", dep);
                        cmd.Parameters.AddWithValue("semestri", semestri);

                        reader = cmd.ExecuteReader();
                        
                        while (reader.Read())
                        {
                            dgv.Rows[getRowFromItsContent(dgv, reader[6].ToString())].Cells[getColumnFromItsHeader(dgv, reader[5].ToString())].Value += $"{reader[0].ToString()} - {reader[1].ToString()}- {reader[2].ToString()}-{reader[3].ToString()}  {reader[4].ToString()}\r\n";
                            dgv.Rows[getRowFromItsContent(dgv, reader[6].ToString())].Cells[getColumnFromItsHeader(dgv, reader[5].ToString())].Style.Font = new Font(dgv.Font, FontStyle.Regular);
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
                closeConnection(conn);
            }
        }

        public static void clearOrari(DataGridView dgv, int fromCol, int toCol, int rows)
        {
            try
            {
                for (int i = fromCol; i < toCol; i++)
                {
                    for (int j = 0; j < rows; j++)
                    {
                        dgv.Rows[j].Cells[i].Value = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void fillComboFromCell(DataGridViewCell dgvc, ComboBox cmb)
        {
            try
            {
                List<string> cellDevided = new List<string>();
                cellDevided.Insert(0, "Select...");
                foreach (string item in dgvc.Value.ToString().Split(new string[] { "\r\n", "\n" }, StringSplitOptions.RemoveEmptyEntries))
                {
                    cellDevided.Add(item);   
                }
                cmb.DataSource = cellDevided;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static int getResultCount(SqlCommand cmd)
        {
            int count = 0;
            try
            {
                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        count++;
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, $"Error code:{sqlEx.ErrorCode}",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return count;
        }

        public static int getHallID(string hall)
        {
            int hallID = -1;
            try
            {
                conn.Open();
                using (cmd = new SqlCommand("SELECT ID_Salla FROM Sallat WHERE Salla = @salla",conn))
                {
                    cmd.Parameters.AddWithValue("salla", hall);
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            hallID = int.Parse(reader[0].ToString());
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
                closeConnection(conn);
            }
            return hallID;
        }

        public static void checkListbox(ListBox lb, ComboBox oraPrej, ComboBox oraDeri, string dita, Button btn)
        {
            try
            {
                var lista = lb.Items.Cast<Tuple<string, string, string>>().ToList();

                foreach (var item in lista)
                {
                    if (item.Item1.ToString() == dita)
                    {
                        if ((((TimeSpan.Parse(oraPrej.Text) >= TimeSpan.Parse(item.Item3.ToString())) && (TimeSpan.Parse(oraPrej.Text) <= TimeSpan.Parse(item.Item2.ToString()))) || ((TimeSpan.Parse(oraDeri.Text) <= TimeSpan.Parse(item.Item3.ToString())))) || (TimeSpan.Parse(oraDeri.Text) >= TimeSpan.Parse(item.Item2.ToString())) && ((TimeSpan.Parse(oraPrej.Text) < TimeSpan.Parse(item.Item3.ToString())) && (TimeSpan.Parse(oraDeri.Text) >= TimeSpan.Parse(item.Item3.ToString()))))
                        {
                            btn.Enabled = false;
                        }else
                        {
                            btn.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string getProfAssFromCPL(int lenda, string profOrAss)
        {
            string name = "";
            try
            {
                conn.Open();

                using (cmd = new SqlCommand("SELECT CONCAT(T.Titulli,S.Emri,' ',S.Mbiemri) FROM CPL INNER JOIN Stafi AS S ON CPL.ID_Stafi = S.ID_Stafi INNER JOIN CPA AS C ON S.ID_CPA = C.ID_CPA INNER JOIN [Titujt Shkencor] AS T ON S.ID_Titulli = T.ID_Titulli WHERE C.CPA = @profAss AND CPL.ID_Lenda = @idLenda",conn))
                {
                    cmd.Parameters.AddWithValue("profAss", profOrAss);
                    cmd.Parameters.AddWithValue("idLenda", lenda);

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            name = reader[0].ToString();
                        }
                    }
                }

            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, $"Error code: {sqlEx.ErrorCode}",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                closeConnection(conn);
            }
            return name;
        }
    }
}
