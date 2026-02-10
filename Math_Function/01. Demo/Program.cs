namespace _01._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Math.Pi: {Math.PI}");
            Console.WriteLine($"Math.E: {Math.E}");

            Console.WriteLine();
            Console.WriteLine($"Math.Abs:{Math.Abs(3)}");
            Console.WriteLine($"Math.Abs:{Math.Abs(-3)}");
            Console.WriteLine($"Math.Ceiling:{Math.Ceiling(3.23)}");
            Console.WriteLine($"Math.Ceiling:{Math.Floor(3.23)}");

            Console.WriteLine();
            Console.WriteLine($"Math.Max(4,7):{Math.Max(4,7)}");
            Console.WriteLine($"Math.Min(4,7):{Math.Min(4, 7)}");

            Console.WriteLine();
            Console.WriteLine($"Math.Sqrt(20):{Math.Sqrt(20)}");

            Console.WriteLine();
            Console.WriteLine($"Math.Pow(3,4):{Math.Pow(3,4)}");

            Console.WriteLine();
            Console.WriteLine($"Math.Round(3.123456,4):{Math.Round(3.123556,3)}");
        }
    }
}
