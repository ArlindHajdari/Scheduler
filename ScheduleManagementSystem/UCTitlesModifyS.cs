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
    public partial class UCTitlesModifyS : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        public UCTitlesModifyS()
        {
            InitializeComponent();
            method.fill_combo("Titujt Shkencor",cmbTitleS);
            method.disableControlls(txtTitleM,btnModifyT);
        }

        private void cmbTitleS_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (method.enableOnIndexChange(cmbTitleS, txtTitleM, btnModifyT))
            {
                method.fillTextBoxes(txtTitleM, cmbTitleS, "Titujt Shkencor", "ID_Titulli", "Titulli");
            }
            
            /*
            int fid;
            bool a = int.TryParse(cmbTitleS.SelectedValue.ToString(), out fid);

            if (a)
            {
                try
                {
                    conn.Open();

                    cmd = new SqlCommand("SELECT Titulli FROM [Titujt SHkencor] WHERE ID_Titulli=@fid", conn);
                    cmd.Parameters.AddWithValue("fid", fid);

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            txtTitleM.Text = reader["Titulli"].ToString();
                        }
                    }

                }
                catch (SqlException ex1)
                {
                    MessageBox.Show(ex1.Message, "Error no." + ex1.ErrorCode);
                }
                finally
                {
                    conn.Close();
                }
            }else
            {
                MessageBox.Show("Couldn't convert to int(ID)","Error converting",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            */
        }

        private void btnModifyT_Click(object sender, EventArgs e)
        {
            int Titulli;
            bool isTitulli = int.TryParse(cmbTitleS.SelectedValue.ToString(), out Titulli);
            
            if (isTitulli)
            {
                try
                {
                    conn.Open();
                    cmd = new SqlCommand("UPDATE [Titujt Shkencor] SET Titulli=@title WHERE ID_Titulli=@id", conn);
                    cmd.Parameters.AddWithValue("title", txtTitleM.Text);
                    cmd.Parameters.AddWithValue("id",Titulli);

                    if (cmd.ExecuteNonQuery() != 0)
                    {
                        MessageBox.Show("The data has been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (SqlException exc1)
                {
                    MessageBox.Show("Error number " + exc1.ErrorCode + "\n" + exc1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            method.fill_combo("Titujt Shkencor", cmbTitleS);
        }
    }
}
