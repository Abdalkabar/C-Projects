// This file contains the Main() entry point of the application
// It instantiates MathDisplay and calls the Calculate() void method
// in two different ways — by position and by named parameters
using System;

class Program
{
    static void Main(string[] args)
    {
        // ==========================================
        // VOID METHOD AND NAMED PARAMETERS ASSIGNMENT
        // ==========================================

        // Print a heading so the user knows what this program does
        Console.WriteLine("--- Void Method & Named Parameters Assignment ---\n");

        // Instantiate the MathDisplay class so we can call its Calculate() method
        // A new object 'math' is created from the MathDisplay blueprint
        MathDisplay math = new MathDisplay();

        // -------------------------------------------------------
        // STEP 3: Call the method passing in two numbers by position
        // The arguments are matched to parameters left to right:
        //   7  → number  (will be tripled)
        //   42 → display (will be printed as-is)
        // This is the standard way to call a method
        // -------------------------------------------------------

        // Print a label so the output is clearly identified
        Console.WriteLine("Call 1 — passing arguments by position:");

        // Call Calculate() with two positional integer arguments
        // No return value is captured since the method is void
        math.Calculate(7, 42);

        // Print a blank line for spacing between the two calls
        Console.WriteLine();

        // -------------------------------------------------------
        // STEP 4: Call the method specifying parameters by name
        // Named parameters use the syntax: parameterName: value
        // They can be written in any order since the names make it clear
        // which value belongs to which parameter
        // Here we swap the order to show that named parameters are order-independent
        // -------------------------------------------------------

        // Print a label so the output is clearly identified
        Console.WriteLine("Call 2 — passing arguments by name:");

        // Call Calculate() using named parameters in swapped order
        // display: is listed first, number: is listed second
        // C# matches each value to the correct parameter by name, not position
        math.Calculate(display: 99, number: 15);

        // Print a blank line for spacing
        Console.WriteLine();

        // Confirm the program has finished executing
        Console.WriteLine("Program complete.");
    }
}