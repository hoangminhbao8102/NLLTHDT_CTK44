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
                    Console.Write("Nhập tên tập tin dữ liệu: ");
                    string filename = Console.ReadLine();
                    hinhHoc.NhapTuFile(filename);
                    Console.WriteLine("Dữ liệu đã được nhập thành công từ file.");
                    break;
                case ChucNangHinhHoc.Xuat:
                    Console.WriteLine("Danh sách hình học:");
                    Console.WriteLine(hinhHoc);
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
                    MenuHienThiHinhHoc menuHienThi = new MenuHienThiHinhHoc();
                    menuHienThi.Run();
                    break;
                case ChucNangHinhHoc.Xoa:
                    MenuXoaHinhHoc menuXoa = new MenuXoaHinhHoc();
                    menuXoa.Run();
                    break;
                case ChucNangHinhHoc.ThemHinhTaiViTri:
                    Console.Write("Nhập vị trí để thêm hình: ");
                    int viTri = int.Parse(Console.ReadLine());
                    Console.WriteLine("Chọn loại hình để thêm (1: Hình Tròn, 2: Hình Vuông, 3: Hình Chữ Nhật): ");
                    int loaiHinh = int.Parse(Console.ReadLine());
                    HinhHoc hh = null;
                    switch (loaiHinh)
                    {
                        case 1:
                            Console.Write("Nhập bán kính hình tròn: ");
                            float r = float.Parse(Console.ReadLine());
                            hh = new HinhTron(r);
                            break;
                        case 2:
                            Console.Write("Nhập cạnh hình vuông: ");
                            float a = float.Parse(Console.ReadLine());
                            hh = new HinhVuong(a);
                            break;
                        case 3:
                            Console.Write("Nhập chiều dài và chiều rộng hình chữ nhật: ");
                            float l = float.Parse(Console.ReadLine());
                            float w = float.Parse(Console.ReadLine());
                            hh = new HinhChuNhat(l, w);
                            break;
                    }
                    if (hh != null)
                    {
                        hinhHoc.ThemHinhTaiViTri(viTri, hh);
                        Console.WriteLine("Hình đã được thêm thành công.");
                    }
                    break;
                case ChucNangHinhHoc.GhiDanhSachHinhXuongFile:
                    hinhHoc.GhiDanhSachHinhXuongFile();
                    Console.WriteLine("Dữ liệu đã được ghi xuống file.");
                    break;
                case ChucNangHinhHoc.XuatKetQua:
                    hinhHoc.XuatKetQua();
                    break;
                case ChucNangHinhHoc.LuuKetQuaXuongFile:
                    Console.Write("Nhập tên file để lưu kết quả: ");
                    string saveFilename = Console.ReadLine();
                    hinhHoc.LuuKetQuaXuongFile(saveFilename);
                    Console.WriteLine("Kết quả đã được lưu vào file.");
                    break;
                case ChucNangHinhHoc.InKetQua:
                    hinhHoc.InKetQua();
                    Console.WriteLine("Kết quả đã được in ra máy in.");
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
