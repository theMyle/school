import javax.swing.*;

public class problem6 {
    public static void main(String[] args) {
        int dollar = 0;
        float rate = 51.50f;
        String input = "";

        try {
            dollar = Integer.parseInt(JOptionPane.showInputDialog("Enter the dollar:"));
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Error parsing input");
            return;
        }

        float value = dollar * rate;
        JOptionPane.showMessageDialog(null, "The value in peso is: " + value);
    }
}