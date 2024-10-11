/* Project:
 * Date:
 * Programmer:
 * Description: This project inputs sales information for clothing.
 *  It calculates the extended price and discount for a sale.
 *  Uses variables, constants, and calculations.
 *  Note that no error trapping is included in this version
 *  of the program.
*/

using System.Drawing.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB6_Desamparo
{

    public partial class Form1 : Form
    {
        // Constants
        private const decimal DEC_DISCOUNT_RATE = 0.3M;
        private decimal decTotalAmount;
        private int intNumberTranscations;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Calculate the discount and amount due.
            // Declare the variables.
            int intQuantity;
            decimal decPrice, decExtendedPrice, decDiscount, decAmountDue;

            // Quantity Try/Catch Block
            try
            {
                intQuantity = int.Parse(quantityTextBox.Text);
                
                // Price Try/Catch Block
                try
                {
                    decPrice = decimal.Parse(priceTextBox.Text);

                    // Calculate Values
                    decExtendedPrice = intQuantity * decPrice;
                    decDiscount = Decimal.Round((decExtendedPrice * DEC_DISCOUNT_RATE), 2);
                    decAmountDue = decExtendedPrice - decDiscount;
                    decTotalAmount += decAmountDue;
                    intNumberTranscations++;

                    // Output Values
                    extendedPriceTextBox.Text = decExtendedPrice.ToString("C");    
                    discountTextBox.Text = decDiscount.ToString("N");
                    amountDueTextBox.Text = decAmountDue.ToString("C");

                    // Output Summary Info
                    totalAmountTextBox.Text = decTotalAmount.ToString("C");
                    numberTransactionsTextBox.Text = intNumberTranscations.ToString();
                }
                catch
                {
                    MessageBox.Show("Invalid Price: Expected a Number", "Data Error");
                    priceTextBox.Focus();
                    priceTextBox.SelectAll();

                }
            }
            catch
            {
                MessageBox.Show("Invalid Number of Items: Expected A Number", "Data Error");
                quantityTextBox.Focus();
                quantityTextBox.SelectAll();
            }


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            quantityTextBox.Clear();
            priceTextBox.Clear();
            discountTextBox.Clear();
            extendedPriceTextBox.Clear();
            amountDueTextBox.Clear();
            quantityTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
