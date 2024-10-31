package problem_01_10;

import javax.swing.*;

public class problem02 {
    public static void main(String[] args) {
        String input = "";
        int units = 0;
        int tuition_fee = 0;

        try {
            input = JOptionPane.showInputDialog("Enter the number of units registered: ");
            units = Integer.parseInt(input);
        } catch (Exception error) {
			JOptionPane.showMessageDialog(null, "Error: " + error.getMessage());
            return;
        }

        if (units >= 21) {
            tuition_fee = 7000;
        } else {
            tuition_fee = units * 300;
        }

		JOptionPane.showMessageDialog(null, "Tuition fee: " + tuition_fee);
    }
}