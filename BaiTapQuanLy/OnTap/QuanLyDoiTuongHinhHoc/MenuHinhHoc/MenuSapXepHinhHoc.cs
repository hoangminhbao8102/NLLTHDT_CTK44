using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class MenuSapXepHinhHoc
    {
        private DanhSachHinhHoc hinhHoc;

        public MenuSapXepHinhHoc()
        {
            hinhHoc = new DanhSachHinhHoc();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("================== MENU SẮP XẾP ==================");
            Console.WriteLine("{0}. Sắp xếp các hình vuông theo diện tích.", (int)ChucNangSapXepHinhHoc.SapXepHinhVuongTheoDienTich);
            Console.WriteLine("{0}. Sắp xếp các hình vuông theo chu vi.", (int)ChucNangSapXepHinhHoc.SapXepHinhVuongTheoChuVi);
            Console.WriteLine("{0}. Sắp xếp các hình tròn theo diện tích.", (int)ChucNangSapXepHinhHoc.SapXepHinhTronTheoDienTich);
            Console.WriteLine("{0}. Sắp xếp các hình tròn theo chu vi.", (int)ChucNangSapXepHinhHoc.SapXepHinhTronTheoChuVi);
            Console.WriteLine("{0}. Sắp xếp các hình vuông theo diện tích.", (int)ChucNangSapXepHinhHoc.SapXepHinhChuNhatTheoDienTich);
            Console.WriteLine("{0}. Sắp xếp các hình chữ nhật theo chu vi.", (int)ChucNangSapXepHinhHoc.SapXepHinhChuNhatTheoChuVi);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangSapXepHinhHoc.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangSapXepHinhHoc Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangSapXepHinhHoc)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu sắp xếp (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangSapXepHinhHoc)menu;
        }

        private void Process(ChucNangSapXepHinhHoc menu)
        {
            switch (menu)
            {
                case ChucNangSapXepHinhHoc.Thoat:
                    Console.WriteLine("Kết thúc chương trình sắp xếp!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangSapXepHinhHoc.SapXepHinhVuongTheoDienTich:
                    Console.WriteLine("Sắp xếp hình vuông theo diện tích:");
                    hinhHoc.SapXepHinhVuongTheoDienTich(true);  // Sắp xếp tăng dần theo diện tích
                    Console.WriteLine(hinhHoc);
                    break;
                case ChucNangSapXepHinhHoc.SapXepHinhVuongTheoChuVi:
                    Console.WriteLine("Sắp xếp hình vuông theo chu vi:");
                    hinhHoc.SapXepHinhVuongTheoChuVi(true);  // Sắp xếp tăng dần theo chu vi
                    Console.WriteLine(hinhHoc);
                    break;
                case ChucNangSapXepHinhHoc.SapXepHinhTronTheoDienTich:
                    Console.WriteLine("Sắp xếp hình tròn theo diện tích:");
                    hinhHoc.SapXepHinhTronTheoDienTich(true);  // Sắp xếp tăng dần theo diện tích
                    Console.WriteLine(hinhHoc);
                    break;
                case ChucNangSapXepHinhHoc.SapXepHinhTronTheoChuVi:
                    Console.WriteLine("Sắp xếp hình tròn theo chu vi:");
                    hinhHoc.SapXepHinhTronTheoChuVi(true);  // Sắp xếp tăng dần theo chu vi
                    Console.WriteLine(hinhHoc);
                    break;
                case ChucNangSapXepHinhHoc.SapXepHinhChuNhatTheoDienTich:
                    Console.WriteLine("Sắp xếp hình chữ nhật theo diện tích:");
                    hinhHoc.SapXepHinhChuNhatTheoDienTich(true);  // Sắp xếp tăng dần theo diện tích
                    Console.WriteLine(hinhHoc);
                    break;
                case ChucNangSapXepHinhHoc.SapXepHinhChuNhatTheoChuVi:
                    Console.WriteLine("Sắp xếp hình chữ nhật theo chu vi:");
                    hinhHoc.SapXepHinhChuNhatTheoChuVi(true);  // Sắp xếp tăng dần theo chu vi
                    Console.WriteLine(hinhHoc);
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangSapXepHinhHoc menu = ChucNangSapXepHinhHoc.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangSapXepHinhHoc.Thoat);
        }
    }
}
