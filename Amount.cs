using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_03_10_5_1
{
    internal class Amount
    {
    }

    public interface IAmount 
    {
        void Sum(int a, int b);

    }
    public class Summary : IAmount
    {
        public int A {  get; set; }
        public int B { get; set; }
        public int Result {  get; set; }

        public Summary(int a, int b) 
        {
            A = a; 
            B = b;
        }

        void IAmount.Sum(int a, int b)
        {
            int result = a + b;
            Result = result;      
        }
        public void Output()
        {
            Console.WriteLine($"Результат сложения {A} и {B} равно {Result}");
        }
    }
}
