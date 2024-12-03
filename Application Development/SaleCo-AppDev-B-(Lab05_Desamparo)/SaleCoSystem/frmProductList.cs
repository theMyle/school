using System.Data;

namespace SaleCoSystem
{
    public partial class frmProductList : Form
    {
        public frmProductList()
        {
            InitializeComponent();
        }

        clsDatabase DB = new clsDatabase();

        private void LoadProductList()
        {
            string sql = @"SELECT
                          p_code,
                          p_descript,
                          p_price,
                          p_qoh,
                          p_min,
                          v_name
                        FROM product p
                        LEFT JOIN vendor v
                          ON v.v_code=p.v_code";
            DataTable dt = DB.QueryData(sql);
            if (dt != null)
            {
                DGV.Rows.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    //DGV.Rows.Add(
                    //    data["p_code"].ToString(),
                    //    data["p_descript"].ToString(),
                    //    data["p_price"].ToString(),
                    //    data["p_qoh"].ToString(),
                    //    data["v_name"].ToString()
                    //);
                    string quantity = "";
                    int min = int.Parse(dr["p_min"].ToString());
                    int qoh = int.Parse(dr["p_qoh"].ToString());
                    if (qoh < min)
                    {
                        quantity = "RESTOCK NEEDED";
                    }
                    else
                    {
                        quantity = dr["p_qoh"].ToString();
                    }

                    DGV.Rows.Add(
                    dr["p_code"].ToString(),
                    dr["p_descript"].ToString(),
                    dr["p_price"].ToString(),
                    quantity,
                    dr["v_name"].ToString()
                    );
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmProductList_Load(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadProductList();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmProductAE newProduct = new frmProductAE();

            newProduct.ShowDialog();
            LoadProductList();
        }

        private void DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //get product id
            string pCode = "";
            if (e.RowIndex > -1) { 
                pCode = DGV.Rows[e.RowIndex].Cells[0].Value.ToString();
            } else
            {
                return;
            }

            switch (e.ColumnIndex)
            {
                case 5:
                    frmProductAE editProduct = new frmProductAE();
                    editProduct.PCODE = pCode;
                    editProduct.lblTitle.Text = "Update Product";

                    editProduct.ShowDialog();
                    LoadProductList();

                    break;

                case 6:
                    //confirm
                    DialogResult input = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (input == DialogResult.No) 
                    {
                        return;
                    }

                    string sql = $@"DELETE FROM product
                                WHERE p_code='{pCode}'";

                    if (DB.ExecuteSQLQuery(sql))
                    {
                        MessageBox.Show("Product has been successfully deleted.", "Product Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadProductList();
                    }
                    else
                    {
                        MessageBox.Show("Error Deleting product.", "Delete Product", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            // prod code, description, vendor


            if (e.KeyCode == Keys.Enter)
            {
                String filter = " ";
                if (cboFilter.SelectedItem != null)
                {
                    switch (cboFilter.SelectedItem.ToString()) {
                        case "Prod Code":
                            filter = "p_code";
                            break;
                        case "Description":
                            filter = "p_descript";
                            break;
                        case "Vendor":
                            filter = "v_name";
                            break;
                        default:
                            break;
                    }
                }
                else {
                    MessageBox.Show("No filter selected", "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                string searchString = txtSearch.Text;
                string query = $@"SELECT
                                p_code,
                                p_descript,
                                p_price,
                                p_qoh,
                                p_min,
                                v_name
                                FROM product p
                                LEFT JOIN vendor v
                                ON v.v_code = p.v_code
                                WHERE 
                                    {filter} LIKE '%{searchString}%'";

                DataTable dt = DB.QueryData(query);
                if (dt != null)
                {
                    DGV.Rows.Clear();
                    foreach (DataRow dr in dt.Rows)
                    {
                        string quantity = "";
                        int min = int.Parse(dr["p_min"].ToString());
                        int qoh = int.Parse(dr["p_qoh"].ToString());
                        if (qoh < min)
                        {
                            quantity = "RESTOCK NEEDED";
                        }
                        else
                        {
                            quantity = dr["p_qoh"].ToString();
                        }

                        DGV.Rows.Add(
                        dr["p_code"].ToString(),
                        dr["p_descript"].ToString(),
                        dr["p_price"].ToString(),
                        quantity,
                        dr["v_name"].ToString()
                        );
                    }
                }
            }
        }
    }
}
