using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace EventManagementSystem
{
    public partial class EventRegistration : Form
    {
        public EventRegistration()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            validate_fields();
        }

        /// <summary>
        /// Validate all form fields
        /// </summary>
        private void validate_fields() 
        {
            // Customer Details Validation
            if (str_txtbox_is_empty(customer_name, "Customer Name")) return;
            if (str_txtbox_is_empty(customer_address, "Customer Address")) return;

            if (str_txtbox_is_empty(customer_phone, "Customer Phone Number")) return;
            if (is_valid_phone_number(customer_phone, "Customer Phone Number")) return;

            // Event Details Validation
        }

        /// <summary>
        /// Checks if textbox is empty or valid.
        ///
        /// Returns TRUE when it is empty.
        /// Returns False when valid.
        /// </summary>
        /// <returns></returns>
        bool str_txtbox_is_empty(TextBox txtbox, String label) 
        {
            if (string.IsNullOrEmpty(txtbox.Text))
            {
                MessageBox.Show("Field Required: " + label + " must not be empty", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbox.Focus();
                txtbox.SelectAll();
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks if phone number field is valid.
        /// </summary>
        /// <param name="phone_number"></param>
        /// <returns>
        ///      true when phone number is all valid numbers and 
        ///      false when it contains invalid characters (letters)
        /// </returns>
        bool is_valid_phone_number(TextBox txtbox, String label) 
        {
            foreach (char c in txtbox.Text) {
                int number = 0;
                bool result = int.TryParse(c.ToString(), out number);
                if (!result)
                {
                    MessageBox.Show("Field Required: " + label + " must be a valid phone number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtbox.Focus();
                    txtbox.SelectAll();
                    return false;
                }
            }
            return true;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

