package problem_11_20;

import javax.swing.*;

public class problem19 {
    public static void main(String[] args) {
        String input = "";
        int grade = 0;
        double final_grade = 0;

        try {
            input = JOptionPane.showInputDialog("Enter your grade (0 - 100):");
            grade = Integer.parseInt(input);
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Error: " + e.getMessage());
        }

        if (grade >= 98 && grade <= 100) {
            final_grade = 1.00;
        } else if (grade >= 95 && grade <= 97) {
            final_grade = 1.25;
        } else if (grade >= 92 && grade <= 94) {
            final_grade = 1.50;
        } else if (grade >= 89 && grade <= 91) {
            final_grade = 1.75;
        } else if (grade >= 85 && grade <= 88) {
            final_grade = 2.00;
        } else if (grade >= 82 && grade <= 84) {
            final_grade = 2.25;
        } else if (grade >= 80 && grade <= 81) {
            final_grade = 2.50;
        } else if (grade >= 77 && grade <= 79) {
            final_grade = 2.75;
        } else if (grade >= 75 && grade <= 76) {
            final_grade = 3.00;
        } else {
            JOptionPane.showMessageDialog(null, "OUT OF RANGE");
            return;
        }

        JOptionPane.showMessageDialog(null, "Grade Equivalent: " + final_grade);
    }
}
