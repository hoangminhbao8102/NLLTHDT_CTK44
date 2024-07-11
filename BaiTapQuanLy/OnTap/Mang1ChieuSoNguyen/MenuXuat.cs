using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    class MenuXuat
    {
        private MangSoNguyen MangNguyen;

        public MenuXuat()
        {
            MangNguyen = new MangSoNguyen();
        }

        private void Show()
        {
            Console.WriteLine("====================== MENU XUẤT =================");
            Console.WriteLine("{0}. Xuất", (int)ChucNangXuat.Xuat);
            Console.WriteLine("{0}. Xuất mảng", (int)ChucNangXuat.XuatMang);
            Console.WriteLine("{0}. Thoát", (int)ChucNangXuat.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangXuat Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNang)).Length;

            int menu = 0;

            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu xuất (0..{0}) : ", SoMenu);
            } while (menu < 0 || menu >= SoMenu);

            return (ChucNangXuat)menu;
        }

        private void Process(ChucNangXuat menu)
        {
            switch (menu)
            {
                case ChucNangXuat.Thoat:
                    Console.WriteLine("Kết thúc chương trình xuất!");
                    return;
                case ChucNangXuat.Xuat:
                    MangNguyen.Xuat();
                    break;
                case ChucNangXuat.XuatMang:
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
            ChucNangXuat menu = ChucNangXuat.Thoat;
            do
            {
                menu = this.Select();
                this.Process(menu);
            } while (menu != ChucNangXuat.Thoat);
        }
    }
}
