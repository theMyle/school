package problem_11_20;

import javax.swing.*;

public class problem15 {
    public static void main(String[] args) {
        String input = "";
        int TEMP = 0;

        try {
            input = JOptionPane.showInputDialog("Enter TEMPERATURE: ");
            TEMP = Integer.parseInt(input);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Error: " + e.getMessage());
            return;
        }

        if (TEMP < 0) {
            JOptionPane.showMessageDialog(null, "ICE");
        } else if (TEMP >= 0 && TEMP <= 100) {
            JOptionPane.showMessageDialog(null, "WATER");
        } else {
            JOptionPane.showMessageDialog(null, "STEAM");
        }
    }
}
