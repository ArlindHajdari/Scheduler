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

    public partial class Search : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        //Atribut i klases Data.SqlClient per marrjen e te dhenave nga databaza si tabele.
        SqlDataAdapter sda;
        SqlCommand cmd;
        DataTable dt;

        public Search()
        {
            InitializeComponent();
        }

        //Nese shtypet tasti Enter atehere kliko butonin btnSearch.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                btnSearch.PerformClick();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Nese klikohet butoni btnSearch atehere shfaq te dhena per perdoruesin e dhene ne TextBox-in txtInfo
        private void btnSearch_Click(object sender, EventArgs e)
        {
            dt = new DataTable();
            sda = new SqlDataAdapter();
            cmd = new SqlCommand("SP_searchEmployee", conn);
            cmd.Parameters.AddWithValue("@emri", txtInfo.Text);
            cmd.CommandType = CommandType.StoredProcedure;
            sda.SelectCommand = cmd;
            sda.Fill(dt);
            DGVInfos.AllowUserToResizeColumns = false;
            DGVInfos.AllowUserToResizeRows = false;
            DGVInfos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVInfos.DataSource = dt;
            DGVInfos.AutoResizeColumns();
        }
    }
}
