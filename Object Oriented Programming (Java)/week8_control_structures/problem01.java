import java.io.*;

public class problem01 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        int total_purchase = 0;
        float discount = 0;
        float amount_to_be_paid = 0;

        try {
            System.out.print("Enter total purchase amount: ");
            total_purchase = Integer.parseInt(reader.readLine());
        } catch (Exception error) {
            System.out.println("Error: " + error.getMessage());
            return;
        }

        if (total_purchase >= 2000) {
            discount = 0.05F;
        }

        amount_to_be_paid = total_purchase - (total_purchase * discount);

        System.out.printf("Amount to be paid: %.2f\n", amount_to_be_paid);
    }
}