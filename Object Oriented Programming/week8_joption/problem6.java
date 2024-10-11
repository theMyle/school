import javax.swing.*;

public class problem6 {
	public static void main(String[] args) {
		String input = "";
		int num1 = 0;
		int num2 = 0;

		try {
			input = JOptionPane.showInputDialog("Enter a number: ");
			num1 = Integer.parseInt(input);

			input = JOptionPane.showInputDialog("Enter a second number: ");
			num2 = Integer.parseInt(input);
		} catch (Exception e) {
			JOptionPane.showMessageDialog(null, "Error " + e.getMessage());
			return;
		}

		if (num1 > num2) {
			JOptionPane.showMessageDialog(null, num2 + "\n" + num1);
		} else {
			JOptionPane.showMessageDialog(null, num1 + "\n" + num2);
		}
	}
}
