using SaleCoSystem;
using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        String event_id;
        String operation_type;
        clsDatabase db = new clsDatabase();

        public Form2(String type, String eventID)
        {
            InitializeComponent();

            event_id = eventID;
            operation_type = type;

            dateTimeTime.Value = DateTime.Today.AddHours(6).AddMinutes(30);

            if (type.ToLower() == "new")
            {
                btnCancelEvent.Visible = false;
            }
            else if (type.ToLower() == "update") 
            {
                lblTitle.Text = "Update Booking";
                Load_Data();
            }
        }

        private void Load_Data()
        {
            String sql = $@"SELECT event_name, customer_name, customer_phone, customer_address, event_type, event_date_time, event_guests, event_theme, event_status
                            FROM events
                            WHERE event_id = {event_id};";

            DataTable table = db.QueryData(sql);
            if (table != null)
            {
                // process the table
                foreach (DataRow row in table.Rows)
                {
                    txtEventName.Text = row["event_name"].ToString();
                    txtCustomerName.Text = row["customer_name"].ToString();
                    txtPhoneNumber.Text = row["customer_phone"].ToString();
                    txtCustomerAddress.Text = row["customer_address"].ToString();
                    txtEventType.Text = row["event_type"].ToString();

                    DateTime start_date = Convert.ToDateTime(row["event_date_time"]);
                    dateTimeDate.Value = start_date;
                    dateTimeTime.Value = start_date;

                    txtNumOfGuests.Text = row["event_guests"].ToString();
                    txtTheme.Text = row["event_theme"].ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // save button
        private void button1_Click(object sender, EventArgs e)
        {
            if (!validate_fields()) return;

            String event_name = txtEventName.Text;
            String customer_name = txtCustomerName.Text;
            String phone = txtPhoneNumber.Text;
            String address = txtCustomerAddress.Text;
            String event_type = txtEventType.Text.ToLower();

            DateTime eventDateTime = dateTimeDate.Value.Date.Add(dateTimeTime.Value.TimeOfDay);
            String event_date_time = eventDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            int guests = int.Parse(txtNumOfGuests.Text);
            String theme = txtTheme.Text;

            String sql_query = "";

            if (operation_type.ToLower() == "new")
            {
                sql_query = $@"INSERT INTO events 
                                (event_name, customer_name, customer_phone, customer_address, event_type, event_date_time, event_guests, event_theme, event_status)
                                VALUES 
                                ('{event_name}', '{customer_name}', '{phone}', 
                                 '{address}', '{event_type}', '{event_date_time}', 
                                 '{guests}', '{theme}', 'Scheduled');";

                if (db.ExecuteSQLQuery(sql_query))
                {
                    MessageBox.Show("Event Successfully Booked", "New Booking Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            } else
            {
                sql_query = $@"
                    UPDATE events
                    SET 
                        event_name = '{event_name}',
                        customer_name = '{customer_name}',
                        customer_phone = '{phone}',
                        customer_address = '{address}',
                        event_type = '{event_type}',
                        event_date_time = '{event_date_time}',
                        event_guests = '{guests}',
                        event_theme = '{theme}'
                    WHERE
                        event_id = {event_id};
                    ";

                if (db.ExecuteSQLQuery(sql_query)) 
                { 
                    MessageBox.Show("Event Successfully Updated", "Booking Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            this.Close();
        }

        private bool validate_fields()
        {
            if (str_txtbox_is_empty(txtEventName, "Event Name")) return false;
            if (str_txtbox_is_empty(txtCustomerName, "Customer Name")) return false;

            if (str_txtbox_is_empty(txtPhoneNumber, "Customer Phone Number")) return false;
            if (!is_valid_phone_number(txtPhoneNumber, "Customer Phone Number")) return false;

            if (str_txtbox_is_empty(txtCustomerAddress, "Address")) return false;
            if (str_txtbox_is_empty(txtEventType, "Event Type")) return false;
            if (!int_txtbox_is_num(txtNumOfGuests, "Number of Guests")) return false;

            // make sure user can only select current day and onwards for new bookings.
            if (operation_type == "new")
            {
                // Date time check
                DateTime now_date = DateTime.Now.Date;
                DateTime user_input_date = dateTimeDate.Value.Date;

                if (user_input_date < now_date)
                {
                    MessageBox.Show("Invalid date: Cannot assign past dates for new events", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dateTimeDate.Focus();
                    return false;
                }
            }

            return true;
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
            foreach (char c in txtbox.Text)
            {
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

        /// <summary>
        /// Checks if input is a valid number
        /// </summary>
        /// <param name="txtbox"></param>
        /// <param name="label"></param>
        /// <returns></returns>
        bool int_txtbox_is_num(TextBox txtbox, String label)
        {
            int number = 0;
            bool result = int.TryParse(txtbox.Text, out number);

            if (!result || number < 1)
            {
                MessageBox.Show("Field Required: " + label + " must be a valid positive number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtbox.Focus();
                txtbox.SelectAll();
                return false;
            }

            return true;
        }

        private void btnCancelEvent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to cancel this event?", "Cancel Booking", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);

            if (result == DialogResult.OK) { 
                String sql = $@"UPDATE events SET event_status = 'Cancelled' WHERE event_id = '{event_id}';";
                db.ExecuteSQLQuery(sql);
                this.Close();
            }
        }
    }
}
