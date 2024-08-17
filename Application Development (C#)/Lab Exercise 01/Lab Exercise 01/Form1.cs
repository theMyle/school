using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Lab_Exercise_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //String form Columns
        const string STR_3_COLS = "{0,-20}{1, -10}{2, -10}";
        const string STR_2_COLS = "{0,-20}{1, -20}";

        //Rug Cleaner rental price
        const decimal RUG_CLEANER_HD = 16.00M;   //Half-day
        const decimal RUG_CLEANER_FD = 24.00M;   //Full-day
        //Lawn mower rental price
        const decimal LAWN_MOWER_HD = 12.00M;   //Half-day
        const decimal LAWN_MOWER_FD = 18.00M;   //Full-day

        //Paint sprayer rental price
        const decimal PAINT_SPRAY_HD = 20.00M;   //Half-day
        const decimal PAINT_SPRAY_FD = 30.00M;   //Full-day

        // Items (item name, halfday price, fullday price)
        string[] itemNames = {"Rug Cleaner", "Lawn Mower", "Paint Sprayer"};
        decimal[] HDPrice = {RUG_CLEANER_HD, LAWN_MOWER_HD, PAINT_SPRAY_HD};
        decimal[] FDPrice = {RUG_CLEANER_FD, LAWN_MOWER_FD, PAINT_SPRAY_FD};

        private void btnShowPrice_Click(object sender, EventArgs e)
        {
            lstRates.Items.Clear();
            lstRates.Items.Add(string.Format(STR_3_COLS,"Price of Equipment", "Half-Day","Full-Day"));
            lstRates.Items.Add(string.Format(STR_3_COLS, "1. Rug Cleaner", RUG_CLEANER_HD, RUG_CLEANER_FD));
            lstRates.Items.Add(string.Format(STR_3_COLS, "2. Lawn Mower", LAWN_MOWER_HD, LAWN_MOWER_FD));
            lstRates.Items.Add(string.Format(STR_3_COLS, "3. Paint Sprayer", PAINT_SPRAY_HD, PAINT_SPRAY_FD));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedItem = 0;
            char duration = ' ';
            string itemName = " ";
            decimal[] priceList = null;
            decimal price = 0;
            const decimal deposit = 30;

            try
            {
                selectedItem = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Invalid Item selected: Please choose a valid item above.", "Invalid Item", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.SelectAll();
                textBox1.Focus();
                return;
            }

            duration = char.Parse(textBox2.Text.ToUpper());
            if (duration != 'H' && duration != 'F')
            {
                MessageBox.Show("Invalid Duration (Only H or F)", "Duration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox2.SelectAll();
                textBox2.Focus();
                return;
            }

            if (duration == 'H')
            {
                priceList = HDPrice;
            } else
            {
                priceList = FDPrice;
            }

            switch (selectedItem)
            {
                case 1:
                    itemName = itemNames[0];
                    price = priceList[0];
                    break;
                case 2:
                    itemName = itemNames[1];
                    price = priceList[1];
                    break;
                case 3:
                    itemName = itemNames[2];
                    price = priceList[2];
                    break;
                default:
                    MessageBox.Show("Item not found", "Item selected error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.SelectAll();
                    textBox1.Focus();
                    break;
            }

            // Output Display 
            lstBill.Items.Clear();  
            lstBill.Items.Add("Transaction Receipt for Roger's Equipment Rental");
            lstBill.Items.Add(" ");
            if (duration == 'F')
                lstBill.Items.Add(string.Format("{0,-20}{1, -10}(Full day rental)", itemName, price));
            else
                lstBill.Items.Add(string.Format(STR_2_COLS, itemName, price));
            lstBill.Items.Add(string.Format(STR_2_COLS, "Deposit", deposit));
            lstBill.Items.Add(" ");
            lstBill.Items.Add(string.Format(STR_2_COLS, "TOTAL", (price + deposit)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lstRates.Items.Clear();
            lstBill.Items.Clear();  
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
