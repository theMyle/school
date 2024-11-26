package problem_21_25;

import javax.swing.*;

public class problem_24 {
    public static void main(String[] args){
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
