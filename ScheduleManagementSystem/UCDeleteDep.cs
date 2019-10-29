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
    public partial class UCDeleteDep : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        public UCDeleteDep()
        {
            InitializeComponent();
            //fill_combo1();
            method.fill_combo("Departamentet", cmbDepD);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (MessageBox.Show("Are you sure that you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand("DELETE FROM Departamentet WHERE ID_Dep=@id", conn);
                    cmd.Parameters.AddWithValue("id", (int)cmbDepD.SelectedValue);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("Data deleted successfully!","Successed",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
            //fill_combo1();
            method.fill_combo("Departamentet",cmbDepD);
        }
        public void fill_combo1()
        {
            string query = "SELECT * FROM Departamentet AS D";
            ds = new DataSet();
            try
            {
                da = new SqlDataAdapter(query, conn);
                da.Fill(ds, "Departamentet");
                cmbDepD.DataSource = ds.Tables["Departamentet"];
                cmbDepD.DisplayMember = "Dep";
                cmbDepD.ValueMember = "ID_Dep";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
