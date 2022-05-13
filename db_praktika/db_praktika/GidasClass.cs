using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace db_praktika
{
    class GidasClass
    {
        DB db = new DB();

        public int gidas_id { get; set; }
        public string vardas { get; set; }
        public string pavarde { get; set; }

        public bool InsertGidas(string vardas, string pavarde)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `gidas`(`Vardas`, `Pavarde`) VALUES (@vard, @pav)", db.getConnection);
            //@vard, @pav
            command.Parameters.Add("@vard", MySqlDbType.VarChar).Value = vardas;
            command.Parameters.Add("@pav", MySqlDbType.VarChar).Value = pavarde;

           

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

        public bool InsertGidasLanguage(int gidas_id, int kalbos_id)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `gidu_kalbos`(`Gido_ID`, `Kalbos_ID`) VALUES (@gid,@kid)", db.getConnection);
            //@gid,@kid
            command.Parameters.Add("@gid", MySqlDbType.Int32).Value = gidas_id;
            command.Parameters.Add("@kid", MySqlDbType.Int32).Value = kalbos_id;


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
        

        public DataTable getGidas(MySqlCommand command)
        {
            command.Connection = db.getConnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool UpdateGidas(string vardas, string pavarde, int gidas_id)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `gidas` SET `Vardas`=(@vard),`Pavarde`=(@pav) WHERE `ID`=(@id)", db.getConnection);
            //@gid,@kid,@id
            command.Parameters.Add("@vard", MySqlDbType.VarChar).Value = vardas;
            command.Parameters.Add("@pav", MySqlDbType.VarChar).Value = pavarde;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = gidas_id;


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
        public bool DeleteGidas(int gidas_id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `gidas` WHERE `ID` = '" + gidas_id + "'", db.getConnection);

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
