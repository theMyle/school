package org.TheMyle;

import java.io.*;

public class Main {
    public static void main(String[] args) {
        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String input = "";
        float average = 0;

        float prelimGrade = 0;
        float midtermGrade = 0;
        float finalGrade = 0;

        try {
            System.out.print("Enter your prelim grade: ");
            input = reader.readLine();
            prelimGrade = Integer.parseInt(input);

            System.out.print("Enter your midterm grade: ");
            input = reader.readLine();
            midtermGrade = Integer.parseInt(input);

            System.out.print("Enter your final grade: ");
            input = reader.readLine();
            finalGrade = Integer.parseInt(input);
        } catch (IOException e) {
            System.out.println("Error");
        }

        prelimGrade *= 0.30F;
        midtermGrade *= 0.30F;
        finalGrade *= 0.40F;

        average = prelimGrade + midtermGrade + finalGrade;
        System.out.println("The average is: " + average);
    }
}