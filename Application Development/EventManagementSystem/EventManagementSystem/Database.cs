using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    internal class Database
    {
        const String DB_HOST = "127.0.0.1";
        const String DB_USER = "root";
        const String DB_PASSWORD = "";
        const String DB_NAME = "eventbooking_db";

        const String CONNECTION_STRING = 
            @"SERVER=" + DB_HOST + ";" +
            "USER="+  DB_USER + ";" +
            "PASSWORD=" + DB_PASSWORD + ";" +
            "DATABASE=" +DB_NAME + ";";

        /// <summary>
        /// Retrieve data from database
        /// </summary>
        /// <param name="sql"></param>
        /// <returns></returns>
        internal DataTable QueryData(String sql)
        {
            // create a mysql connection
            using (MySqlConnection connection = new MySqlConnection(CONNECTION_STRING))
            {
                try
                {
                    // open the connection 
                    connection.Open();

                    // create an sql command
                    using (MySqlCommand command = new MySqlCommand(sql, connection)) 
                    {
                        // execute the mysql command
                        using (MySqlDataReader reader = command.ExecuteReader())
                        { 
                            // load from data reader to table
                            DataTable table = new DataTable();
                            table.Load(reader);
                            return table;
                        }
                    }
                }
                catch (Exception err) 
                {
                    MessageBox.Show("Error connecting to database:\n" + err.Message, "Database connection ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
                }
            }
        }

    }
}
