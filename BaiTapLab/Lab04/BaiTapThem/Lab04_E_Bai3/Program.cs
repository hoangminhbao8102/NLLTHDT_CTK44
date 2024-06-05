using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_E_Bai3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Tạo đa thức thứ nhất
            DaThuc daThuc1 = new DaThuc();
            daThuc1.Them(1, 2);  // 1x^2
            daThuc1.Them(3, 1);  // 3x^1

            // Tạo đa thức thứ hai
            DaThuc daThuc2 = new DaThuc();
            daThuc2.Them(2, 1);  // 2x^1
            daThuc2.Them(4, 0);  // 4x^0

            // Phép cộng
            DaThuc tong = daThuc1 + daThuc2;
            Console.WriteLine("Tổng hai đa thức: " + tong.ToString());

            // Phép trừ
            DaThuc hieu = daThuc1 - daThuc2;
            Console.WriteLine("Hiệu hai đa thức: " + hieu.ToString());

            // Phép nhân
            DaThuc tich = daThuc1 * daThuc2;
            Console.WriteLine("Tích hai đa thức: " + tich.ToString());

            // Phép chia
            // Ghi chú: Phép chia đa thức có thể phức tạp và không phải lúc nào cũng chia hết,
            // nên cần xử lý ngoại lệ hoặc kiểm tra kết quả trước khi hiển thị.
            try
            {
                DaThuc thuong = daThuc1 / daThuc2;
                Console.WriteLine("Thương hai đa thức: " + thuong.ToString());
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Lỗi khi chia: " + ex.Message);
            }

            // Đánh giá giá trị của đa thức tại một điểm xác định
            double giaTri1 = daThuc1.TinhGiaTri(2);  // Tính giá trị của daThuc1 tại x = 2
            Console.WriteLine("Giá trị của Đa thức 1 tại x = 2: " + giaTri1);

            Console.ReadKey();
        }
    }
}
