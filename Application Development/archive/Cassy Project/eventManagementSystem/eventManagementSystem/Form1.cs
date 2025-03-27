using SaleCoSystem;
using System;
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
    public partial class Form1 : Form
    {
        clsDatabase db = new clsDatabase();
        String selected_event;

        public Form1()
        {
            InitializeComponent();
        }

        // Load Contents to Form
        private void Form1_Load(object sender, EventArgs e)
        {
            // Load Data to Grid
            Load_Grid();
        }

        private void Load_Grid()
        {
            dataGridView1.Rows.Clear();

            String sql = $@"SELECT
                            event_id, event_name, customer_name, customer_phone, event_type, event_date_time, event_status
                            FROM events
                            WHERE 
                                LOWER(event_status) != 'ended' AND
                                LOWER(event_status) != 'cancelled'
                            ORDER BY event_date_time;
                            ";

            DataTable table = db.QueryData(sql);

            if (table == null) return;

            foreach (DataRow dr in table.Rows)
            {
                String event_id = dr["event_id"].ToString();
                String event_name = dr["event_name"].ToString();
                String customer_name = dr["customer_name"].ToString();
                String customer_phone = dr["customer_phone"].ToString();
                String event_type = dr["event_type"].ToString();
                String event_date = Convert.ToDateTime(dr["event_date_time"].ToString()).ToString("dd-MMM-yyyy");
                String event_time = Convert.ToDateTime(dr["event_date_time"].ToString()).ToString("h:mm tt");
                String event_status = dr["event_status"].ToString();

                dataGridView1.Rows.Add(event_id, event_name, customer_name, customer_phone,
                    event_type, event_date, event_time, event_status);
            }
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Load_Grid();
            txtbox_filter_event_type.Text = "";
            dateFrom.Value = DateTime.Today;
            dateTo.Value = DateTime.Today;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            Form2 insert = new Form2("new", selected_event);
            insert.ShowDialog();

            Load_Grid();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selected_event = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            }

            switch (e.ColumnIndex)
            {
                case 8:
                    Form2 update = new Form2("update", selected_event);
                    update.ShowDialog();
                    Load_Grid();
                    break;
                case 9:
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this booking?", "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);

                    if (result == DialogResult.Cancel)
                    {
                        return;
                    } 

                    string sql = $@"DELETE FROM events 
                                WHERE event_id='{selected_event}'";

                    if (db.ExecuteSQLQuery(sql))
                    {
                        MessageBox.Show("Product has been successfully deleted.", "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Load_Grid();
                    }
                    else
                    {
                        MessageBox.Show("Error Deleting product.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            DateTime today = DateTime.Today;
            String startDate = dateFrom.Value.ToString("yyy-MM-dd");
            String endDate = dateTo.Value.ToString("yyy-MM-dd");
            String eventType = txtbox_filter_event_type.Text.ToLower().Trim();

            String sql = $@"SELECT
                            event_id, event_name, customer_name, customer_phone, event_type, event_date_time, event_status
                            FROM events
                            WHERE 
                                LOWER(event_status) != 'ended' AND
                                LOWER(event_status) != 'cancelled' AND
                                DATE(event_date_time) >= '{startDate}' AND
                                DATE(event_date_time) <= '{endDate}' AND
                                event_type LIKE '%{eventType}%'
                            ORDER BY event_date_time;
                            ";

            DataTable table = db.QueryData(sql);

            if (table == null) return;

            foreach (DataRow dr in table.Rows)
            {
                String event_id = dr["event_id"].ToString();
                String event_name = dr["event_name"].ToString();
                String customer_name = dr["customer_name"].ToString();
                String customer_phone = dr["customer_phone"].ToString();
                String event_type = dr["event_type"].ToString();
                String event_date = Convert.ToDateTime(dr["event_date_time"].ToString()).ToString("dd-MMM-yyyy");
                String event_time = Convert.ToDateTime(dr["event_date_time"].ToString()).ToString("h:mm tt");
                String event_status = dr["event_status"].ToString();

                dataGridView1.Rows.Add(event_id, event_name, customer_name, customer_phone,
                    event_type, event_date, event_time, event_status);
            }
        }
    }
}
