package theMyle;

import java.io.*;
import java.lang.Math;

public class problem_7 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        double area = 0;
        int radius = 0;

        try {
            System.out.print("Enter the value of radius: ");
            radius = Integer.parseInt(reader.readLine());
        } catch (IOException e) {
            System.out.println("Error");
            return;
        }

        area = Math.PI * Math.pow(radius, 2);
        System.out.printf("The area is: %.2f\n", area);
    }
}