using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace db_praktika
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ekskursijos_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DB db = new DB();
            EkskursijosClass ekskursijos = new EkskursijosClass();
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `ekskursijos`");
            ekskursijos_dataGridView.ReadOnly = true;
            ekskursijos_dataGridView.RowTemplate.Height = 20;
            ekskursijos_dataGridView.DataSource = ekskursijos.getEkskursijos(command2);
            ekskursijos_dataGridView.AllowUserToAddRows = false;
            ekskursijos_dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void ekskursijos_dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DB db = new DB();

            EkskursijosClass ekskursijos = new EkskursijosClass();
            GidasClass gidas = new GidasClass();
            MiestasClass miestas = new MiestasClass();
            PaslaugosClass paslaugos = new PaslaugosClass();
            GiduKalbosClass gidu_kalbos = new GiduKalbosClass();
            InfoEkskursijaForm ieForm = new InfoEkskursijaForm();
            SalisClass salis = new SalisClass();
            KalbaClass kalba = new KalbaClass();
            EkskursijosPaslaugosClass eksk_pasl = new EkskursijosPaslaugosClass();

           
            string gido_id = this.ekskursijos_dataGridView.CurrentRow.Cells[1].Value.ToString();
            string ekskursijos_id = this.ekskursijos_dataGridView.CurrentRow.Cells[0].Value.ToString();
            string miestas_id = this.ekskursijos_dataGridView.CurrentRow.Cells[2].Value.ToString();

            ieForm.label5.Text = this.ekskursijos_dataGridView.CurrentRow.Cells[3].Value.ToString() + " €";
            

            //gido ID to VARDAS

            MySqlCommand command = new MySqlCommand("SELECT * FROM `gidas` WHERE ID ='" + gido_id + "'");
            DataTable dataTable = gidas.getGidas(command);
       
            foreach (DataRow row in dataTable.Rows)
            {
                ieForm.labelVardas.Text = row["Vardas"].ToString();
            }

            //gido ID to PAVARDE
            foreach (DataRow row in dataTable.Rows)
            {
                ieForm.labelPavarde.Text = row["Pavarde"].ToString();
            }

            //gido kalbos X)
            MySqlCommand command2 = new MySqlCommand("SELECT * FROM `gidu_kalbos` WHERE Gido_ID ='" + gido_id + "'");
            DataTable dataTable2 = gidu_kalbos.getGiduKalbos(command2);
            int kalba_id = 0;
            foreach (DataRow row in dataTable2.Rows)
            {
                kalba_id = Convert.ToInt32(row["Kalbos_ID"].ToString());
            }

            //pastebejimas sau, logika turi buti pries konvertuojant ID i Kalbos pavadinima, tai auksciau. perkelti zemiau esancia logika ;-)

            MySqlCommand command3 = new MySqlCommand("SELECT * FROM `kalbos` WHERE ID='" + kalba_id + "'");
            DataTable dataTable3 = kalba.getKalba(command3);

            int datatable3lenght = dataTable3.Rows.Count;
            for (int i = 0; i < datatable3lenght; i++)
            {
                foreach (DataRow row in dataTable3.Rows)
                {
                    ieForm.labelKalbos.Text = row["Kalba"].ToString(); ;
                }
            }
            

            //ekskursijos aprasymas
            MySqlCommand command4 = new MySqlCommand("SELECT * FROM `ekskursijos` WHERE ID ='" + ekskursijos_id + "'");
            DataTable dataTable4 = ekskursijos.getEkskursijos(command4);
            
            foreach (DataRow row in dataTable4.Rows)
            {
                ieForm.textBox1.Text = row["Aprasymas"].ToString();
            }

            //ekskursija id to SALIS
            MySqlCommand command5 = new MySqlCommand("SELECT * FROM `miestas` WHERE ID ='" + miestas_id + "'");
            DataTable dataTable5 = miestas.getMiestas(command5);
            int salis_id = 0;
            foreach (DataRow row in dataTable5.Rows)
            {
                ieForm.labelMiestas.Text = row["Pavadinimas"].ToString();
                salis_id = int.Parse(row["Salis_ID"].ToString());
            }

            //ekskursija id to MIESTAS
            MySqlCommand command6 = new MySqlCommand("SELECT * FROM `salis` WHERE ID ='" + salis_id + "'");
            DataTable dataTable6 = salis.getSalis(command6);
            foreach (DataRow row in dataTable6.Rows)
            {
                ieForm.labelSalis.Text = row["Pavadinimas"].ToString();
            }


            //datagridview su paslaugomis
            //EkskursijosPaslaugosClass eksk_pasl = new EkskursijosPaslaugosClass();
            MySqlCommand command7 = new MySqlCommand("SELECT ep.Ekskursijos_ID, ep.Paslaugos_ID, ps.Pavadinimas, ps.Kaina, ps.Trukme FROM ekskursijos_paslaugos ep INNER JOIN paslauga ps ON ep.Paslaugos_ID = ps.ID WHERE ep.Ekskursijos_ID = '" + ekskursijos_id +"' ");
            ieForm.dataGridView1.ReadOnly = true;
            //////ieForm.dataGridView1.RowTemplate.Height = 20;
            ieForm.dataGridView1.DataSource = eksk_pasl.getEkskursijosPaslaugos(command7);
            ieForm.dataGridView1.AllowUserToAddRows = false;
            ieForm.dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;


            //ekskursijos galutines sumos apskaiciavimas is label ir datagridview

            float sum = 0;
            for (int i = 0; i < ieForm.dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToSingle(ieForm.dataGridView1.Rows[i].Cells[3].Value);
            }

            float ekskursijossum = float.Parse(this.ekskursijos_dataGridView.CurrentRow.Cells[3].Value.ToString());
            sum = sum + ekskursijossum;
            ieForm.label6.Text = "Galutinė ekskursijos suma: " + sum.ToString() + " €";



            ieForm.Show(this);
        }
    }
 }

