using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_E_Bai2_Hexa_P2__
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Tạo các đối tượng Hexa từ số thực
            Hexa oct1 = new Hexa(10.345);
            Hexa oct2 = new Hexa(5.789);

            // Thực hiện các phép tính cộng, trừ, nhân, chia
            Hexa sum = oct1 + oct2;
            Hexa difference = oct1 - oct2;
            Hexa product = oct1 * oct2;
            Hexa quotient = oct1 / oct2;

            // Hiển thị kết quả
            Console.WriteLine("Hexa 1: " + oct1);
            Console.WriteLine("Hexa 2: " + oct2);
            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Difference: " + difference);
            Console.WriteLine("Product: " + product);
            Console.WriteLine("Quotient: " + quotient);

            // Thực hiện ép kiểu và hiển thị số double
            double realNumber = (double)oct1;
            Console.WriteLine("Real Number from Hexa 1: " + realNumber);

            // Thử nghiệm so sánh
            Console.WriteLine("Is Hexa 1 greater than Hexa 2? " + (oct1 > oct2));

            Console.ReadKey();
        }
    }
}
