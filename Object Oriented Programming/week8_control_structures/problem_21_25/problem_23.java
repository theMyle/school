/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package problem_21_25;
import javax.swing.*;
/**
 *
 * @author CCDI_LAB
 */
public class problem_23 {
    public static void main(String[] args){
        String input = "";
        double gpa = 0;
        
        try {
            input = JOptionPane.showInputDialog("Enter GPA (0.0 - 4.0)");
            gpa = Double.parseDouble(input);
        } catch (Exception e) {
            JOptionPane.showConfirmDialog(null, "Error: " + e.getMessage());
            return;
        }
        
        if (gpa >= 0.0 && gpa <= 0.99) {
            JOptionPane.showMessageDialog(null, "Failed semester - registration suspended");
        } else if (gpa >= 1.0 && gpa <= 1.99) {
            JOptionPane.showMessageDialog(null, "On probation for next semester");
        } else if (gpa >= 2.0 && gpa <= 2.99) {
            JOptionPane.showMessageDialog(null, "(no message)");
        } else if (gpa >= 3.0 && gpa <= 3.49) {
            JOptionPane.showMessageDialog(null, "Dean's list for semester");
        } else if (gpa >= 3.5 && gpa <= 4.00) {
            JOptionPane.showMessageDialog(null, "Highest honors for semester");
        }
    }
}
