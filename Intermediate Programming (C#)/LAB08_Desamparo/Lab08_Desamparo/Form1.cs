using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab08_Desamparo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string strCustomerType;
            string strMessage;
            decimal decSubtotal;
            decimal decDiscountPercent = .0m;

            if (txtCustomerType.Text == string.Empty) {
                MessageBox.Show("Invalid Customer Type. Customer  Type must not be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (txtSubTotal.Text != "")
            {
                try
                {
                    strCustomerType = txtCustomerType.Text;
                    decSubtotal = decimal.Parse(txtSubTotal.Text);

                    if (strCustomerType.ToUpper() == "R")
                    {
                        if (decSubtotal < 100)
                            decDiscountPercent = .0m;
                        else if (decSubtotal >= 100 && decSubtotal < 250)
                            decDiscountPercent = .1m;
                        else if (decSubtotal >= 250)
                            decDiscountPercent = .25m;
                    }
                    else if (strCustomerType.ToUpper() == "C")
                    {
                        if (decSubtotal < 250)
                            decDiscountPercent = .2m;
                        else
                            decDiscountPercent = .3m;
                    }
                    else
                    {
                        decDiscountPercent = .4m;
                    }

                    decimal discountAmount = decSubtotal * decDiscountPercent;
                    decimal invoiceTotal = decSubtotal - discountAmount;

                    txtDiscountPercent.Text = decDiscountPercent.ToString("p1");
                    txtDiscountAmount.Text = discountAmount.ToString("c");
                    txtTotal.Text = invoiceTotal.ToString("c");

                    txtCustomerType.Focus();
                }
                catch
                {
                    strMessage = "Nonnumeric data entered for sub total.";
                    MessageBox.Show(strMessage, "Data entry error");
                }
            }
            else
            {
                strMessage = "The quantity is required.";
                MessageBox.Show(strMessage, "Data entry error");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
