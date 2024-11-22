using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace Lab04_Desamparo
{
    public class Helper
    {
        Database db = new Database();

        /// <summary>
        /// Ensures textbox is not empty.
        /// Returns TRUE when textbox is empty.
        /// </summary>
        /// <param name="txtbox"></param>
        /// <param name="txtboxName"></param>
        /// <returns></returns>
        public bool TxtBoxIsEmpty(TextBox txtbox, String txtboxName) {
            if (String.IsNullOrEmpty(txtbox.Text))
            {
                MessageBox.Show("Product " + txtboxName + " must not be empty", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtbox.Focus();
                txtbox.SelectAll();
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Ensures that the combobox selection is not empty.
        /// Returns TRUE when it is empty
        /// </summary>
        /// <param name="comboBox"></param>
        /// <param name="comboBoxName"></param>
        /// <returns></returns>
        public bool ComboBoxIsEmpty(ComboBox comboBox, string comboBoxName) {
            if (comboBox.SelectedItem == null)
            {
                return false;
            }
            else
            {

                if (comboBox.SelectedItem.ToString() == "NULL" || string.IsNullOrEmpty(comboBox.Text))
                {
                    MessageBox.Show("Product " + comboBoxName + " must not be NULL or empty", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox.Focus();
                    comboBox.SelectAll();
                    return true;
                }
                else return false;
            }
        }

        /// <summary>
        /// Parses contents of a textbox into a variable.
        /// Returns TRUE when successful and FALSE when the parsing failed.
        /// </summary>
        /// <param name="txtbox"></param>
        /// <param name="txtboxName"></param>
        /// <param name="output"></param>
        /// <returns></returns>
        public bool ParseInput(TextBox txtbox, String txtboxName, out int output) {
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
        public bool ParseInput(TextBox txtbox, String txtboxName, out double output) {
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

        /// <summary>
        /// Load vendors into a Dictionary containing (vendor name, vendor id) as a key value pair.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> LoadVendors(ComboBox combobox)
        {
            Dictionary<string, string> vendor_id_name_pair = new Dictionary<string, string>();
            String sql_command = "SELECT v_code, v_name FROM vendor;";
            DataTable table = db.GetRows( sql_command );

            combobox.Items.Add("NULL");
            combobox.SelectedIndex = 0;
            vendor_id_name_pair["NULL"] = "";
            
            foreach (DataRow row in table.Rows)
            {
                String v_name = row["v_name"].ToString();
                String v_code = row["v_code"].ToString();

                combobox.Items.Add(v_name);
                vendor_id_name_pair[v_name] = v_code;
            }

            return vendor_id_name_pair;
        }

        /// <summary>
        /// Inserts new vendor into the database
        /// </summary>
        public void CreateNewVendor(ref Dictionary<string, string> vendor_id_name_pair, string vendor_name)
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
            sql_args.Add("@v_name", vendor_name);
            db.Insert(sql_command, sql_args);

            vendor_id_name_pair[vendor_name] = max_vcode.ToString();
        }
    }
}
