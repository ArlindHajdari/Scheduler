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

namespace ScheduleManagementSystem
{
    public partial class UCDepE : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader reader;
        public UCDepE()
        {
            InitializeComponent();
            method.fill_combo("Departamentet",cmbDepE);
            method.disableControlls(cmbFaculty,txtEmriD,btnEdit);
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            int Dep;
            bool isDep = int.TryParse(cmbDepE.SelectedValue.ToString(), out Dep);

            if (isDep)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("UPDATE Departamentet SET Dep=@txtEmriD, ID_Fakulteti=@cmbFaculty WHERE ID_Dep=@Dep", conn);
                    cmd.Parameters.AddWithValue("txtEmriD",txtEmriD.Text);
                    cmd.Parameters.AddWithValue("cmbFaculty",(int)cmbFaculty.SelectedValue);
                    cmd.Parameters.AddWithValue("Dep",Dep);

                    if (MessageBox.Show("The data has been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException exc1)
                {
                    MessageBox.Show("Error number " + exc1.ErrorCode + "\n" + exc1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            method.fill_combo("Departamentet", cmbDepE);
        }

        private void cmbDepE_SelectedIndexChanged(object sender, EventArgs e)
        {   
            if (method.enableOnIndexChange(cmbDepE, txtEmriD,btnEdit,cmbFaculty))
            {
                method.fillTextBoxes(txtEmriD,cmbDepE,"Departamentet","ID_Dep","Dep");

                try
                {
                    method.fill_combo("Fakultetet", cmbFaculty);

                    int fid;
                    bool parseOK = int.TryParse(cmbDepE.SelectedValue.ToString(), out fid);

                    conn.Open();

                    cmd = new SqlCommand($"SELECT f.Fakulteti FROM Fakultetet as f LEFT JOIN Departamentet as d ON f.ID_Fakulteti = d.ID_Fakulteti WHERE ID_Dep=@fid", conn);
                    cmd.Parameters.AddWithValue("fid", fid);

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbFaculty.Text = reader[0].ToString();
                    }
                }
                catch (SqlException ex1)
                {
                    MessageBox.Show(ex1.Message, "Error no." + ex1.ErrorCode, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }

            /*
            conn.Open();
            int fid;
            bool a = int.TryParse(cmbDepE.SelectedValue.ToString(), out fid);
            string query = "SELECT f.Fakulteti,d.ID_Dep,d.Dep FROM Fakultetet as f LEFT JOIN Departamentet as d ON f.ID_Fakulteti = d.ID_Fakulteti WHERE ID_Dep=" + fid;

            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader;

            try
            {
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    txtEmriD.Text = reader["Dep"].ToString();
                    cmbFaculty.Text = reader["Fakulteti"].ToString();
                }
            }
            catch (SqlException ex1)
            {
                MessageBox.Show(ex1.Message, "Error no." + ex1.ErrorCode);
            }
            finally
            {
                conn.Close();
            }
            */
        }
    }
}
