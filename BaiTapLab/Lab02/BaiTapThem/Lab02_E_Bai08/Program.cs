using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02_E_Bai08
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            int terms = 1000000;  // Số hạng mà bạn muốn tính đến
            double pi = CalculatePi(terms);
            Console.WriteLine("Giá trị gần đúng của Pi sau {0} số hạng là: {1}", terms, pi);

            Console.ReadKey();
        }

        static double CalculatePi(int numberOfTerms)
        {
            double sum = 0.0;
            for (int i = 0; i < numberOfTerms; i++)
            {
                int sign = i % 2 == 0 ? 1 : -1;  // Thay đổi dấu mỗi lần lặp
                double term = 1.0 / (2 * i + 1) * sign;
                sum += term;
            }
            return 4 * sum;  // Nhân với 4 để tính toán giá trị gần đúng của Pi
        }
    }
}
