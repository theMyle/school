import javax.swing.*;

public class problem5 {
    public static void main(String[] args) {
        String input = "";
        int radius = 0;
        double area = 0;

        try {
            input = JOptionPane.showInputDialog("Enter the radius: ");
            radius = Integer.parseInt(input);
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Error parsing input");
            return;
        }

        area = 3.1416 * Math.pow(radius, 2);
        JOptionPane.showMessageDialog(null, "The area is: " + area);
    }
}