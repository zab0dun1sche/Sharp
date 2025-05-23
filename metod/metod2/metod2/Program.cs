using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите строку для проверки:");
        string input = Console.ReadLine();
        bool isPalindrome = IsPalindrome(input);
        Console.WriteLine($"Является ли строка палиндромом? {isPalindrome}");
    }

    static bool IsPalindrome(string input)
    {
        string reversed = new string(input.ToCharArray().Reverse().ToArray());
        return input.Equals(reversed, StringComparison.OrdinalIgnoreCase);
    }
}
