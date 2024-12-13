using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class Form1 : Form
    {
        Database db = new Database();

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Application Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            String username = txt_username.Text;
            String password = txt_password.Text;

            if (validate_credentials(username, password))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else 
            {
                MessageBox.Show("Invalid username or Password", "Unknown User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
        }

        // TODO - create a user account database
        // THIS IS JUST FOR TESTING AND QUICK IMPLEMENTATION
        // Of course very unsafe
        /// <summary>
        /// Validates user credentials provided
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool validate_credentials(String username, String password) 
        {
            String sql = 
                $@"
                SELECT password
                FROM accounts
                WHERE username = '{username}';
                ";

            DataTable table = db.QueryData(sql);

            if (table.Rows.Count > 0) 
            {
                if (password == table.Rows[0]["password"].ToString().Trim()) {
                    return true;
                }
            }

            return false;
        }
    }
}
