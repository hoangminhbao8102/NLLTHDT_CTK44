using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_Bai05_QuanLyHinhHoc
{
    public class Program
    {
        static void Main(string[] args)
        {
            DanhSachHinhHoc cacHinh = new DanhSachHinhHoc();

            cacHinh.NhapCoDinh();

            Console.WriteLine(cacHinh);
            Console.WriteLine();

            ISoSanhHinhHoc dieuKien = new SoSanhTheoChuVi();

            cacHinh.SapXep(dieuKien, ThuTu.Tang);

            Console.WriteLine("=========================================");
            Console.WriteLine("Sau khi sap tang theo chu vi");

            Console.WriteLine(cacHinh);

            dieuKien = new SoSanhTheoDienTich();

            cacHinh.SapXep(dieuKien, ThuTu.Giam);

            Console.WriteLine("=========================================");
            Console.WriteLine("Sau khi sap giam theo dien tich");

            Console.WriteLine(cacHinh);

            Console.ReadKey();
        }
    }
}
