// This file contains the Main() entry point of the application
// It asks the user for a number, then calls each method in MathOperations
// and displays the returned result to the screen
using System;

class Program
{
    static void Main(string[] args)
    {
        // ==========================================
        // CALLING METHODS ASSIGNMENT
        // ==========================================

        // Print a heading so the user knows what this program does
        Console.WriteLine("--- Calling Methods Assignment ---\n");

        // Ask the user to enter an integer to perform math operations on
        Console.Write("Enter a number to perform math operations on: ");

        // Read the user's input as a string
        string userInput = Console.ReadLine();

        // Wrap everything in a try/catch to handle invalid input gracefully
        try
        {
            // Attempt to convert the user's string input into an integer
            // Throws a FormatException if the input is not a valid number
            int userNumber = int.Parse(userInput);

            // Create an instance of the MathOperations class
            // This gives us access to the three math methods defined in MathOperations.cs
            MathOperations math = new MathOperations();

            // -------------------------------------------------------
            // Call Method 1: Double
            // Pass the user's number to the Double() method
            // Store the returned integer in the result variable
            // -------------------------------------------------------
            int doubleResult = math.Double(userNumber);

            // Display the result of the Double method to the screen
            Console.WriteLine("\nDouble  : " + userNumber + " x 2 = " + doubleResult);

            // -------------------------------------------------------
            // Call Method 2: Square
            // Pass the user's number to the Square() method
            // Store the returned integer in the result variable
            // -------------------------------------------------------
            int squareResult = math.Square(userNumber);

            // Display the result of the Square method to the screen
            Console.WriteLine("Square  : " + userNumber + " x " + userNumber + " = " + squareResult);

            // -------------------------------------------------------
            // Call Method 3: AddTen
            // Pass the user's number to the AddTen() method
            // Store the returned integer in the result variable
            // -------------------------------------------------------
            int addTenResult = math.AddTen(userNumber);

            // Display the result of the AddTen method to the screen
            Console.WriteLine("Add Ten : " + userNumber + " + 10 = " + addTenResult);
        }
        catch (FormatException ex)
        {
            // Runs if the user typed a non-numeric value (e.g. "hello")
            // ex.Message contains the built-in description of what went wrong
            Console.WriteLine("\nERROR: Please enter a valid whole number.");
            Console.WriteLine("Details: " + ex.Message);
        }
        catch (Exception ex)
        {
            // General catch-all for any other unexpected exceptions
            Console.WriteLine("\nERROR: An unexpected error occurred.");
            Console.WriteLine("Details: " + ex.Message);
        }

        // Confirm the program has finished executing
        Console.WriteLine("\nProgram complete.");
    }
}