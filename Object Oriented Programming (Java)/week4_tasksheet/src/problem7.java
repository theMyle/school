import javax.swing.*;

public class problem7 {
    public static void main(String[] args) {
        int inch = 0;
        float rate = 2.54f;
        String input = "";

        try {
            inch = Integer.parseInt(JOptionPane.showInputDialog("Enter how many inch(es):"));
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Error parsing input");
            return;
        }

        float cm = inch * rate;
        JOptionPane.showMessageDialog(null, "The value in cm is: " + cm);
    }
}