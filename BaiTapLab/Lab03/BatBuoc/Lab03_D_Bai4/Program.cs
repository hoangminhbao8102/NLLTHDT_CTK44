using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai4
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Tạo hai thể hiện của lớp NgayThang
            NgayThang quaKhu = new NgayThang(23, 9, 1990);
            NgayThang hienTai = new NgayThang(DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year);

            // Xuất thông tin ngày tháng của 2 đối tượng
            Console.WriteLine($"Quá khứ: {quaKhu.Ngay}/{quaKhu.Thang}/{quaKhu.Nam}");
            Console.WriteLine($"Hiện tại: {hienTai.Ngay}/{hienTai.Thang}/{hienTai.Nam}");

            // Xuất từng thành phần ngày, tháng, năm của đối tượng quaKhu
            Console.WriteLine($"Ngày của quaKhu: {quaKhu.Ngay}");
            Console.WriteLine($"Tháng của quaKhu: {quaKhu.Thang}");
            Console.WriteLine($"Năm của quaKhu: {quaKhu.Nam}");

            // Cho biết thứ trong tuần ứng với ngày được lưu trong đối tượng quaKhu
            quaKhu.TimThuTrongTuan();

            // Tính cách biệt giữa quaKhu và ngày hiện tại
            int dayDifference = quaKhu.TinhCachBietTheoNgay(hienTai);
            int monthDifference = quaKhu.TinhCachBietTheoThang(hienTai);
            int yearDifference = quaKhu.TinhCachBietTheoNam(hienTai);

            // Điều chỉnh tháng nếu ngày cách biệt vượt qua 30 ngày
            if (dayDifference > 30)
            {
                monthDifference += 1;
            }

            Console.WriteLine($"Cách biệt giữa quaKhu và hiện tại: {dayDifference} ngày, {monthDifference} tháng, {yearDifference} năm");

            // Kiểm tra có phải ngày trong năm nhuận không
            Console.WriteLine($"quaKhu có phải là ngày trong năm nhuận không? {quaKhu.LaNgayNamNhuan()}");

            Console.ReadKey();
        }
    }
}
