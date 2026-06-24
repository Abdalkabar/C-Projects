using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ==========================================
        // PART 1 - Original Array + User Input
        // ==========================================

        // 1. A one-dimensional array of strings
        string[] words = { "Hello", "Goodbye", "Welcome", "Farewell", "Greetings" };

        // 2. Ask the user to input some text
        Console.Write("Enter some text to append to each word: ");
        string userInput = Console.ReadLine();

        // 3. Loop through and append user text (no output here)
        for (int i = 0; i < words.Length; i++)
        {
            words[i] = words[i] + userInput;
        }

        // 4. Second loop to print each updated string
        Console.WriteLine("\nUpdated array:");
        foreach (string word in words)
        {
            Console.WriteLine(word);
        }

        // ==========================================
        // PART 2 - Fixed Infinite Loop
        // ==========================================

        // FIX: A counter variable 'count' was introduced and incremented
        // each iteration. The loop condition checks if count is less than 5,
        // so once count reaches 5, the loop stops — preventing it from
        // running forever.
        int count = 0;
        while (true)
        {
            Console.WriteLine("\nLoop iteration: " + count);

            count++; // FIX: increment the counter each iteration

            if (count >= 5) // FIX: exit condition — breaks the infinite loop
            {
                break; // FIX: 'break' exits the while loop when count hits 5
            }
        }

        Console.WriteLine("\nLoop finished! The infinite loop has been fixed.");

        // ==========================================
        // PART 3 - Loop with "<" operator
        // ==========================================

        // This loop uses "<" so it stops BEFORE reaching 5
        // i goes: 0, 1, 2, 3, 4  (5 is never printed)
        Console.WriteLine("\n--- Loop using '<' operator ---");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("< loop - i is: " + i);
        }

        // ==========================================
        // PART 3 - Loop with "<=" operator
        // ==========================================

        // This loop uses "<=" so it stops AFTER reaching 5
        // i goes: 0, 1, 2, 3, 4, 5  (5 IS printed this time)
        Console.WriteLine("\n--- Loop using '<=' operator ---");
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("<= loop - i is: " + i);
        }

        // ==========================================
        // PART 4 - List Search (single match)
        // ==========================================

        // 1. A list of unique strings
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

        // Display the list so the user knows what's available
        Console.WriteLine("\n--- Fruit List ---");
        for (int i = 0; i < fruits.Count; i++)
        {
            Console.WriteLine("[" + i + "] " + fruits[i]);
        }

        // 2. Ask the user to input text to search for
        Console.Write("\nEnter a fruit to search for: ");
        string searchInput = Console.ReadLine();

        // Track whether a match was found
        bool matchFound = false;

        // 3. Loop through the list to find a match
        for (int i = 0; i < fruits.Count; i++)
        {
            // Case-insensitive comparison so "apple" matches "Apple"
            if (fruits[i].Equals(searchInput, StringComparison.OrdinalIgnoreCase))
            {
                // Display the index of the matching item
                Console.WriteLine("\nMatch found! \"" + fruits[i] + "\" is at index [" + i + "].");

                matchFound = true; // Mark that we found a match

                break; // Stop the loop once a match has been found
            }
        }

        // 4. Tell the user if their input was not found in the list
        if (!matchFound)
        {
            Console.WriteLine("\n\"" + searchInput + "\" was not found in the list.");
        }

        // ==========================================
        // PART 5 - List Search (multiple matches)
        // ==========================================

        // 1. A list that intentionally contains duplicate strings
        List<string> colours = new List<string>
        {
            "Red",
            "Blue",
            "Green",
            "Blue",       // duplicate
            "Yellow",
            "Red",        // duplicate
            "Purple",
            "Green",      // duplicate
            "Orange"
        };

        // Display the list so the user can see all items including duplicates
        Console.WriteLine("\n--- Colour List (contains duplicates) ---");
        for (int i = 0; i < colours.Count; i++)
        {
            Console.WriteLine("[" + i + "] " + colours[i]);
        }

        // 2. Ask the user to select text to search for
        Console.Write("\nEnter a colour to search for: ");
        string colourSearch = Console.ReadLine();

        // Track whether any match was found across the whole list
        bool colourMatchFound = false;

        // 3. Loop through the entire list — NO break, so all matches are found
        for (int i = 0; i < colours.Count; i++)
        {
            // Case-insensitive comparison
            if (colours[i].Equals(colourSearch, StringComparison.OrdinalIgnoreCase))
            {
                // Display each index where a match is found
                Console.WriteLine("Match found! \"" + colours[i] + "\" is at index [" + i + "].");

                // Mark that at least one match was found
                colourMatchFound = true;

                // NOTE: No break here — the loop continues to find ALL matches
            }
        }

        // 4. If no match was found after checking the whole list, inform the user
        if (!colourMatchFound)
        {
            Console.WriteLine("\n\"" + colourSearch + "\" was not found in the list.");
        }
    }
}