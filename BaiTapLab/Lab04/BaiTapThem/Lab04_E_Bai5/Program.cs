using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_E_Bai5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            ThoiGian t1 = new ThoiGian(14, 59, 58);
            ThoiGian t2 = new ThoiGian(15, 0, 0);

            Console.WriteLine("Thời gian t1 ban đầu: " + t1);
            Console.WriteLine("Thời gian t2 ban đầu: " + t2);

            // Thử nghiệm tăng 1 giây
            Console.WriteLine("Tăng t1 lên 1 giây: " + ++t1);
            // Thử nghiệm giảm 1 giây
            Console.WriteLine("Giảm t1 đi 1 giây: " + --t1);

            // So sánh t1 và t2
            Console.WriteLine("t1 > t2? " + (t1 > t2));
            Console.WriteLine("t1 < t2? " + (t1 < t2));
            Console.WriteLine("t1 >= t2? " + (t1 >= t2));
            Console.WriteLine("t1 <= t2? " + (t1 <= t2));
            Console.WriteLine("t1 == t2? " + (t1 == t2));
            Console.WriteLine("t1 != t2? " + (t1 != t2));

            // Giảm t2 đi 2 giây
            Console.WriteLine("Giảm t2 đi 1 giây: " + --t2);
            Console.WriteLine("Giảm t2 đi 1 giây nữa: " + --t2);

            // So sánh lại t1 và t2 sau khi giảm giây
            Console.WriteLine("Sau khi giảm, t1 == t2? " + (t1 == t2));

            Console.ReadKey();
        }
    }
}
