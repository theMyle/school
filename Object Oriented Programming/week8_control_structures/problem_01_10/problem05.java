package problem_01_10;

import javax.swing.*;

public class problem05 {
    public static void main(String[] args) {
        String input = "";
        int hoursWorked = 0;
        double hourlyRate = 0;

        try {
            input = JOptionPane.showInputDialog("Enter number of hours worked: ");
            hoursWorked = Integer.parseInt(input);

            input = JOptionPane.showInputDialog("Enter hourly rate: ");
            hourlyRate = Double.parseDouble(input);
        } catch (Exception error) {
			JOptionPane.showMessageDialog(null, "Error: " + error.getMessage());
            return;
        }

        double overtimePay = 0;
        double grossPay = 0;

        if (hoursWorked > 40) {
            overtimePay = (hoursWorked - 40) * (hourlyRate * 1.5);
            grossPay = (40 * hourlyRate) + overtimePay;
			JOptionPane.showMessageDialog(null, String.format("Gross Pay: %.2f\nOvertime Pay: %.2f\n", grossPay, overtimePay));
        } else {
            grossPay = (hoursWorked * hourlyRate);
			JOptionPane.showMessageDialog(null, "Gross Pay: " + grossPay);
        }
    }
}
