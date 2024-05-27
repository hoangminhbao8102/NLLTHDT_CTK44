using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_E_Bai06
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a positive integer:");
            int num = Convert.ToInt32(Console.ReadLine());
            int reversed = ReverseDigits(num);
            Console.WriteLine($"The reversed number is: {reversed}");
            Console.ReadKey();
        }

        static int ReverseDigits(int num)
        {
            int reversed = 0;
            while (num > 0)
            {
                reversed = reversed * 10 + num % 10;
                num /= 10;
            }
            return reversed;
        }
    }
}
