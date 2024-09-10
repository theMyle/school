use core::num;
use std::{
    io::{self, Write},
    process,
};

mod numbersystem;
use numbersystem::binary::{dec_to_bin, dec_to_bin_float};

fn main() {
    println!("Decimal to Binary Conversion (type 'q' to quit)\n");

    // get user input
    loop {
        print!("Enter a number: ");
        io::stdout().flush().expect("Error flushing stdout");

        // read from stdin
        let mut input: String = String::new();
        io::stdin()
            .read_line(&mut input)
            .expect("failed to read from stdin");

        let input = input.trim();

        // check for exit
        if input.to_lowercase() == "q" {
            break;
        }

        // convert string to float
        let number = match input.parse::<f64>() {
            Ok(num) => num,
            Err(_) => {
                eprintln!("Invalid input, must be a number.");
                process::exit(1);
            }
        };

        // convert to binary
        match number {
            1.0 => {
                let result = dec_to_bin(number as u64) as f64;
                println!("Binary: {result}\n");
            }
            _ => {
                let result = dec_to_bin_float(number);
                println!("Binary: {result}\n");
            }
        };
    }
}
