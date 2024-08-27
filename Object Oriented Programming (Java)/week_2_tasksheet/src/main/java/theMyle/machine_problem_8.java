package theMyle;

import java.io.*;

public class machine_problem_8 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int angle1, angle2, angle3 = 0;

        try {
            System.out.print("Enter the first angle of the triangle: ");
            angle1 = Integer.parseInt(reader.readLine());

            System.out.print("Enter the second angle of the triangle: ");
            angle2 = Integer.parseInt(reader.readLine());
        } catch (IOException e) {
            System.out.printf("Error parsing input: %s\n", e.getMessage());
            return;
        }

        // calculate
        angle3 = 180 - (angle1 + angle2);
        System.out.printf("The third angle of the triangle is: %d\n", angle3);
    }
}
