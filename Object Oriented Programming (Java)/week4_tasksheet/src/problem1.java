import javax.swing.*;

public class problem1 {
    public static void main(String[] args) {
        int first, second, third, fourth, fifth = 0;
        int sum, difference, product;
        double quotient;

        String input = "";

        try {
            input = JOptionPane.showInputDialog("Enter the first number:");
            first = Integer.parseInt(input);

            input = JOptionPane.showInputDialog("Enter the second number:");
            second = Integer.parseInt(input);

            input = JOptionPane.showInputDialog("Enter the third number:");
            third = Integer.parseInt(input);

            input = JOptionPane.showInputDialog("Enter the fourth number:");
            fourth = Integer.parseInt(input);

            input = JOptionPane.showInputDialog("Enter the fifth number:");
            fifth = Integer.parseInt(input);
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Error parsing input");
            return;
        }

        sum = first + second;
        difference = sum - third;
        product = difference * fourth;
        quotient = (double) product / fifth;

        String output = "The sum is: " + sum;
        output += "\nThe difference is: " + difference;
        output += "\nThe product is: " + product;
        output += "\nThe quotient is: " + quotient;

        JOptionPane.showMessageDialog(null, output);
    }
}