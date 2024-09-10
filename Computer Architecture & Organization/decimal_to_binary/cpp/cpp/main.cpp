#include <iostream>

int dec_to_bin(int number);

int main()
{
	int number = 0;

	std::cout << "Enter a number: ";
	std::cin >> number;

	int result = dec_to_bin(number);
	std::cout << "Binary: " << result << "\n";
}

int dec_to_bin(int number) {
	int output = 0;
	int multiplier = 1;

	while (number != 0) {
		int remainder = number % 2;
		number /= 2;
		output += remainder * multiplier;
		multiplier *= 10;
	}
	return output;
}
