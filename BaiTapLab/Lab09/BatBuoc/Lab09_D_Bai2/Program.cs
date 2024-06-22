using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_D_Bai2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Đường dẫn đến file văn bản cần đọc
            string filePath = "input.txt";
            string outputFilePath = "output.txt";

            // Khởi tạo các đối tượng xử lý
            BoDocDuLieu reader = new BoDocDuLieu();
            BoTinhTong calculator = new BoTinhTong();
            BoLuuSo saver = new BoLuuSo(outputFilePath);
            BoXuatSo printer = new BoXuatSo();

            // Kết nối sự kiện từ BoDocDuLieu với các handler tương ứng
            reader.TimThaySo += calculator.CongThem;
            reader.TimThaySo += saver.LuuSo;
            reader.TimThaySo += printer.Xuat;

            // Đọc file và xử lý
            reader.Doc(filePath);

            // Xuất thông tin tổng kết
            Console.WriteLine($"Tổng số: {calculator.TongCong}");
            Console.WriteLine($"Số lượng số hợp lệ: {calculator.SoLuong}");

            // Đóng kết nối với file output
            saver.DongKetNoi();

            Console.ReadKey();
        }
    }
}
