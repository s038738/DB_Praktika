using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;


namespace db_praktika
{

    class DB
    {
        private MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=db3");

        public MySqlConnection getConnection
        {
            get
            {
                return con;
            }
        }

        //function to open connection
        public void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        //function to close connection
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public void ExecuteSelect(string Sql_command)
        {



        }
    }
}
