package problem_21_25;

import javax.swing.*;

public class problem_21 {
    public static void main(String[] args) {
        String input = "";
        double prelim = 0;
        double midterm = 0;
        double finals = 0;
        int total_grade = 0;
        double final_grade = 0;

        try {
            input = JOptionPane.showInputDialog("Enter Prelims Grade: ");
            prelim = Double.parseDouble(input);
            input = JOptionPane.showInputDialog("Enter Midterms Grade: ");
            midterm = Double.parseDouble(input);
            input = JOptionPane.showInputDialog("Enter Finals Grade: ");
            finals = Double.parseDouble(input);
            total_grade = (int) ((prelim * 0.3) + (midterm * 0.3) + (finals*0.4));
        } catch (Exception e) {
            JOptionPane.showMessageDialog(null, "Error: " + e.getMessage());
            return;
        }

        if (total_grade >= 98 && total_grade <= 100) {
            final_grade = 1.00;
        } else if (total_grade >= 95 && total_grade <= 97) {
            final_grade = 1.25;
        } else if (total_grade >= 92 && total_grade <= 94) {
            final_grade = 1.50;
        } else if (total_grade >= 89 && total_grade <= 91) {
            final_grade = 1.75;
        } else if (total_grade >= 85 && total_grade <= 88) {
            final_grade = 2.00;
        } else if (total_grade >= 82 && total_grade <= 84) {
            final_grade = 2.25;
        } else if (total_grade >= 80 && total_grade <= 81) {
            final_grade = 2.50;
        } else if (total_grade >= 77 && total_grade <= 79) {
            final_grade = 2.75;
        } else if (total_grade >= 75 && total_grade <= 76) {
            final_grade = 3.00;
        } else if (total_grade >= 70 && total_grade <= 74) {
            final_grade = 4.00;
        } else {
            final_grade = 5.00;
        }

        JOptionPane.showMessageDialog(null, "Class Card Grade: " + final_grade);
    }
}
