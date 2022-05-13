using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace db_praktika
{
    class PaslaugosClass
    {
        DB db = new DB();
        public bool InsertPaslaugos(string pavadinimas, float kaina, int kiekis, int trukme)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `paslauga`(`Pavadinimas`, `Kaina`, `Kiekis`, `Trukme`) VALUES (@pav, @kaina, @kiekis, @trukme)", db.getConnection);
            //@pav, @kaina, @kiekis, @trukme
            command.Parameters.Add("@pav", MySqlDbType.VarChar).Value = pavadinimas;
            command.Parameters.Add("@kaina", MySqlDbType.Float).Value = kaina;
            command.Parameters.Add("@kiekis", MySqlDbType.Int32).Value = kiekis;
            command.Parameters.Add("@trukme", MySqlDbType.Int32).Value = trukme;

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

        public DataTable getPaslaugos(MySqlCommand command)
        {
            command.Connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deletePaslauga(int paslauga_id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `paslauga` WHERE `ID` = '" + paslauga_id + "'", db.getConnection);

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
