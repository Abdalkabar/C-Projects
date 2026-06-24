// This file contains the Main() entry point of the application
// It demonstrates:
//   - Creating an Employee object and displaying its info
//   - Using polymorphism to store an Employee in an IQuittable variable
//   - Calling the Quit() method through the interface type
using System;

class Program
{
    static void Main(string[] args)
    {
        // ==========================================
        // INTERFACE AND POLYMORPHISM ASSIGNMENT
        // ==========================================

        // Print a heading so the user knows what this program does
        Console.WriteLine("--- Interface & Polymorphism Assignment ---\n");

        // -------------------------------------------------------
        // Create a regular Employee object using the constructor
        // Pass in the employee's name, job title, and ID number
        // -------------------------------------------------------
        Employee employee = new Employee("Sarah Connor", "Software Developer", 1042);

        // Call DisplayInfo() to print the employee's details to the screen
        Console.WriteLine("Employee Details:");
        employee.DisplayInfo();

        // Print a blank line for spacing
        Console.WriteLine();

        // -------------------------------------------------------
        // STEP 3: Polymorphism — store the Employee as an IQuittable type
        //
        // This is polymorphism in action:
        //   - 'quittable' is declared as type IQuittable (the interface)
        //   - but it holds an Employee object (the implementing class)
        // This works because Employee implements IQuittable
        // Through this variable we can only access methods defined in IQuittable
        // In this case, that means only Quit() is accessible via 'quittable'
        // -------------------------------------------------------
        IQuittable quittable = employee;

        // Call Quit() through the IQuittable interface reference
        // Even though the variable type is IQuittable, C# calls the
        // Employee's version of Quit() at runtime — this is polymorphism
        Console.WriteLine("Calling Quit() through IQuittable reference:");
        quittable.Quit();

        // Print a blank line for spacing
        Console.WriteLine();

        // -------------------------------------------------------
        // BONUS: Create a second Employee and call Quit() directly
        // This shows that any Employee object has access to Quit()
        // since Employee implements IQuittable
        // -------------------------------------------------------
        Console.WriteLine("--- Second Employee ---\n");

        // Create a second Employee object with different details
        Employee employee2 = new Employee("John Doe", "Project Manager", 2087);

        // Display the second employee's details
        Console.WriteLine("Employee Details:");
        employee2.DisplayInfo();

        // Store the second employee as IQuittable type
        // Again demonstrating that any Employee can be treated as IQuittable
        IQuittable quittable2 = employee2;

        // Call Quit() on the second employee through the interface reference
        quittable2.Quit();

        // Print a blank line for spacing
        Console.WriteLine();

        // Confirm the program has finished executing
        Console.WriteLine("Program complete.");
    }
}