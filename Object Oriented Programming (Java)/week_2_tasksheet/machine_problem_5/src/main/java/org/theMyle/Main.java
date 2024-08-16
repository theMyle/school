package org.theMyle;

import java.io.*;

public class Main {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
        int area = 0;
        int perimeter = 0;
        int len = 0;
        int width = 0;

        try {
            System.out.print("Enter the length of the rectangle: ");
            len = Integer.parseInt(reader.readLine());

            System.out.print("Enter the width of the rectangle: ");
            width = Integer.parseInt(reader.readLine());
        } catch (IOException e) {
            System.out.printf("Error parsing input: %s\n", e.getMessage());
            return;
        }

        // calculate
        area = len * width;
        perimeter = 2 * (len + width);

        System.out.printf("The area of the rectangle is: %d\n", area);
        System.out.printf("The perimeter of the rectangle is: %d\n", perimeter);
    }
}