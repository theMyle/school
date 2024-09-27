import javax.swing.*;

public class problem3 {
    public static void main(String[] args) {
        int temperature;
        String input = "";

        try {
            input = JOptionPane.showInputDialog("Enter the temperature in celsius: ");
            temperature = Integer.parseInt(input);
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Error parsing input");
            return;
        }

        double fahrenheit = (9.0/5) * temperature + 32;
        JOptionPane.showMessageDialog(null, "The equivalent temperature in fahrenheit is: " + fahrenheit);
    }
}