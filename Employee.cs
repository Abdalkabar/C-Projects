using System;

namespace EmployeeApp
{
    public class Employee
    {
        // Unique identifier for the employee — used as the basis for equality comparison
        public int Id { get; set; }

        // The employee's first name
        public string FirstName { get; set; }

        // The employee's last name
        public string LastName { get; set; }

        // Overload == to compare two Employee objects by their Id
        public static bool operator ==(Employee a, Employee b)
        {
            // Handle null cases using ReferenceEquals to avoid infinite recursion
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;  // Both null = equal

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false; // One null = not equal

            // Compare by Id only
            return a.Id == b.Id;
        }

        // Overload != (required pair with ==)
        public static bool operator !=(Employee a, Employee b)
        {
            // Reuse == and negate to avoid duplicating logic
            return !(a == b);
        }

        // Override Equals() to stay consistent with overloaded ==
        public override bool Equals(object obj)
        {
            return this == (obj as Employee);
        }

        // Override GetHashCode() — required whenever Equals() is overridden
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}