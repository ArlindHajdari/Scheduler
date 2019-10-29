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
    public partial class UCSubjectR : UserControl
    {
        UserControlRegjistrimi UCR = new UserControlRegjistrimi();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        public UCSubjectR()
        {
            InitializeComponent();
            method.fill_combo("Lloji i Lendeve",cmbTypeR);
            method.fill_combo("Departamentet", cmbDep);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                using (cmd = new SqlCommand("sp_InsertSubject", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("lenda", txtSubjectR.Text);
                    cmd.Parameters.AddWithValue("ECTS", txtECTSR.Text);
                    cmd.Parameters.AddWithValue("Semester", txtSemesterR.Text);
                    cmd.Parameters.AddWithValue("type", cmbTypeR.SelectedValue);
                    cmd.Parameters.AddWithValue("dep", cmbDep.SelectedValue);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("The data has been successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("The data couldn't added to database!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }                
            }
            catch (SqlException ex)//if there is any exception(error)
            {
                // Show the errors details. 
                MessageBox.Show("There was an error accessing your data. DETAIL: " + ex.Message, "Error no." + ex.ErrorCode);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
