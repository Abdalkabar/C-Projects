// This file contains the MathOverload class in a separate .cs file
// It demonstrates method overloading — three methods all named "Calculate"
// but each accepting a different parameter type (int, decimal, string)
// C# knows which version to call based on what type of argument is passed in
using System;

class MathOverload
{
    // -------------------------------------------------------
    // Method 1: Calculate(int)
    // Accepts an integer, performs addition, returns an integer
    // This version is called when an int is passed in from Main()
    // Parameter: num — the integer passed in from Main()
    // Returns: num + 50 as an integer
    // -------------------------------------------------------
    public int Calculate(int num)
    {
        // Add 50 to the received integer and return the result to the caller
        return num + 50;
    }

    // -------------------------------------------------------
    // Method 2: Calculate(decimal)
    // Accepts a decimal, performs multiplication, returns an integer
    // This version is called when a decimal is passed in from Main()
    // The result is cast to int, which drops any decimal places (truncates)
    // Parameter: num — the decimal value passed in from Main()
    // Returns: num multiplied by 3, truncated to an integer
    // -------------------------------------------------------
    public int Calculate(decimal num)
    {
        // Multiply the decimal by 3, then cast to int to drop any decimal places
        // Example: 4.7 * 3 = 14.1 → cast to int → 14
        return (int)(num * 3);
    }

    // -------------------------------------------------------
    // Method 3: Calculate(string)
    // Accepts a string, converts it to an integer, performs subtraction
    // Returns the result as an integer
    // This version is called when a string is passed in from Main()
    // Parameter: numString — a string that should represent a whole number
    // Returns: the parsed integer minus 10, or -1 if conversion fails
    // -------------------------------------------------------
    public int Calculate(string numString)
    {
        // Attempt to convert the string to an integer using int.TryParse
        // TryParse returns true if conversion succeeds, false if it fails
        // The converted value is stored in 'parsed' if successful
        bool success = int.TryParse(numString, out int parsed);

        // Check if the string was successfully converted to an integer
        if (success)
        {
            // Conversion succeeded — subtract 10 from the parsed integer and return it
            return parsed - 10;
        }
        else
        {
            // Conversion failed — the string was not a valid integer
            // Print an error message so the caller knows what went wrong
            Console.WriteLine("ERROR: \"" + numString + "\" could not be converted to an integer.");

            // Return -1 as a sentinel value to signal that the operation failed
            return -1;
        }
    }
}