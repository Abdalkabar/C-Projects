// This file contains the Employee class
// It inherits the IQuittable interface, which means it MUST
// implement the Quit() method defined in that interface
// The ':' symbol is used to inherit from an interface or class
using System;

class Employee : IQuittable
{
    // -------------------------------------------------------
    // Properties
    // These store the data associated with each Employee object
    // 'public' means they can be accessed from outside the class
    // -------------------------------------------------------

    // Stores the employee's name
    public string Name { get; set; }

    // Stores the employee's job title
    public string JobTitle { get; set; }

    // Stores the employee's ID number
    public int EmployeeId { get; set; }

    // -------------------------------------------------------
    // Constructor
    // Called automatically when a new Employee object is created
    // Sets the initial values of Name, JobTitle, and EmployeeId
    //
    // Parameter: name       — the employee's name
    // Parameter: jobTitle   — the employee's job title
    // Parameter: employeeId — the employee's ID number
    // -------------------------------------------------------
    public Employee(string name, string jobTitle, int employeeId)
    {
        // Assign the received name argument to the Name property
        Name = name;

        // Assign the received jobTitle argument to the JobTitle property
        JobTitle = jobTitle;

        // Assign the received employeeId argument to the EmployeeId property
        EmployeeId = employeeId;
    }

    // -------------------------------------------------------
    // Method: DisplayInfo
    // Prints the employee's details to the screen
    // This is a regular class method, not part of the interface
    // -------------------------------------------------------
    public void DisplayInfo()
    {
        // Print each property of the employee on its own line
        Console.WriteLine("Employee ID    : " + EmployeeId);
        Console.WriteLine("Name           : " + Name);
        Console.WriteLine("Job Title      : " + JobTitle);
    }

    // -------------------------------------------------------
    // Method: Quit() — required by IQuittable interface
    // This is the implementation of the Quit() method defined
    // in the IQuittable interface — the actual logic lives here
    // The Employee class decides HOW quitting works
    // -------------------------------------------------------
    public void Quit()
    {
        // Print a message to the screen showing the employee has quit
        Console.WriteLine("\n" + Name + " (" + JobTitle + ") has submitted their resignation.");

        // Print a farewell message to make the output more descriptive
        Console.WriteLine(Name + " has left the building. Goodbye!");
    }
}