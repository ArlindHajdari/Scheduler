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
    public partial class UCChangePassword : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader reader;
        Form1 parentForm = (Form1)Application.OpenForms["Form1"];
        public UCChangePassword()
        {
            InitializeComponent();
        }

        private void txtOldPassword_Validating(object sender, CancelEventArgs e)
        {
            try
            {   
                conn.Open();
                using (cmd = new SqlCommand("SELECT Fjalekalimi FROM Stafi WHERE ID_Stafi = @stafi" ,conn))
                {
                    cmd.Parameters.AddWithValue("stafi", Log.id);
                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader[0].ToString() == txtOldPassword.Text)
                            {
                                tick.SetError(txtOldPassword, "Correct!");
                                error.SetError(txtOldPassword, "");
                            }else
                            {
                                tick.SetError(txtOldPassword, "");
                                error.SetError(txtOldPassword, "Wrong password typed!");
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                method.closeConnection(conn);
            }
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtNewPassword.Text.Equals(txtConfirmPassword.Text))
                {
                    method.checkPassword(txtConfirmPassword, error, tick);
                }
                else
                {
                    error.SetError(txtConfirmPassword, "Passwords must match!");
                    tick.SetError(txtConfirmPassword, "");
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {   
            try
            {
                if (method.IsValid(error))
                {
                    conn.Open();

                    using (cmd = new SqlCommand("UPDATE Stafi SET Fjalekalimi = @fjalekalimi WHERE ID_Stafi = @id",conn))
                    {
                        cmd.Parameters.AddWithValue("fjalekalimi", txtConfirmPassword.Text);
                        cmd.Parameters.AddWithValue("id", Log.id);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            parentForm.panel1.Visible = true;
                            parentForm.panel1.Controls.Clear();
                            WelcomePage wp = new WelcomePage();
                            wp.Show();
                            parentForm.panel1.Controls.Add(wp);
                            MessageBox.Show("You have successfully changed your password","Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }else
                        {
                            MessageBox.Show("Password couldn't be changed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("All fields must be filled with the right information!", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                method.closeConnection(conn);
            }
        }

        private void UCChangePassword_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Welcome {Log.name} {Log.surname}";
        }

        private void txtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            method.checkPassword(txtNewPassword, error, tick);
        }
    }
}
