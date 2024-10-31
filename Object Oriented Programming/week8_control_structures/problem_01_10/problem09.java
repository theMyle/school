package problem_01_10;

import javax.swing.*;

public class problem09 {
    public static void main(String[] args) {
        String input = "";
        int income = 0;
        double tax = 0;
        double grossIncome = 0;

        try {
            input = JOptionPane.showInputDialog("Enter income: ");
            income = Integer.parseInt(input);
        } catch (Exception error) {
			JOptionPane.showMessageDialog(null, "Error: " + error.getMessage());
            return;
        }

        if (income <= 5000) {
            tax = 0;
        } else if (income >= 5001 && income <= 10_000) {
            tax = 100 + (0.03 * (income - 500));
        } else if (income >= 10_001 && income <= 25_000) {
            tax = 200 + (0.06 * (income - 10_000));
        } else if (income >= 25_001 && income <= 50_000) {
            tax = 300 + (0.09 * (income - 25_000));
        } else {
            tax = 500 + (0.15 * (income - 50_000));
        }

        grossIncome = income - tax;
		JOptionPane.showMessageDialog(null, "Tax: " + tax + "\nGross Income: " + grossIncome);
    }
}
