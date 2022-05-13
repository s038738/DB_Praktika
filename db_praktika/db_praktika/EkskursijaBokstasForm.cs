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
    public partial class EkskursijaBokstasForm : Form
    {
        public EkskursijaBokstasForm()
        {
            InitializeComponent();
        }

        private void EkskursijaBokstasForm_Load(object sender, EventArgs e)
        {
            EkskursijosClass ekskursijos = new EkskursijosClass();
            BokstasClass bokstas = new BokstasClass();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `ekskursijos`");
            comboBox1.DataSource = ekskursijos.getEkskursijos(command);
            comboBox1.DisplayMember = "Aprasymas";

            

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();
            BokstasClass bokstas = new BokstasClass();
            EkskursijosClass ekskursijos = new EkskursijosClass();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `ekskursijos` WHERE Aprasymas ='" + comboBox1.Text + "'");
            DataTable dataTable = ekskursijos.getEkskursijos(command);
            int ekskursija_id = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                ekskursija_id = int.Parse(row["ID"].ToString());
            }

            string pavadinimas = textBox1.Text;
            float aukstis = float.Parse(textBox2.Text);
            float kaina = float.Parse(textBox3.Text);
            float aukstis_vjl = float.Parse(textBox4.Text);
            DateTime date = dateTimePicker1.Value;

            if (verif())
            {
                if (bokstas.InsertBokstas(ekskursija_id, pavadinimas, aukstis, kaina, aukstis_vjl, date))
                {
                    MessageBox.Show("Bokštas buvo sekmingai pridetas", "Bokšto pridejimas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Bokšto pridejimas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Uzpildykite laukus", "Bokšto pridejimas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            bool verif()
            {
                if ((comboBox1.Text.Trim() == "") ||
                    (textBox1.Text.Trim() == "") ||
                        (textBox2.Text.Trim() == "") ||
                        (textBox3.Text.Trim() == "") ||
                        (textBox4.Text.Trim() == "") ||
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
