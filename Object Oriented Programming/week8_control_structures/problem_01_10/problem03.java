package problem_01_10;

import javax.swing.*;

public class problem03 {
    public static void main(String[] args) {
        String input = "";
        int first = 0;
        int second = 0;

        try {
            input = JOptionPane.showInputDialog("Enter the first integer: ");
            first = Integer.parseInt(input);
            input = JOptionPane.showInputDialog("Enter the second integer: ");
            second = Integer.parseInt(input);
        } catch (Exception error) {
			JOptionPane.showMessageDialog(null, "Error: " + error.getMessage());
            return;
        }

        if (first > second) {
			JOptionPane.showMessageDialog(null, "Higher number: " + first);
        } else if (second > first) {
			JOptionPane.showMessageDialog(null, "Higher number: " + second);
		} else if (first == second) {
			return;
		}
    }
}
