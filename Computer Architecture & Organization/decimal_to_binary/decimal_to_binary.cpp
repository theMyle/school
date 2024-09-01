#include <cstdio>
#include <cmath>
#include <cassert>

int decToBin(int decimal);
double decToBin(double decimal);
void testDecToBin();

int main()
{
	testDecToBin();
	printf("\nAll tests passed!\n");
}

// for whole numbers
int decToBin(const int decimal) {
	int output = 0, remainder = 0, decimalPlace = 0, current_val = decimal;

	while (current_val != 0) {
		remainder = current_val % 2;
		current_val /= 2;
		output += remainder * pow(10, decimalPlace);
		decimalPlace++;
	}

	return output;
}

// for fractional number
double decToBin(const double decimal) {
	int whole = decimal;
	double fractional = decimal - whole;

	int remainder = 0;
	double output = 0;
	int decimalPlace = -1;

	output = decToBin(whole);

	while (fractional != 0.0) {
		remainder = fractional * 2;
		fractional = (fractional * 2) - remainder;
		output += remainder * pow(10, decimalPlace);
		decimalPlace--;
	}

	return output;
}

void testDecToBin() {
	int testCase;
	int expected;
	int testCounter = 0;

	testCase = 10;
	expected = 1010;
	assert(decToBin(testCase) == expected);
	testCounter++;
	printf("Test %d passed!\t[Decimal: %d]\t[Binary: %d]\n", testCounter, testCase, expected);

	testCase = 20;
	expected = 10100;
	assert(decToBin(testCase) == expected);
	testCounter++;
	printf("Test %d passed!\t[Decimal: %d]\t[Binary: %d]\n", testCounter, testCase, expected);

	testCase = 500;
	expected = 111110100;
	assert(decToBin(testCase) == expected);
	testCounter++;
	printf("Test %d passed!\t[Decimal: %d]\t[Binary: %d]\n", testCounter, testCase, expected);

	testCase = 900;
	expected = 1110000100;
	assert(decToBin(testCase) == expected);
	testCounter++;
	printf("Test %d passed!\t[Decimal: %d]\t[Binary: %d]\n", testCounter, testCase, expected);

	testCase = 120;
	expected = 1111000;
	assert(decToBin(testCase) == expected);
	testCounter++;
	printf("Test %d passed!\t[Decimal: %d]\t[Binary: %d]\n", testCounter, testCase, expected);

	double testCase2;
	double expected2;

	testCase2 = 12.75;
	expected2 = 1100.11;
	assert(decToBin(testCase2) == expected2);
	testCounter++;
	printf("Test %d passed!\t[Decimal: %.2f]\t[Binary: %.2f]\n", testCounter, testCase2, expected2);

	testCase2 = 10.5;
	expected2 = 1010.1;
	assert(decToBin(testCase2) == expected2);
	testCounter++;
	printf("Test %d passed!\t[Decimal: %.2f]\t[Binary: %.2f]\n", testCounter, testCase2, expected2);

	testCase2 = 0.75;
	expected2 = 0.11;
	assert(decToBin(testCase2) == expected2);
	testCounter++;
	printf("Test %d passed!\t[Decimal: %.2f]\t[Binary: %.2f]\n", testCounter, testCase2, expected2);
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
