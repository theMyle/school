using System.Data;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Tuquero_Final_AppDev
{
    public partial class frmManageBooking : Form
    {
        String event_ID;
        public frmManageBooking()
        {
            InitializeComponent();

            // Fill the ComboBox with event types
            DB.FillComboBox("SELECT event_id, event_type FROM event_type", "event_id", "event_type", comboBox1);
        }

        clsDatabase DB = new clsDatabase();
        private void loadData()
        {
            //string _sql = $@"
            //        SELECT 
            //        b.booking_id AS booking_code,
            //        booking_pk,
            //        et.event_id,
            //        et.event_type,
            //        e.event_name,
            //        e.start_date,
            //        b.customer_name,
            //        b.booking_date_time AS booking_date,
            //        b.contact_number,
            //        CASE 
            //        WHEN NOW() BETWEEN e.start_date AND e.end_date THEN 'Ongoing'
            //        WHEN NOW() < e.start_date THEN 'Upcoming'
            //        WHEN NOW() > e.end_date THEN 'Done'
            //        ELSE 'Cancelled'
            //        END AS status
            //        FROM bookings b
            //        LEFT JOIN events e ON b.booking_id = e.booking_id
            //        LEFT JOIN event_type et ON e.event_id = et.event_id
            //        ORDER BY start_date;";

            String _sql = @$"SELECT
                    booking_pk, event_type, event_name, customer_name, contact_number, start_date, status
                    FROM events
                    Inner JOIN event_type
                    ON event_type.event_id = events.event_id
                    inner JOIN bookings
                    on bookings.booking_id = events.booking_id
                    ORDER BY start_date;";

            // Query data using your database helper
            DataTable _dt = DB.QueryData(_sql);
            if (_dt != null)
            {
                // Clear existing rows in the DataGridView
                DGV.Rows.Clear();

                // Iterate through the rows in the result set and add them to the DataGridView
                foreach (DataRow dr in _dt.Rows)
                {
                    // calculate time
                    DateTime now = DateTime.Now;
                    DateTime dateTime = Convert.ToDateTime(dr["start_date"]);

                    String event_id = dr["booking_pk"].ToString();
                    String status = dr["status"].ToString();

                    if (status == "Cancelled")
                    {
                        // Ignore
                    }
                    else if (dateTime.Date < now.Date)
                    {
                        status = "Done";
                    }
                    else if (dateTime.Date > now.Date)
                    {
                        status = "Upcoming";
                    }
                    else if (dateTime.Date == now.Date)
                    {
                        status = "Ongoing";
                    }

                    // update query
                    // hain?
                    String sql_update =
                                    $@"
                                    UPDATE events
                                    SET status = '{status}'
                                    WHERE booking_pk = {event_id};";

                    DB.ExecuteSQLQuery(sql_update);

                    DGV.Rows.Add(
                        dr["booking_pk"].ToString(),
                        dr["event_type"].ToString(),   // Event Type
                        dr["event_name"].ToString(),    // Event Name
                        dr["customer_name"].ToString(),  // Customer Name
                        dr["contact_number"].ToString(),
                        Convert.ToDateTime(dr["start_date"].ToString()).ToString("dd-MMM-yyyy hh:mm tt"), // Start Date and Time
                        status
                    );
                }
            }
        }
        private void frmManageBooking_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadData();
            comboBox1.Text = "";
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frmAddBook AddBook = new frmAddBook("new", event_ID);
            AddBook.ShowDialog();

            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(event_ID))
            {
                MessageBox.Show("Please select a booking to update", "No Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmAddBook editProduct = new frmAddBook("update", event_ID);
            editProduct.ShowDialog();

            loadData();
        }


        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DGV.Rows.Clear();

            String eventType = comboBox1.Text;
            String start_date = dateTimePicker1.Value.ToString("yyy-MM-dd");
            String end_date = dateTimePicker2.Value.ToString("yyy-MM-dd");

            String _sql = $@"
                    SELECT 
                    b.booking_id AS booking_code,
                    et.event_id,
                    et.event_type,
                    booking_pk,
                    e.event_name,
                    e.start_date,
                    b.customer_name,
                    b.booking_date_time AS booking_date,
                    b.contact_number,
                    CASE 
                    WHEN NOW() BETWEEN e.start_date AND e.end_date THEN 'Ongoing'
                    WHEN NOW() < e.start_date THEN 'Upcoming'
                    WHEN NOW() > e.end_date THEN 'Done'
                    ELSE 'Cancelled'
                    END AS status
                    FROM bookings b
                    LEFT JOIN events e ON b.booking_id = e.booking_id
                    LEFT JOIN event_type et ON e.event_id = et.event_id
                    WHERE
                        LOWER(status) != 'ended' AND
                        LOWER(status) != 'cancelled' AND
                        DATE(start_date) >= '{start_date}' AND
                        DATE(start_date) <= '{end_date}' AND
                        event_type LIKE '%{eventType}%'
                        ORDER BY start_date;
                    ";

            // Query data using your database helper
            DataTable _dt = DB.QueryData(_sql);
            if (_dt != null)
            {
                // Iterate through the rows in the result set and add them to the DataGridView
                foreach (DataRow dr in _dt.Rows)
                {
                    DGV.Rows.Add(
                        dr["booking_pk"].ToString(),
                        dr["event_type"].ToString(),   // Event Type
                        dr["event_name"].ToString(),    // Event Name
                        dr["customer_name"].ToString(),  // Customer Name
                        dr["contact_number"].ToString(),
                        Convert.ToDateTime(dr["start_date"].ToString()).ToString("dd-MMM-yyyy hh:mm tt"), // Start Date and Time
                        dr["status"]
                    );
                }
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                event_ID = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(event_ID))
            {
                MessageBox.Show("Please select a booking to update", "No Booking Selected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this booking?", "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Cancel)
            {
                return;
            }

            string sql = $@"DELETE FROM events 
                                WHERE booking_pk='{event_ID}'";

            if (DB.ExecuteSQLQuery(sql))
            {
                MessageBox.Show("Product has been successfully deleted.", "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadData();
            }
            else
            {
                MessageBox.Show("Error Deleting product.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
