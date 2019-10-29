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
    public partial class UCDeleteFaculties : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;

        public UCDeleteFaculties()
        {
            InitializeComponent();
            fill_comboF();
        }
        public void fill_comboF()
        {
            string query = "SELECT f.ID_Fakulteti,Fakulteti AS fk FROM Fakultetet AS f";
            ds = new DataSet();
            try
            {
                da = new SqlDataAdapter(query, conn);
                da.Fill(ds, "Fakultetet");
                cmbFacultyD.DataSource = ds.Tables["Fakultetet"];
                cmbFacultyD.DisplayMember = "fk";
                cmbFacultyD.ValueMember = "ID_Fakulteti";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                conn.Close();
            }
        }
        private void UCDeleteFaculties_Load(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Fakultetet WHERE ID_Fakulteti=" + (int)cmbFacultyD.SelectedValue;

            try
            {
                conn.Open();
                if (MessageBox.Show("Are you sure that you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException x1)
            {
                MessageBox.Show("Error number: " + x1.ErrorCode + "\n" + x1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            fill_comboF();
        }
    }
}
