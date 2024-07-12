using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class MenuPhanSo
    {
        private MangPhanSo mangPhanSo;

        public MenuPhanSo()
        {
            mangPhanSo = new MangPhanSo();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Nhập", (int)ChucNangPhanSo.Nhap);
            Console.WriteLine("{0}. Xuất", (int)ChucNangPhanSo.Xuat);
            Console.WriteLine("{0}. Thêm phần tử", (int)ChucNangPhanSo.Them);
            Console.WriteLine("{0}. Xóa phần tử", (int)ChucNangPhanSo.Xoa);
            Console.WriteLine("{0}. Tìm kiếm", (int)ChucNangPhanSo.TimKiem);
            Console.WriteLine("{0}. Đếm", (int)ChucNangPhanSo.Dem);
            Console.WriteLine("{0}. Tính toán", (int)ChucNangPhanSo.TinhToan);
            Console.WriteLine("{0}. Sắp xếp", (int)ChucNangPhanSo.SapXep);
            Console.WriteLine("==================================================");
        }

        private ChucNangPhanSo Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangPhanSo)).Length;

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

            return (ChucNangPhanSo)menu;
        }

        private void Process(ChucNangPhanSo menu)
        {
            switch (menu)
            {
                case ChucNangPhanSo.Thoat:
                    Console.WriteLine("Kết thúc chương trình!");
                    break;
                case ChucNangPhanSo.Nhap:
                    MenuNhapPhanSo menuNhap = new MenuNhapPhanSo();
                    menuNhap.Run();
                    break;
                case ChucNangPhanSo.Xuat:
                    mangPhanSo.Xuat();
                    break;
                case ChucNangPhanSo.Them:
                    MenuThemPhanSo menuThem = new MenuThemPhanSo();
                    menuThem.Run();
                    break;
                case ChucNangPhanSo.Xoa:
                    MenuXoaPhanSo menuXoa = new MenuXoaPhanSo();
                    menuXoa.Run();
                    break;
                case ChucNangPhanSo.TimKiem:
                    MenuTimKiemPhanSo menuTimKiem = new MenuTimKiemPhanSo();
                    menuTimKiem.Run();
                    break;
                case ChucNangPhanSo.Dem:
                    MenuDemPhanSo menuDem = new MenuDemPhanSo();
                    menuDem.Run();
                    break;
                case ChucNangPhanSo.TinhToan:
                    MenuTinhToanPhanSo menuTinhToan = new MenuTinhToanPhanSo();
                    menuTinhToan.Run();
                    break;
                case ChucNangPhanSo.SapXep:
                    MenuSapXepPhanSo menuSapXep = new MenuSapXepPhanSo();
                    menuSapXep.Run();
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangPhanSo menu = ChucNangPhanSo.Thoat;
            do
            {
                menu = this.Select();
                if (menu != ChucNangPhanSo.Thoat)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangPhanSo.Thoat);
        }
    }
}
