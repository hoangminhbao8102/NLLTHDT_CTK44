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

            int menu = 0;

            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu (0..{0}) : ", SoMenu);
            } while (menu < 0 || menu >= SoMenu);

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
                    break;
                case ChucNang.XoaPhanTu:
                    break;
                case ChucNang.ThayThePhanTu:
                    break;
                case ChucNang.DemSoLuong:
                    break;
                case ChucNang.TinhToan:
                    break;
                case ChucNang.SapXep:
                    break;
                case ChucNang.DaoNguoc:
                    break;
                case ChucNang.KiemTra:
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
                this.Process(menu);
            } while (menu != ChucNang.Thoat);
        }
    }
}
