package org.theMyle;

import java.io.*;

public class Main {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int kelvin = 0;
        double fahrenheit = 0;

        try {
            System.out.print("Enter the temperature in Kelvin: ");
            kelvin = Integer.parseInt(reader.readLine());
        } catch (IOException e) {
            System.out.printf("Error parsing input: %s\n", e.getMessage());
            return;
        }

        // calculate
        fahrenheit = (9.0/5) * (kelvin - 273.15) + 32;
        System.out.printf("The temperature in fahrenheit is: %.2f\n", fahrenheit);
    }
}
