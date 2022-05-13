using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace db_praktika
{
    class EkskursijosPaslaugosClass
    {
        DB db = new DB();
        public bool InsertEkskursijaPaslauga (int ekskursija_id, int paslauga_id)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `ekskursijos_paslaugos`(`Ekskursijos_ID`, `Paslaugos_ID`) VALUES (@eid,@pad)", db.getConnection);
            //@eid,@pad
            command.Parameters.Add("@eid", MySqlDbType.Int32).Value = ekskursija_id;
            command.Parameters.Add("@pad", MySqlDbType.Int32).Value = paslauga_id;
            

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

        public DataTable getEkskursijosPaslaugos(MySqlCommand command)
        {
            command.Connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteEkskursijaPaslauga(int ekskursija_id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `ekskursijos_paslaugos` WHERE `ID` = '" + ekskursija_id + "'", db.getConnection);

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
