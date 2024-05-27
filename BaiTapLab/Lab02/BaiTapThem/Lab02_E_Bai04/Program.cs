using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_E_Bai04
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Nhập giá trị x và n từ bàn phím
            Console.Write("Nhập x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhập n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Tính và hiển thị kết quả
            double result = CalculateExpression(x, n);
            Console.WriteLine($"Giá trị của biểu thức {x}^{n} / {n}! là: {result}");

            Console.ReadKey();
        }

        // Hàm tính x^n
        static double Power(double x, int n)
        {
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= x;
            }
            return result;
        }

        // Hàm tính n!
        static double Factorial(int n)
        {
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }

        // Hàm tính (x^n) / n!
        static double CalculateExpression(double x, int n)
        {
            double power = Power(x, n);
            double factorial = Factorial(n);
            return power / factorial;
        }
    }
}
