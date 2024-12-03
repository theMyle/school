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

namespace SaleCoSystem
{
    public partial class frmProductAE : Form
    {
        public frmProductAE()
        {
            InitializeComponent();
        }

        clsDatabase DB = new clsDatabase();

        public string PCODE = "";
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!validForm()) return;

            string sql;
            if (PCODE != "")
            {
                sql = $@"
                            UPDATE product
                            SET
                            p_descript='{txtDescription.Text}',
                            p_price='{txtPrice.Text}',
                            p_qoh='{txtQty.Text}',
                            p_min='{txtReorder.Text}',
                            p_discount='{txtDiscount.Text}'
                            WHERE p_code='{PCODE}'
                        ";

            }
            else
            {
                sql = $@"
                        INSERT INTO product                            
                            (p_code, p_descript, p_price, p_qoh, p_min, p_discount, v_code)                            
                            VALUES
                            ('{txtCode.Text}', '{txtDescription.Text}', '{txtPrice.Text}', '{txtQty.Text}', '{txtReorder.Text}', '{txtDiscount.Text}', 21344)";
            }

            if (DB.ExecuteSQLQuery(sql))
            {
                MessageBox.Show("Product has been saved successfully.", "Product Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error Saving product.", "New Product", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void frmProductAE_Load(object sender, EventArgs e)
        {
            if (PCODE != "")
            {
                string sql = $@"SELECT
                          p_code,
                          p_descript,
                          p_price,
                          p_qoh,
                          p_min,
                          p_discount
                        FROM product p
                        WHERE p_code='{PCODE}'";
                DataTable dt = DB.QueryData(sql);
                if (dt != null)
                {
                    txtCode.Text = dt.Rows[0]["p_code"].ToString();
                    txtCode.ReadOnly = true;
                    txtDescription.Text = dt.Rows[0]["p_descript"].ToString();
                    txtPrice.Text = dt.Rows[0]["p_price"].ToString();
                    txtQty.Text = dt.Rows[0]["p_qoh"].ToString();
                    txtReorder.Text = dt.Rows[0]["p_min"].ToString();
                    txtDiscount.Text = dt.Rows[0]["p_discount"].ToString();
                }
            }

        }

        // returns false when there are input errors
        // returns true when form is good and valid
        bool validForm() {
            // description, quantity, price, reorder level, discount
            if (stringIsEmpty(txtCode, "Product Code")) return false;
            if (stringIsEmpty(txtDescription, "Description")) return false;
            if (invalidInt(txtQty, "Quantity")) return false;
            if (invalidInt(txtPrice, "Price")) return false;
            if (invalidInt(txtReorder, "Reorder Level")) return false;
            if (invalidDiscount(txtDiscount, "Discount")) return false;
            return true;
        }

        bool stringIsEmpty(TextBox input, string label) {
            if (string.IsNullOrEmpty(input.Text))
            {
                MessageBox.Show($"{label} must not be empty", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                input.Focus();
                input.SelectAll();
                return true;
            }
            else {
                return false;
            }
        }

        bool invalidInt(TextBox input, string label) {
            double buffer = 0;
            try
            {
                buffer = double.Parse(input.Text);
            }
            catch {
                MessageBox.Show($"{label} empty or invalid (Please enter a valid input)", $"Invalid {label}", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                input.Focus();
                input.SelectAll();
                return true;
            }
            return false;
        }

        bool invalidDiscount(TextBox input, string label) {
            try
            {
                double buffer = double.Parse(input.Text);
                if (buffer > 100 || buffer < 0) 
                { 
                    MessageBox.Show($"{label} invalid (Must only be 0 - 100)", $"Invalid {label}", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    input.Focus();
                    input.SelectAll();
                    return true;
                }
            }
            catch {
                MessageBox.Show($"{label} empty or invalid (Please enter a valid input)", $"Invalid {label}", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                input.Focus();
                input.SelectAll();
                return true;
            }
            return false;
        }
    }
}
