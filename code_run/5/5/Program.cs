using System;

class Program
{
    static void Main(string[] args)
    {

        var input = Console.ReadLine().Split(' ');
        int a = int.Parse(input[0]);
        int b = int.Parse(input[1]);
        int c = int.Parse(input[2]);

        double D = b * b - 4 * a * c;

        if (D < 0)
        {

            Console.WriteLine(0);
        }
        else if (D == 0)
        {

            double root = -b / (2.0 * a);
            Console.WriteLine(1);
            Console.WriteLine($"{root:F6}");
        }
        else 
        {
            double root1 = (-b - Math.Sqrt(D)) / (2 * a);
            double root2 = (-b + Math.Sqrt(D)) / (2 * a);
            Console.WriteLine(2);
            
            if (root1 > root2)
            {
                (root1, root2) = (root2, root1); 
            }
            Console.WriteLine($"{root1:F6} {root2:F6}");
        }
    }
}
