package problem_11_20;

import javax.swing.*;

public class problem17 {
    public static void main(String[] args) {
        String input = "";

        try {
            input = JOptionPane.showInputDialog("Enter ship class ID");

            if (input.equalsIgnoreCase("b")) {
                JOptionPane.showMessageDialog(null, "Ship Class: Battleship");
            } else if (input.equalsIgnoreCase("c")) {
                JOptionPane.showMessageDialog(null, "Ship Class: Cruiser");
            } else if (input.equalsIgnoreCase("d")) {
                JOptionPane.showMessageDialog(null, "Ship Class: Destroyer");
            } else if (input.equalsIgnoreCase("f")) {
                JOptionPane.showMessageDialog(null, "Ship Class: Frigate");
            } else {
                JOptionPane.showMessageDialog(null, "Unkown Ship ID");
            }

        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Error: " + e.getMessage());
            return;
        }

    }
}
