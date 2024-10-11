using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab09_Desamparo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Constants
        const int intMAX_PER_ROOM = 6;
        const decimal decDAILY_ROOM_CHARGE = 6275.0M;
        const decimal decTAX_RATE = 0.1625M;
        const decimal decDAILY_RESORT_FEE = 625.5M;
        const string strMAX_MSG = "You have exceeded the maximum guests per room";

        // Global Vars
        int totalTranscations = 0;
        int totalRooms = 0;
        int totalGuests = 0;
        decimal totalTranscationAmount = 0m;

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Variables
            int intRoomReserved;
            int intNights;
            int intAdults;
            int intChildren;
            int intNumOfGuests;
            double dblRoomsRequired;
            decimal decTotalRoomCharge;
            decimal decTax;
            decimal decTotalResortFee;
            decimal decTotalDue;

            // User Input
            // No of Rooms
            try
            {
                intRoomReserved = int.Parse(txtRooms.Text);
            }
            catch
            {
                MessageBox.Show("ROOMS: Invalid number of rooms", "Type mismatch (Intger required)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRooms.Focus();
                return;
            }

            // No of Nights
            try
            {
                intNights = int.Parse(txtNights.Text);
            }
            catch
            {
                MessageBox.Show("NIGHTS: Invalid number of nights", "Type mismatch (Intger required)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNights.Focus();
                return;
            }

            // No of Adults
            try
            {
                intAdults = int.Parse(txtAdults.Text);
            }
            catch
            {
                MessageBox.Show("ADULTS: Invalid number of adults", "Type mismatch (Intger required)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAdults.Focus();
                return;
            }

            // No of Children
            try
            {
                intChildren = int.Parse(txtChildren.Text);
            }
            catch
            {
                MessageBox.Show("CHILDREN: Invalid number of children", "Type mismatch (Intger required)", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtChildren.Focus();
                return;
            }

            // Calculate
            intNumOfGuests = intAdults + intChildren;
            dblRoomsRequired = intNumOfGuests / (double)intMAX_PER_ROOM;

            // Calculate and display total charge
            if (intRoomReserved < dblRoomsRequired)
            {
                MessageBox.Show(strMAX_MSG, "Treeline Resort",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            } 
            else
            {
                // Calculate Charges
                decTotalRoomCharge = intRoomReserved * intNights * decDAILY_ROOM_CHARGE;
                decTax = decTotalRoomCharge * decTAX_RATE;
                decTotalResortFee = intRoomReserved * intNights * decDAILY_RESORT_FEE;
                decTotalDue = decTotalRoomCharge + decTax + decTotalResortFee;

                // Display Charges
                txtRoomOutput.Text = decTotalRoomCharge.ToString("n2");
                txtTaxOutput.Text = decTax.ToString("n2");
                txtResortFeeOutput.Text = decTotalResortFee.ToString("n2");
                txtTotalDueOutput.Text = decTotalDue.ToString("n2");

                totalTranscations += 1;
                totalRooms += intRoomReserved;
                totalGuests += intNumOfGuests;
                totalTranscationAmount += decTotalDue;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Total Transactions: {totalTranscations}\n" +
                $"Total Rooms: {totalRooms}\n" +
                $"Total Guests: {totalGuests}\n" +
                $"Transaction Amount: {totalTranscationAmount}",
                "Transaction Summary Today",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAdults.Clear();
            txtRooms.Clear();
            txtNights.Clear();
            txtChildren.Clear();

            txtRoomOutput.Clear();
            txtTaxOutput.Clear();
            txtResortFeeOutput.Clear();
            txtTotalDueOutput.Clear();

            txtRooms.Focus();
        }
    }
}
