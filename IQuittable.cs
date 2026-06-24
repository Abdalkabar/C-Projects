
// This file defines the IQuittable interface
// An interface is a contract — any class that inherits it MUST implement
// all the methods defined inside it, in this case the Quit() method
// Interfaces cannot contain any logic — only method signatures
// By convention, interface names in C# start with a capital 'I'
using System;

interface IQuittable
{
    // -------------------------------------------------------
    // Method signature: Quit()
    // This defines WHAT the method looks like but not HOW it works
    // Any class that implements IQuittable must provide its own
    // version of this method with this exact signature
    // Returns: nothing (void)
    // -------------------------------------------------------
    void Quit();
}