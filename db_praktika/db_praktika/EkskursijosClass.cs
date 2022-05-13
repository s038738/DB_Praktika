using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace db_praktika
{
    class EkskursijosClass
    {
        DB db = new DB();
        public bool InsertEkskursija(int gidas_id, int miestas_id, float kaina, DateTime laikas, string ekskursijos_aprasymas) 
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `ekskursijos`(`Gidas_ID`, `Miestas_ID`, `Kaina`, `Laikas`, `Aprasymas`) VALUES (@gid, @mid, @kaina, @laikas, @desc)", db.getConnection);
            //@gid, @mid, @kaina, @laikas, @epid, @desc
            command.Parameters.Add("@gid", MySqlDbType.Int32).Value = gidas_id;
            command.Parameters.Add("@mid", MySqlDbType.Int32).Value = miestas_id;
            command.Parameters.Add("@kaina", MySqlDbType.Float).Value = kaina;
            command.Parameters.Add("@laikas", MySqlDbType.DateTime).Value = laikas;
            command.Parameters.Add("@desc", MySqlDbType.VarChar).Value = ekskursijos_aprasymas;

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

        public DataTable getEkskursijos (MySqlCommand command)
        {
            command.Connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool deleteEkskursija(int ekskursija_id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `ekskursijos` WHERE `ID` = '" + ekskursija_id + "'", db.getConnection);

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
