using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_D_Bai1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            SoPhuc a = new SoPhuc(1, 2);
            SoPhuc b = new SoPhuc(3, 4);

            Console.WriteLine("Số phức a: " + a);
            Console.WriteLine("Số phức b: " + b);

            // Thử các phép toán cộng, trừ, nhân, chia
            SoPhuc tong = a + b;
            Console.WriteLine("Tổng của a và b: " + tong);

            SoPhuc hieu = a - b;
            Console.WriteLine("Hiệu của a và b: " + hieu);

            SoPhuc tich = a * b;
            Console.WriteLine("Tích của a và b: " + tich);

            SoPhuc thuong = a / b;
            Console.WriteLine("Thương của a và b: " + thuong);

            // Thử phép chuyển đổi ngầm và liên hợp
            SoPhuc c = 5;  // Implicit conversion từ int
            Console.WriteLine("Số phức c (từ int): " + c);

            SoPhuc d = 6.7;  // Implicit conversion từ double
            Console.WriteLine("Số phức d (từ double): " + d);

            SoPhuc lienHopA = ~a;  // Lấy liên hợp của a
            Console.WriteLine("Liên hợp của a: " + lienHopA);

            // Kiểm tra phép so sánh
            Console.WriteLine("a và b có bằng nhau không? " + (a == b));
            Console.WriteLine("a và a có bằng nhau không? " + (a == a));

            Console.ReadKey();
        }
    }
}
