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
    public partial class UCStaffSubjectsModify : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        private int cplA, cplP, prof, assis;

        public UCStaffSubjectsModify()
        {
            InitializeComponent();
        }

        private void UCStaffSubjectsModify_Load(object sender, EventArgs e)
        {
            method.fill_combo(cmbSubject, "SELECT DISTINCT CPL.ID_Lenda, L.Lenda FROM Lendet AS L INNER JOIN CPL ON L.ID_Lenda = CPL.ID_Lenda");
            method.disableControlls(cmbProf, cmbAss);
        }

        private void btnModifySS_Click(object sender, EventArgs e)
        {
            if (cmbSubject.Text != "Select..." && cmbProf.Text != "Select..." && cmbAss.Text != "Select...")
            {
                int lenda;
                bool fresult, sresult;

                try
                {
                    conn.Open();

                    lenda = method.getSubjectID(cmbSubject.Text);
                    
                    bool isProf = int.TryParse(cmbProf.SelectedValue.ToString(), out prof);
                    bool isAssis = int.TryParse(cmbAss.SelectedValue.ToString(), out assis);

                    using (cmd = new SqlCommand("UPDATE CPL SET ID_Stafi = @prof, ID_Lenda = @lenda WHERE ID_CPL = @cpl", conn))
                    {
                        cmd.Parameters.AddWithValue("prof", prof);
                        cmd.Parameters.AddWithValue("lenda", lenda);
                        cmd.Parameters.AddWithValue("cpl", cplP);

                        fresult = cmd.ExecuteNonQuery() > 0;
                    }

                    using (cmd = new SqlCommand("UPDATE CPL SET ID_Stafi = @assis,ID_Lenda = @lenda WHERE ID_CPL = @cpl", conn))
                    {
                        cmd.Parameters.AddWithValue("assis", assis);
                        cmd.Parameters.AddWithValue("lenda", lenda);
                        cmd.Parameters.AddWithValue("cpl", cplA);

                        sresult = cmd.ExecuteNonQuery() > 0;
                    }

                    if (fresult && sresult)
                    {
                        if (MessageBox.Show("The data has been updated successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            method.fill_combo(cmbSubject, "SELECT DISTINCT CPL.ID_Lenda,L.Lenda FROM Lendet AS L INNER JOIN CPL ON L.ID_Lenda = CPL.ID_Lenda");
                            method.disableControlls(cmbProf, cmbAss);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Something went wrong while updating the data!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }

        private void cmbSubject_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int lenda;

            if (method.enableOnIndexChange(cmbSubject, cmbProf, cmbAss))
            {
                try
                {
                    lenda = method.getSubjectID(cmbSubject.Text);

                    string[] procParams = { "Teacher" };

                    method.fill_combo(cmbProf, "sp_getProfAss", procParams, "Professor");
                    method.fill_combo(cmbAss, "sp_getProfAss", procParams, "Assistent");

                    cmbProf.Text = method.getProfAssFromCPL(lenda, "Professor");
                    cmbAss.Text = method.getProfAssFromCPL(lenda, "Assistent");

                    bool isProf = int.TryParse(cmbProf.SelectedValue.ToString(), out prof);
                    bool isAssis = int.TryParse(cmbAss.SelectedValue.ToString(), out assis);

                    cplP = method.getCPL(prof, lenda);
                    cplA = method.getCPL(assis, lenda);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
    }
}
