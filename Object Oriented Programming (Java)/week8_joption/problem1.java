import javax.swing.*;

public class problem1 {
    public static void main(String[] args) {
		int age = 0;
        String input = "";

        try {
            input = JOptionPane.showInputDialog("Enter your age:");
            age = Integer.parseInt(input);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Error: " + e.getMessage());
            return;
        }

		if (age >= 18) {
			JOptionPane.showMessageDialog(null, "You are qualified to vote");
		} else {
			JOptionPane.showMessageDialog(null, "Your are not qualified to vote yet");
		}

    }
}
