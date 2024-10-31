package problem_11_20;

import javax.swing.*;

public class problem13 {
    public static void main(String[] args) {
        String input  = "";
        int a = 0;
        int b = 0;
        int c = 0;

        try {
            input = JOptionPane.showInputDialog("Enter the first unique number:");
            a = Integer.parseInt(input);
            input = JOptionPane.showInputDialog("Enter the second unique number:");
            b = Integer.parseInt(input);
            input = JOptionPane.showInputDialog("Enter the third unique number:");
            c = Integer.parseInt(input);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Error: " + e.getMessage());
            return;
        }

        if (a < b && a < c && b < c) {
            JOptionPane.showMessageDialog(null, String.format("Low to High: [%d, %d, %d]", a, b, c));
        } else if (a < b && a < c && c < b) {
            JOptionPane.showMessageDialog(null, String.format("Low to High: [%d, %d, %d]", a, c, b));
        } else if (b < a && b < c && a < c) {
            JOptionPane.showMessageDialog(null, String.format("Low to High: [%d, %d, %d]", b, a, c));
        } else if (b < a && b < c && c < a) {
            JOptionPane.showMessageDialog(null, String.format("Low to High: [%d, %d, %d]", b, c, a));
        } else if (c < a && c < b && a < b) {
            JOptionPane.showMessageDialog(null, String.format("Low to High: [%d, %d, %d]", c, a, b));
        } else {
            JOptionPane.showMessageDialog(null, String.format("Low to High: [%d, %d, %d]", c, b, a));
        }
    }
}
