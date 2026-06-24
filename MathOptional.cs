// This file contains the MathOptional class in a separate .cs file
// It demonstrates optional parameters — a method that can be called
// with either one or two arguments depending on what the user provides
using System;

class MathOptional
{
    // -------------------------------------------------------
    // Method: Add
    // Takes two integer parameters and returns their sum
    // The second parameter 'b' is optional — it defaults to 0 if not provided
    // This means the method can be called with just one argument or two
    //
    // Parameter: a — the first integer, always required
    // Parameter: b — the second integer, optional (defaults to 0)
    // Returns: the sum of a and b as an integer
    // -------------------------------------------------------
    public int Add(int a, int b = 0)
    {
        // Add the two integers together and return the result
        // If only one argument was passed, b will be 0 so the result is just a
        return a + b;
    }
}