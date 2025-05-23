using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long totalTime = CalculateTotalTime(n);
        Console.WriteLine(totalTime);
    }

    static long CalculateTotalTime(int n)
    {
        if (n <= 0) return 0;
        if (n == 1 || n == 2) return 1;
        long[] t = new long[n + 1];
        t[1] = 1;
        t[2] = 1;
        for (int i = 3; i <= n; i++)
        {
            t[i] = t[i - 1] + t[i - 2];
        }
        long sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += t[i];
        }
        return sum;
    }
}

