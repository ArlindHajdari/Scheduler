using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace ScheduleManagementSystem
{
    public partial class UserControlEditimi : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        ToolTip T1;
        SqlCommand cmd;
        SqlDataReader reader;
        public UserControlEditimi()
        {
            InitializeComponent();
        }
        private void cmbProfesorE_MouseHover(object sender, EventArgs e)
        {
            T1 = new ToolTip();
            T1.ToolTipIcon = ToolTipIcon.Info;
            T1.Show("Select the professor to edit!",cmbProfesorE);
        }
        public void fillContent()
        {
            if (method.enableOnIndexChange(cmbProfesorE, cmbTitulliE, cmbProfesor, txtEmail, txtEmriE, txtMbiemriE, txtPersona_no, txtPwd, btnEdit, btnBrowse, pictureBox1))
            {
                try
                {
                    method.fill_combo("CPA", cmbProfesor);
                    method.fill_combo("Titujt Shkencor", cmbTitulliE);

                    int fid;
                    bool parseOK = int.TryParse(cmbProfesorE.SelectedValue.ToString(), out fid);

                    conn.Open();

                    cmd = new SqlCommand("SELECT S.Emri, S.Mbiemri, S.Numri_Personal, S.Foto, S.Foto_Emri ,S.Fjalekalimi,S.Email, T.ID_Titulli, T.Titulli, C.ID_CPA, C.CPA FROM Stafi AS S LEFT JOIN [Titujt Shkencor] AS T ON S.ID_Titulli=T.ID_Titulli LEFT JOIN CPA AS C ON S.ID_CPA=C.ID_CPA WHERE ID_Stafi=@fid", conn);
                    cmd.Parameters.AddWithValue("fid", fid);

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        txtEmriE.Text = reader["Emri"].ToString();
                        txtMbiemriE.Text = reader["Mbiemri"].ToString();
                        txtPersona_no.Text = reader["Numri_Personal"].ToString();
                        txtPwd.Text = reader["Fjalekalimi"].ToString();
                        txtEmail.Text = reader["Email"].ToString();
                        cmbTitulliE.Text = reader["Titulli"].ToString();
                        cmbProfesor.Text = reader["CPA"].ToString();
                        MemoryStream ms = new MemoryStream((byte[])reader["Foto"]);
                        pictureBox1.Image = new Bitmap(ms);
                        pictureBox1.Tag = reader["Foto_Emri"].ToString();
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                    }
                }
                catch (SqlException ex1)
                {
                    MessageBox.Show(ex1.Message, "Error no." + ex1.ErrorCode, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                finally
                {
                    method.closeConnection(conn);
                }
            }
        }

        private void cmbProfesorE_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            fillContent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                int Profesori, Titulli, Stafi;
                bool isProfesori = int.TryParse(cmbProfesor.SelectedValue.ToString(), out Profesori);
                bool isTitulli = int.TryParse(cmbTitulliE.SelectedValue.ToString(), out Titulli);
                bool isStafi = int.TryParse(cmbProfesorE.SelectedValue.ToString(), out Stafi);

                Image img = pictureBox1.Image;
                string st = pictureBox1.Tag.ToString();
                byte[] img_content = method.ImageToByteArr(img);

                if (isProfesori && isTitulli && isStafi)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Stafi SET Emri = @emri, Mbiemri = @mbiemri, ID_Titulli = @titulli, " +
                    "ID_CPA=@cpa, Numri_Personal=@numri_p, Foto=@img_content,Foto_Emri=@img,Fjalekalimi=@fjalekalimi, Email=@email WHERE ID_Stafi=@stafi", conn);
                    cmd.Parameters.AddWithValue("emri", txtEmriE.Text);
                    cmd.Parameters.AddWithValue("mbiemri", txtMbiemriE.Text);
                    cmd.Parameters.AddWithValue("titulli", Titulli);
                    cmd.Parameters.AddWithValue("cpa", Profesori);
                    cmd.Parameters.AddWithValue("numri_p", txtPersona_no.Text);
                    cmd.Parameters.AddWithValue("img_content", img_content);
                    cmd.Parameters.AddWithValue("img", st);
                    cmd.Parameters.AddWithValue("fjalekalimi", txtPwd.Text);
                    cmd.Parameters.AddWithValue("email", txtEmail.Text);
                    cmd.Parameters.AddWithValue("stafi", Stafi);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        if (MessageBox.Show("The data has been successfully updated!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            method.fill_combo("Stafi", cmbProfesorE, "ID_Stafi, (Emri + ' ' + Mbiemri) AS Emri_Mbiemri");
                        }
                    }
                }
            }
            catch(SqlException exc1)
            {
                MessageBox.Show($"Error number {exc1.ErrorCode}\n {exc1.Message}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            catch(Exception exc2)
            {
                MessageBox.Show(exc2.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                method.closeConnection(conn);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            method.openDialogImage(pictureBox1);
        }

        private void UserControlEditimi_Load(object sender, EventArgs e)
        {
            method.fill_combo("Stafi", cmbProfesorE, "ID_Stafi, (Emri + ' ' + Mbiemri) AS Emri_Mbiemri");
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            method.checkPassword(txtPwd, error, tick);
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            method.checkEmail(txtEmail, error, tick);
        }

        private void txtEmriE_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            method.Check_nameReg(txtEmriE, "Name", error, tick);
        }

        private void txtMbiemriE_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            method.Check_nameReg(txtMbiemriE, "Surname", error, tick);
        }
    }
}
