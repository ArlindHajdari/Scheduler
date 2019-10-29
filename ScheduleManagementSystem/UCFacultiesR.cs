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
    public partial class UCFacultiesR : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        
            
        public UCFacultiesR()
        {
            InitializeComponent();
        }

        private void btnRegisterR_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Fakultetet(Fakulteti) values(@fk)", conn);

            cmd.Parameters.AddWithValue("@fk", txtEmriF.Text);
            
            try
            {
                conn.Open();
                
                if (MessageBox.Show("The data has been successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    txtEmriF.Text = "";
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("There was an error accessing your data. DETAIL: " + ex.ToString(), "Error no." + ex.ErrorCode);
            }
            finally
            {
                conn.Close();
            }

        }

       
    }
}
