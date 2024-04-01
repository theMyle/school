namespace Lab04_Desamparo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void DisplayBillBtn_Click(object sender, EventArgs e)
        {
            decimal HoursOfLabor = decimal.Parse(HoursOfLaborTxtBox.Text);
            decimal CostOfParts = decimal.Parse(CostOfPartsTxtBox.Text);

            decimal RATE = 80.00M;

            decimal laborCost = HoursOfLabor * RATE;
            decimal partsCost = CostOfParts + (CostOfParts * .03M);
            decimal totalCost = laborCost + partsCost;

            // Display
            LaborCostTxtBox.Text = laborCost.ToString("N2");
            PartsCostTxtBox.Text = partsCost.ToString("N2");
            TotalCostTxtBox.Text = totalCost.ToString("N2");
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CustomerNameTxtBox.Clear();
            HoursOfLaborTxtBox.Clear();
            CostOfPartsTxtBox.Clear();
            LaborCostTxtBox.Clear();
            PartsCostTxtBox.Clear();
            TotalCostTxtBox.Clear();  
        }
    }
}
