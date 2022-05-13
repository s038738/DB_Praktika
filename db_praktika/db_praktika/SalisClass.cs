using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace db_praktika
{
    class SalisClass
    {
        DB db = new DB();
        public bool InsertSalis(string pavadinimas, string geo_padetis)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `salis`(`Pavadinimas`, `Geo_padetis`) VALUES (@pav, @gpad)", db.getConnection);
            //@pav, @gpad
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

        public DataTable getSalis(MySqlCommand command)
        {
            command.Connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
