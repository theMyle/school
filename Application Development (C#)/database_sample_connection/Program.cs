using System.Data;
using MySql.Data.MySqlClient;

class Program
{
    const string connectionID = @"
    server=localhost;
    user=root;
    password=;
    database=salecodb;";

    public static void Main(string[] args)
    {
        // set up a connection with the database
        using (MySqlConnection connection = new MySqlConnection(Program.connectionID))
        {
            try
            {
                // open a connection to a connected database
                connection.Open();

                string query = "SELECT p_descript, p_price FROM product";
                // create a query/command to be sent to the databse
                MySqlCommand command = new MySqlCommand(query, connection);
                // send and execute the command
                MySqlDataReader reader = command.ExecuteReader();

                // create a new local table to store the data
                DataTable table = new DataTable();
                // write the data into local table
                table.Load(reader);
                reader.Close(); // close the reader connection

                // process the data
                string fmt = "{0,-40} | {1,15:C2}";
                Console.WriteLine(string.Format(fmt, "Products:", "Prices:"));
                Console.WriteLine("");

                string? product = "";
                string? price = "";

                foreach (DataRow row in table.Rows)
                {
                    product = row[0].ToString();
                    price = row[1].ToString();
                    Console.WriteLine(string.Format("{0,-40} | {1,15:C2}", product, price));
                }
            }
            catch (MySqlException error)
            {
                Console.WriteLine("SQL Error: {0}", error.Message);
            }
            catch (Exception error)
            {
                Console.WriteLine("MySQL Invalid Operation: {0}", error.Message);
            }
        }
    }
}