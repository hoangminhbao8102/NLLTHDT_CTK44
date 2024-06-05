using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_E_Bai1_Octal_P2_
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Tạo các đối tượng Octal từ số thực
            Octal oct1 = new Octal(10.345);
            Octal oct2 = new Octal(5.789);

            // Thực hiện các phép tính cộng, trừ, nhân, chia
            Octal sum = oct1 + oct2;
            Octal difference = oct1 - oct2;
            Octal product = oct1 * oct2;
            Octal quotient = oct1 / oct2;

            // Hiển thị kết quả
            Console.WriteLine("Octal 1: " + oct1);
            Console.WriteLine("Octal 2: " + oct2);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            // Thực hiện ép kiểu và hiển thị số double
            double realNumber = (double)oct1;
            Console.WriteLine("Real Number from Octal 1: " + realNumber);

            // Thử nghiệm so sánh
            Console.WriteLine("Is Octal 1 greater than Octal 2? " + (oct1 > oct2));

            Console.ReadKey();
        }
    }
}
