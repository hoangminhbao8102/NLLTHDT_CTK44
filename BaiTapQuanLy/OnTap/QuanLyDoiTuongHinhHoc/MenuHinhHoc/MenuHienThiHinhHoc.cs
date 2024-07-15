using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class MenuHienThiHinhHoc
    {
        private DanhSachHinhHoc hinhHoc;

        public MenuHienThiHinhHoc()
        {
            hinhHoc = new DanhSachHinhHoc();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("================= MENU HIỂN THỊ ==================");
            Console.WriteLine("{0}. Hiển thị tất cả các hình theo chiều tăng, giảm của diện tích.", (int)ChucNangHienThiHinhHoc.HienThiTheoDienTich);
            Console.WriteLine("{0}. Hiển thị tất cả các hình theo chiều tăng, giảm của chu vi.", (int)ChucNangHienThiHinhHoc.HienThiTheoChuVi);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangHienThiHinhHoc.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangHienThiHinhHoc Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangHienThiHinhHoc)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu hiển thị (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangHienThiHinhHoc)menu;
        }

        private void Process(ChucNangHienThiHinhHoc menu)
        {
            switch (menu)
            {
                case ChucNangHienThiHinhHoc.Thoat:
                    Console.WriteLine("Kết thúc chương trình hiển thị!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangHienThiHinhHoc.HienThiTheoDienTich:
                    Console.WriteLine("Hiển thị tất cả các hình theo chiều tăng của diện tích:");
                    hinhHoc.HienThiTheoDienTich(true);  // true for ascending
                    Console.WriteLine("Hiển thị tất cả các hình theo chiều giảm của diện tích:");
                    hinhHoc.HienThiTheoDienTich(false); // false for descending
                    break;
                case ChucNangHienThiHinhHoc.HienThiTheoChuVi:
                    Console.WriteLine("Hiển thị tất cả các hình theo chiều tăng của chu vi:");
                    hinhHoc.HienThiTheoChuVi(true);  // true for ascending
                    Console.WriteLine("Hiển thị tất cả các hình theo chiều giảm của chu vi:");
                    hinhHoc.HienThiTheoChuVi(false); // false for descending
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangHienThiHinhHoc menu = ChucNangHienThiHinhHoc.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangHienThiHinhHoc.Thoat);
        }
    }
}
