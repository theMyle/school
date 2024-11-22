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
public class problem24 {
    public static void main(String args[]) {
        String input = "";
        int wind = 0;
        
        input = JOptionPane.showInputDialog("Enter wind speed");
        wind = Integer.parseInt(input);
        
        if (wind < 25) {
            JOptionPane.showMessageDialog(null, "not a string wind");
        } else if (wind >= 25 && wind <= 38) {
            JOptionPane.showMessageDialog(null, "string wind");
        } else if (wind >= 39 && wind <= 54) {
            JOptionPane.showMessageDialog(null, "gale");
        } else if (wind >= 55 && wind <= 72) {
            JOptionPane.showMessageDialog(null, "whole gale");
        } else if (wind > 72) {
            JOptionPane.showMessageDialog(null, "hurricane");
        }
    }
}
