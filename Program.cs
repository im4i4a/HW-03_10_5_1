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
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());

                    Summary summary = new Summary(a, b);

                    ((IAmount)summary).Sum(summary.A = a, summary.B = b);
                    summary.Output();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            
            
        }
    }
}
