using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    class MenuXoaSoNguyen
    {
        private MangSoNguyen MangNguyen;

        public MenuXoaSoNguyen()
        {
            MangNguyen = new MangSoNguyen();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("=================== MENU XÓA =====================");
            Console.WriteLine("{0}. Xóa phần tử đầu tiên của mảng", (int)ChucNangXoaSoNguyen.XoaPhanTuDauTien);
            Console.WriteLine("{0}. Xóa phần tử tại vị trí vt của mảng", (int)ChucNangXoaSoNguyen.XoaPhanTuTaiViTri);
            Console.WriteLine("{0}. Xóa phần tử đầu của mảng", (int)ChucNangXoaSoNguyen.XoaPhanTuDau);
            Console.WriteLine("{0}. Xóa phần tử cuoi của mảng", (int)ChucNangXoaSoNguyen.XoaPhanTuCuoi);
            Console.WriteLine("{0}. Xóa phần tử có trong mảng b của mảng", (int)ChucNangXoaSoNguyen.XoaPhanTuCoTrongMang);
            Console.WriteLine("{0}. Xóa tất cả các phần tử của mảng", (int)ChucNangXoaSoNguyen.XoaTatCaPhanTu);
            Console.WriteLine("{0}. Xóa tất cả các số âm của mảng", (int)ChucNangXoaSoNguyen.XoaTatCaSoAm);
            Console.WriteLine("{0}. Xóa tất cả các số dương của mảng", (int)ChucNangXoaSoNguyen.XoaTatCaSoDuong);
            Console.WriteLine("{0}. Xóa tất cả các số chẵn của mảng", (int)ChucNangXoaSoNguyen.XoaTatCaSoChan);
            Console.WriteLine("{0}. Xóa tất cả các số lẻ của mảng", (int)ChucNangXoaSoNguyen.XoaTatCaSoLe);
            Console.WriteLine("{0}. Xóa tất cả các số nguyên tố của mảng", (int)ChucNangXoaSoNguyen.XoaTatCaSoNguyenTo);
            Console.WriteLine("{0}. Xóa tất cả các phần tử trùng nhau của mảng", (int)ChucNangXoaSoNguyen.XoaTatCaPhanTuTrungNhau);
            Console.WriteLine("{0}. Xóa phần tử xuất hiện nhiều nhất của mảng", (int)ChucNangXoaSoNguyen.XoaPhanTuXuatHienNhieuNhat);
            Console.WriteLine("{0}. Xóa phần tử xuất hiện ít nhất của mảng", (int)ChucNangXoaSoNguyen.XoaPhanTuXuatHienItNhat);
            Console.WriteLine("{0}. Thoát", (int)ChucNangXoaSoNguyen.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangXoaSoNguyen Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangXoaSoNguyen)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu xóa (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangXoaSoNguyen)menu;
        }

        private void Process(ChucNangXoaSoNguyen menu)
        {
            int x, vt, lengthb;
            int[] b;

            switch (menu)
            {
                case ChucNangXoaSoNguyen.Thoat:
                    Console.WriteLine("Kết thúc chương trình xóa!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangXoaSoNguyen.XoaPhanTuDauTien:
                    Console.Write("Nhập phần tử cần xóa: ");
                    x = int.Parse(Console.ReadLine());
                    MangNguyen.XoaPhanTuDauTien(x);
                    Console.WriteLine("Đã xóa phần tử đầu tiên có giá trị {0}.", x);
                    break;
                case ChucNangXoaSoNguyen.XoaPhanTuTaiViTri:
                    Console.Write("Nhập vị trí cần xóa: ");
                    vt = int.Parse(Console.ReadLine());
                    MangNguyen.XoaPhanTuTaiViTri(vt);
                    Console.WriteLine("Đã xóa phần tử tại vị trí {0}.", vt);
                    break;
                case ChucNangXoaSoNguyen.XoaPhanTuDau:
                    MangNguyen.XoaPhanTuDau(0);
                    Console.WriteLine("Đã xóa phần tử đầu tiên.");
                    break;
                case ChucNangXoaSoNguyen.XoaPhanTuCuoi:
                    MangNguyen.XoaPhanTuCuoi(MangNguyen.Length - 1);
                    Console.WriteLine("Đã xóa phần tử cuối cùng.");
                    break;
                case ChucNangXoaSoNguyen.XoaPhanTuCoTrongMang:
                    Console.Write("Nhập độ dài mảng cần xóa: ");
                    lengthb = int.Parse(Console.ReadLine());
                    b = new int[lengthb];
                    for (int i = 0; i < lengthb; i++)
                    {
                        Console.Write("Nhập phần tử thứ {0}: ", i);
                        b[i] = int.Parse(Console.ReadLine());
                    }
                    MangNguyen.XoaPhanTuCoTrongMang(b, lengthb);
                    Console.WriteLine("Đã xóa các phần tử có trong mảng.");
                    break;
                case ChucNangXoaSoNguyen.XoaTatCaPhanTu:
                    MangNguyen.XoaTatCaPhanTu();
                    Console.WriteLine("Đã xóa tất cả các phần tử.");
                    break;
                case ChucNangXoaSoNguyen.XoaTatCaSoAm:
                    MangNguyen.XoaTatCaSoAm();
                    Console.WriteLine("Đã xóa tất cả các số âm.");
                    break;
                case ChucNangXoaSoNguyen.XoaTatCaSoDuong:
                    MangNguyen.XoaTatCaSoDuong();
                    Console.WriteLine("Đã xóa tất cả các số dương.");
                    break;
                case ChucNangXoaSoNguyen.XoaTatCaSoChan:
                    MangNguyen.XoaTatCaSoChan();
                    Console.WriteLine("Đã xóa tất cả các số chẵn.");
                    break;
                case ChucNangXoaSoNguyen.XoaTatCaSoLe:
                    MangNguyen.XoaTatCaSoLe();
                    Console.WriteLine("Đã xóa tất cả các số lẻ.");
                    break;
                case ChucNangXoaSoNguyen.XoaTatCaSoNguyenTo:
                    MangNguyen.XoaTatCaSoNguyenTo();
                    Console.WriteLine("Đã xóa tất cả các số nguyên tố.");
                    break;
                case ChucNangXoaSoNguyen.XoaTatCaPhanTuTrungNhau:
                    MangNguyen.XoaTatCaPhanTuTrungNhau();
                    Console.WriteLine("Đã xóa tất cả các phần tử trùng nhau.");
                    break;
                case ChucNangXoaSoNguyen.XoaPhanTuXuatHienNhieuNhat:
                    MangNguyen.XoaPhanTuXuatHienNhieuNhat();
                    Console.WriteLine("Đã xóa các phần tử xuất hiện nhiều nhất.");
                    break;
                case ChucNangXoaSoNguyen.XoaPhanTuXuatHienItNhat:
                    MangNguyen.XoaPhanTuXuatHienItNhat();
                    Console.WriteLine("Đã xóa các phần tử xuất hiện ít nhất.");
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ");
                    break;
            }
        }

        public void Run()
        {
            ChucNangXoaSoNguyen menu = ChucNangXoaSoNguyen.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangXoaSoNguyen.Thoat);
        }
    }
}
