using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ==========================================
        // STRINGS AND INTEGERS ASSIGNMENT
        // ==========================================

        // 1. Create a list of integers to be divided
        List<int> numbers = new List<int> { 10, 25, 50, 100, 75, 200, 33 };

        // Display the list so the user knows what numbers will be divided
        Console.WriteLine("--- List of Integers ---");
        foreach (int number in numbers)
        {
            // Print each integer in the list on its own line
            Console.Write(number + " ");
        }

        // Print a blank line for spacing
        Console.WriteLine("\n");

        // Ask the user to enter the number they want to divide each list item by
        Console.Write("Enter a number to divide each list item by: ");

        // Read the user's input as a string (we will convert it later inside the try/catch)
        string userInput = Console.ReadLine();

        // ==========================================
        // STEP 5 - try/catch block wrapping the loop
        // ==========================================

        // The try block contains code that might throw an exception
        // If an error occurs anywhere inside try{}, execution jumps to catch{}
        try
        {
            // Attempt to convert the user's string input into an integer
            // If the user typed a non-numeric string (e.g. "hello"), this line
            // throws a FormatException and jumps straight to the catch block
            int divisor = int.Parse(userInput);

            // Print a heading for the results section
            Console.WriteLine("--- Division Results ---");

            // Loop through each integer in the numbers list
            // 'number' holds the value of the current list item on each iteration
            foreach (int number in numbers)
            {
                // Divide the current list item by the user's divisor
                // If divisor is 0, this throws a DivideByZeroException
                // and jumps to the catch block immediately
                // The result is stored as a double so decimal answers are shown
                double result = (double)number / divisor;

                // Display the full division expression and its result
                Console.WriteLine(number + " / " + divisor + " = " + result);
            }
        }
        catch (FormatException ex)
        {
            // This catch block runs if the user entered a non-numeric string
            // ex.Message contains the built-in description of what went wrong
            Console.WriteLine("\nERROR: Invalid input. You must enter a whole number.");
            Console.WriteLine("Details: " + ex.Message);
        }
        catch (DivideByZeroException ex)
        {
            // This catch block runs if the user entered zero as the divisor
            // Division by zero is mathematically undefined and causes this exception
            Console.WriteLine("\nERROR: You cannot divide by zero.");
            Console.WriteLine("Details: " + ex.Message);
        }
        catch (Exception ex)
        {
            // This is a general catch-all for any other unexpected exceptions
            // It acts as a safety net for errors not covered by the blocks above
            Console.WriteLine("\nERROR: An unexpected error occurred.");
            Console.WriteLine("Details: " + ex.Message);
        }

        // ==========================================
        // This line runs AFTER the try/catch block
        // regardless of whether an error occurred or not
        // It confirms the program has continued past the try/catch
        // ==========================================
        Console.WriteLine("\nThe program has emerged from the try/catch block and continues executing.");
    }
}