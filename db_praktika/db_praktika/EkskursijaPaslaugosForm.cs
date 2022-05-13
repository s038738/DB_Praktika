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
    public partial class EkskursijaPaslaugosForm : Form
    {
        public EkskursijaPaslaugosForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EkskursijaPaslaugosForm_Load(object sender, EventArgs e)
        {
            EkskursijosClass ekskursijos = new EkskursijosClass();
            PaslaugosClass paslaugos = new PaslaugosClass();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `ekskursijos`");
            comboBox1.DataSource = ekskursijos.getEkskursijos(command);
            comboBox1.DisplayMember = "Aprasymas";

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `paslauga`");
            comboBox2.DataSource = paslaugos.getPaslaugos(command2);
            comboBox2.DisplayMember = "Pavadinimas";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            EkskursijosClass ekskursijos = new EkskursijosClass();
            PaslaugosClass paslaugos = new PaslaugosClass();
            EkskursijosPaslaugosClass eksk_pasl = new EkskursijosPaslaugosClass();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `ekskursijos` WHERE Aprasymas ='" + comboBox1.Text + "'");
            DataTable dataTable = ekskursijos.getEkskursijos(command);
            int ekskursija_id = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                ekskursija_id = int.Parse(row["ID"].ToString());
            }

            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `paslauga` WHERE Pavadinimas ='" + comboBox2.Text + "'");
            DataTable dataTable2 = paslaugos.getPaslaugos(command2);
            int paslauga_id = 0;
            foreach (DataRow row in dataTable2.Rows)
            {
                paslauga_id = int.Parse(row["ID"].ToString());
            }

            if (verif())
            {
                if (eksk_pasl.InsertEkskursijaPaslauga(ekskursija_id, paslauga_id))
                {
                    MessageBox.Show("Paslauga ekskursijai sėkmingai pridėta", "Paslaugos pridėjimas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Užpildykite laukus", "Paslaugos pridėjimas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }
        bool verif()
        {
            if ((comboBox1.Text.Trim() == "") ||
                (comboBox2.Text.Trim() == ""))
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

