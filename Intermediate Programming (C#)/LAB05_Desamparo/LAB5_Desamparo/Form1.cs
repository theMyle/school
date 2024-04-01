using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB5_Desamparo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            // input variables
            decimal price;
            int months = 0;
            decimal interest = 0m;
            decimal downpayment = 0m;

            // get user inputs
            price = decimal.Parse(inputItemPrice.Text);
            months = int.Parse(inputPlanMonths.Text);
            interest = decimal.Parse(inputInterest.Text);
            downpayment = decimal.Parse(inputDownPayment.Text);

            // compute monthly fee
            decimal monthly_fee = price / months;

            // compute interest
            decimal monthly_interest = monthly_fee * (interest / 100);
            monthly_fee += monthly_interest;

            // compute total due
            decimal total_due = 0m;
            const decimal PROCESS_FEE = 350m;
            total_due = monthly_fee * months + PROCESS_FEE;

            // add tax
            const decimal TAX = 0.03M;
            total_due += total_due * TAX;

            // apply downpayment
            total_due -= downpayment;

            // compute new monthly fee
            monthly_fee = total_due / months;

            // display outputs
            outputInterest.Text = $"Php {monthly_interest:N2}"; // monthly_interest.ToString("N2");
            outputMonthlyFee.Text = $"Php {monthly_fee:N2}";
            outputTotalDue.Text = $"Php {total_due:N2}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            inputCustomerName.Clear();
            inputItemName.Clear();
            inputItemPrice.Clear();
            inputPlanMonths.Clear();
            inputInterest.Clear();
            inputDownPayment.Clear();

            outputInterest.Text = "0.00";
            outputMonthlyFee.Text = "0.00";
            outputTotalDue.Text = "0.00";

            inputCustomerName.Focus();  
        }
    }
}
