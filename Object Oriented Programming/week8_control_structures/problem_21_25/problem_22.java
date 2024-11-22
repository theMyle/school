/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Main;

import javax.swing.*;
/**
 *
 * @author CCDI_LAB
 */
public class problem22 {
    public static void main(String args[]) {
        double general_average = 0;
        int assignment = 0;
        int seatwork = 0;
        int quiz = 0;
        int exam = 0;
        String input = "";
        
        try {
            input = JOptionPane.showInputDialog("Enter Assignment Grade");
            assignment = Integer.parseInt(input);
            
            input = JOptionPane.showInputDialog("Enter Seatwork Grade");
            seatwork = Integer.parseInt(input);
            
            input = JOptionPane.showInputDialog("Enter Quiz Grade");
            quiz = Integer.parseInt(input);
            
            input = JOptionPane.showInputDialog("Enter Exam Grade");
            exam = Integer.parseInt(input);
        } catch (Exception e) {
            JOptionPane.showConfirmDialog(null, "Error: " + e.getMessage());
            return;
        }
        
        general_average = 
                (assignment * 0.1) +
                (seatwork * 0.2) +
                (quiz * 0.3) +
                (exam * 0.4);
        
        double equivalent_grade = 0;
        String remarks = "";
        
        if (general_average >= 97 && general_average <= 100) {
            equivalent_grade = 1.00;
            remarks = "Excellent";
        } else if (general_average >= 94 && general_average <= 96) {
            equivalent_grade = 1.25;
            remarks = "Excellent";
        } else if (general_average >= 91 && general_average <= 93) {
            equivalent_grade = 1.50;
            remarks = "Very Good";
        } else if (general_average >= 88 && general_average <= 90) {
            equivalent_grade = 1.75;
            remarks = "Very Good";
        } else if (general_average >= 85 && general_average <= 87) {
            equivalent_grade = 2.00;
            remarks = "Good";
        } else if (general_average >= 85 && general_average <= 87) {
            equivalent_grade = 2.00;
            remarks = "Good";
        } else if (general_average >= 82 && general_average <= 84) {
            equivalent_grade = 2.25;
            remarks = "Good";
        } else if (general_average >= 79 && general_average <= 81) {
            equivalent_grade = 2.50;
            remarks = "Satisfactory";
        } else if (general_average >= 76 && general_average <= 78) {
            equivalent_grade = 2.75;
            remarks = "Fair";
        } else if (general_average >= 75 && general_average < 76) {
            equivalent_grade = 3.00;
            remarks = "Passed";
        } else if (general_average < 75) {
            equivalent_grade = 5.00;
            remarks = "Failed";
        }
        
        JOptionPane.showMessageDialog(null,
            "Equivalent Grade: " + equivalent_grade + 
            "\nRemarks: " + remarks);
    }
}
