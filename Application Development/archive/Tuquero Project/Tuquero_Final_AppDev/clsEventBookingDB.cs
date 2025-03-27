using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
namespace Tuquero_Final_AppDev
{
    public class clsDatabase
    {
        const string DB_HOST = "127.0.0.1";
        const string DB_USER = "root";
        const string DB_PWD = "";
        const string DB_NAME = "eventbookingdb";

        const string CNString = @"SERVER=" + DB_HOST + ";" +
                                "UID=" + DB_USER + ";" +
                                "PWD=" + DB_PWD + ";" +
                                "DATABASE=" + DB_NAME + ";";

        //RETRIEVE DATA 
        public DataTable QueryData(string _sql)
        {
            using (MySqlConnection _cn = new MySqlConnection(CNString))
            {
                try
                {
                    _cn.Open();

                    MySqlCommand _cmd = new MySqlCommand();
                    //Set command properties
                    _cmd.Connection = _cn;  //Assign active connection
                    _cmd.CommandType = CommandType.Text;
                    _cmd.CommandText = _sql; //assign SQL command

                    using (MySqlDataReader _dr = _cmd.ExecuteReader())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(_dr);
                        return dt;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error has encountered while attempting to connect with your database." +
                    "\n" + e.Message, "Database Connection Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return null;
                }
            }
        }
        //----RETRIEVE DATA 


        //Execute NoneQuery
        public bool ExecuteSQLQuery(string _sql, Dictionary<string, object> parameters = null)
        {
            using (MySqlConnection _cn = new MySqlConnection(CNString))
            {
                try
                {
                    _cn.Open();

                    using (MySqlCommand _cmd = new MySqlCommand())
                    {
                        _cmd.Connection = _cn;  // Assign active connection
                        _cmd.CommandType = CommandType.Text;
                        _cmd.CommandText = _sql; // Assign SQL command

                        // Add parameters if any
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                _cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }

                        _cmd.ExecuteNonQuery();
                    }
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show("An error has encountered while attempting to perform action." +
                    "\n" + e.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
        }



        //----Execute NonQuery
        // FillCombo Box dynamically
        public void FillComboBox(string sql, string Value_Member, string Display_Member, ComboBox combo)
        {
            DataTable dt = new DataTable();
            using (var connection = new MySqlConnection(CNString))
            {
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    connection.Open();
                    try
                    {
                        dt.Load(cmd.ExecuteReader());
                    }
                    catch (MySqlException e)
                    {
                        MessageBox.Show(" Error : " + e.ToString());
                    }
                }
            }

            // Check if the DataTable has the required columns
            if (dt.Columns.Contains(Value_Member) && dt.Columns.Contains(Display_Member))
            {
                combo.DataSource = dt;
                combo.ValueMember = Value_Member;
                combo.DisplayMember = Display_Member;
            }
            else
            {
                MessageBox.Show($"The DataTable does not contain the required columns: {Value_Member}, {Display_Member}");
            }
        }

        //----Execute Scalar - Returns single value

        public Int64 ExecuteQryScalar(string sql, Dictionary<string, object> parameters = null)
        {
            using (var connection = new MySqlConnection(CNString))
            {
                using (var cmd = new MySqlCommand(sql, connection))
                {
                    connection.Open();
                    try
                    {
                        if (parameters != null)
                        {
                            foreach (var param in parameters)
                            {
                                cmd.Parameters.AddWithValue(param.Key, param.Value);
                            }
                        }
                        return Convert.ToInt64(cmd.ExecuteScalar());
                    }
                    catch (MySqlException e)
                    {
                        MessageBox.Show("Error: " + e.Message);
                        return 0;
                    }
                }
            }
        }
        public void ExecuteNonQuery(MySqlCommand cmd)
        {
            using (MySqlConnection cn = new MySqlConnection(CNString))
            {
                try
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database operation failed: {ex.Message}");
                }
            }
        }
    }
}
