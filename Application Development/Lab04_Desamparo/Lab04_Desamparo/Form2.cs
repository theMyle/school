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

namespace Lab04_Desamparo
{
    public partial class Form2 : Form
    {
        private Form1 _form1;
        private bool values_inserted = false;

        Database db = new Database();
        Dictionary<string, string> vendor_id_name_pair = new Dictionary<string, string>();
        String code = "";
        String description = "";
        String vendor = "";
        int stocks = 0;
        int min_stocks = 0;
        double price = 0;
        double discount = 0;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            LoadVendors();
        }

        /// <summary>
        /// Close the form, cancel the transcation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            _form1.Set_Operation_Status("New Item Insert Operation Cancelled");
            Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            // Validate Inputs
            if (TxtBoxIsEmpty(txtbox_code, "Code")) return;
            if (TxtBoxIsEmpty(txtbox_description, "Description")) return;
            if (TxtBoxIsEmpty(txtbox_stocks, "Stock")) return;
            if (TxtBoxIsEmpty(txtbox_minimum_stock, "Minimum Stock")) return;
            if (TxtBoxIsEmpty(txtbox_price, "Price")) return;
            if (TxtBoxIsEmpty(txtbox_discount, "Discount")) return;
            if (ComboBoxIsEmpty(comboBox_vendor, "Vendor")) return;

            code = txtbox_code.Text;
            description = txtbox_description.Text;
            vendor = comboBox_vendor.Text;

            if (!ParseInput(txtbox_stocks, "Stock", out stocks)) return;
            if (!ParseInput(txtbox_minimum_stock, "Minimum Stock", out min_stocks)) return;
            if (!ParseInput(txtbox_price, "Price", out price)) return;
            if (!ParseInput(txtbox_discount, "Discount", out discount)) return;
            discount /= 100;

            InsertNewProduct();
            values_inserted = true;
            Close();
            // ClearForm();
        }

        /// <summary>
        /// Ensures textbox is not empty.
        /// Returns TRUE when textbox is empty.
        /// </summary>
        /// <param name="txtbox"></param>
        /// <param name="txtboxName"></param>
        /// <returns></returns>
        private bool TxtBoxIsEmpty(TextBox txtbox, String txtboxName) {
            if (String.IsNullOrEmpty(txtbox.Text))
            {
                MessageBox.Show("Product " + txtboxName + " must not be empty", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbox.Focus();
                txtbox.SelectAll();
                return true;
            }
            else return false;
        }

        private bool ComboBoxIsEmpty(ComboBox comboBox, string comboBoxName) {
            if (String.IsNullOrEmpty(comboBox.Text))
            {
                MessageBox.Show("Product " + comboBoxName + " must not be empty", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBox.Focus();
                comboBox.SelectAll();
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Parses contents of a textbox into a variable.
        /// Returns TRUE when successful and FALSE when the parsing failed.
        /// </summary>
        /// <param name="txtbox"></param>
        /// <param name="txtboxName"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        private bool ParseInput(TextBox txtbox, String txtboxName, out int output) {
            try
            {
                output = int.Parse(txtbox.Text);
            }
            catch
            {
                output = 0;
                MessageBox.Show(
                    "Invalid " + txtboxName + ", must be a number",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                txtbox.Focus();
                txtbox.SelectAll();
                return false;
            }
            return true;
        }

        /// <summary>
        /// Parses contents of a textbox into a variable.
        /// Returns TRUE when successful and FALSE when the parsing failed.
        /// </summary>
        /// <param name="txtbox"></param>
        /// <param name="txtboxName"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        private bool ParseInput(TextBox txtbox, String txtboxName, out double output) {
            try
            {
                output = double.Parse(txtbox.Text);
            }
            catch
            {
                output = 0;
                MessageBox.Show(
                    "Invalid " + txtboxName + ", must be a number",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
                txtbox.Focus();
                txtbox.SelectAll();
                return false;
            }
            return true;
        }

        private void LoadVendors()
        {
            String sql_command = "SELECT v_code, v_name FROM vendor;";
            DataTable table = db.GetRows( sql_command );

            foreach (DataRow row in table.Rows)
            {
                String v_name = row["v_name"].ToString();
                String v_code = row["v_code"].ToString();

                comboBox_vendor.Items.Add(v_name);
                vendor_id_name_pair[v_name] = v_code;
            }
        }

        /// <summary>
        /// Inserts new product into the database.
        /// </summary>
        private void InsertNewProduct() 
        {
            String sql_command = @"INSERT INTO product (p_code, p_descript, p_qoh, p_min, p_price, p_discount, v_code)
                                    VALUES(@code, @description, @stocks, @min_stocks, @price, @discount, @vendor_code)";

            
            // check if vendor is already present in the database
            if (!vendor_id_name_pair.ContainsKey(vendor))
            {
                CreateNewVendor();
            }
            
            Dictionary<String, Object> sql_args = new Dictionary<String, Object>();
            sql_args.Add("@code", code);
            sql_args.Add("@description", description);
            sql_args.Add("@stocks", stocks);
            sql_args.Add("@min_stocks", min_stocks);
            sql_args.Add("@price", price);
            sql_args.Add("@discount", discount);
            sql_args.Add("@vendor_code", vendor_id_name_pair[vendor]);
            db.Insert(sql_command, sql_args);
        }

        /// <summary>
        /// Inserts new vendor into the database
        /// </summary>
        private void CreateNewVendor()
        {
            // get the max v_code value and increment it by one
            int max_vcode = 0;
            DataTable table = db.GetRows("SELECT MAX(v_code) FROM vendor");

            if (!int.TryParse(table.Rows[0][0].ToString(), out max_vcode))
            {
                MessageBox.Show("Failed to get max v_code from the database\n",
                    "Insert New Product Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                return;
            }
            max_vcode += 1;

            String sql_command = @"INSERT INTO vendor (v_code, v_name)
                                VALUES (@v_code, @v_name)";

            Dictionary<String, Object> sql_args = new Dictionary<String, Object>();
            sql_args.Add("@v_code", max_vcode);
            sql_args.Add("@v_name", vendor);
            db.Insert(sql_command, sql_args);

            vendor_id_name_pair[vendor] = max_vcode.ToString();
        }

        private void ClearForm()
        {
            txtbox_code.Clear();
            txtbox_description.Clear();
            txtbox_stocks.Clear();
            txtbox_minimum_stock.Clear();
            txtbox_price.Clear();
            txtbox_discount.Clear();
            comboBox_vendor.SelectedItem = null;
            txtbox_code.Focus();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (values_inserted)
            {
                _form1.Set_Operation_Status($"Operation Success | New Item Inserted | Item Code: {code}");
                _form1.Load_Data();
            }
        }
    }
}
