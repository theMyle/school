import javax.swing.*;

public class problem2 {
    public static void main(String[] args) {
        double prelim, midterm, finals = 0;
        double average = 0;
        String input = "";

        try {
            input = JOptionPane.showInputDialog("Enter your prelim grade:");
            prelim = Double.parseDouble(input);

            input = JOptionPane.showInputDialog("Enter your midterm grade:");
            midterm = Double.parseDouble(input);

            input = JOptionPane.showInputDialog("Enter your final grade:");
            finals = Double.parseDouble(input);
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Error parsing input");
            return;
        }

        prelim *= 0.3;
        midterm *= 0.3;
        finals *= 0.4;
        average = prelim + midterm + finals;

        JOptionPane.showMessageDialog(null, "Your general average is " + average);
    }
}