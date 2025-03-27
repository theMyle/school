using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eventManagementSystem
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = txtUser.Text;
            String password = txtPass.Text;

            if (username == "cassy" && password == "cassy") 
            {
                MessageBox.Show("Login Success", "Login", MessageBoxButtons.OK);
                this.DialogResult = DialogResult.OK;    
            } else
            {
                MessageBox.Show("Invalid Credentials", "Login", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUser.Clear();
                txtPass.Clear();
                txtUser.Focus();
            }
        }
    }
}
