namespace HW_03_10_5_1
{
    internal class Program
    {
        static ILogger logger = new Logger();
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

                    Summary summary = new Summary(a, b, logger);

                    ((IAmount)summary).Sum(summary.A = a, summary.B = b, logger);
                    summary.Output(logger);
                }
                catch (FormatException ex)
                {
                    logger.Error(ex.Message);
                }
            }
        }
    }
}
