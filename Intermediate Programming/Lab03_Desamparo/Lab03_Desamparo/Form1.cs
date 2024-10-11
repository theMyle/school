namespace Lab03_Desamparo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BtnDisplayCost_Click(object sender, EventArgs e)
        {
            decimal lotSize = int.Parse(TxtLotSize.Text);
            decimal lotSold = decimal.Parse(TxtLotSold.Text)/100;
            decimal lotPrice = decimal.Parse(TxtLotPrice.Text);
            decimal result = (lotSize * lotSold) * lotPrice;

            // output
            TxtCost.Text = result.ToString("N2");
        }
    }
}