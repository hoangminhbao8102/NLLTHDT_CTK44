using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    class MenuSapXepSoNguyen
    {
        private MangSoNguyen MangNguyen;

        public MenuSapXepSoNguyen()
        {
            MangNguyen = new MangSoNguyen();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("================== MENU SẮP XẾP ==================");
            Console.WriteLine("{0}. Sắp xếp mảng số nguyên theo tăng dần", (int)ChucNangSapXepSoNguyen.SapXepTang);
            Console.WriteLine("{0}. Sắp xếp mảng số nguyên theo giảm dần", (int)ChucNangSapXepSoNguyen.SapXepGiam);
            Console.WriteLine("{0}. Thoát", (int)ChucNangSapXepSoNguyen.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangSapXepSoNguyen Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangSapXepSoNguyen)).Length;

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

            return (ChucNangSapXepSoNguyen)menu;
        }

        private void Process(ChucNangSapXepSoNguyen menu)
        {
            switch (menu)
            {
                case ChucNangSapXepSoNguyen.Thoat:
                    Console.WriteLine("Kết thúc chương trình sắp xếp!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangSapXepSoNguyen.SapXepTang:
                    MangNguyen.SapXepTang();
                    Console.WriteLine("Đã sắp xếp mảng theo thứ tự tăng dần.");
                    MangNguyen.Xuat(); // Giả sử MangNguyen có phương thức Xuat() để in mảng ra màn hình
                    break;
                case ChucNangSapXepSoNguyen.SapXepGiam:
                    MangNguyen.SapXepGiam();
                    Console.WriteLine("Đã sắp xếp mảng theo thứ tự giảm dần.");
                    MangNguyen.Xuat(); // Giả sử MangNguyen có phương thức Xuat() để in mảng ra màn hình
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ");
                    break;
            }
        }

        public void Run()
        {
            ChucNangSapXepSoNguyen menu = ChucNangSapXepSoNguyen.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangSapXepSoNguyen.Thoat);
        }
    }
}
