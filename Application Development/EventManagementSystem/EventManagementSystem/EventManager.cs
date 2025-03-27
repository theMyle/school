using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class EventManager : Form
    {
        String selected_event_id = "";

        // create a database class instance
        Database db = new Database();

        public EventManager()
        {
            InitializeComponent();
            filter_event_type.SelectedIndex = 0;
            filter_eventstatus.SelectedIndex = 0;
        }

        /// <summary>
        /// Loads content from database to application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventManager_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void Load_Data() 
        { 
            // clear rows
            datagrid_events.Rows.Clear();

            // query Data
            String query = 
                @"SELECT
                    event_id,
                    event_name,
                    customer_name,
                    customer_phone,
                    event_start_datetime, 
                    event_end_date,
                    event_type,
                    status
                  FROM events
                  INNER JOIN customers
                    ON events.customer_id = customers.customer_id;";

            DataTable table = db.QueryData(query);
            if (table != null)
            {
                datagrid_events.Rows.Clear();

                // process the table
                foreach (DataRow row in table.Rows) 
                {
                    String id = row["event_id"].ToString();
                    String event_name = row["event_name"].ToString();
                    String customer_name = row["customer_name"].ToString();
                    String customer_phone = row["customer_phone"].ToString();
                    String event_type = row["event_type"].ToString();

                    // Convert to dateTime and fix formatting
                    // start date
                    DateTime start_date = Convert.ToDateTime(row["event_start_datetime"]);
                    String event_start_date = start_date.ToString("dd-MMM-yyyy");

                    // end date
                    DateTime end_date = Convert.ToDateTime(row["event_end_date"]);
                    String event_end_date = end_date.ToString("dd-MMM-yyyy");

                    // start time
                    DateTime start_time = Convert.ToDateTime(row["event_start_datetime"]);
                    String event_start_time = start_time.ToString("h:mm tt");   

                    // calcluate and update event status
                    String event_status = row["status"].ToString();
                    event_status = calculate_event_status(start_date, end_date, event_status, id);

                    datagrid_events.Rows.Add(
                        id, event_name, event_type, customer_name, 
                        customer_phone, event_start_date, event_end_date,
                        event_start_time, 
                        event_status
                    );
                }
            }
        }

        /// <summary>
        /// Calculates the right status based on the date today and the event info
        /// and updates the database records
        /// </summary>
        /// <param name="start_date"></param>
        /// <param name="end_date"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        private String calculate_event_status(DateTime start_date, DateTime end_date, String status, String event_id) 
        {
            String calculated_status = "";

            if (start_date.Date == DateTime.Now.Date ||
                DateTime.Now.Date > start_date.Date && DateTime.Now.Date < end_date.Date)
            {
                // Set status to ongoing
                // 1. if event is today
                // 2. if event start passed but date today is within start and end
                calculated_status = "ONGOING";
                
            } else if (start_date.Date < DateTime.Now.Date && end_date.Date < DateTime.Now.Date)
            {
                // Set status to ended
                // 1. if start date is alread passed date today
                calculated_status = "ENDED";
            } else 
            {
                calculated_status = "SCHEDULED";
            }

            // if status is cancelled, just keep it
            if (status.ToUpper() == "CANCELLED")
            {
                calculated_status = "CANCELLED";
            } 
            else 
            { 
            // else update it 
            String sql_update = 
                $@"
                UPDATE events
                SET status = '{calculated_status.ToLower()}'
                WHERE event_id = {event_id};";
            db.ExecuteNonQuery(sql_update);
            }

            return calculated_status;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            EventRegistration form = new EventRegistration("new", null); 
            form.ShowDialog();
            Load_Data();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // validate that a row/booking is selected
            if (string.IsNullOrEmpty(selected_event_id)) 
            {
                MessageBox.Show("Please select a booking to update", "No Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            EventRegistration form = new EventRegistration("update", selected_event_id);
            form.ShowDialog();
            selected_event_id = null;
            Load_Data();
        }

        // select a booking/row
        private void datagrid_events_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            { 
                selected_event_id = datagrid_events.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        // reloads data
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Load_Data();
            filter_event_type.SelectedIndex = 0;
            filter_eventstatus.SelectedIndex = 0;
        }

        // delete event
        private void btn_delete_Click(object sender, EventArgs e)
        {
            // validate that a row/booking is selected
            if (string.IsNullOrEmpty(selected_event_id)) 
            {
                MessageBox.Show("Please select a booking to delete", "No Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this booking? (Event_ID: " + selected_event_id + ")", 
					"Booking Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) 
            { 
                // delete the event
                string delete_query =
                    $@"
                    DELETE FROM events WHERE event_id = {selected_event_id};
                    ";

                db.ExecuteNonQuery(delete_query);
                Load_Data();
            }
        }

        // filter events
        private void btn_search_Click(object sender, EventArgs e)
        {
            String start = filter_date_from.Value.ToString("yyyy-MM-dd");
            String end = filter_date_to.Value.ToString("yyyy-MM-dd");
            String type = filter_event_type.Text.Trim().ToLower();
            String selected_status = filter_eventstatus.Text.Trim().ToLower();

            // Default search query when all fields are set to "ALL"
            String query =
                  $@"SELECT
                    event_id,
                    event_name,
                    customer_name,
                    customer_phone,
                    event_start_datetime, 
                    event_end_date,
                    event_type,
                    status
                  FROM events
                  INNER JOIN customers
                    ON events.customer_id = customers.customer_id
                  WHERE
                    DATE(event_start_datetime) >= '{start}' AND
                    DATE(event_start_datetime) <= '{end}'";

            String search_condition = "";

            datagrid_events.Rows.Clear();

            // specific search conditions
            // all 4 permutations
            // all type, all status
            if (type == "all" && selected_status == "all") 
            {
                search_condition = ";";
            }
            // specific type, all status
            else if (type != "all" && selected_status != "all")
            {
                search_condition =
                    $@"AND
                        LOWER(status) = LOWER('{selected_status}') AND
                        LOWER(event_type) = LOWER('{type}');
                    ";
            }
            // specific type, specific status
            else if (type != "all" && selected_status == "all")
            {
                search_condition =
                    $@"AND
                        DATE(event_start_datetime) >= '{start}' AND
                        DATE(event_start_datetime) <= '{end}' AND
                        LOWER(event_type) = LOWER('{type}');
                    ";
            }
            // all type, specific status
            else if (type == "all" && selected_status != "all")
            {
                search_condition =
                    $@"AND
                        DATE(event_start_datetime) >= '{start}' AND
                        DATE(event_start_datetime) <= '{end}' AND
                        LOWER(status) = LOWER('{selected_status}');
                    ";
            }

            DataTable table = db.QueryData(query + search_condition);
            if (table != null)
            {
                // process the table
                foreach (DataRow row in table.Rows) 
                {
                    String id = row["event_id"].ToString();
                    String event_name = row["event_name"].ToString();
                    String customer_name = row["customer_name"].ToString();
                    String customer_phone = row["customer_phone"].ToString();
                    String event_type = row["event_type"].ToString();

                    // Convert to dateTime and fix formatting
                    // start date
                    DateTime start_date = Convert.ToDateTime(row["event_start_datetime"]);
                    String event_start_date = start_date.ToString("dd-MMM-yyyy");

                    // end date
                    DateTime end_date = Convert.ToDateTime(row["event_end_date"]);
                    String event_end_date = end_date.ToString("dd-MMM-yyyy");

                    // start time
                    DateTime start_time = Convert.ToDateTime(row["event_start_datetime"]);
                    String event_start_time = start_time.ToString("h:mm tt");   

                    // calcluate and update event status
                    String event_status = row["status"].ToString();
                    event_status = calculate_event_status(start_date, end_date, event_status, id);

                    datagrid_events.Rows.Add(
                        id, event_name, event_type, customer_name, 
                        customer_phone, event_start_date, event_end_date,
                        event_start_time, 
                        event_status
                    );
                }
            }
        }

    }
}
