using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<HinhTron> danhSachHinhTron = new List<HinhTron>
            {
                new HinhTron(5.75, "Xanh"),
                new HinhTron(23, "Đỏ"),
                new HinhTron(9.12, "Vàng"),
                new HinhTron(238.7635, "Tím")
            };

            // Biến đổi bán kính theo tỷ lệ cho trước
            double[] tyLeBienDoi = { 30, 7.5, 13.36, 2.71 }; // Tỷ lệ tương ứng với mỗi hình tròn
            for (int i = 0; i < danhSachHinhTron.Count; i++)
            {
                danhSachHinhTron[i].BienDoiTyLe(tyLeBienDoi[i]);
            }

            // Sắp xếp tăng dần theo diện tích
            danhSachHinhTron.Sort((h1, h2) => h1.TinhDienTich().CompareTo(h2.TinhDienTich()));

            // In thông tin sau khi sắp xếp theo diện tích
            Console.WriteLine("Sắp xếp tăng dần theo diện tích:");
            foreach (var hinh in danhSachHinhTron)
            {
                Console.WriteLine(hinh);
            }

            // Sắp xếp giảm dần theo chu vi
            danhSachHinhTron.Sort((h1, h2) => h2.TinhChuVi().CompareTo(h1.TinhChuVi()));

            // In thông tin sau khi sắp xếp theo chu vi
            Console.WriteLine("\nSắp xếp giảm dần theo chu vi:");
            foreach (var hinh in danhSachHinhTron)
            {
                Console.WriteLine(hinh);
            }

            // Tính tổng diện tích và chu vi
            double tongDienTich = 0, tongChuVi = 0;
            foreach (var hinh in danhSachHinhTron)
            {
                tongDienTich += hinh.TinhDienTich();
                tongChuVi += hinh.TinhChuVi();
            }

            Console.WriteLine($"\nTổng diện tích của các hình tròn: {tongDienTich}");
            Console.WriteLine($"Tổng chu vi của các hình tròn: {tongChuVi}");

            Console.ReadKey();
        }
    }
}
