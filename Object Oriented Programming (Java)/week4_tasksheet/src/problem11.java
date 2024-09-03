import javax.swing.JOptionPane;

public class problem11 {
    public static void main(String[] args) {
        try {
            final int PERSONAL_ALLOWANCE = 5000;
            final int CHILD_ALLOWANCE = 1000;

            String incomeInput = JOptionPane.showInputDialog(null, "Enter the total income:");
            int totalIncome = Integer.parseInt(incomeInput);

            String childrenInput = JOptionPane.showInputDialog(null, "Enter the number of children:");
            int numberOfChildren = Integer.parseInt(childrenInput);

            int taxableIncome = totalIncome - PERSONAL_ALLOWANCE - CHILD_ALLOWANCE * numberOfChildren;

            int taxOwed = taxableIncome / 3;

            int afterTaxIncome = totalIncome - taxOwed;

            String message = String.format(
                    "Income: %d\n" +
                            "Taxable: %d\n" +
                            "Tax: %d\n" +
                            "After Tax: %d",
                    totalIncome, taxableIncome, taxOwed, afterTaxIncome
            );
            JOptionPane.showMessageDialog(null, message);
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Invalid input! Please enter valid numbers.");
        }
    }
}