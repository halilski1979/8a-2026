namespace z01___MaxValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Broy chisla: ");
            int n=int.Parse(Console.ReadLine());
            
            //На maxValue взима най-малката стойност от тип int
            int maxValue=int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (maxValue<number)
                {
                    maxValue = number;
                }
            }
            Console.WriteLine($"Max={maxValue}");
        }
    }
}
