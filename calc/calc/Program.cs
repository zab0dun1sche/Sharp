using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите первое число:");
                double num1;
                while (!double.TryParse(Console.ReadLine(), out num1))
                {
                    Console.WriteLine("Ошибка! Введите корректное число:");
                }

                Console.WriteLine("Введите второе число:");
                double num2;
                while (!double.TryParse(Console.ReadLine(), out num2))
                {
                    Console.WriteLine("Ошибка! Введите корректное число:");
                }

                Console.WriteLine("Выберите операцию:");
                Console.WriteLine("+  - сложение");
                Console.WriteLine("-  - вычитание");
                Console.WriteLine("*  - умножение");
                Console.WriteLine("/  - деление");
                Console.WriteLine("%  - остаток от деления");
                Console.WriteLine("++ - инкремент первого числа");
                Console.WriteLine("-- - декремент первого числа");
                string operation = Console.ReadLine();

                double result = 0;
                bool isError = false;

                switch (operation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Ошибка: деление на ноль");
                            isError = true;
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    case "%":
                        if (num2 == 0)
                        {
                            Console.WriteLine("Ошибка: деление на ноль");
                            isError = true;
                        }
                        else
                        {
                            result = num1 % num2;
                        }
                        break;
                    case "++":
                        result = num1 + 1;
                        break;
                    case "--":
                        result = num1 - 1;
                        break;
                    default:
                        Console.WriteLine("Неизвестная операция");
                        isError = true;
                        break;
                }

                if (!isError)
                {
                    Console.WriteLine($"Результат: {result}");
                }

                Console.WriteLine("Хотите продолжить? (д/н)");
                if (Console.ReadLine().ToLower() != "д")
                {
                    break;
                }
            }
        }
    }
}
