using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace ScheduleManagementSystem
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        SqlCommand cmd;
        SqlDataReader reader;
        //krijo nje objekt te klases search
        Search sc = new Search();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            //Nuk te lejon me rrit formen
            MaximizeBox = false;
            //Nese id eshte null
            if (Log.id == null)
            {
                panel1.Visible = true; //shfaq panelin1
                panel1.Controls.Clear(); //fshiji kontrollat paraprake nga paneli1
                Login Lg = new Login(); //krijo nje objekt te klases login
                Lg.Show(); //shfaqe formen per kycje(login)
                panel1.Controls.Add(Lg); //shto kontrollat e reja ne panelin1
                btnLogOut.Visible = false; //fsheh butonin logOut nga paneli1
                btnLogOut.Enabled = false; //nuk i lejon mundesi klikimi butonit logout
                btnAvailability.Visible = false;
                btnAvailability.Enabled = false;
                btnChangePassword.Visible = false;
                btnChangePassword.Enabled = false;
                ToolStripMenuItem.Enabled = false;
                SearchToolStrip.Enabled = false;
                mainToolStripMenuItem.Enabled = false;
                administratorToolStripMenuItem.Enabled = false;
                teacherToolStripMenuItem.Enabled = false;
                studentToolStripMenuItem.Enabled = true;
            }else //nese id nuk eshte null, pra permban vlera
            {
                if (Log.role == "Admin") //Nese roli i personit qe deshiron te kycet eshte Admin ekzekuto kodin ne vazhdim
                {
                    ToolStripMenuItem.Enabled = true; //shfaq Menun per menaxhimin e te dhenave
                    SearchToolStrip.Enabled = true; //shfaq menun per kerkimin e te dhenave
                    panel1.Visible = true; //shfaq panelin1
                    panel1.Controls.Clear(); //fshiji kontrollat ekzistuese nga paneli1
                    WelcomePage wp = new WelcomePage(); //Krijo nje objekt te klases WelcomePage te dizajnuar specifikisht per admin
                    panel1.Controls.Add(wp);
                    mainToolStripMenuItem.Enabled = true;
                    btnLogOut.Visible = true; //shfaq butonin logout
                    btnLogOut.Enabled = true; //lejoje mundesin e klikimit te butonit logout
                    administratorToolStripMenuItem.Enabled = true;
                    teacherToolStripMenuItem.Enabled = false;
                    studentToolStripMenuItem.Enabled = false;
                }
                else if (Log.role == "User") //nese roli i personit qe deshiron te kycet eshte User
                {
                    ToolStripMenuItem.Enabled = false; //nuk e lejon mundesin e klikimit te menyr per menaxhimin e te dhenave
                    ToolStripItems.Enabled = false;  
                    panel1.Visible = true;
                    panel1.Controls.Clear();
                    UCProfesori UP = new UCProfesori();// Krijo nje objekt te klases UCProfesori te dizajnuar specifikisht per profesorin
                    panel1.Controls.Add(UP);
                    //Color_White();
                    mainToolStripMenuItem.Enabled = true;
                    btnLogOut.Visible = true;
                    btnLogOut.Enabled = true;
                    btnChangePassword.Visible = true;
                    btnChangePassword.Enabled = true;
                    btnAvailability.Visible = true;
                    btnAvailability.Enabled = true;
                    administratorToolStripMenuItem.Enabled = false;
                    teacherToolStripMenuItem.Enabled = true;
                    studentToolStripMenuItem.Enabled = false;
                }
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        //metoda per mbylljen e formes
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            //Nese shtypet butoni per mbylljen e formes(X)
            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            //Na paraqitet mesazhi ne vijim
            if (MessageBox.Show("Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                return;
            }else //nese e anulojm mbylljen
            {
                e.Cancel = true;
            }
        }
        //Funksioni i cili ekzekutohet ne rast se klikohet butoni LogOut
        private void btnLogOut_Click(object sender, EventArgs e)
        {   
            UCProfesori UCP = new UCProfesori();
            UCP.temp.Clear();
            ToolStripMenuItem.Enabled = false;
            SearchToolStrip.Enabled = false;
            mainToolStripMenuItem.Enabled = false;
            btnAvailability.Visible = false;
            btnAvailability.Enabled = false;
            btnChangePassword.Visible = false;
            btnChangePassword.Enabled = false;
            administratorToolStripMenuItem.Enabled = false;
            teacherToolStripMenuItem.Enabled = false;
            studentToolStripMenuItem.Enabled = true;
            btnLogOut.Visible = false;
            panel1.Controls.Clear();
            Login Lg = new Login();
            Lg.Show();
            panel1.Controls.Add(Lg);
            Lg.txtPassword.Text = "";
            Lg.txtUsername.Text = "";
            Log.LogOut();
            Lg.txtUsername.Focus();
            method.decreaseFormSize();
            loginToolStripMenuItem.Text = "Login";
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UserControlRegjistrimi usercontrol = new UserControlRegjistrimi();
            usercontrol.Show();
            panel1.Controls.Add(usercontrol);
            method.decreaseFormSize();
        }

        private void membersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UserControlEditimi usercontrol1 = new UserControlEditimi();
            usercontrol1.Show();
            panel1.Controls.Add(usercontrol1);
            method.decreaseFormSize();
        }

        private void membersToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCDeleteStaff ucDelete = new UCDeleteStaff();
            ucDelete.Show();
            panel1.Controls.Add(ucDelete);
            method.decreaseFormSize();
        }

        private void titlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCTitleS ucTitle = new UCTitleS();
            ucTitle.Show();
            panel1.Controls.Add(ucTitle);
            method.decreaseFormSize();
        }

        private void titlesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCTitlesModifyS UCTMS = new UCTitlesModifyS();
            UCTMS.Show();
            panel1.Controls.Add(UCTMS);
            method.decreaseFormSize();
        }

        private void titlesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCDeleteTitles UCDT = new UCDeleteTitles();
            UCDT.Show();
            panel1.Controls.Add(UCDT);
            method.decreaseFormSize();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCSubjectR UCSR = new UCSubjectR();
            UCSR.Show();
            panel1.Controls.Add(UCSR);
            method.decreaseFormSize();
        }

        private void subjectsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCSubjectE UCSE = new UCSubjectE();
            UCSE.Show();
            panel1.Controls.Add(UCSE);
            method.decreaseFormSize();
        }

        private void subjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCDeleteSu UCDSu= new UCDeleteSu();
            UCDSu.Show();
            panel1.Controls.Add(UCDSu);
            method.decreaseFormSize();
        }

        private void newToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCSallaDete UCDSE = new UCSallaDete();
            UCDSE.Show();
            panel1.Controls.Add(UCDSE);
            method.decreaseFormSize();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCSallatRE UCSRE = new UCSallatRE();
            UCSRE.Show();
            panel1.Controls.Add(UCSRE);
            method.decreaseFormSize();
        }

        private void typeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCSallatTipi UCST = new UCSallatTipi();
            panel1.Controls.Add(UCST);
            method.decreaseFormSize();
        }

        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCSallaEditimi UCSD = new UCSallaEditimi();
            panel1.Controls.Add(UCSD);
            method.decreaseFormSize();
        }

        private void typeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCTipiEdit UCTE = new UCTipiEdit();
            panel1.Controls.Add(UCTE);
            method.decreaseFormSize();
        }

        private void typeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCTipiDelete UCTD = new UCTipiDelete();
            panel1.Controls.Add(UCTD);
            method.decreaseFormSize();
        }

        private void departmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCDepR UCDR = new UCDepR();
            panel1.Controls.Add(UCDR);
            method.decreaseFormSize();
        }

        private void departmentsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCDepE UCDE = new UCDepE();
            panel1.Controls.Add(UCDE);
            method.decreaseFormSize();
        }

        private void departmentsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCDeleteDep UCDD = new UCDeleteDep();
            panel1.Controls.Add(UCDD);
            method.decreaseFormSize();
        }

        private void facultiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCFacultiesR UCFR = new UCFacultiesR();
            panel1.Controls.Add(UCFR);
            method.decreaseFormSize();
        }

        private void facultiesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCFacultiesE UCFE = new UCFacultiesE();
            panel1.Controls.Add(UCFE);
            method.decreaseFormSize();
        }

        private void facultiesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCDeleteFaculties UCDF = new UCDeleteFaculties();
            panel1.Controls.Add(UCDF);
            method.decreaseFormSize();
        }
        //Nese klikohet Exit tek menu-ja atehere mbylle aplikacionin.
        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Nese behet minimize forma atehere ajo te shkoje tek tray icons(iconat afer ores ne desktop).
        private void Form1_Move(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                notify.ShowBalloonTip(2000,"Orari","Orari will run in tray!",ToolTipIcon.Info);
            }
        }

        //Shfaqe aplikacionin nese klikohet Orari tek menu-ja
        private void orariToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        //Shfaqe aplikcaionin nese klokohet dy here icon-i i orarit tek tray icons.
        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        //Shfaqe aplikacionin nese klikohet njoftimi tek tray icons.
        private void notify_BalloonTipClicked(object sender, EventArgs e)
        {
            Show();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            Search s = new Search();
            panel1.Controls.Add(s);
            method.decreaseFormSize();
        }

        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Log.role == "Admin")
            {
                btnAvailability.Visible = false;
                btnAvailability.Enabled = false;
                btnChangePassword.Visible = false;
                btnChangePassword.Enabled = false;
            }
            panel1.Controls.Clear();
            WelcomePage wp = new WelcomePage();
            wp.Show();
            panel1.Controls.Add(wp);
            method.decreaseFormSize();
        }

        private void btnAvailability_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCProfesori ucp = new UCProfesori();
            panel1.Controls.Add(ucp);
            method.decreaseFormSize();
        }

        private void orariToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCOrari uco = new UCOrari();
            panel1.Controls.Add(uco);
            method.increaseFormSize();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            if (Log.id != null)
            {
                if (MessageBox.Show("Are you sure you want to logout?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {   
                    ToolStripMenuItem.Enabled = false;
                    SearchToolStrip.Enabled = false;
                    mainToolStripMenuItem.Enabled = false;
                    btnAvailability.Visible = false;
                    btnAvailability.Enabled = false;
                    btnChangePassword.Visible = false;
                    btnChangePassword.Enabled = false;
                    btnLogOut.Visible = false;
                    btnLogOut.Enabled = false;
                    Log.LogOut();
                    ////////////////////////
                    panel1.Visible = true;
                    panel1.Controls.Clear();
                    Login lg = new Login();
                    lg.Show();
                    panel1.Controls.Add(lg);
                    lg.txtPassword.Text = "";
                    lg.txtUsername.Text = "";
                    lg.txtUsername.Focus();
                    Width = 566;
                    Height = 456;
                    panel1.Width = 499;
                    panel1.Height = 333;
                    loginToolStripMenuItem.Text = "Login";
                    administratorToolStripMenuItem.Enabled = false;
                    teacherToolStripMenuItem.Enabled = false;
                    studentToolStripMenuItem.Enabled = true;

                }
            }
            else
            {
                panel1.Visible = true;
                panel1.Controls.Clear();
                Login lg = new Login();
                lg.Show();
                panel1.Controls.Add(lg);
                lg.txtPassword.Text = "";
                lg.txtUsername.Text = "";
                lg.txtUsername.Focus();
                Width = 566;
                Height = 456;
                panel1.Width = 499;
                panel1.Height = 333;
                administratorToolStripMenuItem.Enabled = false;
                teacherToolStripMenuItem.Enabled = false;
                studentToolStripMenuItem.Enabled = true;
            }
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                using (cmd = new SqlCommand("SELECT passNderruar FROM Stafi WHERE ID_Stafi = @id",conn))
                {
                    cmd.Parameters.AddWithValue("id",Log.id);

                    using (reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if ((bool)reader["passNderruar"])
                            {
                                MessageBox.Show("You cant change password more than once!","Information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }else
                            {
                                panel1.Visible = true;
                                panel1.Controls.Clear();
                                UCChangePassword UCCP = new UCChangePassword();
                                UCCP.Show();
                                panel1.Controls.Add(UCCP);
                                method.decreaseFormSize();
                                UCCP.txtOldPassword.Focus();
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

        private void subjectsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCProfSubject UCPS = new UCProfSubject();
            UCPS.Show();
            panel1.Controls.Add(UCPS);
            method.decreaseFormSize();
        }

        private void subjectsToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            UCStaffSubjectsModify UCSSM = new UCStaffSubjectsModify();
            UCSSM.Show();
            panel1.Controls.Add(UCSSM);
            method.decreaseFormSize();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@".\student.pdf");
        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@".\teacher.pdf");
        }

        private void administratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start(@".\admin.pdf");
        }
    }
}
