using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Collections;

namespace ScheduleManagementSystem
{
    public partial class UCProfesori : UserControl
    {   
        //Lidhja me bazen e te dhenave
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);
        //Deklarimi i variables permes se ciles ekzekutohen pyetesoret.
        SqlCommand cmd;
        //Deklarimi i variables permes se ciles merren te dhenat te cilat jane ekzekutuar nga SqlCommand
        SqlDataReader reader;
        //Lista e perkohshme ne te cilen do te ruhen elementet e reja qe futen ne listbox.
        public List<Tuple<string, string, string>> temp = new List<Tuple<string, string, string>>();
        //Konstruktori
        public UCProfesori()
        {
            InitializeComponent();
        }
        //Funksioni i cili ekzekutohen kur te inciohet user kontrolla UCProfesori
        private void UCProfesori_Load(object sender, EventArgs e)
        {
            try
            {   
                //Inicimi i secilit comboBox me oren e paracaktuar, permes funksionit fillList i cili gjendet
                //tek klasa statike methods.cs
                cmbMondayFrom.DataSource = method.fillList(9, 16);
                cmbFridayFrom.DataSource = method.fillList(9, 16);
                cmbSaturdayFrom.DataSource = method.fillList(9, 16);
                cmbThursdayFrom.DataSource = method.fillList(9, 16);
                cmbTuesdayFrom.DataSource = method.fillList(9, 16);
                cmbWednesdayFrom.DataSource = method.fillList(9, 16);
                
                //Hapja e lidhjes me bazen e te dhenave.
                conn.Open();

                //Shtimi i elementeve perkatese nga baza e te dhenave ne listbox-in listRezulteti.
                using (cmd = new SqlCommand("SELECT Dita, CONVERT(NVARCHAR(5),OraPrej, 108), CONVERT(NVARCHAR(5),OraDeri,108) FROM Disponueshmeria WHERE ID_Stafi=@id", conn))
                {
                    cmd.Parameters.AddWithValue("id", Log.id);

                    reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        listRezultati.Items.Add(new Tuple<string, string, string>(reader[0].ToString(), reader[1].ToString(), reader[2].ToString()));
                    }
                }

                lblProf.Text = $"Welcome {Log.name} {Log.surname}";
            }
            catch (SqlException SqlEx)
            {   //Nese ka ndonje gabim ne Sql sintakse atehere shfaqe error-in me te dhenat perkatese.
                MessageBox.Show(SqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {   //Nese ka ndonje gabim tjeter perveq sql(per arsye se nese ka gabim ne sql hyn ne catch-in e mesiperm) shfaq errorin
                //me te dhenat perkatese.
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //Nese lidhja me databaze eshte e inicuar atehere mbylle ate.
                method.closeConnection(conn);
            }
        }

        //Per cdo comboBox i cili ndryshon tekstin, ndrysho listen e burimeve(resource) te listes tjeter 
        //perkatese qe lidhet me te.
        private void cmbMondayFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            method.resultOnCombobox(cmbMondayFrom, cmbMondayTo);
        }

        private void cmbTuesdayFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            method.resultOnCombobox(cmbTuesdayFrom, cmbTuesdayTo);
        }

        private void cmbWednesdayFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            method.resultOnCombobox(cmbWednesdayFrom, cmbWednesdayTo);
        }

        private void cmbThursdayFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            method.resultOnCombobox(cmbThursdayFrom, cmbThursdayTo);
        }

        private void cmbFridayFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            method.resultOnCombobox(cmbFridayFrom, cmbFridayTo);
        }

        private void cmbSaturdayFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            method.resultOnCombobox(cmbSaturdayFrom, cmbSaturdayTo);
        }

        /// <summary>
        /// Futja e te dhenave ne dy lista perkatese pas klikimit te butonit perkates.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInsertToResult(object sender, EventArgs e)
        {
            Button butoni = sender as Button;

            if (butoni.Name == "btnMonday")
            {   
                //Kjo liste paraqet listbox-in, elementet e te cilit do te shfaqen tek perdoruesi.
                listRezultati.Items.Add(new Tuple<string, string, string>(Monday.Text, cmbMondayFrom.Text, cmbMondayTo.Text));
                //Lista ne te cilen do te ruhen elementet e reja te cilat klienti i fut ne listbox.
                temp.Add(new Tuple<string, string, string>(Monday.Text, cmbMondayFrom.Text, cmbMondayTo.Text));
            }

            if (butoni.Name == "btnTuesday")
            {
                listRezultati.Items.Add(new Tuple<string, string, string>(Tuesday.Text, cmbTuesdayFrom.Text, cmbTuesdayTo.Text));
                temp.Add(new Tuple<string, string, string>(Tuesday.Text, cmbTuesdayFrom.Text, cmbTuesdayTo.Text));
            }

            if (butoni.Name == "btnWednesday")
            {
                listRezultati.Items.Add(new Tuple<string, string, string>(Wednesday.Text, cmbWednesdayFrom.Text, cmbWednesdayTo.Text));
                temp.Add(new Tuple<string, string, string>(Wednesday.Text, cmbWednesdayFrom.Text, cmbWednesdayTo.Text));
            }

            if (butoni.Name == "btnThursday")
            {
                listRezultati.Items.Add(new Tuple<string, string, string>(Thursday.Text, cmbThursdayFrom.Text, cmbThursdayTo.Text));
                temp.Add(new Tuple<string, string, string>(Thursday.Text, cmbThursdayFrom.Text, cmbThursdayTo.Text));
            }

            if (butoni.Name == "btnFriday")
            {
                listRezultati.Items.Add(new Tuple<string, string, string>(Friday.Text, cmbFridayFrom.Text, cmbFridayTo.Text));
                temp.Add(new Tuple<string, string, string>(Friday.Text, cmbFridayFrom.Text, cmbFridayTo.Text));
            }

            if (butoni.Name == "btnSaturday")
            {
                listRezultati.Items.Add(new Tuple<string, string, string>(Saturday.Text, cmbSaturdayFrom.Text, cmbSaturdayTo.Text));
                temp.Add(new Tuple<string, string, string>(Saturday.Text, cmbSaturdayFrom.Text, cmbSaturdayTo.Text));
            }
        }
        //Fshirja e te dhenave nga listBoxi
        private void btnRemove_Click(object sender, EventArgs e)
        {   //Nese elementi i selektuar nuk eshte null atehere ...
            if (listRezultati.SelectedItems != null)
            {
                try
                {
                    conn.Open();
                    //Kthe ne liste elementet e listBox-it
                    var lista = listRezultati.SelectedItems.Cast<Tuple<string,string,string>>().ToList();

                    //Per secilin element te listbox-it 
                    foreach (var item in lista)
                    {   //Fshij nga tabela Disponueshmeria te dhenat me inputet perkatese
                        using (cmd = new SqlCommand("DELETE FROM Disponueshmeria WHERE Dita=@dita AND OraPrej=@oraprej AND OraDeri=@oraderi AND ID_Stafi=@id", conn))
                        {
                            cmd.Parameters.AddWithValue("dita", item.Item1.ToString());
                            cmd.Parameters.AddWithValue("oraprej", item.Item2.ToString());
                            cmd.Parameters.AddWithValue("oraderi", item.Item3.ToString());
                            cmd.Parameters.AddWithValue("id",Log.id);

                            //Pyet nese perdoruesi eshte i sigurte per veprimin
                            if (MessageBox.Show("Are you sure you want to delete?","Warning!",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                //Ekzekuto pyetesorin e krijuar me lart.    
                                if (cmd.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("The data has been deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }

                        if (temp.Count != 0)
                        {
                            //Nese lista e perkohshme temp ka elemente...
                            if (temp.Count == listRezultati.Items.Count)
                            {
                                temp.RemoveAt(listRezultati.SelectedIndex);
                            }
                            else
                            {   //Fshije elementin tek pozicioni i elementit te selektuar minus madhesise se listes temp.
                                temp.RemoveAt(Math.Abs(listRezultati.SelectedIndex - listRezultati.Items.Count)-1);
                            }
                        }

                        //Fshjie gjithashtu edhe nga listBox-i
                        listRezultati.Items.RemoveAt(listRezultati.SelectedIndex);
                    }
                }
                catch (SqlException SqlEx)
                {
                    MessageBox.Show(SqlEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    method.closeConnection(conn);
                }
            }else
            {
                MessageBox.Show("Please select an item to remove!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Madhesia e listes temp ruhet tek variabla result
                int[] results = new int[temp.Count];

                conn.Open();
                //Per i prej 0 deri te madhesia e listes temp ekzekuto kodin ne vijim
                for (int i = 0; i < temp.Count; i++)
                {   //Shto ne tabelen Disonueshmeria te dhenat perkatese
                    using (cmd = new SqlCommand("INSERT INTO Disponueshmeria VALUES(@Dita, @Orap, @Orad, @ID_Stafi)",conn))
                    {
                        //Shto te dhenen e par (temp[0]) ne kolonen e par te tabeles Disponueshmeria
                        cmd.Parameters.AddWithValue("Dita", temp[i].Item1.ToString());
                        cmd.Parameters.AddWithValue("Orap", temp[i].Item2.ToString());
                        cmd.Parameters.AddWithValue("Orad", temp[i].Item3.ToString());
                        cmd.Parameters.AddWithValue("ID_Stafi", Log.id);
                        //Ekzekuto pyetsorin
                        results[i] = cmd.ExecuteNonQuery();
                    }
                }
                //Nese rezultati permban 0
                if (results.Contains(0))
                {   //Shfaq mesazhin se te dhenat nuk u insertuan ne bazen e te dhenave
                    MessageBox.Show("The data could't be inserted to the database!","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }else
                {   //Nese rezultati eshte ne rregull shfaq mesazhin qe te dhenat jan ruajtur me sukses
                    MessageBox.Show("The data has been successfully inserted into database!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Fshij elementet nga listBoxi i rezultateve
                    listRezultati.Items.Clear();
                }
            }
            catch(SqlException sqExc)
            {
                MessageBox.Show(sqExc.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void cmbMondayTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            method.checkListbox(listRezultati, cmbMondayFrom, cmbMondayTo, Monday.Text, btnMonday);
        }

        private void cmbTuesdayTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            method.checkListbox(listRezultati, cmbTuesdayFrom, cmbTuesdayTo, Tuesday.Text, btnTuesday);
        }

        private void cmbWednesdayTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            method.checkListbox(listRezultati, cmbWednesdayFrom, cmbWednesdayTo, Wednesday.Text, btnWednesday);
        }

        private void cmbThursdayTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            method.checkListbox(listRezultati, cmbThursdayFrom, cmbThursdayTo, Thursday.Text, btnThursday);
        }

        private void cmbFridayTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            method.checkListbox(listRezultati, cmbFridayFrom, cmbFridayTo, Friday.Text, btnFriday);
        }

        private void cmbSaturdayTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            method.checkListbox(listRezultati, cmbSaturdayFrom, cmbSaturdayTo, Saturday.Text, btnSaturday);
        }
    }
}