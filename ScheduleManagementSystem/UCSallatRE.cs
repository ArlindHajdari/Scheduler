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
    public partial class UCSallatRE : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        public UCSallatRE()
        {
            InitializeComponent();
            method.fill_combo("Llojet e Sallave", cmbLlojiSalles);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into Sallat(Salla,Kapaciteti,ID_LlojiSalles) values(@Salla,@Kapaciteti,@ID_LlojiSalles)", conn);

            cmd.Parameters.AddWithValue("@Salla", txtSalla.Text);
            cmd.Parameters.AddWithValue("@Kapaciteti", txtKapaciteti.Text);
            cmd.Parameters.AddWithValue("@ID_LlojiSalles", cmbLlojiSalles.SelectedValue);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("The data has been successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKapaciteti.Clear();
                txtSalla.Clear();
            }
            catch (SqlException ex)//if there is any exception(error)
            {
                // Show the errors details. 
                MessageBox.Show("There was an error accessing your data. DETAIL: " + ex.ToString(), "Error no." + ex.ErrorCode);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
