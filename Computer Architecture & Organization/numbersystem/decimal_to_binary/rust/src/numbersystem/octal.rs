pub fn dec_to_octal(mut num: u64) -> u64 {
    let mut output: u64 = 0;
    let mut multiplier: u64 = 1;

    while num != 0 {
        let remainder = num % 8;
        num /= 8;
        output += remainder * multiplier;
        multiplier *= 10;
    }
    output
}

pub fn octal_to_dec(mut num: u64) -> u64 {
    let mut output: u64 = 0;
    let mut power: u64 = 1;

    while num != 0 {
        output += (num % 10) * power;
        num /= 10;
        power *= 8;
    }
    output
}

#[cfg(test)]
mod tests {
    use crate::numbersystem::octal::{dec_to_octal, octal_to_dec};

    #[test]
    fn dec_to_octal_test() {
        assert_eq!(dec_to_octal(10), 12);
        assert_eq!(dec_to_octal(20), 24);
        assert_eq!(dec_to_octal(0), 0);
    }

    #[test]
    fn octal_to_dec_test() {
        assert_eq!(octal_to_dec(12), 10);
        assert_eq!(octal_to_dec(24), 20);
        assert_eq!(octal_to_dec(0), 0);
    }
}
