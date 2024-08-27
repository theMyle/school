package theMyle;

import java.io.*;

public class problem_10 {
    public static void main(String[] args) {
        String movieName = "";
        double adultTicketPrice = 0;
        double childTicketPrice = 0;
        int adultTicketSold = 0;
        int childTicketSold = 0;
        double percentageDonation = 0;

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        try {
            System.out.print("Enter the movie name: ");
            movieName = reader.readLine();

            System.out.print("Enter the price of adult ticket: ");
            adultTicketPrice = Double.parseDouble(reader.readLine());

            System.out.print("Enter the price of child ticket: ");
            childTicketPrice = Double.parseDouble(reader.readLine());

            System.out.print("Enter the number of adult ticket sold: ");
            adultTicketSold = Integer.parseInt(reader.readLine());

            System.out.print("Enter the number of child ticket sold: ");
            childTicketSold = Integer.parseInt(reader.readLine());

            System.out.print("Enter the percentage of donation: ");
            percentageDonation = Double.parseDouble(reader.readLine());
        } catch (IOException e) {
            System.out.println("Error");
            return;
        }

        int totalTicketSold = adultTicketSold + childTicketSold;
        double grossAmount = (adultTicketPrice * adultTicketSold) + (childTicketPrice * childTicketSold);
        double amountDonated = grossAmount * (percentageDonation/100);
        double netSale = grossAmount - amountDonated;

        System.out.println("\nOutput:");
        System.out.printf("Movie Name\t\t\t\t:\t%s\n", movieName);
        System.out.printf("Number of ticket sold\t:\t%d\n", totalTicketSold);
        System.out.printf("Gross amount\t\t\t:\t%.2f\n", grossAmount);
        System.out.printf("Amount donated\t\t\t:\t%.2f\n", amountDonated);
        System.out.printf("Net sale\t\t\t\t:\t%.2f\n", netSale);
    }
}