using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab04_Desamparo
{
    public partial class Form3 : Form
    {
        private Form1 _form1;
        private bool values_updated = false;
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

        
        public Form3(Form1 form1)
        {
            InitializeComponent();
            _form1 = form1;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            vendor_id_name_pair = helper.LoadVendors(comboBox_vendor);
            LoadProductId();
        }
        

        private void LoadProductId() 
        {
            String sql_command = "SELECT p_code FROM product";
            DataTable table = db.GetRows(sql_command);

            foreach (DataRow row in table.Rows)
            {
                String v_name = row["p_code"].ToString();
                comboBox_code.Items.Add(v_name);
            }
        }

        private void comboBox_code_DropDownClosed(object sender, EventArgs e)
        {
            String sql_command = $@"SELECT p_code, p_descript, p_qoh, p_min, p_price, p_discount, p_code, vendor.v_name 
                                    FROM product
                                    LEFT JOIN vendor ON product.v_code = vendor.v_code
                                    WHERE p_code = '{comboBox_code.Text}'";
            DataTable table = db.GetRows(sql_command);
            DataRow row = table.Rows[0];

            string description = row["p_descript"].ToString();
            string stocks = row["p_qoh"].ToString();
            string min_stocks = row["p_min"].ToString();
            string price = row["p_price"].ToString();
            string discount = row["p_discount"].ToString();
            string vendor_name = row["v_name"].ToString();

            textBox_description.Text = description;
            textBox_stocks.Text = stocks;
            textBox_min_stocks.Text = min_stocks;
            textBox_price.Text = price;
            textBox_discount.Text = discount;
            comboBox_vendor.Text = vendor_name;
        }

        /// <summary>
        /// Update product
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            // validate inputs
            if (helper.TxtBoxIsEmpty(textBox_description, "description")) return;
            if (helper.TxtBoxIsEmpty(textBox_stocks, "stocks")) return;
            if (helper.TxtBoxIsEmpty(textBox_min_stocks, "minimum stocks")) return;
            if (helper.TxtBoxIsEmpty(textBox_price, "price")) return;
            if (helper.TxtBoxIsEmpty(textBox_discount, "discount")) return;
            if (helper.ComboBoxIsEmpty(comboBox_vendor, "vendor name")) return;
            
            // parse inputs
            code = comboBox_code.Text;
            description = textBox_description.Text;
            vendor = comboBox_vendor.Text;

            if (!helper.ParseInput(textBox_stocks, "Stock", out stocks)) return;
            if (!helper.ParseInput(textBox_min_stocks, "Minimum Stock", out min_stocks)) return;
            if (!helper.ParseInput(textBox_price, "Price", out price)) return;
            if (!helper.ParseInput(textBox_discount, "Discount", out discount)) return;
            discount /= 100;

            UpdateProduct();
            values_updated = true;
            Close();
        }

        /// <summary>
        /// Updates a product in the database
        /// </summary>
        private void UpdateProduct()
        {
            // check if vendor is not present in the database
            if (!vendor_id_name_pair.ContainsKey(vendor))
            {
                helper.CreateNewVendor(ref vendor_id_name_pair, vendor);
            }

            String sql_command = @"UPDATE product
                                    SET
                                        p_descript = @description,
                                        p_qoh = @stocks,
                                        p_min = @min_stocks,
                                        p_price = @price,
                                        p_discount = @discount,
                                        v_code = @vendor_code
                                    WHERE p_code = @product_code";

            Dictionary<string, object> sql_args = new Dictionary<string, object>();
            sql_args.Add("@product_code", code);
            sql_args.Add("@description", description);
            sql_args.Add("@stocks", stocks);
            sql_args.Add("@min_stocks", min_stocks);
            sql_args.Add("@price", price);
            sql_args.Add("@discount", discount);
            sql_args.Add("@vendor_code", vendor_id_name_pair[vendor]);

            db.Update(sql_command, sql_args);
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (values_updated)
            {
                _form1.Set_Operation_Status($"Operation Success | Item Updated | Item Code: {code}");
                _form1.Load_Data();
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            _form1.Set_Operation_Status("Item Update Operation Cancelled");
            Close();
        }
    }
}
