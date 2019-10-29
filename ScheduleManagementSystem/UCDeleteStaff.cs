using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace ScheduleManagementSystem
{
    public partial class UCDeleteStaff : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt;
        SqlDataReader reader;
        public UCDeleteStaff()
        {
            InitializeComponent();
            //fill_comboD();
            method.fill_combo("Stafi", cmbStaffD, "ID_Stafi, (Emri + ' ' + Mbiemri) AS [Emri_Mbiemri]", "WHERE Roli <> 'Admin'");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                bool isID = int.TryParse(cmbStaffD.SelectedValue.ToString(), out id);
                conn.Open();
                if (MessageBox.Show("Are you sure that you want to delete?","Delete",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("DELETE FROM Stafi WHERE ID_Stafi=@id", conn);
                    cmd.Parameters.AddWithValue("id", id);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        if (MessageBox.Show("Data deleted successfully!","Information",MessageBoxButtons.OK,MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            method.fill_combo("Stafi", cmbStaffD, "ID_Stafi, (Emri + ' ' + Mbiemri) AS [Emri_Mbiemri]", "WHERE Roli <> 'Admin'");
                            pbProf.Image = null;
                        }   
                    }
                }
            }
            catch (SqlException x1)
            {
                MessageBox.Show(x1.Message,$"Error code:{x1.ErrorCode}",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                method.closeConnection(conn);
            }
        }
        public void fill_comboD()
        {
            dt = new DataTable();
            try
            {
                da = new SqlDataAdapter("SELECT S.ID_Stafi, (S.Emri + ' ' + S.Mbiemri) AS [Emri_Mbiemri] FROM Stafi AS S WHERE Roli <> 'Admin'", conn);
                da.Fill(dt);

                DataRow row = dt.NewRow();

                row[dt.Columns[0].ToString()] = DBNull.Value;
                row[dt.Columns[1].ToString()] = "Select...";

                dt.Rows.InsertAt(row, 0);

                cmbStaffD.DataSource = dt;
                cmbStaffD.DisplayMember = "Emri_Mbiemri";
                cmbStaffD.ValueMember = "ID_Stafi";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                method.closeConnection(conn);
            }
        }

        private void cmbStaffD_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbStaffD.Text == "Select...")
            {
                pbProf.Image = null;
            }

            int idS;
            try
            {
                bool isIDS = int.TryParse(cmbStaffD.SelectedValue.ToString(), out idS);
                if (isIDS)
                {
                    conn.Open();

                    using (cmd = new SqlCommand("SELECT Foto FROM Stafi WHERE ID_Stafi=@id", conn))
                    {
                        cmd.Parameters.AddWithValue("id", idS);

                        using (reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MemoryStream ms = new MemoryStream((byte[])reader["Foto"]);
                                pbProf.Image = new Bitmap(ms);
                            }
                        }
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
            finally
            {
                method.closeConnection(conn);
            }
        }
    }
}
