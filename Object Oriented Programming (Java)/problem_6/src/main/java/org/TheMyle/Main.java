package org.TheMyle;

import java.io.*;

public class Main {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        String input = "";

        String name = "";
        double ratePerHour = 0;
        double salary = 0;
        int hoursWorked = 0;

        try {
            System.out.print("Enter the name: ");
            name = reader.readLine();

            System.out.print("Enter the rate per hour: ");
            input = reader.readLine();
            ratePerHour = Double.parseDouble(input);

            System.out.print("Enter hours worked: ");
            input = reader.readLine();
            hoursWorked = Integer.parseInt(input);
        } catch (IOException e) {
            System.out.println("Error");
        }

        salary = ratePerHour * hoursWorked;
        System.out.printf("%s, your salary is: %.2f", name, salary);
    }
}