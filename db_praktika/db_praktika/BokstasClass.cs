using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace db_praktika
{
    class BokstasClass
    {
        DB db = new DB();
        public bool InsertBokstas(int ekskursija_id, string pavadinimas, float aukstis, float kaina, float aukstis_vjl, DateTime date)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `bokstas`(`Ekskursija_ID`, `Pavadinimas`, `Aukstis`, `Kaina`, `Aukstis_virs_juros_lygio`, `Pastatymo_data`) VALUES (@eid, @pav, @auks, @kain, @avjl, @pasdata)", db.getConnection);
            //@eid, @pav, @auks, @kain, @avjl, @pasdata
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = ekskursija_id;
            command.Parameters.Add("@pav", MySqlDbType.VarChar).Value = pavadinimas;
            command.Parameters.Add("@auks", MySqlDbType.Float).Value = aukstis;
            command.Parameters.Add("@kain", MySqlDbType.Float).Value = kaina;
            command.Parameters.Add("@avjl", MySqlDbType.Float).Value = aukstis_vjl;
            command.Parameters.Add("@pasdata", MySqlDbType.DateTime).Value = date;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }

        public DataTable getBokstas(MySqlCommand command)
        {
            command.Connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteBokstas(int bokstas_id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `bokstas` WHERE `ID` = '" + bokstas_id + "'", db.getConnection);

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                db.closeConnection();
                return true;
            }
            else
            {
                db.closeConnection();
                return false;
            }
        }
    }
}
