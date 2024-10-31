package problem_11_20;

import javax.swing.*;

public class problem14 {
    public static void main(String[] args) {
        String input  = "";
        int a = 0;
        int b = 0;
        int c = 0;
        int highest = 0;
        int lowest = 0;

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
            lowest = a;
            highest = c;
        } else if (a < b && a < c && c < b) {
            lowest = a;
            highest = b;
        } else if (b < a && b < c && a < c) {
            lowest = b;
            highest = c;
        } else if (b < a && b < c && c < a) {
            lowest = b;
            highest = a;
        } else if (c < a && c < b && a < b) {
            lowest = c;
            highest = b;
        } else {
            JOptionPane.showMessageDialog(null, String.format("Low to High: [%d, %d, %d]", c, b, a));
            lowest = c;
            highest = a;
        }

        JOptionPane.showMessageDialog(null,
                String.format("Difference of highest and lowest: %d", highest-lowest)
        );
    }
}
