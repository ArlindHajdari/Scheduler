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
    public partial class UCDepR : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlDataAdapter da;
        DataSet ds;
        public UCDepR()
        {
            InitializeComponent();
            fill_combo("Fakultetet", cmbFac);
        }

        public void fill_combo(string table, ComboBox cmb)
        {

            ds = new DataSet();
            da = new SqlDataAdapter("select * from [" + table + "]", conn);

            da.Fill(ds, "[" + table + "]");
            cmb.DataSource = ds.Tables["[" + table + "]"];
            cmb.ValueMember = ds.Tables["[" + table + "]"].Columns[0].ToString();
            cmb.DisplayMember = ds.Tables["[" + table + "]"].Columns[1].ToString();
        }

        private void btnRegisterD_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Departamentet(Dep,ID_Fakulteti) VALUES(@dp,@fk)", conn);

            cmd.Parameters.AddWithValue("@dp", txtEmriD.Text);
            cmd.Parameters.AddWithValue("@fk", cmbFac.SelectedValue);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                if (MessageBox.Show("The data has been successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    txtEmriD.Text = "";
                }

            }
            catch (SqlException ex)
            {
                MessageBox.Show("There was an error accessing your data. DETAIL: " + ex.ToString(), "Error no." + ex.ErrorCode);

            }
            finally
            {
                conn.Close();
            }
        }
    }
}
