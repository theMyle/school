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
        String operation_type = "";
        String selected_event_id = "";
        Database db = new Database();

		// EVENT REGISTRATION FORM
        public EventRegistration(String operation, String event_id)
        {
            InitializeComponent();

            operation_type = operation;     // set operation type 

            if (operation_type == "new")    // Initialize if operation is "new"
            {
                label15.Visible = false;
                event_status_combo.Visible = false;
                event_status_combo.SelectedIndex = 1;
            }

            if (operation_type == "update")  // Initialize if operation is "update"
            {
                registration_type.Text = "(update)";
                selected_event_id = event_id;
                Load_Data();                // load content to form
            }
        }

        /// <summary>
        /// Loads data into the form
        /// </summary>
        public void Load_Data()
        {
            // query Data
            String query = 
                $@"SELECT
                    event_id,
                    event_name,
                    customer_name,
                    customer_address,
                    customer_phone,
                    customer_email,
                    event_type,
                    event_name,
                    event_start_datetime as event_start_date, 
                    event_end_date, 
                    event_preferences,
                    number_of_guests,
                    status
                  FROM events
                  INNER JOIN customers
                    ON events.customer_id = customers.customer_id
                  WHERE
                    event_id = {selected_event_id};";

            DataTable table = db.QueryData(query);
            if (table != null)
            {
                // process the table
                foreach (DataRow row in table.Rows) 
                {
                    // load customer info
                    customer_name.Text = row["customer_name"].ToString();
                    customer_address.Text = row["customer_address"].ToString();
                    customer_phone.Text = row["customer_phone"].ToString();
                    customer_email.Text = row["customer_email"].ToString();

                    DateTime start_date = Convert.ToDateTime(row["event_start_date"]);
                    DateTime end_date = Convert.ToDateTime(row["event_end_date"]);
                    int total_days = 1 + (end_date - start_date).Days;

                    // load event info
                    event_type.Text = row["event_type"].ToString();
                    event_name.Text = row["event_name"].ToString();
                    event_date.Value = start_date;
                    event_duration.Text = total_days.ToString();
                    event_time.Value = start_date;
                    event_preferences.Text = row["event_preferences"].ToString();
                    event_status_combo.Text = row["status"].ToString();
                    event_guests.Text = row["number_of_guests"].ToString();
                }
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // validate inputs
            if (!validate_fields()) return;

            // load form data into variables
            String sql_query = "";

            String name = customer_name.Text.Trim();
            String address = customer_address.Text.Trim();
            String phone_number = customer_phone.Text.Trim();
            String email = customer_email.Text.Trim();

            String evt_type = event_type.Text.Trim();
            String evt_name = event_name.Text.Trim();
            String date_now = DateTime.Now.ToString("yyyy-MM-dd");
            String evt_preferences = event_preferences.Text.Trim();
            String evt_status = event_status_combo.Text.Trim();
            int evt_guests= int.Parse(event_guests.Text);

            // initialize start date with the specified time
            DateTime dateTimeBuffer = new DateTime(
                event_date.Value.Year,
                event_date.Value.Month,
                event_date.Value.Day,
                event_time.Value.Hour,
                event_time.Value.Minute,
                event_time.Value.Second);
            String evt_start_date = dateTimeBuffer.ToString("yyyy-MM-dd h:mm tt");
            String customer_id = "";

            // calculate end date using start date and event duration
            int evt_duration = int.Parse(event_duration.Text) - 1;
            String evt_end_date = event_date.Value.AddDays(evt_duration).ToString("yyyy-MM-dd");

            // retrieve the id of the customer
            customer_id = find_customer_id(name, phone_number, address, email);

            /// CODE FOR NEW BOOKING
            if (operation_type == "new")
            {
                // load the insert query
                sql_query = $@"
                    INSERT INTO events (event_name, event_type, date_booked, event_start_datetime, event_end_date, number_of_guests, event_preferences, status, customer_id)
                    VALUES ('{evt_name}',
                            '{evt_type}',
                            '{date_now}',
                            '{evt_start_date}',
                            '{evt_end_date}',
                            '{evt_guests}',
                            '{evt_preferences}',
                            'scheduled',
                            '{customer_id}');
                    ";

            }
            else if (operation_type == "update")
            { 
                // load the update query
                sql_query = $@"
                    UPDATE events
                    SET 
                        event_name = '{evt_name}',
                        event_type = '{evt_type}',
                        event_start_datetime = '{evt_start_date}',
                        event_end_date= '{evt_end_date}',
                        number_of_guests = '{evt_guests}',
                        event_preferences = '{evt_preferences}',
                        status = '{evt_status}',
                        customer_id = '{customer_id}'
                    WHERE
                        event_id = {selected_event_id};
                    ";
            }

            // Executes the query
            db.ExecuteNonQuery(sql_query);

            MessageBox.Show("Event Successfully Booked", "New Booking Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        /// <summary>
        /// Checks if the customer exists and retrieves customer ID.
        /// If customer does not exists it inserts the information as new customer and returns Its customer ID.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        private String find_customer_id(String name, String phone, String address, String email) 
        { 
            // check if customer exists
            // it exists if it has the same:
            // name, address, and phone number.
            string sql = 
                $@"SELECT
                        customer_id
                    FROM 
                        customers
                    WHERE
                        LOWER(customer_name) = LOWER('{name}') AND 
                        LOWER(customer_phone) = LOWER('{phone}') AND 
                        LOWER(customer_address) = LOWER('{address}');
                ";

            DataTable table = db.QueryData(sql);

            // if it does not exist, add it as a new customer
            if (table == null || table.Rows.Count == 0)
            {
                // insert new customer
                string new_customer = 
                    $@"
                    INSERT INTO customers (customer_name, customer_phone, customer_address, customer_email)
                    VALUES ('{name}',
                            '{phone}',
                            '{address}',
                            '{email}');
                    ";

                db.ExecuteNonQuery(new_customer);
                table = db.QueryData(sql);
            }

                // retrieve the id of the customer
            String customer_id = table.Rows[0]["customer_id"].ToString();
            return customer_id;
        }

        /// <summary>
        /// Validate all form fields
        /// Returns true when all fields are valid
        /// </summary>
        private bool validate_fields() 
        {
            // Customer Details Validation
            if (str_txtbox_is_empty(customer_name, "Customer Name")) return false;
            if (str_txtbox_is_empty(customer_address, "Customer Address")) return false;

            if (str_txtbox_is_empty(customer_phone, "Customer Phone Number")) return false;
            if (!is_valid_phone_number(customer_phone, "Customer Phone Number")) return false;

            // Event Details Validation
            if (combo_box_selection_is_empty(event_type, "Event Type")) return false;
            if (combo_box_selection_is_empty(event_status_combo, "Event Status")) return false;
            if (str_txtbox_is_empty(event_name, "Event Name")) return false;
            if (!int_txtbox_is_num(event_duration, "Event Duration")) return false;
            if (!int_txtbox_is_num(event_guests, "Event No. Of Guests")) return false;

            // make sure user can only select current day and onwards for new bookings.
            if (operation_type == "new")
            {
                // Date time check
                DateTime now_date = DateTime.Now.Date;
                DateTime user_input_date = event_date.Value.Date;

                if (user_input_date < now_date)
                {
                    MessageBox.Show("Invalid date: Cannot assign past dates for new events", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    event_date.Focus();
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

        /// <summary>
        /// Checks if combo box has an items selected
        /// </summary>
        /// <param name="cbox"></param>
        /// <param name="label"></param>
        /// <returns></returns>
        bool combo_box_selection_is_empty(ComboBox cbox, String label) 
        {
            if (string.IsNullOrEmpty(cbox.Text))
            {
                MessageBox.Show("Field Required: " + label + " must not be empty", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbox.Focus();
                cbox.SelectAll();
                return true;
            }
            return false;
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

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

