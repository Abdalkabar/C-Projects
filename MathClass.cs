// This file contains the MathClass class in a separate .cs file
// It demonstrates:
//   1. A void method that divides by 2 and prints the result
//   2. A method with output parameters (out keyword)
//   3. Method overloading — same method name, different parameter types
using System;

class MathClass
{
    // -------------------------------------------------------
    // Method 1: DivideByTwo (void)
    // Takes one integer, divides it by 2, and prints the result
    // Returns nothing (void) — output goes directly to the screen
    //
    // Parameter: number — the integer to be divided by 2
    // -------------------------------------------------------
    public void DivideByTwo(int number)
    {
        // Divide the received integer by 2
        // Declare result as a double so decimal answers are preserved
        double result = (double)number / 2;

        // Print the division operation and its result to the screen
        Console.WriteLine("DivideByTwo result : " + number + " / 2 = " + result);
    }

    // -------------------------------------------------------
    // Method 2: GetMathResults (output parameters)
    // Instead of returning one value, this method uses the 'out' keyword
    // to pass multiple results back to the caller
    // The caller must declare the variables before passing them in
    //
    // Parameter: number   — the integer to perform operations on
    // Out param: half     — the result of number divided by 2
    // Out param: doubled  — the result of number multiplied by 2
    // Out param: squared  — the result of number multiplied by itself
    // -------------------------------------------------------
    public void GetMathResults(int number, out double half, out int doubled, out int squared)
    {
        // Divide the number by 2 and assign to the 'half' output parameter
        // Cast to double first so the result preserves decimal places
        half = (double)number / 2;

        // Multiply the number by 2 and assign to the 'doubled' output parameter
        doubled = number * 2;

        // Multiply the number by itself and assign to the 'squared' output parameter
        squared = number * number;
    }

    // -------------------------------------------------------
    // Method 3a: Calculate (overload 1 — takes an int)
    // Multiplies the integer by 10 and prints the result
    // This version is called when an int argument is passed in
    //
    // Parameter: number — the integer to multiply by 10
    // -------------------------------------------------------
    public void Calculate(int number)
    {
        // Multiply the integer by 10 and store the result
        int result = number * 10;

        // Print the operation and result, noting this is the int overload
        Console.WriteLine("Calculate(int)     : " + number + " x 10 = " + result);
    }

    // -------------------------------------------------------
    // Method 3b: Calculate (overload 2 — takes a double)
    // Multiplies the double by 10 and prints the result
    // This version is called when a double argument is passed in
    // C# picks this version automatically based on the argument type
    //
    // Parameter: number — the double to multiply by 10
    // -------------------------------------------------------
    public void Calculate(double number)
    {
        // Multiply the double by 10 and store the result
        double result = number * 10;

        // Print the operation and result, noting this is the double overload
        Console.WriteLine("Calculate(double)  : " + number + " x 10 = " + result);
    }
}