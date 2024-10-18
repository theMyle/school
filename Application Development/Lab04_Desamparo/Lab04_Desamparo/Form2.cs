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

        Helper helper = new Helper();
        Database db = new Database();
        Dictionary<string, string> vendor_id_name_pair;

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
            vendor_id_name_pair = helper.LoadVendors(comboBox_vendor);
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
            if (helper.TxtBoxIsEmpty(txtbox_code, "Code")) return;
            if (helper.TxtBoxIsEmpty(txtbox_description, "Description")) return;
            if (helper.TxtBoxIsEmpty(txtbox_stocks, "Stock")) return;
            if (helper.TxtBoxIsEmpty(txtbox_minimum_stock, "Minimum Stock")) return;
            if (helper.TxtBoxIsEmpty(txtbox_price, "Price")) return;
            if (helper.TxtBoxIsEmpty(txtbox_discount, "Discount")) return;
            if (helper.ComboBoxIsEmpty(comboBox_vendor, "Vendor")) return;

            code = txtbox_code.Text;
            description = txtbox_description.Text;
            vendor = comboBox_vendor.Text;

            if (!helper.ParseInput(txtbox_stocks, "Stock", out stocks)) return;
            if (!helper.ParseInput(txtbox_minimum_stock, "Minimum Stock", out min_stocks)) return;
            if (!helper.ParseInput(txtbox_price, "Price", out price)) return;
            if (!helper.ParseInput(txtbox_discount, "Discount", out discount)) return;
            discount /= 100;

            InsertNewProduct();
            values_inserted = true;
            Close();
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
                helper.CreateNewVendor(ref vendor_id_name_pair, vendor);
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
