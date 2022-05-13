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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            KalbaClass kalba = new KalbaClass();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `kalbos`");
            comboBox1.DataSource = kalba.getKalba(command);
            comboBox1.DisplayMember = "Kalba";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            GidasClass gidas = new GidasClass();
            KalbaClass kalba = new KalbaClass();

            string vardas = textBox1.Text;
            string pavarde = textBox2.Text;

            MySqlCommand command = new MySqlCommand("SELECT * FROM `kalbos` WHERE Kalba ='" + comboBox1.Text + "'");
            DataTable dataTable = kalba.getKalba(command);
            int kalbos_id = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                kalbos_id = int.Parse(row["ID"].ToString());
            }

            if (verif())
            {
                if (gidas.InsertGidas(vardas,pavarde))
                {
                    MessageBox.Show("Gidas sėkmingai pridėtas", "Gido pridėjimas", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    MySqlCommand command2 = new MySqlCommand("SELECT * FROM `gidas` WHERE Vardas ='" + textBox1.Text + "'");
                    DataTable dataTable2 = gidas.getGidas(command2);
                    int gidas_id = 0;
                    foreach (DataRow row in dataTable2.Rows)
                    {
                        gidas_id = int.Parse(row["ID"].ToString());
                    }
                    gidas.InsertGidasLanguage(gidas_id, kalbos_id);
                }
                else
                {
                    MessageBox.Show("Užpildykite laukus", "Gido pridėjimas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
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
    }
}
