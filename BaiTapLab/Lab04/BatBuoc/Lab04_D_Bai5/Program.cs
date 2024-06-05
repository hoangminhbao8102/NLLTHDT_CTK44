using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_D_Bai5
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Khởi tạo hai ma trận để thực hiện các phép toán
            MaTran matran1 = new MaTran(2, 2);
            MaTran matran2 = new MaTran(2, 2);

            // Nhập giá trị ngẫu nhiên cho ma trận
            matran1.NhapNgauNhien();
            matran2.NhapNgauNhien();

            Console.WriteLine("Ma trận 1:");
            Console.WriteLine(matran1);

            Console.WriteLine("Ma trận 2:");
            Console.WriteLine(matran2);

            // Thực hiện phép cộng
            MaTran tong = matran1 + matran2;
            Console.WriteLine("Tổng hai ma trận:");
            Console.WriteLine(tong);

            // Thực hiện phép trừ
            MaTran hieu = matran1 - matran2;
            Console.WriteLine("Hiệu hai ma trận:");
            Console.WriteLine(hieu);

            // Thực hiện phép nhân
            MaTran tich = matran1 * matran2;
            Console.WriteLine("Tích hai ma trận:");
            Console.WriteLine(tich);

            // Tìm ma trận chuyển vị của ma trận 1
            MaTran chuyenVi = ~matran1;
            Console.WriteLine("Ma trận chuyển vị của Ma trận 1:");
            Console.WriteLine(chuyenVi);

            // Giả sử Ma trận 1 là vuông và khả năng nghịch đảo, tìm nghịch đảo
            try
            {
                MaTran nghichDao = !matran1;
                Console.WriteLine("Ma trận nghịch đảo của Ma trận 1:");
                Console.WriteLine(nghichDao);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
