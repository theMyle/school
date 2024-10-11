import javax.swing.*;

public class problem2 {
	public static void main(String[] args) {
		int number = 0;
		String input = "";

		try {
			input = JOptionPane.showInputDialog("Enter a number:");
			number = Integer.parseInt(input);
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null, "Error: " + e.getMessage());
			return;
		}

		if (number < 0) {
			JOptionPane.showMessageDialog(null, "Input number is negative");
		} else {
			JOptionPane.showMessageDialog(null, "Input number is positive");
		}

	}
}
