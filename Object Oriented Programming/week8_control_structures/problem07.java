import javax.swing.*;

public class problem07 {
    public static void main(String[] args) {
        String input = "";
        double taxRate = 0;
        double profit = 0;

        try {
            input = JOptionPane.showInputDialog("Enter sales expense: ");
            profit = Integer.parseInt(input);
        } catch (Exception error) {
			JOptionPane.showMessageDialog(null, "Error: " + error.getMessage());
            return;
        }

        if (profit <= 1000) {
			JOptionPane.showMessageDialog(null, String.format("Profit: %.2f\nTax: %.2f\n", profit, taxRate));
        } else if (profit >= 1001 && profit <= 3000) {
            taxRate = 100 + (profit * 0.03);
			JOptionPane.showMessageDialog(null, String.format("Profit: %.2f\nTax: %.2f\n", profit, taxRate));
        } else if (profit >= 3001 && profit <= 5000) {
            taxRate = 200 + (profit * 0.05);
			JOptionPane.showMessageDialog(null, String.format("Profit: %.2f\nTax: %.2f\n", profit, taxRate));
        } else if (profit > 5000) {
            taxRate = 300 + (profit * 0.07);
			JOptionPane.showMessageDialog(null, String.format("Profit: %.2f\nTax: %.2f\n", profit, taxRate));
        }
    }
}
