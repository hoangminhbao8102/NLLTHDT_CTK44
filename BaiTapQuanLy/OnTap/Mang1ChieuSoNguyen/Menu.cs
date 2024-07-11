using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    class Menu
    {
        private MangSoNguyen MangNguyen;

        public Menu()
        {
            MangNguyen = new MangSoNguyen();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Nhập liệu", (int)ChucNang.NhapLieu);
            Console.WriteLine("{0}. Xuất dữ liệu", (int)ChucNang.XuatDuLieu);
            Console.WriteLine("{0}. Tìm kiếm", (int)ChucNang.TimKiem);
            Console.WriteLine("{0}. Thêm phần tử", (int)ChucNang.ThemPhanTu);
            Console.WriteLine("{0}. Xóa phần tử", (int)ChucNang.XoaPhanTu);
            Console.WriteLine("{0}. Thay thế phần tử", (int)ChucNang.ThayThePhanTu);
            Console.WriteLine("{0}. Đếm số lượng", (int)ChucNang.DemSoLuong);
            Console.WriteLine("{0}. Tính toán", (int)ChucNang.TinhToan);
            Console.WriteLine("{0}. Sắp xếp", (int)ChucNang.SapXep);
            Console.WriteLine("{0}. Đảo ngược", (int)ChucNang.DaoNguoc);
            Console.WriteLine("{0}. Kiểm tra", (int)ChucNang.KiemTra);
            Console.WriteLine("{0}. Thoát", (int)ChucNang.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNang Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNang)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNang)menu;
        }

        private void Process(ChucNang menu)
        {
            switch (menu)
            {
                case ChucNang.Thoat:
                    Console.WriteLine("Kết thúc chương trình!");
                    break;
                case ChucNang.NhapLieu:
                    MenuNhap menuNhap = new MenuNhap();
                    menuNhap.Run();
                    break;
                case ChucNang.XuatDuLieu:
                    MenuXuat menuXuat = new MenuXuat();
                    menuXuat.Run();
                    break;
                case ChucNang.TimKiem:
                    MenuTimKiem menuTimKiem = new MenuTimKiem();
                    menuTimKiem.Run();
                    break;
                case ChucNang.ThemPhanTu:
                    MenuThem menuThem = new MenuThem();
                    menuThem.Run();
                    break;
                case ChucNang.XoaPhanTu:
                    MenuXoa menuXoa = new MenuXoa();
                    menuXoa.Run();
                    break;
                case ChucNang.ThayThePhanTu:
                    Console.Write("Nhập giá trị cần thay thế: ");
                    int cu = int.Parse(Console.ReadLine());
                    Console.Write("Nhập giá trị mới: ");
                    int moi = int.Parse(Console.ReadLine());
                    if (MangNguyen.ThayThePhanTu(cu, moi))
                    {
                        Console.WriteLine("Đã thay thế phần tử {0} bằng {1}.", cu, moi);
                    }
                    else
                    {
                        Console.WriteLine("Thay thế phần tử thất bại.");
                    }
                    break;
                case ChucNang.DemSoLuong:
                    MenuDem menuDem = new MenuDem();
                    menuDem.Run();
                    break;
                case ChucNang.TinhToan:
                    int tong = MangNguyen.TinhTongCacSoNguyen();
                    Console.WriteLine("Tổng các số nguyên trong mảng là: {0}", tong);
                    break;
                case ChucNang.SapXep:
                    MenuSapXep menuSapXep = new MenuSapXep();
                    menuSapXep.Run();
                    break;
                case ChucNang.DaoNguoc:
                    MangNguyen.DaoNguocMang();
                    Console.WriteLine("Đã đảo ngược mảng.");
                    MangNguyen.Xuat(); // Giả sử MangNguyen có phương thức Xuat() để in mảng ra màn hình
                    break;
                case ChucNang.KiemTra:
                    Console.Write("Nhập giá trị cần kiểm tra: ");
                    int x = int.Parse(Console.ReadLine());
                    if (MangNguyen.KiemTra(x))
                    {
                        Console.WriteLine("{0} là số nguyên tố.", x);
                    }
                    else
                    {
                        Console.WriteLine("{0} không phải là số nguyên tố.", x);
                    }
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ");
                    break;
            }
        }

        public void Run()
        {
            ChucNang menu = ChucNang.Thoat;
            do
            {
                menu = this.Select();
                if (menu != ChucNang.Thoat)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNang.Thoat);
        }
    }
}
