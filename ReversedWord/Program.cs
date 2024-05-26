using System;
using System.Collections;

class Program
{
    static public void Main()
    {
        Console.WriteLine("Enter the word: ");
        string word = Console.ReadLine();

        string reversedWord = WordReversing(word);
        Console.WriteLine($"Reversed word: {reversedWord}");
    }

    static string WordReversing(string word)
    {
        string reverseword = "";
        Stack<char> stack = new Stack<char>();
        foreach (char c in word)
        {
            stack.Push(c);
        }
        while (stack.Count > 0)
        {
            reverseword += stack.Pop();
        }
        return reverseword;
    }
}
