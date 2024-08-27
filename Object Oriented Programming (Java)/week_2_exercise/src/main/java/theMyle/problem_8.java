package theMyle;

import java.io.*;

public class problem_8 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        double dollar = 0;
        double pesoEquivalent = 0;

        try {
            System.out.print("Enter the dollar amount: ");
            dollar = Double.parseDouble(reader.readLine());
        } catch (IOException e) {
            System.out.println("Error");
            return;
        }

        pesoEquivalent = dollar * 51.50;
        System.out.printf("The value in peso is: %.2f\n", pesoEquivalent);
    }
}