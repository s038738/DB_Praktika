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
    public partial class UpdateGidasForm : Form
    {
        public UpdateGidasForm()
        {
            InitializeComponent();
        }
        
        private void UpdateGidasForm_Load(object sender, EventArgs e)
        {
            GidasClass gidas = new GidasClass();
            textBox1.Text = USERNAME.login;
            textBox2.Text = PASSWORD.password;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            GidasClass gidas = new GidasClass();
            
            string oldvardas = USERNAME.login;
            string vardas = textBox1.Text;
            string pavarde = textBox2.Text;

            MySqlCommand command = new MySqlCommand("SELECT `ID` FROM `gidas` WHERE Vardas ='" + oldvardas + "'");
            DataTable dataTable = gidas.getGidas(command);
            int gidas_id = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                gidas_id = int.Parse(row["ID"].ToString());
            }

            if (verif())
            {
                if (gidas.UpdateGidas(vardas, pavarde, gidas_id))
                {
                    MessageBox.Show("Gidas sėkmingai atnaujintas", "Gido atnaujinimas", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Užpildykite laukus", "Gido atnaujinimas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

