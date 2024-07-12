using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    class MenuSoNguyen
    {
        private MangSoNguyen MangNguyen;

        public MenuSoNguyen()
        {
            MangNguyen = new MangSoNguyen();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Nhập liệu", (int)ChucNangSoNguyen.NhapLieu);
            Console.WriteLine("{0}. Xuất dữ liệu", (int)ChucNangSoNguyen.XuatDuLieu);
            Console.WriteLine("{0}. Tìm kiếm", (int)ChucNangSoNguyen.TimKiem);
            Console.WriteLine("{0}. Thêm phần tử", (int)ChucNangSoNguyen.ThemPhanTu);
            Console.WriteLine("{0}. Xóa phần tử", (int)ChucNangSoNguyen.XoaPhanTu);
            Console.WriteLine("{0}. Thay thế phần tử", (int)ChucNangSoNguyen.ThayThePhanTu);
            Console.WriteLine("{0}. Đếm số lượng", (int)ChucNangSoNguyen.DemSoLuong);
            Console.WriteLine("{0}. Tính toán", (int)ChucNangSoNguyen.TinhToan);
            Console.WriteLine("{0}. Sắp xếp", (int)ChucNangSoNguyen.SapXep);
            Console.WriteLine("{0}. Đảo ngược", (int)ChucNangSoNguyen.DaoNguoc);
            Console.WriteLine("{0}. Kiểm tra", (int)ChucNangSoNguyen.KiemTra);
            Console.WriteLine("{0}. Thoát", (int)ChucNangSoNguyen.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangSoNguyen Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangSoNguyen)).Length;

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

            return (ChucNangSoNguyen)menu;
        }

        private void Process(ChucNangSoNguyen menu)
        {
            switch (menu)
            {
                case ChucNangSoNguyen.Thoat:
                    Console.WriteLine("Kết thúc chương trình!");
                    break;
                case ChucNangSoNguyen.NhapLieu:
                    MenuNhapSoNguyen menuNhap = new MenuNhapSoNguyen();
                    menuNhap.Run();
                    break;
                case ChucNangSoNguyen.XuatDuLieu:
                    MenuXuatSoNguyen menuXuat = new MenuXuatSoNguyen();
                    menuXuat.Run();
                    break;
                case ChucNangSoNguyen.TimKiem:
                    MenuTimKiemSoNguyen menuTimKiem = new MenuTimKiemSoNguyen();
                    menuTimKiem.Run();
                    break;
                case ChucNangSoNguyen.ThemPhanTu:
                    MenuThemSoNguyen menuThem = new MenuThemSoNguyen();
                    menuThem.Run();
                    break;
                case ChucNangSoNguyen.XoaPhanTu:
                    MenuXoaSoNguyen menuXoa = new MenuXoaSoNguyen();
                    menuXoa.Run();
                    break;
                case ChucNangSoNguyen.ThayThePhanTu:
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
                case ChucNangSoNguyen.DemSoLuong:
                    MenuDemSoNguyen menuDem = new MenuDemSoNguyen();
                    menuDem.Run();
                    break;
                case ChucNangSoNguyen.TinhToan:
                    int tong = MangNguyen.TinhTongCacSoNguyen();
                    Console.WriteLine("Tổng các số nguyên trong mảng là: {0}", tong);
                    break;
                case ChucNangSoNguyen.SapXep:
                    MenuSapXepSoNguyen menuSapXep = new MenuSapXepSoNguyen();
                    menuSapXep.Run();
                    break;
                case ChucNangSoNguyen.DaoNguoc:
                    MangNguyen.DaoNguocMang();
                    Console.WriteLine("Đã đảo ngược mảng.");
                    MangNguyen.Xuat(); // Giả sử MangNguyen có phương thức Xuat() để in mảng ra màn hình
                    break;
                case ChucNangSoNguyen.KiemTra:
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
            ChucNangSoNguyen menu = ChucNangSoNguyen.Thoat;
            do
            {
                menu = this.Select();
                if (menu != ChucNangSoNguyen.Thoat)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangSoNguyen.Thoat);
        }
    }
}
