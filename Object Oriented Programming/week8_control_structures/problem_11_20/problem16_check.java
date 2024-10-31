package problem_11_20;

import javax.swing.*;

public class problem16_check {
    public static void main(String[] args) {
        String input = "";
        double ritcher_value = 0;

        try {
            input = JOptionPane.showInputDialog("Enter Ritcher Value:");
            ritcher_value = Double.parseDouble(input);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Error: " + e.getMessage());
            return;
        }

        if (ritcher_value < 5) {
            JOptionPane.showMessageDialog(null, "LITTLE OR NO DAMAGE");
        } else if (ritcher_value >= 5 && ritcher_value <= 5.5) {
            JOptionPane.showMessageDialog(null, "SOME DAMAGE");
        } else if (ritcher_value > 5.5 && ritcher_value <= 6.5) {
            JOptionPane.showMessageDialog(null, "SERIOUS DAMAGE");
        } else if (ritcher_value > 6.5 && ritcher_value <= 7.5) {
            JOptionPane.showMessageDialog(null, "DISASTER");
        } else {
            JOptionPane.showMessageDialog(null, "CATASTROPHE");
        }
    }
}
