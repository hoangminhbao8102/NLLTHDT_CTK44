using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    class MenuNhap
    {
        private MangSoNguyen MangNguyen;

        public MenuNhap()
        {
            MangNguyen = new MangSoNguyen();
        }

        private void Show()
        {
            Console.WriteLine("====================== MENU NHẬP =================");
            Console.WriteLine("{0}. Nhập", (int)ChucNangNhap.Nhap);
            Console.WriteLine("{0}. Nhập ngẫu nhiên", (int)ChucNangNhap.NhapNgauNhien);
            Console.WriteLine("{0}. Thoát", (int)ChucNangNhap.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangNhap Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNang)).Length;

            int menu = 0;

            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu nhập (0..{0}) : ", SoMenu);
            } while (menu < 0 || menu >= SoMenu);

            return (ChucNangNhap)menu;
        }

        private void Process(ChucNangNhap menu)
        {
            switch (menu)
            {
                case ChucNangNhap.Thoat:
                    Console.WriteLine("Kết thúc chương trình nhập!");
                    return;
                case ChucNangNhap.Nhap:
                    MangNguyen.Nhap();
                    break;
                case ChucNangNhap.NhapNgauNhien:
                    MangNguyen.NhapNgauNhien();
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ");
                    break;
            }
        }

        public void Run()
        {
            ChucNangNhap menu = ChucNangNhap.Thoat;
            do
            {
                menu = this.Select();
                this.Process(menu);
            } while (menu != ChucNangNhap.Thoat);
        }
    }
}
