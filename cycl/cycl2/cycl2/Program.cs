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
        int i = 0;

        while (i < months)
        {
            total += total * 0.07m;
            i++;
        }

        Console.WriteLine($"Конечная сумма вклада через {months} месяцев: {total:F2}");
    }
}
