package org.TheMyle;

import java.io.*;

public class Main {
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
        }

        output = ((F-32) * 5.0)/9;
        // 5/9 (F-32) not working ?
        System.out.printf("The equivalent temperature in Celsius is: %.2f", output);
    }
}