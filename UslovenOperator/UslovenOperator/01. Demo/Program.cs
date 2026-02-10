namespace _01._Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine(a * a);
            }
            else
            {
                Console.WriteLine("FALSE");
            }

        }
    }
}
