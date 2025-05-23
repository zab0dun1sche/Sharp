using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число для вычисления его факториала:");
        int number = int.Parse(Console.ReadLine());
        long factorial = Factorial(number);
        Console.WriteLine($"Факториал {number} равен {factorial}");
    }

    static long Factorial(int n)
    {
        if (n == 0)
            return 1;
        return n * Factorial(n - 1);
    }
}
