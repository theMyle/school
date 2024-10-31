package problem_01_10;

import javax.swing.*;

public class problem04 {
    public static void main(String[] args) {
        String input = "";
        int first = 0;
        int second = 0;
        int third = 0;

        try {
            input = JOptionPane.showInputDialog("Enter the first integer: ");
            first = Integer.parseInt(input);

            input = JOptionPane.showInputDialog("Enter the second integer: ");
            second = Integer.parseInt(input);

            input = JOptionPane.showInputDialog("Enter the third integer: ");
            third = Integer.parseInt(input);

        } catch (Exception error) {
			JOptionPane.showMessageDialog(null, "Error: " + error.getMessage());
            return;
        }

		if (first == second) {
			JOptionPane.showMessageDialog(null, first);
		}
		else if (second == third) {
			JOptionPane.showMessageDialog(null, second);
		}
		else if (third == first) {
			JOptionPane.showMessageDialog(null, third);
		}
		else {
            double average = (first + second + third) / 3.0;
			JOptionPane.showMessageDialog(null, "Average: " + average);
		}
    }
}
