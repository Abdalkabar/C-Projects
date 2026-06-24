using System;

class Program
{
    static void Main(string[] args)
    {
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
        // PART 2 - Infinite Loop (then fixed)
        // ==========================================

        // STEP 1: This was the original infinite loop (broken):
        // while (true)
        // {
        //     Console.WriteLine("This runs forever!");
        // }

        // FIX: A counter variable 'count' was introduced and incremented
        // each iteration. The loop condition checks if count is less than 5,
        // so once count reaches 5, the loop stops — preventing it from
        // running forever.
        int count = 0;
        while (true)
        {
            Console.WriteLine("Loop iteration: " + count);

            count++; // FIX: increment the counter each iteration

            if (count >= 5) // FIX: exit condition — breaks the infinite loop
            {
                break; // FIX: 'break' exits the while loop when count hits 5
            }
        }

        Console.WriteLine("\nLoop finished! The infinite loop has been fixed.");
    }
}