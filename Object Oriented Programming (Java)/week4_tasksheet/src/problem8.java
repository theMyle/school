import javax.swing.*;

public class problem8 {
    public static void main(String[] args) {
        String movieName = "";
        String input = "";
        double adultTicketPrice = 0;
        double childTicketPrice = 0;
        int adultTicketSold = 0;
        int childTicketSold = 0;
        double percentageDonation = 0;

        try {
            movieName = JOptionPane.showInputDialog("Enter the movie name:");

            input = JOptionPane.showInputDialog("Enter the price of adult ticket: ");
            adultTicketPrice = Double.parseDouble(input);

            input = JOptionPane.showInputDialog("Enter the price of child ticket: ");
            childTicketPrice = Double.parseDouble(input);

            input = JOptionPane.showInputDialog("Enter the number of adult ticket sold: ");
            adultTicketSold = Integer.parseInt(input);

            input = JOptionPane.showInputDialog("Enter the number of child ticket sold: ");
            childTicketSold = Integer.parseInt(input);

            input = JOptionPane.showInputDialog("Enter the percentage of donation: ");
            percentageDonation = Double.parseDouble(input);
        } catch (NumberFormatException e) {
            JOptionPane.showMessageDialog(null, "Error parsing input");
            return;
        }

        int totalTicketSold = adultTicketSold + childTicketSold;
        double grossAmount = (adultTicketPrice * adultTicketSold) + (childTicketPrice * childTicketSold);
        double amountDonated = grossAmount * (percentageDonation/100);
        double netSale = grossAmount - amountDonated;

        String output = "Movie Name: " + movieName;
        output += "\nNumber of ticket sold: " + totalTicketSold;
        output += "\nGross amount: " + grossAmount;
        output += "\nAmount donated: " + amountDonated;
        output += "\nNet sale: " + netSale;

        JOptionPane.showMessageDialog(null, output);
    }
}