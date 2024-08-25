using System;
using System.Windows.Forms;

namespace Lab01_WeeklyPayroll
{
    public partial class frmPayroll : Form
    {
        string empName = "";
        double hrWage = 0.0;              
        double hrsWorked= 0.0;               
        int allowances = 0;               
        int exemptions=0;                
        string mStatus = "";            
        double prevPay = 0.0;                  
        double pay = 0.0;
        double totalPay = 0.0;                 
        double ficaTax = 0.0;                  
        double fedTax = 0.0;                   
        double check = 0.0;                    

        public frmPayroll()
        {
            InitializeComponent();
        }


        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //Task 1: Perform form validation
            // Name
            if (IsEmpty(txtName, "Name")) return;
            empName = txtName.Text; 

            // Wage
            if (IsEmpty(txtWage, "Wage")) return;
            if (!ParseDouble(txtWage, "Hourly Wage", out hrWage)) return;

            // Hours Worked
            if (IsEmpty(txtHours, "Hours Worked")) return;
            if (!ParseDouble(txtHours, "Hours Worked", out hrsWorked)) return;

            // Exemptions
            if (IsEmpty(txtExempts, "Number of Exemptions")) return;
            if (!ParseInt(txtExempts, "Exemption", out exemptions)) return;

            // Marital Status
            if (!ValidateMaritalStatus(txtMarital)) return;
            mStatus = txtMarital.Text.ToUpper()[0].ToString(); 

            // Previous pay
            if (IsEmpty(txtPriorPay, "Previous Pay")) return;
            if (!ParseDouble(txtPriorPay, "Previous Pay", out prevPay)) return;

            // Calculations
            pay = ComputePay(hrsWorked, hrWage);                // Calculate Gross Pay
            totalPay = prevPay + pay;                           // Total Pay

            ficaTax = CalculateFicaTax(pay, totalPay, prevPay); // Task 5: Compute social security and medicare tax
            fedTax = CalculateFedTax(mStatus, pay, exemptions); // Task 6: Compute Federal Income Tax
            check = pay - ficaTax - fedTax;                     // Task 7: Compute Check amount

            DisplayResults();                                   // Task 8: Display results of payroll computations
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtWage.Clear();
            txtHours.Clear();
            txtExempts.Clear();
            txtMarital.Clear();
            txtPriorPay.Clear();
            lstResults.Items.Clear();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private bool IsEmpty(TextBox txt, string name)
        {
            if (String.IsNullOrEmpty(txt.Text.Trim()))
            {
                MessageBox.Show($"Employee {name} must not be left blank.",
                            $"Missing Employee {name}", //title
                            MessageBoxButtons.OK, //button
                            MessageBoxIcon.Error); //icon
                txt.Focus();
                return true; //Exit from the current method
            }
            return false;
        }

        private double ComputePay(double hrsWorked, double hrWage)
        {
            double pay;
            if (hrsWorked <= 40)
            {
                pay = hrsWorked* hrWage;
            }
            else
            {
                pay = 40 * hrWage + (hrsWorked - 40) * 1.5 * hrWage;
            }

            return pay;
        }

        private bool ParseDouble(TextBox txtBox, String dataName, out double result)
        {
            try
            {
                result = double.Parse(txtBox.Text.Trim());
            } catch {
                result = 0;
                MessageBox.Show($"Invalid {dataName}.",
                            "Invalid Numeric Value",
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                txtBox.Clear();
                txtBox.Focus();
                return false;
            }
            return true;
        }

        private bool ParseInt(TextBox txtBox, String dataName, out int result)
        {
            try
            {
                result = int.Parse(txtBox.Text.Trim());
            } catch {
                result = 0;
                MessageBox.Show($"Invalid {dataName}.",
                            "Invalid Numeric Value",
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Error);
                txtBox.Clear();
                txtBox.Focus();
                return false;
            }
            return true;
        }

        private bool ValidateMaritalStatus(TextBox txtBox) {
            string input = txtBox.Text.Trim().ToUpper();
            if (string.IsNullOrEmpty(input) || (input[0] != 'S' && input[0] != 'M'))
            {
                MessageBox.Show("Employee marital status is invalid.",
                            "Invalid Employee Status", //title
                            MessageBoxButtons.OK, //button
                            MessageBoxIcon.Error); //icon
                txtBox.Clear();
                txtBox.Focus();
                return false;
            }
            return true;
        }

        private double CalculateFedTax(String mStatus, double pay, double exemptions)
        {
            double adjPay;
            double tax = 0; 

            adjPay = Convert.ToDouble(pay - (61.54 * exemptions));
            if (adjPay < 0) adjPay = 0;

            if (mStatus == "S")
            {
                if (adjPay >= 0 && adjPay <= 51)            tax = 0;
                else if (adjPay > 51 && adjPay <= 188)      tax = (adjPay - 51) * 0.1D;
                else if (adjPay > 188 && adjPay <= 606)     tax = 13.70 + (adjPay - 188) * 0.15D;
                else if (adjPay > 606 && adjPay <= 1341)    tax = 76.4D + (adjPay - 606) * 0.25D;
                else if (adjPay > 1341 && adjPay <= 2922)   tax = 260.15D + (adjPay - 1341) * 0.28D;
                else if (adjPay > 2922 && adjPay <= 6313)   tax = 702.83D + (adjPay - 2922) * 0.33D;
                else                                        tax = 1821.86D + (adjPay - 6313) * 0.35D;
            }
            else
            {
                if (adjPay >= 0 && adjPay <= 154)           tax = 0;
                else if (adjPay > 154 && adjPay <= 435)     tax = (adjPay - 154) * 0.1D;
                else if (adjPay > 435 && adjPay <= 1273)    tax = 28.1D + (adjPay - 435) * 0.15D;
                else if (adjPay > 1273 && adjPay <= 2322)   tax = 153.8D + (adjPay - 1273) * 0.25D;
                else if (adjPay > 2322 && adjPay <= 3646)   tax = 416.05D + (adjPay - 2322) * 0.28D;
                else if (adjPay > 3646 && adjPay <= 6409)   tax = 786.77D + (adjPay - 3646) * 0.33D;
                else                                        tax = 1698.56D + (adjPay - 6409) * 0.35D;
            }

            return Math.Round(tax, 2);
        }

        private void DisplayResults()
        {
            lstResults.Items.Clear();
            lstResults.Items.Add("Payroll results for " + empName);
            lstResults.Items.Add("");
            lstResults.Items.Add("Gross pay this period:" + "   " + string.Format("{0:C}", pay));
            lstResults.Items.Add("");
            lstResults.Items.Add("Year-to-date earnings:" + "   " + string.Format("{0:C}", totalPay));
            lstResults.Items.Add("");
            lstResults.Items.Add("FICA tax this period:" + "    " + string.Format("{0:C}", ficaTax));
            lstResults.Items.Add("");
            lstResults.Items.Add("Income tax withheld:" + "     " + string.Format("{0:C}", fedTax));
            lstResults.Items.Add("");
            lstResults.Items.Add("Net pay (check amount):" + "  " + string.Format("{0:C}", check));
        }

        private double CalculateFicaTax(double pay, double totalPay, double prevPay)
        {
            double socialSecurity = 0;
            double medicare = 0;
            const double WAGE_BASE = 90000;
            if (totalPay <= WAGE_BASE)
            {
                socialSecurity = Convert.ToDouble(0.062 * pay);
            }
            else if (prevPay < WAGE_BASE)
            {
                socialSecurity = Convert.ToDouble(0.062 * (WAGE_BASE - prevPay));
            }
            medicare = Convert.ToDouble(0.0145 * pay);
            double sum = socialSecurity + medicare;
            return Math.Round(sum, 2);
        }
    }
}
