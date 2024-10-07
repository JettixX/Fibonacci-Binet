using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Which Fibonacci value? [X to quit]");

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToUpper() == "X") break;
            if (int.TryParse(input, out int n) && n >= 0)
                Console.WriteLine($"The {n}th term is {Fibonacci(n)}");
            else
                Console.WriteLine("Invalid input. Enter a non-negative integer.");
        }
    }

    static double Fibonacci(int n)
    {
        double phi = (1 + Math.Sqrt(5)) / 2, alpha = (1 - Math.Sqrt(5)) / 2;
        return (Math.Pow(phi, n) - Math.Pow(alpha, n)) / Math.Sqrt(5);
    }
}
