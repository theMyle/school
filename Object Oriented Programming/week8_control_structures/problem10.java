import javax.swing.*;

public class problem10 {
    public static void main(String[] args) {
        String input = "";
        int position;
        double salary = 0;
        double finalSalary = 0;

        try {
            input = JOptionPane.showInputDialog("Enter your position:\n1. Sales Person\n2. Linemen\n3. Engineer");
            position = Integer.parseInt(input);

            input = JOptionPane.showInputDialog("Enter your salary: ");
            salary = Double.parseDouble(input);
        } catch (Exception error) {
			JOptionPane.showMessageDialog(null, "Error: " + error.getMessage());
            return;
        }

        if (position == 1) {
            finalSalary = salary + (salary * 0.15);
			JOptionPane.showMessageDialog(null, "Sales Person Salary: " + finalSalary);
        } else if (position == 2) {
            finalSalary = salary + (salary * 0.1);
			JOptionPane.showMessageDialog(null, "Linemen Salary: " + finalSalary);
        } else if (position == 3) {
            finalSalary = salary + (salary * 0.08);
			JOptionPane.showMessageDialog(null, "Engineer Salary: " + finalSalary);
        } 
    }
}
