using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace db_praktika
{
    public partial class AddPaslaugosForm : Form
    {
        public AddPaslaugosForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            PaslaugosClass paslaugos = new PaslaugosClass();
            string pavadinimas = textBoxPavadinimas.Text;
            float kaina = float.Parse(textBoxKaina.Text);
            int kiekis = int.Parse(textBoxKiekis.Text);
            int trukme = int.Parse(textBoxTrukme.Text);

            if (verif())
            {
                if (paslaugos.InsertPaslaugos(pavadinimas, kaina, kiekis, trukme))
                {
                    MessageBox.Show("Paslauga pridėta", "Paslaugos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error", "Paslaugos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Uzpildykite laukus", "Paslaugos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        bool verif()
        {
            if ((textBoxPavadinimas.Text.Trim() == "") ||
                (textBoxKaina.Text.Trim() == "") ||
                (textBoxKiekis.Text.Trim() == "" ||
                textBoxTrukme.Text.Trim() == ""))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void AddPaslaugosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
