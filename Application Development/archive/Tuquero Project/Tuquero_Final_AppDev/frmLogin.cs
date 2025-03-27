using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Tuquero_Final_AppDev
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            // Any initialization code can go here
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            clsDatabase db = new clsDatabase();

            // SQL query with parameters
            string sql = "SELECT COUNT(1) FROM users WHERE user_name = @Username AND password = @Password";

            // Create parameter values
            var parameters = new Dictionary<string, object>
            {
                { "@Username", txtUser .Text.Trim() },
                { "@Password", txtPassword.Text.Trim() }
            };

            try
            {
                Int64 count = db.ExecuteQryScalar(sql, parameters);

                if (count == 1)
                {
                    MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    frmManageBooking bookingList = new frmManageBooking();
                    bookingList.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred during login: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}