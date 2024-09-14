package main

import (
	"fmt"
	"os"
)

func main() {
	var number int

	fmt.Print("Enter a number: ")
	_, err := fmt.Scanln(&number)
	if err != nil {
		fmt.Println("Invalid input, must be an integer")
		os.Exit(1)
	}

	result := decToBin(number)
	fmt.Printf("Binary: %d\n", result)
}

func decToBin(num int) int {
	output := 0
	decimalPlace := 1

	for num != 0 {
		remainder := num % 2
		num /= 2
		output += remainder * decimalPlace
		decimalPlace *= 10
	}
	return output
}
