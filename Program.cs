// This file contains the Main() entry point of the application
// It demonstrates calling three overloaded versions of Calculate()
// each accepting a different type: int, decimal, and string
using System;

class Program
{
    static void Main(string[] args)
    {
        // ==========================================
        // MAIN METHOD ASSIGNMENT - Method Overloading
        // ==========================================

        // Print a heading so the user knows what this program does
        Console.WriteLine("--- Main Method Assignment ---\n");

        // Create a single instance of MathOverload to use for all three method calls
        // One instance is enough since all three methods live in the same class
        MathOverload math = new MathOverload();

        // -------------------------------------------------------
        // STEP 2: Call Method 1 — Calculate(int)
        // Pass a plain integer literal to the method
        // C# sees the argument is an int and calls the int version of Calculate()
        // -------------------------------------------------------

        // Declare an integer value to pass into the first method
        int intInput = 25;

        // Call the int version of Calculate(), store the returned integer in intResult
        int intResult = math.Calculate(intInput);

        // Display the input and the returned result to the screen
        Console.WriteLine("Method 1 - Calculate(int):");
        Console.WriteLine("  Input  : " + intInput + " (integer)");
        Console.WriteLine("  Math   : " + intInput + " + 50");
        Console.WriteLine("  Result : " + intResult);

        // Print a blank line for spacing between sections
        Console.WriteLine();

        // -------------------------------------------------------
        // STEP 4: Call Method 2 — Calculate(decimal)
        // Pass a decimal literal to the method (the 'm' suffix tells C# it's a decimal)
        // C# sees the argument is a decimal and calls the decimal version of Calculate()
        // -------------------------------------------------------

        // Declare a decimal value to pass into the second method
        // The 'm' suffix is required in C# to denote a decimal literal
        decimal decimalInput = 4.7m;

        // Call the decimal version of Calculate(), store the returned integer in decimalResult
        int decimalResult = math.Calculate(decimalInput);

        // Display the input and the returned result to the screen
        Console.WriteLine("Method 2 - Calculate(decimal):");
        Console.WriteLine("  Input  : " + decimalInput + " (decimal)");
        Console.WriteLine("  Math   : " + decimalInput + " x 3 = " + (decimalInput * 3) + " → truncated to int");
        Console.WriteLine("  Result : " + decimalResult);

        // Print a blank line for spacing between sections
        Console.WriteLine();

        // -------------------------------------------------------
        // STEP 6: Call Method 3 — Calculate(string)
        // Pass a string that represents a whole number to the method
        // C# sees the argument is a string and calls the string version of Calculate()
        // -------------------------------------------------------

        // Declare a string value that represents a valid integer
        string stringInput = "80";

        // Call the string version of Calculate(), store the returned integer in stringResult
        int stringResult = math.Calculate(stringInput);

        // Display the input and the returned result to the screen
        Console.WriteLine("Method 3 - Calculate(string):");
        Console.WriteLine("  Input  : \"" + stringInput + "\" (string)");
        Console.WriteLine("  Math   : " + stringInput + " - 10");
        Console.WriteLine("  Result : " + stringResult);

        // Print a blank line for spacing
        Console.WriteLine();

        // -------------------------------------------------------
        // BONUS: Call Method 3 with an invalid string to show error handling
        // -------------------------------------------------------

        // Declare a string that cannot be converted to an integer
        string badInput = "hello";

        // Call the string version — TryParse will fail and return -1
        int badResult = math.Calculate(badInput);

        // Display the result of passing an invalid string
        Console.WriteLine("Method 3 - Calculate(string) with invalid input:");
        Console.WriteLine("  Input  : \"" + badInput + "\" (string)");
        Console.WriteLine("  Result : " + badResult + " (sentinel value — conversion failed)");

        // Print a blank line for spacing
        Console.WriteLine();

        // Confirm the program has finished executing
        Console.WriteLine("Program complete.");
    }
}