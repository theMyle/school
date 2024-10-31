package problem_11_20;

import javax.swing.*;

public class problem18 {
    public static void main(String[] args) {
        String input = "";
        int key = 0;
        int tuition_fee = 0;
        double total_fee = 0;

        try {
            input = JOptionPane.showInputDialog("Select mode of payment:\n" +
                    "1. Cash\n" +
                    "2. Two Installment\n" +
                    "3. Three Installment");
            key = Integer.parseInt(input.trim());
            input = JOptionPane.showInputDialog("Enter Tuition Fee:");
            tuition_fee = Integer.parseInt(input.trim());
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Error: " + e.getMessage());
            return;
        }

        if (key == 1) {
            total_fee = tuition_fee - (tuition_fee * 0.1);
            JOptionPane.showMessageDialog(null, "Your total tuition fee is: " + total_fee);
        } else if (key == 2) {
            total_fee = tuition_fee + (tuition_fee * 0.05);
            JOptionPane.showMessageDialog(null, "Your total tuition fee is: " + total_fee);
        } else if (key == 3) {
            total_fee = tuition_fee + (tuition_fee * 0.1);
            JOptionPane.showMessageDialog(null, "Your total tuition fee is: " + total_fee);
        } else {
            JOptionPane.showMessageDialog(null, "Invalid Payment Method");
        }
    }
}
