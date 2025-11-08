namespace HW_03_10_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задание 1
            int a,b;


            while (true)
            {
                try
                {
                    Console.WriteLine("Введите 1 число:");
                    a = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите 2 число:");
                    b = Convert.ToInt32(Console.ReadLine());

                    Summary summary = new Summary(a, b);

                    ((IAmount)summary).Sum(summary.A = a, summary.B = b);
                    summary.Output();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Ошибка - " + ex.Message);
                }
            }
            
            
        }
    }
}
