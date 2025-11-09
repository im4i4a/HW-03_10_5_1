using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03_10_5_1
{
    public interface IAmount 
    {
        void Sum(int a, int b, ILogger logger);
        

    }
    public interface ILogger
    {
        void Event(string message);
        void Error(string message);
    }
    public class Logger : ILogger
    {
        public void Error(string message)
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Ошибка!!!" + message);
            Console.BackgroundColor = ConsoleColor.Black;
        }

        public void Event(string message)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(message);
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
    public class Summary : IAmount
    {
        ILogger Logger { get; }
        public int A {  get; set; }
        public int B { get; set; }
        public int Result {  get; set; }

        public Summary(int a, int b, ILogger logger) 
        {
            A = a; 
            B = b;
            logger.Event($"Пользователь ввел {A} и {B}");
        }

        void IAmount.Sum(int a, int b, ILogger logger)
        {
            int result = a + b;
            Result = result;
            logger.Event("Результат Записался");
        }
        public void Output(ILogger logger)
        {
            Console.WriteLine($"Результат сложения {A} и {B} равно {Result}");
            logger.Event("Результат вывелся");
        }
    }
}
