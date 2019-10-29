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
    public partial class UCDeleteTitles : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        public UCDeleteTitles()
        {
            InitializeComponent();
            method.fill_combo("Titujt Shkencor",cmbTitleD);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM [Titujt Shkencor] WHERE ID_Titulli=" + (int)cmbTitleD.SelectedValue;

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
            method.fill_combo("Titujt Shkencor", cmbTitleD);
        }
    }
}
