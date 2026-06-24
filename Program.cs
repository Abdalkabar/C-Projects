using System;

namespace EmployeeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create employee1 with Id = 1
            Employee employee1 = new Employee
            {
                Id        = 1,
                FirstName = "Alice",
                LastName  = "Johnson"
            };

            // Create employee2 with the SAME Id as employee1
            Employee employee2 = new Employee
            {
                Id        = 1,
                FirstName = "Alice",
                LastName  = "Johnson"
            };

            // Create employee3 with a DIFFERENT Id
            Employee employee3 = new Employee
            {
                Id        = 2,
                FirstName = "Bob",
                LastName  = "Smith"
            };

            // Display employee details
            Console.WriteLine("=== Employee Details ===");
            Console.WriteLine($"Employee 1 — Id: {employee1.Id}, Name: {employee1.FirstName} {employee1.LastName}");
            Console.WriteLine($"Employee 2 — Id: {employee2.Id}, Name: {employee2.FirstName} {employee2.LastName}");
            Console.WriteLine($"Employee 3 — Id: {employee3.Id}, Name: {employee3.FirstName} {employee3.LastName}");
            Console.WriteLine();

            // Compare employee1 and employee2 — same Id, should be TRUE
            Console.WriteLine("=== Comparison Results ===");
            Console.WriteLine($"employee1 == employee2 (same Id):      {employee1 == employee2}");  // True
            Console.WriteLine($"employee1 != employee2 (same Id):      {employee1 != employee2}");  // False
            Console.WriteLine();

            // Compare employee1 and employee3 — different Id, should be FALSE
            Console.WriteLine($"employee1 == employee3 (different Id): {employee1 == employee3}"); // False
            Console.WriteLine($"employee1 != employee3 (different Id): {employee1 != employee3}"); // True
        }
    }
}