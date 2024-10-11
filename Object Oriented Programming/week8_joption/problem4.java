import javax.swing.*;

public class problem4 {
	public static void main(String[] args) {
		String input = "";
		int number = 0;

		try {
			input = JOptionPane.showInputDialog("Enter a number:");
			number = Integer.parseInt(input);
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null, "Error: " + e.getMessage());
			return;
		}

		if ((number % 2) == 0) {
			JOptionPane.showMessageDialog(null, "Number is EVEN");
		} else {
			JOptionPane.showMessageDialog(null, "Number is ODD");
		}
	}
}
