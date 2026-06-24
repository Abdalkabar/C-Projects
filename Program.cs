// This file contains the Main() entry point of the application
// It demonstrates:
//   - Instantiating a class and calling a void method
//   - Using output parameters to receive multiple values from a method
//   - Calling overloaded methods
//   - Calling a static class method without instantiation
using System;

class Program
{
    static void Main(string[] args)
    {
        // ==========================================
        // CLASS METHOD ASSIGNMENT
        // ==========================================

        // Print a heading so the user knows what this program does
        Console.WriteLine("--- Class Method Assignment ---\n");

        // -------------------------------------------------------
        // STEP 2: Instantiate MathClass
        // Create a new object 'math' from the MathClass blueprint
        // This gives us access to all non-static methods in MathClass
        // -------------------------------------------------------
        MathClass math = new MathClass();

        // -------------------------------------------------------
        // STEP 3: Ask the user for a number, call DivideByTwo()
        // -------------------------------------------------------

        // Prompt the user to enter a number to be divided by two
        Console.Write("Enter a number to divide by two: ");

        // Read the user's input as a string
        string userInput = Console.ReadLine();

        // Wrap input parsing and method calls in a try/catch block
        // to handle any invalid (non-numeric) input gracefully
        try
        {
            // Attempt to convert the user's string input into an integer
            // Throws a FormatException if the input is not a valid number
            int userNumber = int.Parse(userInput);

            // Print a blank line for spacing
            Console.WriteLine();

            // -------------------------------------------------------
            // STEP 1 & 3: Call the void DivideByTwo() method
            // Pass the user's number in — the method prints the result
            // No return value is captured since the method is void
            // -------------------------------------------------------
            math.DivideByTwo(userNumber);

            // Print a blank line for spacing
            Console.WriteLine();

            // -------------------------------------------------------
            // STEP 4: Call GetMathResults() using output parameters
            // Declare three variables to hold the output values
            // The 'out' keyword means the method will assign values to them
            // They do not need to be initialized before being passed in
            // -------------------------------------------------------
            Console.WriteLine("Output Parameters:");

            // Declare output variables — they will be assigned inside the method
            double half;
            int doubled;
            int squared;

            // Call GetMathResults(), passing the user's number and the three out variables
            // After this line, half, doubled, and squared all have values assigned by the method
            math.GetMathResults(userNumber, out half, out doubled, out squared);

            // Display each output parameter value returned by the method
            Console.WriteLine("  Half    : " + userNumber + " / 2 = " + half);
            Console.WriteLine("  Doubled : " + userNumber + " x 2 = " + doubled);
            Console.WriteLine("  Squared : " + userNumber + " x " + userNumber + " = " + squared);

            // Print a blank line for spacing
            Console.WriteLine();

            // -------------------------------------------------------
            // STEP 5: Call the overloaded Calculate() methods
            // C# automatically picks the correct version based on argument type:
            //   passing an int    → calls Calculate(int)
            //   passing a double  → calls Calculate(double)
            // -------------------------------------------------------
            Console.WriteLine("Overloaded Methods:");

            // Call the int overload — pass the user's integer directly
            math.Calculate(userNumber);

            // Call the double overload — cast the integer to double first
            // This forces C# to call the double version of Calculate()
            math.Calculate((double)userNumber);

            // Print a blank line for spacing
            Console.WriteLine();

            // -------------------------------------------------------
            // STEP 6: Call the static class method
            // StaticHelper is a static class — no instantiation needed
            // Call its method directly using the class name
            // -------------------------------------------------------
            Console.WriteLine("Static Class:");

            // Call Describe() directly on the static class, passing the user's number
            StaticHelper.Describe(userNumber);
        }
        catch (FormatException ex)
        {
            // Runs if the user entered a non-numeric value
            // ex.Message contains the built-in description of what went wrong
            Console.WriteLine("\nERROR: Please enter a valid whole number.");
            Console.WriteLine("Details: " + ex.Message);
        }
        catch (Exception ex)
        {
            // General catch-all for any other unexpected errors
            Console.WriteLine("\nERROR: An unexpected error occurred.");
            Console.WriteLine("Details: " + ex.Message);
        }

        // Print a blank line for spacing
        Console.WriteLine();

        // Confirm the program has finished executing
        Console.WriteLine("Program complete.");
    }
}