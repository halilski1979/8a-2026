namespace Rectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());
            if (a > 0 && b > 0) 
            {
                Console.WriteLine((a + b )* 2);
                Console.WriteLine(a * b);
            }
            else
            {
              Console.WriteLine("FALSE");
            }
                ;
        }
    }
}
