// This file contains the MathDisplay class in a separate .cs file
// It demonstrates a void method — a method that performs actions
// but does not return a value back to the caller
using System;

class MathDisplay
{
    // -------------------------------------------------------
    // Method: Calculate
    // A void method — it performs work but returns nothing
    // Takes two integer parameters:
    //   - 'number'  : has a math operation performed on it (tripled)
    //   - 'display' : is printed as-is to the screen
    //
    // Parameter: number  — the integer to perform math on
    // Parameter: display — the integer to display to the screen
    // Returns: nothing (void)
    // -------------------------------------------------------
    public void Calculate(int number, int display)
    {
        // Perform a math operation on the first integer — multiply it by 3
        int result = number * 3;

        // Display the math operation and its result to the screen
        Console.WriteLine("Math operation on first number  : " + number + " x 3 = " + result);

        // Display the second integer directly to the screen with no math applied
        Console.WriteLine("Display value of second number  : " + display);
    }
}