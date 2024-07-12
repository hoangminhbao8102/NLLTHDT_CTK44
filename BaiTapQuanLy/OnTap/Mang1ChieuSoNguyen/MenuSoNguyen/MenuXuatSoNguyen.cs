using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    class MenuXuatSoNguyen
    {
        private MangSoNguyen MangNguyen;

        public MenuXuatSoNguyen()
        {
            MangNguyen = new MangSoNguyen();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("=================== MENU XUẤT ====================");
            Console.WriteLine("{0}. Xuất", (int)ChucNangXuatSoNguyen.Xuat);
            Console.WriteLine("{0}. Xuất mảng", (int)ChucNangXuatSoNguyen.XuatMang);
            Console.WriteLine("{0}. Thoát", (int)ChucNangXuatSoNguyen.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangXuatSoNguyen Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangXuatSoNguyen)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu xuất (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangXuatSoNguyen)menu;
        }

        private void Process(ChucNangXuatSoNguyen menu)
        {
            switch (menu)
            {
                case ChucNangXuatSoNguyen.Thoat:
                    Console.WriteLine("Kết thúc chương trình xuất!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangXuatSoNguyen.Xuat:
                    MangNguyen.Xuat();
                    break;
                case ChucNangXuatSoNguyen.XuatMang:
                    Console.Write("Nhập độ dài mảng muốn xuất: ");
                    int len = int.Parse(Console.ReadLine());
                    int[] arr = new int[len];
                    for (int i = 0; i < len; i++)
                    {
                        Console.Write("Nhập phần tử thứ {0}: ", i);
                        arr[i] = int.Parse(Console.ReadLine());
                    }
                    MangNguyen.XuatMang(arr, len);
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ");
                    break;
            }
        }

        public void Run()
        {
            ChucNangXuatSoNguyen menu = ChucNangXuatSoNguyen.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangXuatSoNguyen.Thoat);
        }
    }
}
