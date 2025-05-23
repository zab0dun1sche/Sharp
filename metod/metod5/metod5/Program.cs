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

        List<int> uniqueNumbers = RemoveDuplicates(numbers);
        Console.WriteLine("Список без дубликатов: " + string.Join(", ", uniqueNumbers));
    }

    static List<int> RemoveDuplicates(List<int> numbers)
    {
        HashSet<int> uniqueSet = new HashSet<int>(numbers);
        return new List<int>(uniqueSet);
    }
}
