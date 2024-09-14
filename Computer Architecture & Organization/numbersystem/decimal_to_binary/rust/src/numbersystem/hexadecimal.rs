fn from_char(letter: char) -> Option<u32> {
    match letter {
        '0'..='9' => Some((letter as u32) - ('0' as u32)),
        'A'..='F' => Some((letter as u32) - ('A' as u32) + 10),
        'a'..='f' => Some((letter as u32) - ('a' as u32) + 10),
        _ => None,
    }
}

fn from_dec(num: u32) -> Option<char> {
    match num {
        0..=9 => Some((b'0' + num as u8) as char),
        10..=15 => Some((b'A' + (num - 10) as u8) as char),
        _ => None,
    }
}

pub fn dec_to_hex(mut num: u64) -> String {
    todo!()
}

pub fn hex_to_dec(hex: &str) -> u64 {
    let mut output: u64 = 0;

    for c in hex.chars() {
        output += (16 * from_char(c).unwrap()) as u64;
    }
    output
}

#[cfg(test)]
mod tests {
    use super::{from_char, from_dec};

    #[test]
    fn dec_to_hex_test() {
        todo!()
    }

    #[test]
    fn hex_to_dec_test() {
        todo!()
    }

    #[test]
    fn from_char_test() {
        assert_eq!(from_char('A').unwrap(), 10);
        assert_eq!(from_char('0').unwrap(), 0);
        assert_eq!(from_char('f').unwrap(), 15);
    }

    #[test]
    fn from_dec_test() {
        assert_eq!(from_dec(10).unwrap(), 'A');
        assert_eq!(from_dec(0).unwrap(), '0');
        assert_eq!(from_dec(15).unwrap(), 'F');
    }
}
