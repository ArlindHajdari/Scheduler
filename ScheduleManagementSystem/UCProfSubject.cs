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
    public partial class UCProfSubject : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        public UCProfSubject()
        {
            InitializeComponent();
        }

        private void UCProfSubject_Load(object sender, EventArgs e)
        {
            string[] procParams = {"teacher"};
            method.fill_combo(cmbProf, "sp_getProfAss", procParams, "Professor");
            method.fill_combo(cmbAssistent, "sp_getProfAss", procParams, "Assistent");
            method.fill_combo("Lendet", cmbSubject, "ID_Lenda,Lenda", "WHERE ID_Lenda NOT IN (SELECT ID_Lenda FROM CPL)");
        }

        private void btnAddTS_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                if (cmbAssistent.Text != "Select..." && cmbProf.Text != "Select..." && cmbSubject.Text != "Select...")
                {
                    bool prof, assis;

                    using (cmd = new SqlCommand("INSERT INTO CPL VALUES(@idstafi, @idlenda)",conn))
                    {
                        cmd.Parameters.AddWithValue("idstafi", cmbProf.SelectedValue);
                        cmd.Parameters.AddWithValue("idlenda", cmbSubject.SelectedValue);
                        prof = cmd.ExecuteNonQuery() > 0;
                    }

                    using (cmd = new SqlCommand("INSERT INTO CPL VALUES(@idstafi, @idlenda)",conn))
                    {
                        cmd.Parameters.AddWithValue("idstafi", cmbAssistent.SelectedValue);
                        cmd.Parameters.AddWithValue("idlenda", cmbSubject.SelectedValue);

                        assis = cmd.ExecuteNonQuery() > 0;
                    }

                    if (prof && assis)
                    {
                        if (MessageBox.Show("The data has been successfully inserted!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            UCProfSubject_Load(sender, e);
                        }
                    }
                }else
                {
                    MessageBox.Show("Please fill out all fields!","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show(sqlEx.Message, $"Error code.{sqlEx.ErrorCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
