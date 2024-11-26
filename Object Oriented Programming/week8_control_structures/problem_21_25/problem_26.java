package problem_21_25;

import javax.swing.*;

public class problem_26 {
    public static void main(String[] args) {
        String input = "";
        int kw = 0;

        input = JOptionPane.showInputDialog("Enter Kilowatts");
        kw = Integer.parseInt(input);

        int total = 0;
        if (kw >= 1 && kw <= 99) {
            total += kw * 10;
        }
        else if (kw >= 100 && kw <= 249) {
            total += (99 * 10);
            total += (kw - 99) * 50;
        }
        else if (kw >= 250) {
            total += (99 * 10);
            total += (150 * 50);
            total += (kw - 249) * 100;
        }

        JOptionPane.showMessageDialog(null,
                "Total electric bill is P " + total);

    }
}


//        else if (kw >= 100 && kw <= 249) {JOptionPane.showMessageDialog(null, "Total electric bill is P " + kw * 50.00);}
//        else if (kw >= 250) {JOptionPane.showMessageDialog(null, "Total electric bill is P " + kw * 100.00);}
