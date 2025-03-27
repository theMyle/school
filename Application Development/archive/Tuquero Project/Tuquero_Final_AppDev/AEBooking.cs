using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuquero_Final_AppDev
{
    public partial class frmAddBook : Form
    {
        String event_id;
        String form_type;
        clsDatabase db = new clsDatabase();

        public frmAddBook(String type, String eventID)
        {
            InitializeComponent();

            event_id = eventID;
            form_type = type;

            if (type == "new")
            {
                // code here
            }
            if (type == "update")
            {
                //code here
                lblTitle.Text = "Update Booking";

                String sql = $@"SELECT 
                                    event_type, event_name, start_date, number_guests, description,
                                    customer_name, address, contact_number, email
                                FROM EVENTS
                                INNER JOIN event_type
                                    ON event_type.event_id = events.event_id
                                INNER JOIN bookings
                                    ON bookings.booking_id = events.booking_id
                                WHERE booking_pk = {event_id}
                                ORDER BY start_date;";

                DataTable table = db.QueryData(sql);

                foreach (DataRow dr in table.Rows )
                {
                    cboEventType.Text = dr["event_type"].ToString();
                    txtEventName.Text = dr["event_name"].ToString();
                    dtpStart.Value = Convert.ToDateTime(dr["start_date"]);
                    txtNumGuest.Text = dr["number_guests"].ToString();
                    txtDescript.Text = dr["description"].ToString();

                    txtCusName.Text = dr["customer_name"].ToString();
                    txtAddress.Text = dr["address"].ToString();
                    txtContact.Text = dr["contact_number"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtCusName.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtEventName.Text) ||
                string.IsNullOrWhiteSpace(txtNumGuest.Text) ||
                cboEventType.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (form_type == "update")
            {
                string updateSql = $@"
                    UPDATE EVENTS
                    INNER JOIN event_type ON event_type.event_id = events.event_id
                    INNER JOIN bookings ON bookings.booking_id = events.booking_id
                    SET 
                        event_type.event_type = @EventType,
                        events.event_name = @EventName,
                        events.start_date = @StartDate,
                        events.number_guests = @NumGuests,
                        events.description = @Description,
                        bookings.customer_name = @CustomerName,
                        bookings.address = @Address,
                        bookings.contact_number = @ContactNumber,
                        bookings.email = @Email
                    WHERE events.booking_pk = @EventId;";

                var updateParams = new Dictionary<string, object>
                        {
                            { "@EventType", cboEventType.Text },
                            { "@EventName", txtEventName.Text },
                            { "@StartDate", dtpStart.Value },
                            { "@NumGuests", txtNumGuest.Text },
                            { "@Description", txtDescript.Text },
                            { "@CustomerName", txtCusName.Text },
                            { "@Address", txtAddress.Text },
                            { "@ContactNumber", txtContact.Text },
                            { "@Email", txtEmail.Text },
                            { "@EventId", event_id} // Replace with the actual event ID.
                        };

                if (db.ExecuteSQLQuery(updateSql, updateParams))
                {
                    MessageBox.Show("Booking added Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to update event information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Insert customer information into the bookings table
                string insertBookingSql = @$"INSERT INTO bookings (customer_name, address, contact_number, email)
                                             VALUES (@CustomerName, @Address, @ContactNumber, @Email)";

                // Create parameters for the booking
                var bookingParams = new Dictionary<string, object>
                {
                    { "@CustomerName", txtCusName.Text },
                    { "@Address", txtAddress.Text },
                    { "@ContactNumber", txtContact.Text },
                    { "@Email", txtEmail.Text }
                };

                // Execute the insert command
                if (db.ExecuteSQLQuery(insertBookingSql, bookingParams))
                {
                    // Get the last inserted booking ID
                    long bookingId = db.ExecuteQryScalar("SELECT LAST_INSERT_ID()");

                    // Insert event information into the events table
                    string insertEventSql = @$"INSERT INTO events (booking_id, event_name, description, start_date, event_id, status, number_guests)
                                               VALUES (@BookingId, @EventName, @Description, @StartDate , @EventId, 'Upcoming', @Guests)";

                    // Create parameters for the event
                    var eventParams = new Dictionary<string, object>
                    {
                        { "@BookingId", bookingId },
                        { "@EventName", txtEventName.Text },
                        { "@Description", txtDescript.Text },
                        { "@StartDate", dtpStart.Value },
                        { "@EventId", cboEventType.SelectedValue },
                        { "@Guests", txtNumGuest.Text}// Assuming the ComboBox is filled with event types
                    };

                    // Execute the insert command for the event
                    if (db.ExecuteSQLQuery(insertEventSql, eventParams))
                    {
                        MessageBox.Show("Booking added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add event information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Failed to add booking information.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearForm()
        {
            txtCusName.Clear();
            txtAddress.Clear();
            txtContact.Clear();
            txtEmail.Clear();
            txtEventName.Clear();
            txtNumGuest.Clear();
            txtDescript.Clear();
            cboEventType.SelectedIndex = -1; // Reset ComboBox selection
            dtpStart.Value = DateTime.Now; // Reset DateTimePicker
        }


        private void frmAddBook_Load(object sender, EventArgs e)
        {
            // Fill the ComboBox with event types
            db.FillComboBox("SELECT event_id, event_type FROM event_type", "event_id", "event_type", cboEventType);

            // Debug: Check the items in the ComboBox
            foreach (var item in cboEventType.Items)
            {
                Console.WriteLine(item.ToString());
            }

            if (!string.IsNullOrEmpty(event_id))
            {
                string _sql = $@"SELECT * FROM events 
                         WHERE event_id = '{event_id}'";

                DataTable _dt = db.QueryData(_sql);

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
