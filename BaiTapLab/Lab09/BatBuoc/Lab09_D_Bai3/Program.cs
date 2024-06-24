using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_D_Bai3
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // b. Tạo 3 thể hiện của lớp ToaSoan
            ToaSoan ts1 = new ToaSoan("ToaSoan A");
            ToaSoan ts2 = new ToaSoan("ToaSoan B");
            ToaSoan ts3 = new ToaSoan("ToaSoan C");

            // c. Tạo 5 thể hiện của lớp DocGia
            DocGia dg1 = new DocGia(001, "Độc Giả 1", "Địa chỉ 1");
            DocGia dg2 = new DocGia(002, "Độc Giả 2", "Địa chỉ 2");
            DocGia dg3 = new DocGia(003, "Độc Giả 3", "Địa chỉ 3");
            DocGia dg4 = new DocGia(004, "Độc Giả 4", "Địa chỉ 4");
            DocGia dg5 = new DocGia(005, "Độc Giả 5", "Địa chỉ 5");

            // d. Đăng ký mua báo
            ts1.ThemDangKy(dg1);
            ts1.ThemDangKy(dg2);
            ts2.ThemDangKy(dg3);
            ts3.ThemDangKy(dg4);
            ts3.ThemDangKy(dg5);

            // e. Xuất danh sách độc giả của mỗi tòa soạn
            Console.WriteLine("Danh sách độc giả Toa Soan A:");
            ts1.XuatDanhSachDocGia();
            Console.WriteLine("Danh sách độc giả Toa Soan B:");
            ts2.XuatDanhSachDocGia();
            Console.WriteLine("Danh sách độc giả Toa Soan C:");
            ts3.XuatDanhSachDocGia();

            // f. Mỗi tòa soạn xuất bản ít nhất 3 bài báo
            Bao bao1 = new Bao(5000, DateTime.Now, "Thể thao quốc tế", 10);
            Bao bao2 = new Bao(8000, DateTime.Now.AddDays(1), "Kinh tế Việt Nam", 8);
            Bao bao3 = new Bao(6000, DateTime.Now.AddDays(2), "Giải trí mới nhất", 5);

            ts1.XuatBan(bao1);
            ts1.XuatBan(bao2);
            ts1.XuatBan(bao3);

            // g. Tổng doanh thu của mỗi tòa soạn
            Console.WriteLine($"Tổng doanh thu của Toa Soan A: {ts1.DoanhThu}");
            Console.WriteLine($"Tổng doanh thu của Toa Soan B: {ts2.DoanhThu}");
            Console.WriteLine($"Tổng doanh thu của Toa Soan C: {ts3.DoanhThu}");

            // h. Hủy 5 đăng ký dịch vụ bất kỳ
            ts1.XoaDangKy(dg1);
            ts1.XoaDangKy(dg2);
            ts2.XoaDangKy(dg3);
            ts3.XoaDangKy(dg4);
            ts3.XoaDangKy(dg5);

            // i. Mỗi tòa soạn xuất bản tiếp một bài báo
            ts1.XuatBan(new Bao(7000, DateTime.Now.AddDays(3), "Khoa học vũ trụ", 6));
            ts2.XuatBan(new Bao(4500, DateTime.Now.AddDays(4), "Sức khỏe cộng đồng", 7));
            ts3.XuatBan(new Bao(5000, DateTime.Now.AddDays(5), "Giáo dục Việt Nam", 9));

            Console.ReadKey();
        }
    }
}
