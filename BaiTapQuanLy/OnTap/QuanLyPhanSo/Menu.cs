using QuanLyPhanSo.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class Menu
    {
        private MangPhanSo mangPhanSo;

        public Menu()
        {
            mangPhanSo = new MangPhanSo();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Nhập", (int)ChucNang.Nhap);
            Console.WriteLine("{0}. Xuất", (int)ChucNang.Xuat);
            Console.WriteLine("{0}. Thêm phần tử", (int)ChucNang.Them);
            Console.WriteLine("{0}. Xóa phần tử", (int)ChucNang.Xoa);
            Console.WriteLine("{0}. Tìm kiếm", (int)ChucNang.TimKiem);
            Console.WriteLine("{0}. Đếm", (int)ChucNang.Dem);
            Console.WriteLine("{0}. Tính toán", (int)ChucNang.TinhToan);
            Console.WriteLine("{0}. Sắp xếp", (int)ChucNang.SapXep);
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
                case ChucNang.Nhap:
                    MenuNhap menuNhap = new MenuNhap();
                    menuNhap.Run();
                    break;
                case ChucNang.Xuat:
                    mangPhanSo.Xuat();
                    break;
                case ChucNang.Them:
                    MenuThem menuThem = new MenuThem();
                    menuThem.Run();
                    break;
                case ChucNang.Xoa:
                    MenuXoa menuXoa = new MenuXoa();
                    menuXoa.Run();
                    break;
                case ChucNang.TimKiem:
                    MenuTimKiem menuTimKiem = new MenuTimKiem();
                    menuTimKiem.Run();
                    break;
                case ChucNang.Dem:
                    MenuDem menuDem = new MenuDem();
                    menuDem.Run();
                    break;
                case ChucNang.TinhToan:
                    MenuTinhToan menuTinhToan = new MenuTinhToan();
                    menuTinhToan.Run();
                    break;
                case ChucNang.SapXep:
                    MenuSapXep menuSapXep = new MenuSapXep();
                    menuSapXep.Run();
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
