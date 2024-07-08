

// Binet's Formula:
// F_n = (phi^n - alpha^n) / (phi - alpha) = (phi^n - alpha^n) / 5^1/2


internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Which value in the Fibonacci sequence do you want?");
        int n = int.Parse(Console.ReadLine());

        Fibonacci(n);
    }
    
    
    
    static double Fibonacci(int n)
        {
            double phi = (1 + Math.Sqrt(5)) / 2; // Let phi = the golden ratio, 1.61803....
            double alpha = (1 - Math.Sqrt(5)) / 2;  // alpha


            double fibonacci = (Math.Pow(phi, n) - Math.Pow(-phi, -n)) / Math.Sqrt(5);


            Console.WriteLine($"The {n}th term of the Fibonacci sequence is equal to {fibonacci}");
            return fibonacci;
        }
}