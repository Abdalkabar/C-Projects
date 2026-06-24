// This file contains the StaticHelper class
// It is declared as STATIC — which means:
//   - You cannot create an instance of it with 'new'
//   - All methods inside must also be static
//   - You call its methods directly using the class name: StaticHelper.MethodName()
// Static classes are useful for utility/helper methods that don't need object state
using System;

static class StaticHelper
{
    // -------------------------------------------------------
    // Static Method: Describe
    // Takes an integer and prints a descriptive message about it
    // Called directly on the class — no instantiation needed
    //
    // Parameter: number — the integer to describe
    // -------------------------------------------------------
    public static void Describe(int number)
    {
        // Determine whether the number is even or odd using the modulus operator
        // number % 2 returns the remainder after dividing by 2
        // If remainder is 0, the number is even; otherwise it is odd
        string evenOrOdd = (number % 2 == 0) ? "even" : "odd";

        // Print a description of the number including whether it is even or odd
        Console.WriteLine("StaticHelper.Describe  : " + number + " is " + evenOrOdd);

        // Print whether the number is positive, negative, or zero
        if (number > 0)
        {
            // The number is greater than zero — it is positive
            Console.WriteLine("StaticHelper.Describe  : " + number + " is positive");
        }
        else if (number < 0)
        {
            // The number is less than zero — it is negative
            Console.WriteLine("StaticHelper.Describe  : " + number + " is negative");
        }
        else
        {
            // The number is neither positive nor negative — it is zero
            Console.WriteLine("StaticHelper.Describe  : " + number + " is zero");
        }
    }
}