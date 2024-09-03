#include "NumberSystem.h"

#include <iostream>
#include <cmath>
#include <cassert>

using namespace std;

void testDecToBin();

int main()
{
	testDecToBin();
}

void testDecToBin() {
	int testCase;
	int expected;
	int testCounter = 0;

	testCase = 10;
	expected = 1010;
	assert(NumberSystem::decToBin(testCase) == expected);
	testCounter++;
	cout << "Test " << testCounter << " passed!\tDecimal: " << testCase << "\tBinary: " << expected << "\n";

	testCase = 20;
	expected = 10100;
	assert(NumberSystem::decToBin(testCase) == expected);
	testCounter++;
	cout << "Test " << testCounter << " passed!\tDecimal: " << testCase << "\tBinary: " << expected << "\n";

	testCase = 500;
	expected = 111110100;
	assert(NumberSystem::decToBin(testCase) == expected);
	testCounter++;
	cout << "Test " << testCounter << " passed!\tDecimal: " << testCase << "\tBinary: " << expected << "\n";

	testCase = 900;
	expected = 1110000100;
	assert(NumberSystem::decToBin(testCase) == expected);
	testCounter++;
	cout << "Test " << testCounter << " passed!\tDecimal: " << testCase << "\tBinary: " << expected << "\n";

	testCase = 120;
	expected = 1111000;
	assert(NumberSystem::decToBin(testCase) == expected);
	testCounter++;
	cout << "Test " << testCounter << " passed!\tDecimal: " << testCase << "\tBinary: " << expected << "\n";

	double testCase2;
	double expected2;

	testCase2 = 12.75;
	expected2 = 1100.11;
	assert(NumberSystem::decToBin(testCase2) == expected2);
	testCounter++;
	cout << "Test " << testCounter << " passed!\tDecimal: " << testCase << "\tBinary: " << expected << "\n";

	testCase2 = 10.5;
	expected2 = 1010.1;
	assert(NumberSystem::decToBin(testCase2) == expected2);
	testCounter++;
	cout << "Test " << testCounter << " passed!\tDecimal: " << testCase << "\tBinary: " << expected << "\n";

	testCase2 = 0.75;
	expected2 = 0.11;
	assert(NumberSystem::decToBin(testCase2) == expected2);
	testCounter++;
	cout << "Test " << testCounter << " passed!\tDecimal: " << testCase << "\tBinary: " << expected << "\n";

	cout << "All tests passed!\n";
}
