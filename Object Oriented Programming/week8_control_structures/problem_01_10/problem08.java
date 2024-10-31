package problem_01_10;

import javax.swing.*;

public class problem08 {
    public static void main(String[] args) {
        String input = "";
        double realEstate = 0;
        double tax = 0;

        try {
            input = JOptionPane.showInputDialog("Enter real estate value: ");
            realEstate = Double.parseDouble(input);
        } catch (Exception error) {
			JOptionPane.showMessageDialog(null, "Error: " + error.getMessage());
            return;
        }

        if (realEstate < 250_001) {
            tax = realEstate * 0.05;
        } else if (realEstate >= 250_001 && realEstate <= 500_000) {
            tax = realEstate * 0.1;
        } else {
            tax = realEstate * 0.15;
        }

		JOptionPane.showMessageDialog(null, "Real Estate Tax: " + tax);
    }
}
