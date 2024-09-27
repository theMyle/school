import javax.swing.JOptionPane;

public class problem9 {
    public static void main(String[] args) {
        try {
            String grossInput = JOptionPane.showInputDialog(null, "Enter the Gross amount:");
            double grossAmount = Double.parseDouble(grossInput);

            double federalIncomeTax = grossAmount * 0.15;
            double stateTax = grossAmount * 0.035;
            double socialSecurityTax = grossAmount * 0.0575;
            double medicareTax = grossAmount * 0.0275;
            double pensionPlan = grossAmount * 0.05;
            double healthInsurance = 75.00;

            double totalDeductions = federalIncomeTax + stateTax + socialSecurityTax +
                    medicareTax + pensionPlan + healthInsurance;

            double netPay = grossAmount - totalDeductions;

            String message = String.format(
                            "Federal Income Tax: %.2f\n" +
                            "State Tax: %.2f\n" +
                            "Social Security Tax: $%.2f\n" +
                            "Medicare Tax: %.2f\n" +
                            "Pension Plan: %.2f\n" +
                            "Health Insurance: %.2f\n" +
                            "Total Deductions: %.2f\n" +
                            "Net Pay: %.2f",
                    federalIncomeTax, stateTax, socialSecurityTax, medicareTax,
                    pensionPlan, healthInsurance, totalDeductions, netPay
            );
            JOptionPane.showMessageDialog(null, message);
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Invalid input! Please enter a valid number.");
        }
    }
}