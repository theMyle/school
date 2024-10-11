import javax.swing.*;

public class problem06 {
    public static void main(String[] args) {
        String input = "";
        int speed = 0;

        try {
            input = JOptionPane.showInputDialog("Enter the aircraft speed in km/h: ");
            speed = Integer.parseInt(input);
        } catch (Exception error) {
			JOptionPane.showMessageDialog(null, "Error: " + error.getMessage());
            return;
        }

        if (speed < 500) {
			JOptionPane.showMessageDialog(null, "It's a BIRD!");
        } else if (speed >= 500 && speed <= 1100) {
			JOptionPane.showMessageDialog(null, "It's a military aircraft!");
        } else {
			JOptionPane.showMessageDialog(null, "It's a civilian aircraft");
        }
    }
}