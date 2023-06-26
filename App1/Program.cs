using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ввдеите первое число");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int b = Convert.ToInt32(Console.ReadLine());

            int result = SumTwoElement(a, b);

            Console.WriteLine($"Результат суммы равен {result}");
            Console.ReadKey();

            int SumTwoElement(int firstValue, int SecondValue) 
            {
                int res = firstValue + SecondValue;
                return res;
            }
        }
    }
}
