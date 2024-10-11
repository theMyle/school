package theMyle;

import java.io.*;

public class machine_problem_7 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int radius;
        double area, circumference;

        try {
            System.out.print("Enter the radius of a circle: ");
            radius = Integer.parseInt(reader.readLine());
        } catch (IOException e) {
            System.out.printf("Error parsing input: %s\n", e.getMessage());
            return;
        }

        // calculate
        area = Math.PI * (Math.pow(radius,2));
        circumference = 2 * Math.PI * radius;

        System.out.printf("The area of the circle is: %.2f\n", area);
        System.out.printf("The circumference of the circle is: %.2f\n", circumference);
    }
}
