package theMyle;

import java.io.*;

public class problem_4 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String input = "";

        double F = 0;
        double output = 0;

        try {
            System.out.print("Enter the temperature in Fahrenheit: ");
            input = reader.readLine();
            F = Double.parseDouble(input);
        } catch (IOException e) {
            System.out.println("Error");
            return;
        }

        output = ((F-32) * 5.0)/9;
        System.out.printf("The equivalent temperature in Celsius is: %.2f", output);
    }
}