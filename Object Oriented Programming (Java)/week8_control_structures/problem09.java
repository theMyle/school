import java.io.*;

public class problem09 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        double realEstate = 0;
        double tax = 0;

        try {
            System.out.print("Enter real estate value: ");
            realEstate = Double.parseDouble(reader.readLine());
        } catch (Exception e) {
            System.out.println("Error: " + e.getMessage());
            return;
        }

        if (realEstate < 250_001) {
            tax = realEstate * 0.05;
        } else if (realEstate >= 250_001 && realEstate <= 500_000) {
            tax = realEstate * 0.1;
        } else {
            tax = realEstate * 0.15;
        }

        System.out.println("Real Estate Tax: " + tax);
    }
}
