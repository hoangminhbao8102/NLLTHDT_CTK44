using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_E_Bai2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Tạo đối tượng Hyundai
            XeTai hyundai = new XeTai();
            hyundai._bienSo = "HYD-1234";
            hyundai._hangSx = "Hyundai";
            hyundai._namSx = 2015;
            hyundai._ngayDk = new NgayThang { Ngay = 1, Thang = 6, Nam = 2015 };
            hyundai._tocDoToiDa = 180.0f;
            hyundai._trongTai = 5000.0f;

            // Tạo đối tượng Suzuki
            XeTai suzuki = new XeTai();
            suzuki._bienSo = "SUZ-5678";
            suzuki._hangSx = "Suzuki";
            suzuki._namSx = 2017;
            suzuki._ngayDk = new NgayThang { Ngay = 15, Thang = 4, Nam = 2017 };
            suzuki._tocDoToiDa = 150.0f;
            suzuki._trongTai = 3000.0f;

            // Tạo đối tượng Benz
            XeTai benz = new XeTai();
            benz._bienSo = "BEN-91011";
            benz._hangSx = "Mercedes-Benz";
            benz._namSx = 2018;
            benz._ngayDk = new NgayThang { Ngay = 12, Thang = 7, Nam = 2018 };
            benz._tocDoToiDa = 200.0f;
            benz._trongTai = 6000.0f;

            // In thông tin và kiểm tra các phương thức
            Console.WriteLine($"Hyundai: Số năm hoạt động: {hyundai.TinhSoNamHoatDong()}, Tuổi thọ còn lại: {hyundai.TinhTuoiTho(10.0f)}");
            Console.WriteLine($"Suzuki: Số năm hoạt động: {suzuki.TinhSoNamHoatDong()}, Tuổi thọ còn lại: {suzuki.TinhTuoiTho(20.0f)}");
            Console.WriteLine($"Benz: Số năm hoạt động: {benz.TinhSoNamHoatDong()}, Tuổi thọ còn lại: {benz.TinhTuoiTho(15.0f)}");

            Console.ReadKey();
        }
    }
}
