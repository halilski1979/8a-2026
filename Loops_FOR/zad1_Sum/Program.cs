namespace zad1_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Сбор на числа
            int sum = 0;

            for (int i = 10; i <= 20; i+=2)
            {
                sum = sum + i;
            }
            Console.WriteLine(sum);
        }
    }
}
