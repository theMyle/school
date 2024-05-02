using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB07_Desamparo
{


    public partial class Form1 : Form
    {

        // Class Scoped Variable
        private decimal totalBill = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Clear
            txtPrice.Clear();
            txtQuantity.Clear();
            lblSubTotal.Text = "";
            txtPrice.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get user input
            decimal price = 0;
            int quantity = 0;
            decimal subTotal;

            try {
                price = decimal.Parse(txtPrice.Text);

                try
                {
                    quantity = int.Parse(txtQuantity.Text);
                }
                catch (Exception err)
                {
                    MessageBox.Show("QUANTITY ORDERED: "+err.Message, "Input Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                    txtQuantity.Clear();
                    txtQuantity.Focus();
                }

            } catch (Exception err) {
                MessageBox.Show("ITEM PRICE: " + err.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtPrice.Clear();
                txtPrice.Focus();
            }

            // Compute
            subTotal = price * quantity;
            totalBill += subTotal;

            // Output
            lblSubTotal.Text = subTotal.ToString("N2");
            lblTotalBill.Text = totalBill.ToString("N2");
        }
    }
}
