using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите сумму вклада: ");
        decimal deposit = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Введите количество месяцев: ");
        int months = Convert.ToInt32(Console.ReadLine());

        decimal total = deposit;

        for (int i = 0; i < months; i++)
        {
            total += total * 0.07m; 
        }

        Console.WriteLine($"Конечная сумма вклада через {months} месяцев: {total:F2}");
    }
}
