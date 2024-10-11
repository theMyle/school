import javax.swing.*;

public class problem5 {
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
			JOptionPane.showMessageDialog(null, "first number is higher: " + num1);
		} else if (num2 > num1){
			JOptionPane.showMessageDialog(null, "second number is higher: " + num2);
		} else {
			JOptionPane.showMessageDialog(null, num1);
		}
	}
}
