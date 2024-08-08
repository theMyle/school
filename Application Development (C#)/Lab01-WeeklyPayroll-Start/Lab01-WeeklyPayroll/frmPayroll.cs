using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01_WeeklyPayroll
{
    public partial class frmPayroll : Form
    {
        public frmPayroll()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            string empName = "";            //Name of employee
            double hrWage = 0.0;            //Hourly wage
            double hrsWorked = 0.0;         //Hours worked this week
            int allowances = 0;             //Number of withholding allowances for employee
            int exemptions;                 //Number of exemptions for employee
            string mStatus = "";            //Marital status: S - Single; M - Married
            double prevPay = 0.0;           //Total pay for year excluding this week
            double pay;                     //This week's pay before taxes
            double totalPay;                //Total pay for year including this week
            double ficaTax;                 //FICA taxes for this week
            double fedTax;                  //Federal income tax withheld this week
            double check;                   //Paycheck this week (take-home pay)

            //-------------------------------------------------------
            //Task 1: Perform form validation
            //-------------------------------------------------------

            //WRITE CODE HERE
            //-------------------------------------------------------
            
            // Employee Name
            if (String.IsNullOrEmpty(txtName.Text.Trim()))
            {
            MessageBox.Show("Employee name must not be empty.", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
            }
            empName = txtName.Text.Trim();

            // Hourly Wage
            try
            {
                hrWage = double.Parse(txtWage.Text);
            }
            catch 
            {
                MessageBox.Show("Invalid hourly wage (Must be a number)", "Hourly wage error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWage.Focus();
                txtWage.SelectAll();
                return;
            }

            // Number of hours worked
            try
            {
                hrsWorked = double.Parse(txtHours.Text);
            }
            catch 
            {
                MessageBox.Show("Invalid hours worked (must be a number).", "Hours worked error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHours.Focus();
                txtHours.SelectAll();
                return;
            }

            // Number of exemptions
            try
            {
                exemptions = int.Parse(txtExempts.Text);
            }
            catch 
            {
                MessageBox.Show("Invalid number of exemptions (must be a number).", "Number of exemptions error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtExempts.Focus();
                txtExempts.SelectAll();
                return;
            }

            // Marital Status
            if (String.IsNullOrEmpty(txtMarital.Text.Trim()))
            {
                MessageBox.Show("Marital status must not be empty.", "Marital status error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarital.Focus();
                return;
            }

            if (txtMarital.Text.Trim().ToUpper() == "M" || txtMarital.Text.Trim().ToUpper() == "S")
            {
                mStatus = txtMarital.Text.Trim().ToUpper();
            } else
            {
                MessageBox.Show("Marital status must only be (M or S).", "Marital status error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarital.Focus();
                txtMarital.SelectAll();
                return;
            }

            // Total prior pay
            try
            {
                prevPay = double.Parse(txtPriorPay.Text);
            }
            catch 
            {
                MessageBox.Show("Invalid total pay (must be a number).", "Total pay error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPriorPay.Focus();
                txtPriorPay.SelectAll();
                return;
            }

            //-------------------------------------------------------
            //T Calculate Gross Pay
            if (hrsWorked <= 40)
            {
                pay = hrsWorked * hrWage;
            }
            else
            {
                pay = 40 * hrWage + (hrsWorked - 40) * 1.5 * hrWage;
            }
            //-------------------------------------------------------


            //-------------------------------------------------------
            //Total Pay
            totalPay = prevPay + pay;
            //-------------------------------------------------------


            //-------------------------------------------------------
            //Task 5: Compute social security and medicare tax
            double socialSecurity = 0; //Social Security tax for this week
            double medicare = 0; //Medicare tax for this week
            double sum = 0; //Sum of above two taxes
            const double WAGE_BASE = 106800;
            if (totalPay <= WAGE_BASE)
            {
                socialSecurity = System.Convert.ToDouble(0.062 * pay);
            }
            else if (prevPay < WAGE_BASE)
            {
                socialSecurity = System.Convert.ToDouble(0.062 * (WAGE_BASE - prevPay));
            }
            medicare = System.Convert.ToDouble(0.0145 * pay);
            sum = socialSecurity + medicare;
            ficaTax = Math.Round(sum, 2); //Round to nearest cent
            //-------------------------------------------------------


            //---------------------------------------------------------------------------
            //Compute federal income tax withheld rounded to 2 decimal places
            double adjPay;
            double tax = 0; //Unrounded federal tax withheld
            adjPay = Convert.ToDouble(pay - (70.19 * allowances));
            if (adjPay < 0)
            {
                adjPay = 0;
            }
            if (mStatus == "S")
            {
                //-------------------------------------------------------
                //Find the taxes for "S" Single (See Table 3 from the document

                //WRITE CODE HERE..



                //-------------------------------------------------------
            }
            else
            {
                //-------------------------------------------------------
                //Find the taxes for "M" Married (See Table 4 from the document

                //WRITE CODE HERE..

                //-------------------------------------------------------
            }
            fedTax = Math.Round(tax, 2); //Round to nearest cent
            //-------------------------------------------------------------


            //Task 7: Compute Check amount
            check = pay - ficaTax - fedTax;


            //Task 8: Display results of payroll computations
            lstResults.Items.Clear();
            lstResults.Items.Add("Payroll results for " + empName);
            lstResults.Items.Add("");
            lstResults.Items.Add("Gross pay this period:" + "   " + string.Format("{0:C}", pay));
            lstResults.Items.Add("");
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //Clear all textbox and listbox contents
            txtName.Clear();
            txtWage.Clear();
            txtHours.Clear();
            txtExempts.Clear();
            txtMarital.Clear();
            txtPriorPay.Clear();
            lstResults.Items.Clear();
            txtName.Focus();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
