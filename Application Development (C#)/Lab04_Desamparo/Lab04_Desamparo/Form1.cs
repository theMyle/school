using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Lab04_Desamparo
{
    public partial class Form1 : Form
    {

        Database db = new Database(); // instantiate database class

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Load database content into the form on startup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            String sql_command = @"SELECT
                                    Product.p_code,
                                    Product.p_descript,
                                    Product.p_price,
                                    vendor.v_name
                                FROM Product
                                LEFT JOIN vendor ON vendor.v_code=Product.v_code";
            DataTable table = db.GetRows(sql_command);
            dataGridView1.DataSource = table;
        }

        /// <summary>
        /// Search for a specific item in the database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_search_Click(object sender, EventArgs e)
        {
            String search_string = textBox1.Text;
            String sql_command = @"SELECT
                                    Product.p_code,
                                    Product.p_descript,
                                    Product.p_price,
                                    vendor.v_name
                                FROM Product
                                LEFT JOIN vendor ON vendor.v_code=Product.v_code
                                WHERE
                                    Product.p_code LIKE @search_string OR
                                    Product.p_descript LIKE @search_string OR
                                    Product.p_price LIKE @search_string OR
                                    vendor.v_name LIKE @search_string
                                    ";
            Dictionary<String,Object> sql_args = new Dictionary<String,Object>();
            sql_args.Add("@search_string", $"%{search_string}%");

            DataTable table = db.GetRows(sql_command, sql_args);
            dataGridView1.DataSource = table;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                btn_search.PerformClick();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                btn_search.PerformClick();
            }
        }
    }
}
