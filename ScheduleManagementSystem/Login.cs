using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ScheduleManagementSystem
{
    public partial class Login : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        DataTable dt;
        SqlDataAdapter da;
        Form1 parentForm = (Form1)Application.OpenForms["Form1"];
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            txtUsername.Select();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnLogin.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text != "" && txtUsername.Text != "")
            {
                string escapedUsername = txtUsername.Text.Replace("'", "");
                string escapedPassword = txtPassword.Text.Replace("'", "");

                dt = new DataTable();
                try
                {   
                    da = new SqlDataAdapter("SELECT * FROM Stafi WHERE ID_LOG=@escapedUsername AND Fjalekalimi=@escapedPassword", conn);
                    da.SelectCommand.Parameters.AddWithValue("escapedUsername", escapedUsername);
                    da.SelectCommand.Parameters.AddWithValue("escapedPassword", escapedPassword);

                    da.Fill(dt);

                    if (dt.Rows.Count != 0)
                    {
                        parentForm.loginToolStripMenuItem.Text = "Logout";
                        if (dt.Rows[0][11].ToString().ToLower() == "admin")
                        {
                            Log.id = (int)dt.Rows[0][0];
                            parentForm.ToolStripMenuItem.Enabled = true;
                            parentForm.ToolStripItems.Enabled = true;
                            parentForm.SearchToolStrip.Enabled = true;
                            Log.role = "Admin";
                            Log.name = dt.Rows[0][1].ToString();
                            Log.surname = dt.Rows[0][2].ToString();
                            parentForm.panel1.Visible = true;
                            parentForm.panel1.Controls.Clear();
                            WelcomePage wp = new WelcomePage();
                            parentForm.panel1.Controls.Add(wp);
                            parentForm.mainToolStripMenuItem.Enabled = true;
                            parentForm.btnLogOut.Visible = true;
                            parentForm.btnLogOut.Enabled = true;
                            parentForm.administratorToolStripMenuItem.Enabled = true;
                            parentForm.teacherToolStripMenuItem.Enabled = true;
                            parentForm.studentToolStripMenuItem.Enabled = true;
                        }
                        else if (dt.Rows[0][11].ToString().ToLower() == "user")
                        {
                            Log.id = (int)dt.Rows[0][0];
                            parentForm.ToolStripMenuItem.Enabled = false;
                            parentForm.SearchToolStrip.Enabled = false;
                            Log.role = "User";
                            Log.name = dt.Rows[0][1].ToString();
                            Log.surname = dt.Rows[0][2].ToString();
                            parentForm.panel1.Visible = true;
                            parentForm.panel1.Controls.Clear();
                            WelcomePage wp = new WelcomePage();
                            parentForm.panel1.Controls.Add(wp);
                            //parentForm.Color_White();
                            parentForm.mainToolStripMenuItem.Enabled = true;
                            parentForm.btnLogOut.Visible = true;
                            parentForm.btnLogOut.Enabled = true;
                            parentForm.btnChangePassword.Visible = true;
                            parentForm.btnChangePassword.Enabled = true;
                            parentForm.btnAvailability.Visible = true;
                            parentForm.btnAvailability.Enabled = true;
                            parentForm.administratorToolStripMenuItem.Enabled = false;
                            parentForm.teacherToolStripMenuItem.Enabled = true;
                            parentForm.studentToolStripMenuItem.Enabled = false;
                        }
                        method.decreaseFormSize();
                        MessageBox.Show("You have been successfully logged into our system!", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Please type the right informations!", "Login Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtPassword.Clear();
                        txtUsername.Clear();
                    }
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex2)
                {
                    MessageBox.Show(ex2.Message, "Error in " + ex2.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    method.closeConnection(conn);
                }
            }
            else
            {
                MessageBox.Show("Please fill out both fields!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            method.onlyNumbers(txtUsername);
        }
    }
}
