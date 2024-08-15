package org.theMyle;

import java.io.*;

public class Main {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        double inches = 0;
        double cm = 0;

        try {
            System.out.print("Enter the value in inch(es): ");
            inches = Double.parseDouble(reader.readLine());
        } catch (IOException e) {
            System.out.println("Error");
            return;
        }

        // calculate value in CM
        cm = inches * 2.54;
        System.out.printf("The value in cm is: %.2f\n", cm);
    }
}