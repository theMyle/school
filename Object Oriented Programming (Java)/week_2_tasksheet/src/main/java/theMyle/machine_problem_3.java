package theMyle;

import java.io.*;

public class machine_problem_3 {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int radius = 0;
        double volume = 0;


        try {
            System.out.print("Input the radius of a sphere: ");
            radius = Integer.parseInt(reader.readLine());
        } catch (IOException e) {
            System.out.printf("Error parsing input: %s\n", e.getMessage());
            return;
        }

        volume = 4 * (Math.PI * Math.pow(radius, 3.0))/3;
        System.out.printf("The volume of the sphere is: %.2f\n", volume);
    }
}