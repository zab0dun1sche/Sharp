using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int sum = SumOfList(numbers);
        Console.WriteLine($"Сумма чисел в списке: {sum}");
    }

    static int SumOfList(List<int> numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}
