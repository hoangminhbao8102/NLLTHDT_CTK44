using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class MenuHinhHoc
    {
        private DanhSachHinhHoc hinhHoc;

        public MenuHinhHoc()
        {
            hinhHoc = new DanhSachHinhHoc();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Nhập dữ liệu hình học từ file.", (int)ChucNangHinhHoc.NhapTuFile);
            Console.WriteLine("{0}. Xuất các hình học.", (int)ChucNangHinhHoc.Xuat);
            Console.WriteLine("{0}. Tìm kiếm các hình học.", (int)ChucNangHinhHoc.TimKiem);
            Console.WriteLine("{0}. Sắp xếp các hình học.", (int)ChucNangHinhHoc.SapXep);
            Console.WriteLine("{0}. Tính tổng các hình học", (int)ChucNangHinhHoc.TinhTong);
            Console.WriteLine("{0}. Đếm các hình học", (int)ChucNangHinhHoc.Dem);
            Console.WriteLine("{0}. Hiển thị các hình học", (int)ChucNangHinhHoc.HienThi);
            Console.WriteLine("{0}. Xóa các hình học", (int)ChucNangHinhHoc.Xoa);
            Console.WriteLine("{0}. Thêm hình vào vị trí x", (int)ChucNangHinhHoc.ThemHinhTaiViTri);
            Console.WriteLine("{0}. Ghi danh sách các hình xuống file", (int)ChucNangHinhHoc.GhiDanhSachHinhXuongFile);
            Console.WriteLine("{0}. Xuất kết quả ra bảng tổng hợp thông tin", (int)ChucNangHinhHoc.XuatKetQua);
            Console.WriteLine("{0}. In nội dung của bảng tổng hợp thông tin xuống file", (int)ChucNangHinhHoc.LuuKetQuaXuongFile);
            Console.WriteLine("{0}. In nội dung của bảng tổng hợp thông tin ra máy in", (int)ChucNangHinhHoc.InKetQua);
            Console.WriteLine("==================================================");
        }

        private ChucNangHinhHoc Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangHinhHoc)).Length;

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

            return (ChucNangHinhHoc)menu;
        }

        private void Process(ChucNangHinhHoc menu)
        {
            switch (menu)
            {
                case ChucNangHinhHoc.Thoat:
                    Console.WriteLine("Kết thúc chương trình!");
                    break;
                case ChucNangHinhHoc.NhapTuFile:
                    //...
                    break;
                case ChucNangHinhHoc.Xuat:
                    //...
                    break;
                case ChucNangHinhHoc.TimKiem:
                    MenuTimKiemHinhHoc menuTimKiem = new MenuTimKiemHinhHoc();
                    menuTimKiem.Run();
                    break;
                case ChucNangHinhHoc.SapXep:
                    MenuSapXepHinhHoc menuSapXep = new MenuSapXepHinhHoc();
                    menuSapXep.Run();
                    break;

                case ChucNangHinhHoc.TinhTong:
                    MenuTinhTongHinhHoc menuTinhTong = new MenuTinhTongHinhHoc();
                    menuTinhTong.Run();
                    break;
                case ChucNangHinhHoc.Dem:
                    MenuDemHinhHoc menuDem = new MenuDemHinhHoc();
                    menuDem.Run();
                    break;

                case ChucNangHinhHoc.HienThi:
                    MenuHienThiHinhHoc menuThem = new MenuHienThiHinhHoc();
                    menuHienThi.Run();
                    break;
                case ChucNangHinhHoc.Xoa:
                    MenuXoaHinhHoc menuXoa = new MenuXoaHinhHoc();
                    menuXoa.Run();
                    break;
                case ChucNangHinhHoc.ThemHinhTaiViTri:
                    //...
                    break;
                case ChucNangHinhHoc.GhiDanhSachHinhXuongFile:
                    //...
                    break;
                case ChucNangHinhHoc.XuatKetQua:
                    //...
                    break;
                case ChucNangHinhHoc.LuuKetQuaXuongFile:
                    //...
                    break;
                case ChucNangHinhHoc.InKetQua:
                    //...
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangHinhHoc menu = ChucNangHinhHoc.Thoat;
            do
            {
                menu = this.Select();
                if (menu != ChucNangHinhHoc.Thoat)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangHinhHoc.Thoat);
        }
    }
}
