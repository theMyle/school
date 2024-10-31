package problem_11_20;

import javax.swing.*;

public class problem11 {
    public static void main(String[] args) {
        String input = "";
        int choice = 0;
        int first_num = 0;
        int second_num = 0;
        double output = 0;

        try {
            input = JOptionPane.showInputDialog("1. ADD TWO NUMBERS\n" +
                    "2. SUBTRACT TWO NUMBERS\n" +
                    "3. MULTIPLY TWO NUMBERS\n" +
                    "4. DIVIDE TWO NUMBERS\n" +
                    "5. EXIT"
            );
            choice = Integer.parseInt(input);

            input = JOptionPane.showInputDialog("Enter the first number: ");
            first_num = Integer.parseInt(input);

            input = JOptionPane.showInputDialog("Enter the second number: ");
            second_num = Integer.parseInt(input);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "ERROR: " + e.getMessage());
            return;
        }

        if (choice == 1) {
            JOptionPane.showMessageDialog(null, "The sum is: " + (first_num + second_num));
        } else if (choice == 2) {
            JOptionPane.showMessageDialog(null, "The difference is: " + (first_num - second_num));
        } else if (choice == 3) {
            JOptionPane.showMessageDialog(null, "The product is: " + (first_num * second_num));
        } else if (choice == 4) {
            JOptionPane.showMessageDialog(null, "The quotient is: " + (first_num / second_num));
        } else if (choice == 5) {
            return;
        } else {
            JOptionPane.showMessageDialog(null, "Invalid Option (1-5 only)");
        }
    }
}
