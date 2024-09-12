function decToBin(number: number): string {
    let result = ""
    let remainder = 0
    let fractional = number - Math.floor(number)
    number -= fractional

    while (number != 0) {
        remainder = number % 2
        number = Math.floor(number / 2)
        result = remainder.toString() + result
    }

    if (fractional != 0) {
        result = result + "."
        while (fractional != 0) {
            remainder = Math.floor(fractional * 2)
            fractional = (fractional * 2) - remainder
            result = result + remainder
        }
    }

    return result;
}

function main(): number {
    let input = prompt("Enter a number:")
    if (input == null) {
        console.log("Error: empty input")
        return -1
    }

    let number = parseFloat(input);
    if (Number.isNaN(number)) {
        console.log("Error: Invalid input, must be a number")
        return -1
    }

    let result = decToBin(number)
    console.log(`Binary: ${result}\n`)

    return 1
}