using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Lab03_Desamparo
{
    public partial class Form1 : Form
    {
        static string server = "localhost";
        static string username = "root";
        static string password = "";
        static string database = "salecodb";
        static string connectionString = $"SERVER={server};USER={username};PASSWORD={password};DATABASE={database}";

        private void connectDB()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT p_descript, p_price FROM product";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        DataTable table = new DataTable();  // create a table to load query results

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            table.Load(reader); // load result into local table
                        }

                        string fmt = "{0,-40} {1,-15:C2}";
                        listBox1.Items.Add(string.Format(fmt, "Products", "Prices"));

                        string product = "";
                        decimal price = 0;   

                        foreach (DataRow row in table.Rows)
                        {
                            product = row[0].ToString().Trim();
                            price = Convert.ToDecimal(row[1]);

                            listBox1.Items.Add(string.Format(fmt, product, price));
                        }
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
            connectDB();
        }
    }
}
