package problem_11_20;

import javax.swing.*;

public class problem12 {
    public static void main(String[] args) {
        String input = "";
        int n1 = 0;
        int n2 = 0;
        int n3 = 0;

        try {
            input = JOptionPane.showInputDialog("Enter the first unique number: ");
            n1 = Integer.parseInt(input);
            input = JOptionPane.showInputDialog("Enter the second unique number: ");
            n2 = Integer.parseInt(input);
            input = JOptionPane.showInputDialog("Enter the third unique number: ");
            n3 = Integer.parseInt(input);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Error: " + e.getMessage());
        }

        if (n1 < n2 && n1 < n3) {
            JOptionPane.showMessageDialog(null, "Lowest (first number): " + n1);
        } else if (n2 < n1 && n2 < n3) {
            JOptionPane.showMessageDialog(null, "Lowest (second number): " + n2);
        } else {
            JOptionPane.showMessageDialog(null, "Lowest (third number): " + n3);
        }
    }
}
