namespace Lab_01_Desamparo
{
    public partial class frmNewStudent : Form
    {
        public frmNewStudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "New Student Added!";
            lblStatus.BackColor = Color.LightGreen;
            lblStatus.Visible = true;
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            lblStatus.Text = "Operation Cancelled";
            lblStatus.BackColor = Color.HotPink;
            lblStatus.Visible = true;
        }
    }
}
