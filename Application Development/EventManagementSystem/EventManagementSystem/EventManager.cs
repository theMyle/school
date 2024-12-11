using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventManagementSystem
{
    public partial class EventManager : Form
    {

        // create a database class instance
        Database db = new Database();

        public EventManager()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads content from database to application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventManager_Load(object sender, EventArgs e)
        {
            // query Data
            String query = 
                @"SELECT
                    event_id,
                    event_name,
                    customer_name,
                    customer_phone,
                    event_start as event_date, 
                    event_start as start_time,
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
                    String customer_name = row["event_name"].ToString();
                    String customer_phone = row["customer_phone"].ToString();
                    // Convert to date time and fix formatting
                    String event_date = Convert.ToDateTime(row["event_date"]).ToString("dd-MMM-yyyy");
                    // Convert to date time and fix formatting
                    String event_time = Convert.ToDateTime(row["event_date"]).ToString("h:mm tt");   
                    String event_status = row["status"].ToString().ToUpper();

                    datagrid_events.Rows.Add(
                        id, event_name, customer_name, 
                        customer_phone, event_date, event_time, 
                        event_status
                        );
                }
            }

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            EventRegistration form = new EventRegistration();
            form.ShowDialog();
        }
    }
}
