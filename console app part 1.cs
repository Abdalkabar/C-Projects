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
    }
}