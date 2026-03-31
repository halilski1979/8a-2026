namespace zad2_MaxEl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Най-голямо число

            Console.Write("Broy chisla: ");
            int n = int.Parse(Console.ReadLine());            
            int max = 0;
           
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > max)
                {
                    max= num;
                }
            }

            Console.WriteLine($"Max={max}");

        }
    }
}
