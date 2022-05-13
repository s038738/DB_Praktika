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
using System.Data.SqlClient;

namespace db_praktika
{
    public partial class AddEkskursijaForm : Form
    {
        public AddEkskursijaForm()
        {
            InitializeComponent();
        }

        private void AddEkskursijaForm_Load(object sender, EventArgs e)
        {
            GidasClass gidas = new GidasClass();
            MiestasClass miestas = new MiestasClass();
            PaslaugosClass paslaugos = new PaslaugosClass();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `gidas`");
            comboBox1.DataSource = gidas.getGidas(command);
            comboBox1.DisplayMember = "Vardas";

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `miestas`");
            comboBox2.DataSource = miestas.getMiestas(command2);
            comboBox2.DisplayMember = "Pavadinimas";

            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `paslauga`");
            checkedListBox1.DataSource = paslaugos.getPaslaugos(command3);
            checkedListBox1.DisplayMember = "Pavadinimas";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            EkskursijosClass ekskursijos = new EkskursijosClass();
            GidasClass gidas = new GidasClass();
            MiestasClass miestas = new MiestasClass();
            PaslaugosClass paslaugos = new PaslaugosClass();
           

            MySqlCommand command = new MySqlCommand("SELECT * FROM `gidas` WHERE Vardas ='" + comboBox1.Text + "'");
            DataTable dataTable = gidas.getGidas(command);
            int gidas_id = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                gidas_id = int.Parse(row["ID"].ToString());
            }

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `miestas` WHERE Pavadinimas= '" + comboBox2.Text + "'");
            DataTable dataTable1 = miestas.getMiestas(command2);
            int miestas_id = 0;
            foreach (DataRow row in dataTable1.Rows)
            {
                miestas_id = int.Parse(row["ID"].ToString());
            }

            
            float kaina = Convert.ToInt32(textBox2.Text.ToString());
            DateTime laikas = dateTimePicker1.Value;
            string ekskursijos_aprasymas = textBox4.Text;
            
            
            if(verif())
            {
                if(ekskursijos.InsertEkskursija(gidas_id,miestas_id,kaina,laikas,ekskursijos_aprasymas))
                {
                    MessageBox.Show("Ekskursija buvo sekmingai prideta", "Ekskursijos pridejimas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Ekskursijos pridejimas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            else
            {
                MessageBox.Show("Uzpildykite laukus", "Ekskursijos pridejimas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            bool verif()
            {
                if ((comboBox1.Text.Trim() == "") ||
                    (comboBox2.Text.Trim() == "") ||
                        (textBox2.Text.Trim() == "") ||
                        (dateTimePicker1.Value == null))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }



        }
    }
}
