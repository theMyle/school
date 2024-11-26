package problem_21_25;

import javax.swing.*;

public class problem_25 {
    public static void main(String[] args) {
        String input = "";
        int watts = 0;
        int brightness = 0;
        
        input = JOptionPane.showInputDialog("Enter wattage");
        watts = Integer.parseInt(input);
        
        switch (watts) {
            case 15:
                brightness = 125;
                break;
            case 25:
                brightness = 215;
                break;
            case 40:
                brightness = 500;
                break;
            case 60:
                brightness = 880;
                break;
            case 75:
                brightness = 1000;
                break;
            case 100:
                brightness = 1675;
                break;
            default:
                brightness = -1;
                break;
        }
        
        JOptionPane.showMessageDialog(null, "Brightness: " + brightness);
    }
}
