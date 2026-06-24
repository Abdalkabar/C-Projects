// This file contains the Main() entry point of the application
// It asks the user for one or two numbers, then calls the Add() method
// in MathOptional, passing in the provided values and displaying the result
using System;

class Program
{
    static void Main(string[] args)
    {
        // ==========================================
        // METHOD ASSIGNMENT - Optional Parameters
        // ==========================================

        // Print a heading so the user knows what this program does
        Console.WriteLine("--- Method Assignment: Optional Parameters ---\n");

        // Instantiate the MathOptional class so we can call its Add() method
        MathOptional math = new MathOptional();

        // -------------------------------------------------------
        // Ask the user for the first number (always required)
        // -------------------------------------------------------

        // Prompt the user to enter the first number
        Console.Write("Enter the first number: ");

        // Read the user's input as a string
        string firstInput = Console.ReadLine();

        // -------------------------------------------------------
        // Ask the user for the second number (optional — they can skip it)
        // -------------------------------------------------------

        // Let the user know the second number is optional
        Console.Write("Enter the second number (or press Enter to skip): ");

        // Read the user's input — this may be an empty string if they just press Enter
        string secondInput = Console.ReadLine();

        // -------------------------------------------------------
        // Wrap everything in a try/catch to handle invalid input
        // -------------------------------------------------------
        try
        {
            // Attempt to convert the first input string to an integer
            // Throws a FormatException if the input is not a valid number
            int firstNumber = int.Parse(firstInput);

            // Check if the user entered anything for the second number
            // string.IsNullOrWhiteSpace() returns true if the string is empty or blank
            if (string.IsNullOrWhiteSpace(secondInput))
            {
                // -------------------------------------------------------
                // CASE 1: User skipped the second number
                // Call Add() with only one argument
                // The optional parameter b will default to 0 inside the method
                // -------------------------------------------------------

                // Call Add() passing only the first number
                int result = math.Add(firstNumber);

                // Display the operation and result to the screen
                Console.WriteLine("\nNo second number entered — using default value of 0.");
                Console.WriteLine("Math : " + firstNumber + " + 0");
                Console.WriteLine("Result : " + result);
            }
            else
            {
                // -------------------------------------------------------
                // CASE 2: User entered both numbers
                // Convert the second input and call Add() with two arguments
                // -------------------------------------------------------

                // Attempt to convert the second input string to an integer
                // Throws a FormatException if the input is not a valid number
                int secondNumber = int.Parse(secondInput);

                // Call Add() passing both numbers
                int result = math.Add(firstNumber, secondNumber);

                // Display the operation and result to the screen
                Console.WriteLine("\nMath   : " + firstNumber + " + " + secondNumber);
                Console.WriteLine("Result : " + result);
            }
        }
        catch (FormatException ex)
        {
            // Runs if the user typed a non-numeric value for either number
            // ex.Message contains the built-in description of what went wrong
            Console.WriteLine("\nERROR: Please enter valid whole numbers only.");
            Console.WriteLine("Details: " + ex.Message);
        }
        catch (Exception ex)
        {
            // General catch-all for any other unexpected errors
            Console.WriteLine("\nERROR: An unexpected error occurred.");
            Console.WriteLine("Details: " + ex.Message);
        }

        // Confirm the program has finished executing
        Console.WriteLine("\nProgram complete.");
    }
}