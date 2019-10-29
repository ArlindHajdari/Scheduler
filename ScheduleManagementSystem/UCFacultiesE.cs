using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ScheduleManagementSystem
{
    public partial class UCFacultiesE : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;

        public UCFacultiesE()
        {
            InitializeComponent();
            method.fill_combo("Fakultetet", cmbFakultetiE);
            method.disableControlls(txtEmriE, btnEdit);
        }

        private void cmbFakultetiE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (method.enableOnIndexChange(cmbFakultetiE, txtEmriE, btnEdit))
            {
                method.fillTextBoxes(txtEmriE, cmbFakultetiE, "Fakultetet", "ID_Fakulteti", "Fakulteti");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int Fk = 1;
            bool isFk = int.TryParse(cmbFakultetiE.SelectedValue.ToString(), out Fk);
            if (isFk)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("UPDATE Fakultetet SET Fakulteti=@fakulteti WHERE ID_Fakulteti=@id", conn);
                    cmd.Parameters.AddWithValue("fakulteti", txtEmriE.Text);
                    cmd.Parameters.AddWithValue("id", Fk);

                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("The data has been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException exc1)
                {
                    MessageBox.Show($"Error number {exc1.ErrorCode}\n {exc1.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBox.Show($"{ex.Message}","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            method.fill_combo("Fakultetet", cmbFakultetiE);
        }

        private void UCFacultiesE_Load(object sender, EventArgs e)
        {
            //method.fill_combo("Fakultetet", cmbFakultetiE);
        }
    }
}
