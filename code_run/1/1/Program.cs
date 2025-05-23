using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] parts = input.Split(' ');

        long A = long.Parse(parts[0]);
        long B = long.Parse(parts[1]);

        long result = A + B;

        Console.WriteLine(result);
    }
}
