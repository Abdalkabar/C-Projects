// This file contains the MathOperations class, kept in a separate .cs file
// as required, so the logic is organized away from the Main() program
using System;

class MathOperations
{
    // -------------------------------------------------------
    // Method 1: Double
    // Takes one integer parameter, multiplies it by 2, and returns the result
    // Parameter: num — the integer passed in from Main()
    // Returns: the result of num multiplied by 2
    // -------------------------------------------------------
    public int Double(int num)
    {
        // Multiply the received integer by 2 and return the result to the caller
        return num * 2;
    }

    // -------------------------------------------------------
    // Method 2: Square
    // Takes one integer parameter, multiplies it by itself, and returns the result
    // Parameter: num — the integer passed in from Main()
    // Returns: the result of num squared (num * num)
    // -------------------------------------------------------
    public int Square(int num)
    {
        // Multiply the received integer by itself and return the result to the caller
        return num * num;
    }

    // -------------------------------------------------------
    // Method 3: AddTen
    // Takes one integer parameter, adds 10 to it, and returns the result
    // Parameter: num — the integer passed in from Main()
    // Returns: the result of num plus 10
    // -------------------------------------------------------
    public int AddTen(int num)
    {
        // Add 10 to the received integer and return the result to the caller
        return num + 10;
    }
}