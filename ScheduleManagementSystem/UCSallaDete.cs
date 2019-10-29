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
    public partial class UCSallaDete : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public UCSallaDete()
        {
            InitializeComponent();
            method.fill_combo("Sallat", cmbSalla);
        }

        private void btnFshirja_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Sallat WHERE ID_Salla=" + (int)cmbSalla.SelectedValue;
            SqlCommand cmd = new SqlCommand(query, conn);
            try
            {
                conn.Open();
                if (MessageBox.Show("Are you sure that you want to delete?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cmd = new SqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Executed succesfully");
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
        }
    }
}
