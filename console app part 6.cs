using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ==========================================
        // PART 1 - Original Array + User Input
        // ==========================================

        // Declare a one-dimensional array of five greeting strings
        string[] words = { "Hello", "Goodbye", "Welcome", "Farewell", "Greetings" };

        // Prompt the user to type some text which will be appended to each array element
        Console.Write("Enter some text to append to each word: ");

        // Read and store whatever the user types into the variable userInput
        string userInput = Console.ReadLine();

        // Loop through every index in the array using a counter variable i
        // i starts at 0 (first element) and increments by 1 each iteration
        // The loop stops when i reaches the length of the array (i.e. no longer < words.Length)
        for (int i = 0; i < words.Length; i++)
        {
            // Overwrite each array element by joining the original string with the user's input
            // No output is printed here — only the stored values are updated
            words[i] = words[i] + userInput;
        }

        // Print a heading before displaying the updated array contents
        Console.WriteLine("\nUpdated array:");

        // Use a foreach loop to iterate through every element in the array one at a time
        // 'word' takes the value of the current element on each iteration
        foreach (string word in words)
        {
            // Print the current element to the console on its own line
            Console.WriteLine(word);
        }

        // ==========================================
        // PART 2 - Fixed Infinite Loop
        // ==========================================

        // Declare and initialize a counter variable to track how many times the loop has run
        int count = 0;

        // 'while (true)' creates an infinite loop — it would run forever without a fix
        while (true)
        {
            // Print the current value of count to show which iteration we are on
            Console.WriteLine("\nLoop iteration: " + count);

            // FIX: Increment count by 1 after each iteration so it moves toward the exit condition
            count++;

            // FIX: Check if count has reached 5 — if so, we exit the loop
            if (count >= 5)
            {
                // FIX: 'break' immediately exits the while loop, preventing it from running forever
                break;
            }
        }

        // Confirm to the user that the loop has completed successfully
        Console.WriteLine("\nLoop finished! The infinite loop has been fixed.");

        // ==========================================
        // PART 3 - Loop with "<" operator
        // ==========================================

        // Print a heading to identify this section in the console output
        Console.WriteLine("\n--- Loop using '<' operator ---");

        // This for loop uses the strict less-than operator "<"
        // i starts at 0 and the loop runs while i is LESS THAN 5
        // The value 5 itself is never reached — the loop prints 0 through 4 only
        for (int i = 0; i < 5; i++)
        {
            // Print the current value of i on each iteration
            Console.WriteLine("< loop - i is: " + i);
        }

        // ==========================================
        // PART 3 - Loop with "<=" operator
        // ==========================================

        // Print a heading to identify this section in the console output
        Console.WriteLine("\n--- Loop using '<=' operator ---");

        // This for loop uses the less-than-or-equal-to operator "<="
        // i starts at 0 and the loop runs while i is LESS THAN OR EQUAL TO 5
        // Unlike "<", this includes 5 itself — the loop prints 0 through 5
        for (int i = 0; i <= 5; i++)
        {
            // Print the current value of i on each iteration
            Console.WriteLine("<= loop - i is: " + i);
        }

        // ==========================================
        // PART 4 - List Search (single match)
        // ==========================================

        // Declare a generic List of strings containing unique fruit names
        // List<string> is used instead of an array because lists are more flexible
        List<string> fruits = new List<string>
        {
            "Apple",
            "Banana",
            "Cherry",
            "Dragonfruit",
            "Elderberry",
            "Fig",
            "Grape"
        };

        // Print a heading and display every item in the list along with its index
        Console.WriteLine("\n--- Fruit List ---");
        for (int i = 0; i < fruits.Count; i++)
        {
            // fruits.Count returns the total number of items in the list
            // Display each item's index in square brackets followed by its value
            Console.WriteLine("[" + i + "] " + fruits[i]);
        }

        // Prompt the user to enter the name of a fruit they want to find
        Console.Write("\nEnter a fruit to search for: ");

        // Store the user's search text in searchInput
        string searchInput = Console.ReadLine();

        // Declare a boolean flag to track whether any matching item has been found
        // Starts as false — will be set to true if a match is found
        bool matchFound = false;

        // Loop through every index in the fruits list to look for a match
        for (int i = 0; i < fruits.Count; i++)
        {
            // Compare the current list item to the user's input
            // OrdinalIgnoreCase makes the comparison case-insensitive (e.g. "apple" matches "Apple")
            if (fruits[i].Equals(searchInput, StringComparison.OrdinalIgnoreCase))
            {
                // A match was found — display the item and its index
                Console.WriteLine("\nMatch found! \"" + fruits[i] + "\" is at index [" + i + "].");

                // Set the flag to true so we know at least one match was found
                matchFound = true;

                // 'break' exits the loop immediately since we only need the first match
                break;
            }
        }

        // After the loop, check if no match was ever found
        // If matchFound is still false, the user's input does not exist in the list
        if (!matchFound)
        {
            Console.WriteLine("\n\"" + searchInput + "\" was not found in the list.");
        }

        // ==========================================
        // PART 5 - List Search (multiple matches)
        // ==========================================

        // Declare a list of colour strings that intentionally contains duplicates
        // "Blue", "Red", and "Green" each appear more than once
        List<string> colours = new List<string>
        {
            "Red",
            "Blue",
            "Green",
            "Blue",       // duplicate of index 1
            "Yellow",
            "Red",        // duplicate of index 0
            "Purple",
            "Green",      // duplicate of index 2
            "Orange"
        };

        // Print a heading and display every colour along with its index
        Console.WriteLine("\n--- Colour List (contains duplicates) ---");
        for (int i = 0; i < colours.Count; i++)
        {
            Console.WriteLine("[" + i + "] " + colours[i]);
        }

        // Prompt the user to enter the colour they want to search for
        Console.Write("\nEnter a colour to search for: ");

        // Store the user's input in colourSearch
        string colourSearch = Console.ReadLine();

        // Boolean flag to track whether at least one match was found across the whole list
        bool colourMatchFound = false;

        // Loop through the entire colours list — no break statement so ALL matches are found
        for (int i = 0; i < colours.Count; i++)
        {
            // Case-insensitive comparison between the current item and the user's search text
            if (colours[i].Equals(colourSearch, StringComparison.OrdinalIgnoreCase))
            {
                // Print the index of every item that matches
                Console.WriteLine("Match found! \"" + colours[i] + "\" is at index [" + i + "].");

                // Mark that at least one match has been found
                colourMatchFound = true;

                // No break here — the loop continues checking the rest of the list for more matches
            }
        }

        // After the full loop, if no match was ever found, inform the user
        if (!colourMatchFound)
        {
            Console.WriteLine("\n\"" + colourSearch + "\" was not found in the list.");
        }

        // ==========================================
        // PART 6 - Duplicate Detector with foreach
        // ==========================================

        // Declare a list of animals that contains intentional duplicates
        // "Cat", "Eagle", and "Dog" each appear more than once
        List<string> animals = new List<string>
        {
            "Dog",
            "Cat",
            "Bird",
            "Dog",        // duplicate of index 0
            "Eagle",
            "Cat",        // duplicate of index 1
            "Hamster",
            "Eagle",      // duplicate of index 4
            "Rabbit"
        };

        // Print a heading for this section
        Console.WriteLine("\n--- Duplicate Detector ---");

        // Declare a separate list to keep track of every string we have already seen
        // This starts empty and grows as we iterate through the animals list
        List<string> seen = new List<string>();

        // Use a foreach loop to evaluate each item in the animals list one at a time
        // 'animal' holds the value of the current item on each iteration
        foreach (string animal in animals)
        {
            // Check if the current animal has already been added to the 'seen' list
            // Contains() returns true if the item exists in the list, false if not
            // OrdinalIgnoreCase ensures the check is not affected by capitalisation
            if (seen.Contains(animal, StringComparer.OrdinalIgnoreCase))
            {
                // This animal has already appeared earlier in the list — it is a duplicate
                Console.WriteLine(animal + " - this item is a duplicate");
            }
            else
            {
                // This animal has not been seen before — it is unique so far
                Console.WriteLine(animal + " - this item is unique");

                // Add this animal to the 'seen' list so future duplicates can be detected
                seen.Add(animal);
            }
        }
    }
}