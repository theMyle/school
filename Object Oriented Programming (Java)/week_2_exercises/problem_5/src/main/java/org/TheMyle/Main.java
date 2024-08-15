package org.TheMyle;

import java.io.*;

public class Main {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String input = "";

        double C = 0;
        double output = 0;

        try {
            System.out.print("Enter the temperature in Celsius: ");
            input = reader.readLine();
            C = Double.parseDouble(input);
        } catch (IOException e) {
            System.out.println("Error");
            return;
        }

        output = (9.0/5) * (C + 32);
        System.out.println("The equivalent temperature in Fahrenheit is: " + output);
    }
}