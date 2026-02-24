namespace _03._SumFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //СУма на числа в цикъл For
            int s = 0;

            for (int i = 0; i <= 10; i++)
            {
                s = s + i;
            }

            Console.WriteLine($"Sum={s}");
        }
    }
}
