package theMyle;

import java.io.*;

public class machine_problem_6 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int s1,s2,s3 = 0;
        double side = 0;
        double area = 0;

        try {
            System.out.print("Enter the length of the first side of the triangle: ");
            s1 = Integer.parseInt(reader.readLine());

            System.out.print("Enter the length of the second side of the triangle: ");
            s2 = Integer.parseInt(reader.readLine());

            System.out.print("Enter the length of the third side of the triangle: ");
            s3 = Integer.parseInt(reader.readLine());
        } catch (IOException e) {
            System.out.printf("Error parsing input: %s\n", e.getMessage());
            return;
        }

        // calculate
        side = (double) (s1 + s2 + s3) /2;
        area = Math.sqrt(side * (side - s1) * (side - s2) * (side - s3));

        System.out.printf("The area of the triangle is: %.2f\n", area);
    }
}
