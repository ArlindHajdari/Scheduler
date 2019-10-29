using System;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ScheduleManagementSystem
{
    public partial class UserControlRegjistrimi : UserControl
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        public UserControlRegjistrimi()
        {
            InitializeComponent();
            method.fill_combo("Titujt Shkencor", cmbTitulliR);
            method.fill_combo("CPA", cmbProfesorR);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbTitulliR.Text != "Select..." && cmbProfesorR.Text != "Select...")
            {
                if (method.IsValid(error))
                {
                    try
                    {
                        conn.Open();
                        Image img = pImage.Image;
                        byte[] img_content = method.ImageToByteArr(img);

                        cmd = new SqlCommand("INSERT INTO Stafi(Emri,Mbiemri,ID_Titulli,ID_CPA, Numri_Personal, Foto, Foto_Emri,Fjalekalimi,Email) VALUES(@name,@surname,@title,@cpa,@num,@foto,@foto_emri,@fjalekalimi,@email)", conn);
                        SqlParameter picParameter = new SqlParameter();

                        picParameter.SqlDbType = SqlDbType.Image;
                        picParameter.ParameterName = "foto";
                        picParameter.Value = img_content;
                        cmd.Parameters.AddWithValue("name", txtEmriR.Text);
                        cmd.Parameters.AddWithValue("surname", txtMbiemriR.Text);
                        cmd.Parameters.AddWithValue("title", cmbTitulliR.SelectedValue);
                        cmd.Parameters.AddWithValue("cpa", cmbProfesorR.SelectedValue);
                        cmd.Parameters.AddWithValue("num", txtPersonal_no.Text);
                        cmd.Parameters.Add(picParameter);
                        cmd.Parameters.AddWithValue("foto_emri", pImage.Tag.ToString());
                        cmd.Parameters.AddWithValue("fjalekalimi", txtPwd.Text);
                        cmd.Parameters.AddWithValue("email", txtEmail.Text);

                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            if (MessageBox.Show("The data has been successfully added!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            {
                                method.resetTxt(txtEmail, txtEmriR, txtMbiemriR, txtPersonal_no, txtPwd);
                                method.fill_combo("Titujt Shkencor", cmbTitulliR);
                                method.fill_combo("CPA", cmbProfesorR);
                                method.resetErrorProvider(error, txtEmail, txtEmriR, txtMbiemriR, txtPersonal_no, txtPwd);
                                method.resetErrorProvider(tick, txtEmail, txtEmriR, txtMbiemriR, txtPersonal_no, txtPwd);
                                pImage.Image = null;
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("There was an error accessing your data. DETAIL: " + ex.ToString(), "Error no." + ex.ErrorCode);
                    }
                    catch (Exception ex1)
                    {
                        MessageBox.Show(ex1.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
                else
                {
                    MessageBox.Show("All fields must be filled with the right information!", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
            {
                MessageBox.Show("All fields must be filled with the right information!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtEmriR_Validating(object sender, CancelEventArgs e)
        {
            method.Check_nameReg(txtEmriR, "Name",error,tick);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            method.openDialogImage(pImage);
        }

        private void txtMbiemriR_Validating(object sender, CancelEventArgs e)
        {
            method.Check_nameReg(txtMbiemriR,"Surname", error, tick);
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            method.checkEmail(txtEmail,error, tick);
        }

        private void txtPersonal_no_TextChanged(object sender, EventArgs e)
        {
            method.onlyNumbers(txtPersonal_no);
            method.checkPersonalNumber(txtPersonal_no, error, tick);
        }

        private void txtPwd_TextChanged(object sender, EventArgs e)
        {
            method.checkPassword(txtPwd, error, tick);
        }

    }
}