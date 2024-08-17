package org.theMyle;

import java.io.*;

public class Main {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int side = 0;
        double volume = 0;

        try {
            System.out.print("Enter the length of a side of a cube: ");
            side = Integer.parseInt(reader.readLine());
        } catch (IOException e) {
            System.out.printf("Error parsing input %s\n", e.getMessage());
            return;
        }

        volume = Math.pow(side, 3);
        System.out.printf("The volume of the cube is: %.2f\n", volume);
    }
}