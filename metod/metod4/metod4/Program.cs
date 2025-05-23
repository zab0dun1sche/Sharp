using System;
using System.Collections.Generic;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Введите числа (введите 'stop' для завершения ввода):");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "stop") break;

            if (int.TryParse(input, out int number))
            {
                numbers.Add(number);
            }
            else
            {
                Console.WriteLine("Пожалуйста, введите допустимое число или 'stop'.");
            }
        }

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
