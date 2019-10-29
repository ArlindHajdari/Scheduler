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
    public partial class UCSubjectE : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader reader;
        ToolTip T1;
        public UCSubjectE()
        {
            InitializeComponent();
        }

        private void cmbSubjectM_SelectedIndexChanged(object sender, EventArgs e)
        {
            int sid;

            if (method.enableOnIndexChange(cmbSubjectM, cmbTypeS,txtECTSM,txtNameS,txtSemesterM,btnEdit))
            {
                try
                {
                    method.fill_combo("Lloji i Lendeve", cmbTypeS);

                    conn.Open();

                    bool isConverted = int.TryParse(cmbSubjectM.SelectedValue.ToString(), out sid);

                    if (isConverted)
                    {
                        cmd = new SqlCommand("SELECT L.Lenda, L.Kredite, L.Semestri, Ll.LlojiL FROM Lendet AS L LEFT JOIN [Lloji i Lendeve] AS Ll ON L.ID_LlojiLendes = Ll.ID_LlojiLendes WHERE ID_Lenda=@sid", conn);
                        cmd.Parameters.AddWithValue("sid", sid);

                        reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            txtNameS.Text = reader["Lenda"].ToString();
                            txtECTSM.Text = reader["Kredite"].ToString();
                            txtSemesterM.Text = reader["Semestri"].ToString();
                            cmbTypeS.Text = reader["LlojiL"].ToString();
                        }
                    }
                }catch (SqlException ex1)
                {
                    MessageBox.Show(ex1.Message, $"Error no.{ex1.ErrorCode}", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int type, Subject;

            try
            {
                bool isType = int.TryParse(cmbTypeS.SelectedValue.ToString(), out type);
                bool isSubject = int.TryParse(cmbSubjectM.SelectedValue.ToString(), out Subject);

                if (isType && isSubject)
                {
                    conn.Open();

                    cmd = new SqlCommand("UPDATE Lendet SET Lenda=@txtNameS, Kredite=@txtECTSM, Semestri=@txtSemesterM, ID_LlojiLendes=@llojiL WHERE ID_Lenda=@Subject", conn);
                    cmd.Parameters.AddWithValue("txtNameS", txtNameS.Text);
                    cmd.Parameters.AddWithValue("txtECTSM", txtECTSM.Text);
                    cmd.Parameters.AddWithValue("txtSemesterM", txtSemesterM.Text);
                    cmd.Parameters.AddWithValue("Subject", Subject);
                    cmd.Parameters.AddWithValue("llojiL",type);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("The data has been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }catch (SqlException exc1)
            {
                MessageBox.Show($"Error number {exc1.ErrorCode} \n {exc1.Message}","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } finally
            {
                conn.Close();
            }
            method.fill_combo("Lendet", cmbSubjectM);
        }

        private void cmbSubjectM_MouseHover(object sender, EventArgs e)
        {
            T1 = new ToolTip();
            T1.ToolTipIcon = ToolTipIcon.Info;
            T1.Show("Select the subject to edit!", cmbSubjectM);
        }

        private void UCSubjectE_Load(object sender, EventArgs e)
        {
            method.fill_combo("Lendet", cmbSubjectM);
            method.disableControlls(cmbTypeS, txtECTSM, txtNameS, txtSemesterM, btnEdit);
        }
    }
}
