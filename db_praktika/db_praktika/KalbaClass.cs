using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace db_praktika
{
    class KalbaClass
    {
        DB db = new DB();

        public bool InsertKalba(string kalba)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `kalbos`(`Kalba`) VALUES (@kal)", db.getConnection);
            //@kal
            
            command.Parameters.Add("@kal", MySqlDbType.VarChar).Value = kalba;
            

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

        public DataTable getKalba(MySqlCommand command)
        {
            command.Connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}