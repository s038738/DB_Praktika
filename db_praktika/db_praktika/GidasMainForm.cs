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
    public partial class GidasMainForm : Form
    {
        public GidasMainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GidasMainForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            label1.Text = "Gidas: " + USERNAME.login;
            string vartotojas = USERNAME.login;

            EkskursijosClass ekskursijos = new EkskursijosClass();
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `ekskursijos`");
            ekskursijos_dataGridView.ReadOnly = true;
            ekskursijos_dataGridView.RowTemplate.Height = 20;
            ekskursijos_dataGridView.DataSource = ekskursijos.getEkskursijos(command2);
            ekskursijos_dataGridView.AllowUserToAddRows = false;
            ekskursijos_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void buttonNewPaslauga_Click(object sender, EventArgs e)
        {
            AddPaslaugosForm addPslF = new AddPaslaugosForm();
            addPslF.Show(this);
        }

        private void buttonNewEkskursija_Click(object sender, EventArgs e)
        {
            AddEkskursijaForm addEksF = new AddEkskursijaForm();
            addEksF.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EkskursijaBokstasForm ebf = new EkskursijaBokstasForm();
            ebf.Show(this);
        }

        private void ekskursijos_dataGridView_DoubleClick(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EkskursijaPaslaugosForm epf = new EkskursijaPaslaugosForm();
            epf.Show(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdateGidasForm ugf = new UpdateGidasForm();
            ugf.Show(this);
        }
    }
}
