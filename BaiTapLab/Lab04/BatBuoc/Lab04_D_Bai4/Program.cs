using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_D_Bai4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Fahrenheit f = 100.0;
            Console.Write($"{f}");
            Celsius c = f;
            Console.Write($" = {c}");
            Kelvin k = c;
            Console.Write($" = {k}");

            Console.ReadKey();
        }
    }
}
