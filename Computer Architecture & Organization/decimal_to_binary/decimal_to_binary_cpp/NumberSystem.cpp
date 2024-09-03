#include "NumberSystem.h"
#include <cmath>

int NumberSystem::decToBin(const int number) {
	int currentVal = number;
	int remainder = 0;
	int decimalPlace = 0;
	int output = 0;

	while (currentVal != 0) {
		remainder = currentVal % 2;
		currentVal /= 2;
		output += remainder * std::pow(10, decimalPlace);
		decimalPlace++;
	}

	return output;
}

double NumberSystem::decToBin(const double number) {
	int whole = number;
	double fractional = number - whole;
	double output = decToBin(whole);
	int decimalPlace = 1;

	// calculate fractional part
	while (fractional != 0) {
		whole = fractional * 2;
		fractional = (fractional * 2.0) - whole;
		output += whole * std::pow(10, -decimalPlace);
		decimalPlace++;
	}

	return output;
}
