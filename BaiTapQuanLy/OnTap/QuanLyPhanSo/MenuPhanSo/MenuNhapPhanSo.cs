using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class MenuNhapPhanSo
    {
        private MangPhanSo mangPhanSo;

        public MenuNhapPhanSo()
        {
            mangPhanSo = new MangPhanSo();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("====================== MENU NHẬP =================");
            Console.WriteLine("{0}. Nhập mảng phân số từ bàn phím.", (int)ChucNangNhapPhanSo.Nhap);
            Console.WriteLine("{0}. Nhập mảng phân số từ file", (int)ChucNangNhapPhanSo.NhapTuFile);
            Console.WriteLine("{0}. Nhập ngẫu nhiên", (int)ChucNangNhapPhanSo.NhapNgauNhien);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangNhapPhanSo.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangNhapPhanSo Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangNhapPhanSo)).Length;

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

            return (ChucNangNhapPhanSo)menu;
        }

        private void Process(ChucNangNhapPhanSo menu)
        {
            switch (menu)
            {
                case ChucNangNhapPhanSo.Thoat:
                    Console.WriteLine("Kết thúc chương trình nhập!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangNhapPhanSo.Nhap:
                    mangPhanSo.Nhap();
                    break;
                case ChucNangNhapPhanSo.NhapTuFile:
                    mangPhanSo.NhapTuFile(@"Data\data.txt");
                    break;
                case ChucNangNhapPhanSo.NhapNgauNhien:
                    mangPhanSo.NhapNgauNhien();
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangNhapPhanSo menu = ChucNangNhapPhanSo.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangNhapPhanSo.Thoat);
        }
    }
}
