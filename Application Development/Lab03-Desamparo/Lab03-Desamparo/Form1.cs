using System;
using System.Data;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Lab03_Desamparo
{

    /*
    Notes:

    Data Set -> DataTable

    Provider: -> MySql.Data.MySqlClient
    1. MySqlConnection  -> Establishing connection
    2. MySqlCommand     -> Executing sql command
    3. MySqlDataReader  -> 

    Provider is based on the type of database used.
    Construct provider first before we can interact with the database.
     */

    public partial class Form1 : Form
    {
        static string server = "localhost";
        static string username = "root";
        static string password = "";
        static string database = "salecodb";
        static string connectionString = $"SERVER={server};USER={username};PASSWORD={password};DATABASE={database}";

        /// <summary>
        /// Retrive data from database
        /// </summary>
        /// <param name="sql"></param>
        private void LoadData(string sql)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        DataTable table = new DataTable();  // create a table to load query results

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            table.Load(reader); // load result into local table
                        }

                        // load table data into datagrid
                        dataGridView1.DataSource = table;
                    }
                }
            } catch (Exception error)
            {
                MessageBox.Show($"{error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string query = "SELECT p_code, p_descript, p_price, p_qoh FROM product ORDER BY p_qoh DESC";
            LoadData(query);
        }

        // Search Bar
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // When enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                string searchParam = textBox1.Text;
                string query = $@"SELECT
                                p_code,
                                p_descript,
                                p_price,
                                p_qoh
                              FROM product
                              WHERE
                                p_descript LIKE '%{searchParam}%' OR
                                p_code LIKE '%{searchParam}'";
                LoadData(query);
            }
        }
    }
}
