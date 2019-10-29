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
    public partial class UCTipiEdit : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        public UCTipiEdit()
        {
            InitializeComponent();
            method.fill_combo("Llojet e Sallave", cmbLlojiSalles);
            method.disableControlls(txtSalla,btnEdit);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int ID_LlojiSalles;
            
            try
            {   
                conn.Open();

                bool isSalla = int.TryParse(cmbLlojiSalles.SelectedValue.ToString(), out ID_LlojiSalles);
                if (isSalla)
                {
                    cmd = new SqlCommand("UPDATE [Llojet e Sallave] SET Llloji=@lloji WHERE ID_LlojiSalles=@id", conn);
                    cmd.Parameters.AddWithValue("lloji", txtSalla.Text);
                    cmd.Parameters.AddWithValue("id", cmbLlojiSalles.SelectedIndex);

                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("The data has been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }catch (SqlException exc1)
            {
                MessageBox.Show("Error number " + exc1.ErrorCode + "\n" + exc1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
            method.fill_combo("Llojet e Sallave", cmbLlojiSalles);
        }

        private void cmbLlojiSalles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (method.enableOnIndexChange(cmbLlojiSalles, txtSalla,btnEdit))
            {
                method.fillTextBoxes(txtSalla, cmbLlojiSalles, "Llojet e Sallave", "ID_LlojiSalles", "LlojiS");
            }
        }
    }
}
