using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Lab04_Desamparo
{
    public class Database
    {
        private MySqlConnection connection = null;
        private String connection_string = "SERVER=localhost;USER=root;PASSWORD= ;DATABASE=salecodb;";

        /// <summary>
        /// Connects to the database
        /// </summary>
        private void ConnectDB()
        {
            connection = new MySqlConnection(connection_string);

            try
            {
                if (connection.State != ConnectionState.Open) connection.Open();
            } catch (Exception error)
            {
                MessageBox.Show($"Error: {error.Message}");
                Application.Exit();
            }
        }

        /// <summary>
        /// Closes the database connection
        /// </summary>
        private void CloseDB()
        {
            if (connection.State == ConnectionState.Open) connection.Close();
        }

        /// <summary>
        /// Returns table containing queried values.
        /// </summary>
        /// <param name="sql_command"></param>
        /// <returns></returns>
        public DataTable GetRows(String raw_sql_string_command) 
        {
            DataTable table = new DataTable();

            ConnectDB();
            using (MySqlCommand cmd = new MySqlCommand(raw_sql_string_command, connection))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    table.Load(reader);
                }
            }
            CloseDB();

            return table;
        }

        /// <summary>
        /// Returns table containing queried values.
        /// <br></br>
        /// With additional parameter for MySqlCommand.Parameters.AddWithValue(String, Object).
        /// </summary>
        /// <param name="sql_command"></param>
        /// <param name="sql_command_params">Dictionary parameter for SqlCommand.Parameters.AddWithValue(String, Object)</param>
        /// <returns></returns>
        public DataTable GetRows(String sql_command, Dictionary<String, object> sql_command_params)
        { 
            DataTable table = new DataTable();

            ConnectDB();
            using (MySqlCommand command = new MySqlCommand(sql_command, connection))
            {
                foreach (var item in sql_command_params) 
                {
                    command.Parameters.AddWithValue(item.Key, item.Value); 
                }

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    table.Load(reader);
                }
            }

            CloseDB();
            return table;
        }
    }
}
