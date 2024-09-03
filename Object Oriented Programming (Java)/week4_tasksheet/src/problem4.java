import javax.swing.*;

public class problem4 {
    public static void main(String[] args) {
        String input = "";
        String name = "";
        int rate = 0;
        int hours = 0;

        try {
            name = JOptionPane.showInputDialog("Enter the name: ");
            rate = Integer.parseInt(JOptionPane.showInputDialog("Enter rate per hour:"));
            hours = Integer.parseInt(JOptionPane.showInputDialog("Enter hours worked:"));
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Error parsing input");
            return;
        }

        int salary = rate * hours;
        JOptionPane.showMessageDialog(null, name + ", Your salary is " + salary);
    }
}