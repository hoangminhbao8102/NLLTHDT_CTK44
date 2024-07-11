using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    class MenuDem
    {
        private MangSoNguyen MangNguyen;

        public MenuDem()
        {
            MangNguyen = new MangSoNguyen();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("====================== MENU ĐẾM ==================");
            Console.WriteLine("{0}. Đếm số lần xuất hiện của phần tử x trong mảng", (int)ChucNangDem.DemSoLanXuatHienCuaPhanTu);
            Console.WriteLine("{0}. Đếm số dương trong mảng", (int)ChucNangDem.DemSoDuong);
            Console.WriteLine("{0}. Đếm số âm trong mảng", (int)ChucNangDem.DemSoAm);
            Console.WriteLine("{0}. Đếm số nguyên tố trong mảng", (int)ChucNangDem.DemSoNguyenTo);
            Console.WriteLine("{0}. Đếm số chẵn trong mảng", (int)ChucNangDem.DemSoChan);
            Console.WriteLine("{0}. Đếm số lẻ trong mảng", (int)ChucNangDem.DemSoLe);
            Console.WriteLine("{0}. Thoát", (int)ChucNangDem.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangDem Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangDem)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu đếm (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangDem)menu;
        }

        private void Process(ChucNangDem menu)
        {
            int x, count;

            switch (menu)
            {
                case ChucNangDem.Thoat:
                    Console.WriteLine("Kết thúc chương trình đếm!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    break;
                case ChucNangDem.DemSoLanXuatHienCuaPhanTu:
                    Console.Write("Nhập giá trị cần đếm: ");
                    x = int.Parse(Console.ReadLine());
                    count = MangNguyen.DemSoLanXuatHienCuaPhanTu(x);
                    Console.WriteLine("Số lần xuất hiện của phần tử {0} là: {1}", x, count);
                    break;
                case ChucNangDem.DemSoDuong:
                    count = MangNguyen.DemSoDuong();
                    Console.WriteLine("Số lượng số dương trong mảng là: {0}", count);
                    break;
                case ChucNangDem.DemSoAm:
                    count = MangNguyen.DemSoAm();
                    Console.WriteLine("Số lượng số âm trong mảng là: {0}", count);
                    break;
                case ChucNangDem.DemSoNguyenTo:
                    count = MangNguyen.DemSoNguyenTo();
                    Console.WriteLine("Số lượng số nguyên tố trong mảng là: {0}", count);
                    break;
                case ChucNangDem.DemSoChan:
                    count = MangNguyen.DemSoChan();
                    Console.WriteLine("Số lượng số chẵn trong mảng là: {0}", count);
                    break;
                case ChucNangDem.DemSoLe:
                    count = MangNguyen.DemSoLe();
                    Console.WriteLine("Số lượng số lẻ trong mảng là: {0}", count);
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ");
                    break;
            }
        }

        public void Run()
        {
            ChucNangDem menu = ChucNangDem.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangDem.Thoat);
        }
    }
}
