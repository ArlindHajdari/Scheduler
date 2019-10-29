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
    public partial class UCTitleS : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        public UCTitleS()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                cmd = new SqlCommand("INSERT INTO [Titujt Shkencor](Titulli) VALUES(@txttitleR)", conn);
                cmd.Parameters.AddWithValue("txttitleR",txtTitleR.Text);
                
                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Data successfully inserted into database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
                txtTitleR.Clear();
            }
            catch (SqlException x2)
            {
                MessageBox.Show($"Error number: {x2.ErrorCode}\n {x2.Message}","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
