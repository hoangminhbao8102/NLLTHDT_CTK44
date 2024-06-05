using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_E_Bai4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            NgayThang ngay1 = new NgayThang(15, 6, 2022);
            NgayThang ngay2 = new NgayThang(20, 6, 2022);

            Console.WriteLine("Ngày 1: " + ngay1.Ngay + "/" + ngay1.Thang + "/" + ngay1.Nam);
            Console.WriteLine("Ngày 2: " + ngay2.Ngay + "/" + ngay2.Thang + "/" + ngay2.Nam);

            // Sử dụng toán tử ++
            ngay1++;
            Console.WriteLine("Ngày 1 sau khi tăng: " + ngay1.Ngay + "/" + ngay1.Thang + "/" + ngay1.Nam);

            // Sử dụng toán tử --
            ngay2--;
            Console.WriteLine("Ngày 2 sau khi giảm: " + ngay2.Ngay + "/" + ngay2.Thang + "/" + ngay2.Nam);

            // So sánh ngày
            Console.WriteLine("Ngày 1 == Ngày 2? " + (ngay1 == ngay2));
            Console.WriteLine("Ngày 1 != Ngày 2? " + (ngay1 != ngay2));
            Console.WriteLine("Ngày 1 < Ngày 2? " + (ngay1 < ngay2));
            Console.WriteLine("Ngày 1 > Ngày 2? " + (ngay1 > ngay2));
            Console.WriteLine("Ngày 1 <= Ngày 2? " + (ngay1 <= ngay2));
            Console.WriteLine("Ngày 1 >= Ngày 2? " + (ngay1 >= ngay2));

            // Phép ép kiểu từ số nguyên sang NgayThang
            int daysSinceEpoch = 18500; // Ví dụ ngẫu nhiên
            NgayThang ngay3 = (NgayThang)daysSinceEpoch;
            Console.WriteLine("Ngày từ epoch: " + ngay3.Ngay + "/" + ngay3.Thang + "/" + ngay3.Nam);

            Console.ReadKey();
        }
    }
}
