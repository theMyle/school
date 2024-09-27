import java.io.*;

public class problem07_8 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        double taxRate = 0;
        double profit = 0;

        try {
            System.out.print("Enter sales expense: ");
            profit = Integer.parseInt(reader.readLine());
        } catch (Exception e) {
            System.out.println("Error: " + e.getMessage());
            return;
        }

        if (profit <= 1000) {
            System.out.printf("Profit: %.2f\nTax: %.2f\n", profit, taxRate);
        } else if (profit >= 1001 && profit <= 3000) {
            taxRate = 100 + (profit * 0.03);
            System.out.printf("Profit: %.2f\nTax: %.2f\n", profit, taxRate);
        } else if (profit >= 3001 && profit <= 5000) {
            taxRate = 200 + (profit * 0.05);
            System.out.printf("Profit: %.2f\nTax: %.2f\n", profit, taxRate);
        } else if (profit > 5000) {
            taxRate = 300 + (profit * 0.07);
            System.out.printf("Profit: %.2f\nTax: %.2f\n", profit, taxRate);
        }
    }
}
