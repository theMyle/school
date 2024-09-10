pub fn dec_to_bin(mut num: u64) -> u64 {
    let mut output: u64 = 0;
    let mut multiplier: u64 = 1;
    let mut remainder: u64;

    while num != 0 {
        remainder = num % 2;
        num /= 2;
        output += remainder * multiplier;
        multiplier *= 10;
    }
    output
}

pub fn dec_to_bin_float(num: f64) -> f64 {
    let mut output: f64 = dec_to_bin(num as u64) as f64;
    let mut fractional: f64 = num - num.floor();
    let mut multiplier: f64 = 0.1;
    let mut whole: i32;

    while fractional != 0.0 {
        whole = (fractional * 2.0) as i32;
        fractional = (fractional * 2.0) - whole as f64;
        output += whole as f64 * multiplier;
        multiplier /= 10.0;
    }
    output
}

pub fn bin_to_dec(mut num: u64) -> u64 {
    let mut output: u64 = 0;
    let mut power: u64 = 1;

    while num != 0 {
        output += (num % 10) * power;
        num /= 10;
        power *= 2;
    }
    output
}

#[cfg(test)]
mod test {
    use crate::numbersystem::binary::{bin_to_dec, dec_to_bin};

    #[test]
    fn dec_to_bin_test() {
        assert_eq!(dec_to_bin(10), 1010);
        assert_eq!(dec_to_bin(0), 0);
        assert_eq!(dec_to_bin(2), 10);
    }

    #[test]
    fn bin_to_dec_test() {
        assert_eq!(bin_to_dec(1), 1);
        assert_eq!(bin_to_dec(1010), 10);
        assert_eq!(bin_to_dec(10100), 20);
    }
}
