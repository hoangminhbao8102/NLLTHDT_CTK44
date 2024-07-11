using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    class MenuXoa
    {
        private MangSoNguyen MangNguyen;

        public MenuXoa()
        {
            MangNguyen = new MangSoNguyen();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("====================== MENU XÓA ==================");
            Console.WriteLine("{0}. Xóa phần tử đầu tiên của mảng", (int)ChucNangXoa.XoaPhanTuDauTien);
            Console.WriteLine("{0}. Xóa phần tử tại vị trí vt của mảng", (int)ChucNangXoa.XoaPhanTuTaiViTri);
            Console.WriteLine("{0}. Xóa phần tử đầu của mảng", (int)ChucNangXoa.XoaPhanTuDau);
            Console.WriteLine("{0}. Xóa phần tử cuoi của mảng", (int)ChucNangXoa.XoaPhanTuCuoi);
            Console.WriteLine("{0}. Xóa phần tử có trong mảng b của mảng", (int)ChucNangXoa.XoaPhanTuCoTrongMang);
            Console.WriteLine("{0}. Xóa tất cả các phần tử của mảng", (int)ChucNangXoa.XoaTatCaPhanTu);
            Console.WriteLine("{0}. Xóa tất cả các số âm của mảng", (int)ChucNangXoa.XoaTatCaSoAm);
            Console.WriteLine("{0}. Xóa tất cả các số dương của mảng", (int)ChucNangXoa.XoaTatCaSoDuong);
            Console.WriteLine("{0}. Xóa tất cả các số chẵn của mảng", (int)ChucNangXoa.XoaTatCaSoChan);
            Console.WriteLine("{0}. Xóa tất cả các số lẻ của mảng", (int)ChucNangXoa.XoaTatCaSoLe);
            Console.WriteLine("{0}. Xóa tất cả các số nguyên tố của mảng", (int)ChucNangXoa.XoaTatCaSoNguyenTo);
            Console.WriteLine("{0}. Xóa tất cả các phần tử trùng nhau của mảng", (int)ChucNangXoa.XoaTatCaPhanTuTrungNhau);
            Console.WriteLine("{0}. Xóa phần tử xuất hiện nhiều nhất của mảng", (int)ChucNangXoa.XoaPhanTuXuatHienNhieuNhat);
            Console.WriteLine("{0}. Xóa phần tử xuất hiện ít nhất của mảng", (int)ChucNangXoa.XoaPhanTuXuatHienItNhat);
            Console.WriteLine("{0}. Thoát", (int)ChucNangXoa.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangXoa Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangXoa)).Length;

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

            return (ChucNangXoa)menu;
        }

        private void Process(ChucNangXoa menu)
        {
            int x, vt, lengthb;
            int[] b;

            switch (menu)
            {
                case ChucNangXoa.Thoat:
                    Console.WriteLine("Kết thúc chương trình xóa!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    break;
                case ChucNangXoa.XoaPhanTuDauTien:
                    Console.Write("Nhập phần tử cần xóa: ");
                    x = int.Parse(Console.ReadLine());
                    MangNguyen.XoaPhanTuDauTien(x);
                    Console.WriteLine("Đã xóa phần tử đầu tiên có giá trị {0}.", x);
                    break;
                case ChucNangXoa.XoaPhanTuTaiViTri:
                    Console.Write("Nhập vị trí cần xóa: ");
                    vt = int.Parse(Console.ReadLine());
                    MangNguyen.XoaPhanTuTaiViTri(vt);
                    Console.WriteLine("Đã xóa phần tử tại vị trí {0}.", vt);
                    break;
                case ChucNangXoa.XoaPhanTuDau:
                    MangNguyen.XoaPhanTuDau(0);
                    Console.WriteLine("Đã xóa phần tử đầu tiên.");
                    break;
                case ChucNangXoa.XoaPhanTuCuoi:
                    MangNguyen.XoaPhanTuCuoi(MangNguyen.Length - 1);
                    Console.WriteLine("Đã xóa phần tử cuối cùng.");
                    break;
                case ChucNangXoa.XoaPhanTuCoTrongMang:
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
                case ChucNangXoa.XoaTatCaPhanTu:
                    MangNguyen.XoaTatCaPhanTu();
                    Console.WriteLine("Đã xóa tất cả các phần tử.");
                    break;
                case ChucNangXoa.XoaTatCaSoAm:
                    MangNguyen.XoaTatCaSoAm();
                    Console.WriteLine("Đã xóa tất cả các số âm.");
                    break;
                case ChucNangXoa.XoaTatCaSoDuong:
                    MangNguyen.XoaTatCaSoDuong();
                    Console.WriteLine("Đã xóa tất cả các số dương.");
                    break;
                case ChucNangXoa.XoaTatCaSoChan:
                    MangNguyen.XoaTatCaSoChan();
                    Console.WriteLine("Đã xóa tất cả các số chẵn.");
                    break;
                case ChucNangXoa.XoaTatCaSoLe:
                    MangNguyen.XoaTatCaSoLe();
                    Console.WriteLine("Đã xóa tất cả các số lẻ.");
                    break;
                case ChucNangXoa.XoaTatCaSoNguyenTo:
                    MangNguyen.XoaTatCaSoNguyenTo();
                    Console.WriteLine("Đã xóa tất cả các số nguyên tố.");
                    break;
                case ChucNangXoa.XoaTatCaPhanTuTrungNhau:
                    MangNguyen.XoaTatCaPhanTuTrungNhau();
                    Console.WriteLine("Đã xóa tất cả các phần tử trùng nhau.");
                    break;
                case ChucNangXoa.XoaPhanTuXuatHienNhieuNhat:
                    MangNguyen.XoaPhanTuXuatHienNhieuNhat();
                    Console.WriteLine("Đã xóa các phần tử xuất hiện nhiều nhất.");
                    break;
                case ChucNangXoa.XoaPhanTuXuatHienItNhat:
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
            ChucNangXoa menu = ChucNangXoa.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangXoa.Thoat);
        }
    }
}
