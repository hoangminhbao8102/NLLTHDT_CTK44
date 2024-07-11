using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    class MenuThem
    {
        private MangSoNguyen MangNguyen;

        public MenuThem()
        {
            MangNguyen = new MangSoNguyen();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("====================== MENU THÊM =================");
            Console.WriteLine("{0}. Thêm phần tử x tại vị trí vt của mảng", (int)ChucNangThem.ThemPhanTuTaiViTri);
            Console.WriteLine("{0}. Thêm phần tử x vào đầu danh sách của mảng", (int)ChucNangThem.ThemPhanTuDauDanhSach);
            Console.WriteLine("{0}. Thêm phần tử x vào cuối danh sách của mảng", (int)ChucNangThem.ThemPhanTuCuoiDanhSach);
            Console.WriteLine("{0}. Thêm một mảng b vào danh sách tại vị trí vt của mảng", (int)ChucNangThem.ThemMotMangVaoDanhSachTaiViTri);
            Console.WriteLine("{0}. Thêm một mảng b vào đầu danh sách của mảng", (int)ChucNangThem.ThemMotMangVaoDauDanhSach);
            Console.WriteLine("{0}. Thêm một mảng b vào cuối danh sách của mảng", (int)ChucNangThem.ThemMotMangVaoCuoiDanhSach);
            Console.WriteLine("{0}. Thoát", (int)ChucNangThem.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangThem Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangThem)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu thêm (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangThem)menu;
        }

        private void Process(ChucNangThem menu)
        {
            int x, vt, lengthb;
            int[] b;

            switch (menu)
            {
                case ChucNangThem.Thoat:
                    Console.WriteLine("Kết thúc chương trình thêm!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    break;
                case ChucNangThem.ThemPhanTuTaiViTri:
                    Console.Write("Nhập phần tử cần thêm: ");
                    x = int.Parse(Console.ReadLine());
                    Console.Write("Nhập vị trí cần thêm: ");
                    vt = int.Parse(Console.ReadLine());
                    if (MangNguyen.ThemPhanTuTaiViTri(x, vt))
                    {
                        Console.WriteLine("Đã thêm phần tử {0} tại vị trí {1}.", x, vt);
                    }
                    else
                    {
                        Console.WriteLine("Thêm phần tử thất bại.");
                    }
                    break;
                case ChucNangThem.ThemPhanTuDauDanhSach:
                    Console.Write("Nhập phần tử cần thêm vào đầu danh sách: ");
                    x = int.Parse(Console.ReadLine());
                    if (MangNguyen.ThemPhanTuDauDanhSach(x))
                    {
                        Console.WriteLine("Đã thêm phần tử {0} vào đầu danh sách.", x);
                    }
                    else
                    {
                        Console.WriteLine("Thêm phần tử thất bại.");
                    }
                    break;
                case ChucNangThem.ThemPhanTuCuoiDanhSach:
                    Console.Write("Nhập phần tử cần thêm vào cuối danh sách: ");
                    x = int.Parse(Console.ReadLine());
                    if (MangNguyen.ThemPhanTuCuoiDanhSach(x))
                    {
                        Console.WriteLine("Đã thêm phần tử {0} vào cuối danh sách.", x);
                    }
                    else
                    {
                        Console.WriteLine("Thêm phần tử thất bại.");
                    }
                    break;
                case ChucNangThem.ThemMotMangVaoDanhSachTaiViTri:
                    Console.Write("Nhập độ dài mảng cần thêm: ");
                    lengthb = int.Parse(Console.ReadLine());
                    b = new int[lengthb];
                    for (int i = 0; i < lengthb; i++)
                    {
                        Console.Write("Nhập phần tử thứ {0}: ", i);
                        b[i] = int.Parse(Console.ReadLine());
                    }
                    Console.Write("Nhập vị trí cần thêm mảng: ");
                    vt = int.Parse(Console.ReadLine());
                    if (MangNguyen.ThemMotMangVaoDanhSachTaiViTri(b, lengthb, vt))
                    {
                        Console.WriteLine("Đã thêm mảng vào vị trí {0}.", vt);
                    }
                    else
                    {
                        Console.WriteLine("Thêm mảng thất bại.");
                    }
                    break;
                case ChucNangThem.ThemMotMangVaoDauDanhSach:
                    Console.Write("Nhập độ dài mảng cần thêm: ");
                    lengthb = int.Parse(Console.ReadLine());
                    b = new int[lengthb];
                    for (int i = 0; i < lengthb; i++)
                    {
                        Console.Write("Nhập phần tử thứ {0}: ", i);
                        b[i] = int.Parse(Console.ReadLine());
                    }
                    if (MangNguyen.ThemMotMangVaoDauDanhSach(b, lengthb))
                    {
                        Console.WriteLine("Đã thêm mảng vào đầu danh sách.");
                    }
                    else
                    {
                        Console.WriteLine("Thêm mảng thất bại.");
                    }
                    break;
                case ChucNangThem.ThemMotMangVaoCuoiDanhSach:
                    Console.Write("Nhập độ dài mảng cần thêm: ");
                    lengthb = int.Parse(Console.ReadLine());
                    b = new int[lengthb];
                    for (int i = 0; i < lengthb; i++)
                    {
                        Console.Write("Nhập phần tử thứ {0}: ", i);
                        b[i] = int.Parse(Console.ReadLine());
                    }
                    if (MangNguyen.ThemMotMangVaoCuoiDanhSach(b, lengthb))
                    {
                        Console.WriteLine("Đã thêm mảng vào cuối danh sách.");
                    }
                    else
                    {
                        Console.WriteLine("Thêm mảng thất bại.");
                    }
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ");
                    break;
            }
        }

        public void Run()
        {
            ChucNangThem menu = ChucNangThem.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangThem.Thoat);
        }
    }
}
