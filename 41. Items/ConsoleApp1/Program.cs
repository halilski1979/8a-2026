namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("m=");
            int m = int.Parse(Console.ReadLine());
            Console.Write("n=");
            int n = int.Parse(Console.ReadLine());


            double s = 0;
            for (int i = m; i <= n; i++)
            {
                s += i;                
            }
            Console.WriteLine($"S={s}");
            Console.WriteLine($"Average: {s/(n-m+1)}");
        }
    }
}
