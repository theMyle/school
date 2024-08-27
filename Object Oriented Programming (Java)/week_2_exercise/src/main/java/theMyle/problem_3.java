package theMyle;

import java.io.*;

public class problem_3 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String input = "";

        int purchasePrice = 0;
        int yearsInService = 0;
        int salvageValue = 0;
        float earlyDepreciation = 0F;

        try {
            System.out.print("Enter the purchase price of an item: ");
            input = reader.readLine();
            purchasePrice = Integer.parseInt(input);

            System.out.print("Enter the number of years in service: ");
            input = reader.readLine();
            yearsInService = Integer.parseInt(input);

            System.out.print("Enter the expected salvage value: ");
            input = reader.readLine();
            salvageValue = Integer.parseInt(input);
        } catch (IOException e) {
            System.out.println("Error");
            return;
        }

        earlyDepreciation = (float) (purchasePrice - salvageValue) / yearsInService;
        System.out.println("The early depreciation for this item is: " + earlyDepreciation);
    }
}