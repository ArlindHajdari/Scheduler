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
    public partial class UCSallaEditimi : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader reader;
        public UCSallaEditimi()
        {
            InitializeComponent();
            method.fill_combo("Sallat", cmbSalla);
            method.disableControlls(cmbLlojiSalles,txtKapaciteti,btnEdit);
        }
        private void cmbSalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (method.enableOnIndexChange(cmbSalla, cmbLlojiSalles, txtKapaciteti))
            {
                int fid;
                
                try
                {
                    method.fillTextBoxes(txtKapaciteti, cmbSalla, "Sallat", "ID_Salla", "Kapaciteti");
                    method.fill_combo("Llojet e Sallave", cmbLlojiSalles);

                    conn.Open();

                    bool a = int.TryParse(cmbSalla.SelectedValue.ToString(), out fid);

                    cmd = new SqlCommand("SELECT s.Salla,s.Kapaciteti,L.LlojiS FROM Sallat AS s INNER JOIN [Llojet e Sallave] as L ON s.ID_LlojiSalles=L.ID_LlojiSalles WHERE ID_Salla=@id", conn);
                    cmd.Parameters.AddWithValue("id", fid);

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtKapaciteti.Text = reader["Kapaciteti"].ToString();
                            cmbLlojiSalles.Text = reader["LlojiS"].ToString();
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error no. " + ex.ErrorCode, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int Salla, LlojiSalles;

            try
            {
                conn.Open();
                bool isSalla = int.TryParse(cmbSalla.SelectedValue.ToString(), out Salla);
                bool isLlojiSalles = int.TryParse(cmbLlojiSalles.SelectedValue.ToString(), out LlojiSalles);

                if (isSalla && isLlojiSalles)
                {
                    cmd = new SqlCommand("UPDATE Sallat SET Kapaciteti=@txtKapaciteti, ID_LlojiSalles=@LlojiSalles WHERE ID_Salla=@Salla", conn);
                    cmd.Parameters.AddWithValue("txtKapaciteti", txtKapaciteti.Text);
                    cmd.Parameters.AddWithValue("LlojiSalles", LlojiSalles);
                    cmd.Parameters.AddWithValue("Salla", Salla);
                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("The data has been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message, $"Error no.{sqlex.ErrorCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
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