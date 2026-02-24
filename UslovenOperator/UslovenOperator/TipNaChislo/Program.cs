namespace TipNaChislo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());

            if (a >0)
            {
                Console.WriteLine("Polojitelno");
            }
            else if (a < 0)
            {
                Console.WriteLine("Otricatelno");
            }
            else
            {
                Console.WriteLine("Nula");
            }
        }




    }
}
