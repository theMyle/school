import javax.swing.JOptionPane;

public class problem10 {

    public static void main(String[] args) {
        try {
            String input = JOptionPane.showInputDialog(null, "Enter change in cents:");
            int totalCents = Integer.parseInt(input);

            int halfDollars = totalCents / 50;
            totalCents %= 50;

            int quarters = totalCents / 25;
            totalCents %= 25;

            int dimes = totalCents / 10;
            totalCents %= 10;

            int nickels = totalCents / 5;
            totalCents %= 5;

            int pennies = totalCents;

            String message = String.format(
                    "The Change you entered is %d cents\n" +
                            "The Number of half dollars to be returned are: %d\n" +
                            "The Number of quarters to be returned are: %d\n" +
                            "The Number of dimes to be returned are: %d\n" +
                            "The Number of nickels to be returned are: %d\n" +
                            "The Number of pennies to be returned are: %d",
                    Integer.parseInt(input), halfDollars, quarters, dimes, nickels, pennies
            );
            JOptionPane.showMessageDialog(null, message);
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Invalid input! Please enter a valid number of cents.");
        }
    }
}