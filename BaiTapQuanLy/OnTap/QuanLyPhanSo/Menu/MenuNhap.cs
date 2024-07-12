using QuanLyPhanSo.ChucNang;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo.Menu
{
    class MenuNhap
    {
        private MangPhanSo mangPhanSo;

        public MenuNhap()
        {
            mangPhanSo = new MangPhanSo();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("====================== MENU NHẬP =================");
            Console.WriteLine("{0}. Nhập", (int)QuanLyPhanSo.ChucNang.ChucNangNhap.Nhap);
            Console.WriteLine("{0}. Nhập từ file", (int)QuanLyPhanSo.ChucNang.ChucNangNhap.NhapTuFile);
            Console.WriteLine("{0}. Nhập ngẫu nhiên", (int)QuanLyPhanSo.ChucNang.NhapNgauNhien);
            Console.WriteLine("{0}. Thoát", (int)QuanLyPhanSo.ChucNang.Thoat);
            Console.WriteLine("==================================================");
        }

        private QuanLyPhanSo.ChucNang.ChucNangNhap Select()
        {
            int SoMenu = Enum.GetNames(typeof(QuanLyPhanSo.ChucNang.ChucNangNhap)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu nhập (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (QuanLyPhanSo.ChucNang.ChucNangNhap)menu;
        }

        private void Process(QuanLyPhanSo.ChucNang.ChucNangNhap menu)
        {
            switch (menu)
            {
                case QuanLyPhanSo.ChucNang.ChucNangNhap.Thoat:
                    Console.WriteLine("Kết thúc chương trình nhập!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    break;
                case QuanLyPhanSo.ChucNang.ChucNangNhap.Nhap:
                    mangPhanSo.Nhap();
                    break;
                case QuanLyPhanSo.ChucNang.ChucNangNhap.NhapTuFile:
                    mangPhanSo.NhapTuFile("Data\\data.txt");
                    break;
                case QuanLyPhanSo.ChucNang.ChucNangNhap.NhapNgauNhien:
                    mangPhanSo.NhapNgauNhien();
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ");
                    break;
            }
        }

        public void Run()
        {
            QuanLyPhanSo.ChucNang.ChucNangNhap menu = QuanLyPhanSo.ChucNang.ChucNangNhap.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != QuanLyPhanSo.ChucNang.ChucNangNhap.Thoat);
        }
    }
}
