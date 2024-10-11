import javax.swing.*;

public class problem7_8 {
	public static void main(String[] args) {
		String input = "";
		int profit = 0;
		double tax = 0;

		try {
			input = JOptionPane.showInputDialog("Enter profit");
			profit = Integer.parseInt(input);
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null, "(Error) " + e.getMessage());
			return;
		}

		if (profit >= 0 && profit <= 10_000) {
			tax = 0;
		} else if (profit >= 10_001 && profit <= 30_000) {
			tax = 100 + (profit * 0.03);
		} else if (profit >= 30_001 && profit <= 50_000) {
			tax = 200 + (profit * 0.05);
		} else if (profit > 50_000) {
			tax = 300 + (profit * 0.07);
		}

		JOptionPane.showMessageDialog(
				null,
				String.format("Profit: %d\nTax: %.2f", profit, tax));
	}
}
