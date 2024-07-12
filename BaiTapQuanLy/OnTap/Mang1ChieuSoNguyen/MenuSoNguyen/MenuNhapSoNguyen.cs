using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    class MenuNhapSoNguyen
    {
        private MangSoNguyen MangNguyen;

        public MenuNhapSoNguyen()
        {
            MangNguyen = new MangSoNguyen();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("=================== MENU NHẬP ====================");
            Console.WriteLine("{0}. Nhập", (int)ChucNangNhapSoNguyen.Nhap);
            Console.WriteLine("{0}. Nhập ngẫu nhiên", (int)ChucNangNhapSoNguyen.NhapNgauNhien);
            Console.WriteLine("{0}. Thoát", (int)ChucNangNhapSoNguyen.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangNhapSoNguyen Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangNhapSoNguyen)).Length;

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

            return (ChucNangNhapSoNguyen)menu;
        }

        private void Process(ChucNangNhapSoNguyen menu)
        {
            switch (menu)
            {
                case ChucNangNhapSoNguyen.Thoat:
                    Console.WriteLine("Kết thúc chương trình nhập!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangNhapSoNguyen.Nhap:
                    MangNguyen.Nhap();
                    break;
                case ChucNangNhapSoNguyen.NhapNgauNhien:
                    MangNguyen.NhapNgauNhien();
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ");
                    break;
            }
        }

        public void Run()
        {
            ChucNangNhapSoNguyen menu = ChucNangNhapSoNguyen.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangNhapSoNguyen.Thoat);
        }
    }
}
