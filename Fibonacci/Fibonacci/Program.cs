using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Which value in the Fibonacci sequence do you want?");
        Console.WriteLine("[X] Quit Program");
        

        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToUpper() == "X")
            {
                Console.WriteLine("Exiting...");
                Environment.Exit(0);
            }

            // Error handling
            if (int.TryParse(input, out int n))
            {
                if (n < 0)
                {
                    Console.WriteLine("Please enter a non-negative integer.");
                }
                else
                {
                    Fibonacci(n);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
    }

    static double Fibonacci(int n)
    {
        double phi = (1 + Math.Sqrt(5)) / 2; // The golden ratio
        double alpha = (1 - Math.Sqrt(5)) / 2; // The conjugate of the golden ratio

        // Binet's Formula for the nth Fibonacci number
        double fibonacci = (Math.Pow(phi, n) - Math.Pow(alpha, n)) / Math.Sqrt(5);

        Console.WriteLine($"The {n}th term of the Fibonacci sequence is {fibonacci}");
        return fibonacci;
    }
}
