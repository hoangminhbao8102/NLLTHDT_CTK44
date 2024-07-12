using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    class MenuDemSoNguyen
    {
        private MangSoNguyen MangNguyen;

        public MenuDemSoNguyen()
        {
            MangNguyen = new MangSoNguyen();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("=================== MENU ĐẾM =====================");
            Console.WriteLine("{0}. Đếm số lần xuất hiện của phần tử x trong mảng", (int)ChucNangDemSoNguyen.DemSoLanXuatHienCuaPhanTu);
            Console.WriteLine("{0}. Đếm số dương trong mảng", (int)ChucNangDemSoNguyen.DemSoDuong);
            Console.WriteLine("{0}. Đếm số âm trong mảng", (int)ChucNangDemSoNguyen.DemSoAm);
            Console.WriteLine("{0}. Đếm số nguyên tố trong mảng", (int)ChucNangDemSoNguyen.DemSoNguyenTo);
            Console.WriteLine("{0}. Đếm số chẵn trong mảng", (int)ChucNangDemSoNguyen.DemSoChan);
            Console.WriteLine("{0}. Đếm số lẻ trong mảng", (int)ChucNangDemSoNguyen.DemSoLe);
            Console.WriteLine("{0}. Thoát", (int)ChucNangDemSoNguyen.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangDemSoNguyen Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangDemSoNguyen)).Length;

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

            return (ChucNangDemSoNguyen)menu;
        }

        private void Process(ChucNangDemSoNguyen menu)
        {
            int x, count;

            switch (menu)
            {
                case ChucNangDemSoNguyen.Thoat:
                    Console.WriteLine("Kết thúc chương trình đếm!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangDemSoNguyen.DemSoLanXuatHienCuaPhanTu:
                    Console.Write("Nhập giá trị cần đếm: ");
                    x = int.Parse(Console.ReadLine());
                    count = MangNguyen.DemSoLanXuatHienCuaPhanTu(x);
                    Console.WriteLine("Số lần xuất hiện của phần tử {0} là: {1}", x, count);
                    break;
                case ChucNangDemSoNguyen.DemSoDuong:
                    count = MangNguyen.DemSoDuong();
                    Console.WriteLine("Số lượng số dương trong mảng là: {0}", count);
                    break;
                case ChucNangDemSoNguyen.DemSoAm:
                    count = MangNguyen.DemSoAm();
                    Console.WriteLine("Số lượng số âm trong mảng là: {0}", count);
                    break;
                case ChucNangDemSoNguyen.DemSoNguyenTo:
                    count = MangNguyen.DemSoNguyenTo();
                    Console.WriteLine("Số lượng số nguyên tố trong mảng là: {0}", count);
                    break;
                case ChucNangDemSoNguyen.DemSoChan:
                    count = MangNguyen.DemSoChan();
                    Console.WriteLine("Số lượng số chẵn trong mảng là: {0}", count);
                    break;
                case ChucNangDemSoNguyen.DemSoLe:
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
            ChucNangDemSoNguyen menu = ChucNangDemSoNguyen.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangDemSoNguyen.Thoat);
        }
    }
}
