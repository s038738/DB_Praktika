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

namespace db_praktika
{
    public partial class LoginForm : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=db3");
        int i;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void Prisijungimas_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            i = 0;
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM `gidas` where Vardas='" + textBoxName.Text + "' and Pavarde='" + textBoxPassword.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            

            i = Convert.ToInt32(dt.Rows.Count.ToString());

            if (textBoxName.Text == "admin" && textBoxPassword.Text == "admin")
            {
                i = 1;
            }

            if (i == 0)
            {
                MessageBox.Show("Bloga info");
                con.Close();
            }
            else
            {
                if (textBoxName.Text == "admin" && textBoxPassword.Text == "admin")
                {
                    USERNAME.login = textBoxName.Text; // where textBox1 is a login textBoxt
                    PASSWORD.password = textBoxPassword.Text;
                    this.Hide();
                    AdminMainForm amf = new AdminMainForm();
                    amf.Show();
                    con.Close();
                }
                else
                {
                    USERNAME.login = textBoxName.Text; // where textBox1 is a login textBoxt
                    PASSWORD.password = textBoxPassword.Text;
                    this.Hide();
                    GidasMainForm gmf = new GidasMainForm();
                    gmf.Show();
                    con.Close();
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mf = new MainForm();
            mf.Show();
            con.Close();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.Show();
        }
    }
}
