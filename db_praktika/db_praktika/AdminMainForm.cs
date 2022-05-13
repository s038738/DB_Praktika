using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace db_praktika
{
    public partial class AdminMainForm : Form
    {
        public AdminMainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            SalisClass salis = new SalisClass();
            string pavadinimas = textBox1.Text;
            string geo_padetis = textBox2.Text;

            if (verif())
            {
                if (salis.InsertSalis(pavadinimas,geo_padetis))
                {
                    MessageBox.Show("Salis buvo sekmingai prideta", "Salies pridejimas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Uzpildykite laukus", "Salies pridejimas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        bool verif()
        {
            if ((textBox1.Text.Trim() == "") ||
                (textBox2.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            SalisClass salis = new SalisClass();
            EkskursijosClass ekskursijos = new EkskursijosClass();
            PaslaugosClass paslaugos = new PaslaugosClass();
            BokstasClass bokstas = new BokstasClass();
            GidasClass gidas = new GidasClass();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `salis`");
            comboBox1.DataSource = salis.getSalis(command);
            comboBox1.DisplayMember = "Pavadinimas";

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `ekskursijos`");
            comboBox2.DataSource = ekskursijos.getEkskursijos(command2);
            comboBox2.DisplayMember = "ID";

            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `paslauga`");
            comboBox3.DataSource = paslaugos.getPaslaugos(command3);
            comboBox3.DisplayMember = "ID";

            MySqlCommand command4 = new MySqlCommand("SELECT * FROM `bokstas`");
            comboBox4.DataSource = paslaugos.getPaslaugos(command4);
            comboBox4.DisplayMember = "ID";

            MySqlCommand command5 = new MySqlCommand("SELECT * FROM `gidas`");
            comboBox5.DataSource = gidas.getGidas(command5);
            comboBox5.DisplayMember = "Vardas";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SalisClass salis = new SalisClass();
            MiestasClass miestas = new MiestasClass();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `salis` WHERE Pavadinimas ='" + comboBox1.Text + "'");
            DataTable dataTable = salis.getSalis(command);
            int salis_id = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                salis_id = int.Parse(row["ID"].ToString());
            }
            string pavadinimas = textBox3.Text;
            string geo_padetis = textBox4.Text;

            if (verif2())
            {
                if (miestas.InsertMiestas(salis_id, pavadinimas, geo_padetis))
                {
                    MessageBox.Show("Miestas buvo sekmingai pridetas", "Miesto pridejimas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Uzpildykite laukus", "Miesto pridejimas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }
        bool verif2()
        {
            if ((textBox3.Text.Trim() == "") ||
                (textBox4.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            KalbaClass kalbos = new KalbaClass();
            string kalba = textBox5.Text;
            if (verif3())
            {
                if (kalbos.InsertKalba(kalba))
                {
                    MessageBox.Show("Kalba buvo sekmingai prideta", "Kalbos pridejimas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("Uzpildykite laukus", "Kalbos pridejimas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }
        bool verif3()
        {
            if (textBox5.Text.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ekskursijos_id = Convert.ToInt32(comboBox2.Text);

            EkskursijosClass ekskursijos = new EkskursijosClass();
            if (MessageBox.Show("Ar tikrai norite ištrinti ekskursiją?", "Ekskursijos ištrynimas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (ekskursijos.deleteEkskursija(ekskursijos_id))
                {
                    MessageBox.Show("Ekskursija sėkmingai ištrinta", "Ekskursijos ištrynimas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ekskursija nebuvo ištrinta", "Ekskursijos ištrynimas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int paslaugos_id = Convert.ToInt32(comboBox3.Text);

            PaslaugosClass paslaugos = new PaslaugosClass();
            if (MessageBox.Show("Ar tikrai norite ištrinti paslaugą?", "Paslaugos ištrynimas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (paslaugos.deletePaslauga(paslaugos_id))
                {
                    MessageBox.Show("Paslauga sėkmingai ištrinta", "Paslaugos ištrynimas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Paslauga nebuvo ištrinta", "Paslaugos ištrynimas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int bokstas_id = Convert.ToInt32(comboBox4.Text);

         
            BokstasClass bokstas = new BokstasClass();
            if (MessageBox.Show("Ar tikrai norite ištrinti bokštą?", "Bokšto ištrynimas", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (bokstas.deleteBokstas(bokstas_id))
                {
                    MessageBox.Show("Bokštas sėkmingai ištrintas", "Bokšto ištrynimas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Bokštas nebuvo ištrintas", "Bokšto ištrynimas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            GidasClass gidas = new GidasClass();
            
           
            MySqlCommand command = new MySqlCommand("SELECT * FROM `gidas` WHERE Vardas ='" + comboBox5.Text + "'");
            DataTable dataTable = gidas.getGidas(command);
            int gidas_id = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                gidas_id = int.Parse(row["ID"].ToString());
            }

            if (verif4())
            {
                if (gidas.DeleteGidas(gidas_id))
                {
                    MessageBox.Show("Gidas sėkmingai ištrintas", "Gido ištrinimas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                }
                else
                {
                    MessageBox.Show("Užpildykite laukus", "Gido ištrinimas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }
        bool verif4()
        {
            if ((comboBox5.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
