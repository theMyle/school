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
public class problem26 {
    public static void main(String args[]) {
        String input = "";
        int kw = 0;
        
        input = JOptionPane.showInputDialog("Enter Kilowatts");
        kw = Integer.parseInt(input);
        
        if (kw >= 1 && kw <= 99) { JOptionPane.showMessageDialog(null, "Total electric bill is P " + kw * 10.00);}
        else if (kw >= 100 && kw <= 249) {JOptionPane.showMessageDialog(null, "Total electric bill is P " + kw * 50.00);}
        else if (kw >= 250) {JOptionPane.showMessageDialog(null, "Total electric bill is P " + kw * 100.00);}
    }
}
