using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace db_praktika
{
    class MiestasClass
    {
        DB db = new DB();

        public bool InsertMiestas(int salis_id, string pavadinimas, string geo_padetis)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `miestas`(`Salis_ID`, `Pavadinimas`, `Geo_padetis`) VALUES (@sid, @pav, @gpad)", db.getConnection);
            //@sid, @pav, @gpad
            command.Parameters.Add("@sid", MySqlDbType.Int32).Value = salis_id;
            command.Parameters.Add("@pav", MySqlDbType.VarChar).Value = pavadinimas;
            command.Parameters.Add("@gpad", MySqlDbType.VarChar).Value = geo_padetis;

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
        public DataTable getMiestas(MySqlCommand command)
        {
            command.Connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
