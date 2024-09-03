#pragma once

/// <summary>
/// A class for converting different number systems to other number systems.
/// </summary>
class NumberSystem
{
public:
	/// <summary>
	/// This method takes an integer in decimal format and coverts it into its binary representation.
	/// </summary>
	/// <param name="number">- the decimal integer to be converted.</param>
	/// <returns>The Binary representation of the input as an integer.</returns>
	static int decToBin(const int number);

	/// <summary>
	/// This method takes an fractional integer in decimal format and coverts it into its binary representation.
	/// </summary>
	/// <param name="number">- the fractional decimal integer to be converted.</param>
	/// <returns>The Binary representation of the input as double.</returns>
	static double decToBin(const double number);
};

