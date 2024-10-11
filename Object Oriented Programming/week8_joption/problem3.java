import javax.swing.*;

public class problem3 {
	public static void main(String[] args) {
		String input = "";
		int number = 0;

		try {
			input = JOptionPane.showInputDialog("Guess a the magic number:");
			number = Integer.parseInt(input);
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null, "Error: " + e.getMessage());
			return;
		}

		if (number == 143) {
			JOptionPane.showMessageDialog(null, "I LOVE YOU");
		} else {
			JOptionPane.showMessageDialog(null, "Sorry, better luck next time");
		}
	}
}
