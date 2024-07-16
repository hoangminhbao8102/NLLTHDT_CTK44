using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    public class MenuMayTinh
    {
        private DanhSachMayTinh mayTinh;

        public MenuMayTinh()
        {
            mayTinh = new DanhSachMayTinh();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Nhập dữ liệu từ file.", (int)ChucNangMayTinh.NhapTuFile);
            Console.WriteLine("{0}. Xuất dữ liệu danh sách các máy tính.", (int)ChucNangMayTinh.Xuat);
            Console.WriteLine("{0}. Thêm máy tính vào danh sách.", (int)ChucNangMayTinh.Them);
            Console.WriteLine("{0}. Đếm số lượng thiết bị theo hãng.", (int)ChucNangMayTinh.Dem);
            Console.WriteLine("{0}. Tìm kiếm các máy tính có trong danh sách.", (int)ChucNangMayTinh.TimKiem);
            Console.WriteLine("{0}. Sắp xếp các máy tính có trong danh sách.", (int)ChucNangMayTinh.SapXep);
            Console.WriteLine("{0}. Hiển thị thông tin máy tính có trong danh sách.", (int)ChucNangMayTinh.HienThi);
            Console.WriteLine("{0}. Cập nhật thông tin máy tính có trong danh sách.", (int)ChucNangMayTinh.CapNhat);
            Console.WriteLine("{0}. Xóa các máy tính có trong danh sách.", (int)ChucNangMayTinh.Xoa);
            Console.WriteLine("{0}. Lưu dữ liệu vào file.", (int)ChucNangMayTinh.LuuDuLieu);
            Console.WriteLine("==================================================");
        }

        private ChucNangMayTinh Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangMayTinh)).Length;

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

            return (ChucNangMayTinh)menu;
        }

        private void Process(ChucNangMayTinh menu)
        {
            switch (menu)
            {
                case ChucNangMayTinh.Thoat:
                    Console.WriteLine("Kết thúc chương trình!");
                    break;
                case ChucNangMayTinh.NhapTuFile:
                    Console.Write("Nhập đường dẫn tệp tin: ");
                    string filePath = Console.ReadLine();
                    mayTinh.NhapTuFile(filePath);
                    Console.WriteLine("Dữ liệu đã được nhập thành công từ file.");
                    break;
                case ChucNangMayTinh.Xuat:
                    Console.WriteLine("Danh sách máy tính:");
                    Console.WriteLine(mayTinh.ToString());
                    break;
                case ChucNangMayTinh.Them:
                    MenuThemMayTinh menuThem = new MenuThemMayTinh();
                    menuThem.Run();
                    break;
                case ChucNangMayTinh.Dem:
                    Console.Write("Nhập hãng để đếm thiết bị: ");
                    string hang = Console.ReadLine();
                    int count = mayTinh.DemThietBiTheoHang(hang);
                    Console.WriteLine($"Số lượng thiết bị của hãng {hang}: {count}");
                    break;
                case ChucNangMayTinh.TimKiem:
                    MenuTimKiemMayTinh menuTimKiem = new MenuTimKiemMayTinh();
                    menuTimKiem.Run();
                    break;
                case ChucNangMayTinh.SapXep:
                    MenuSapXepMayTinh menuSapXep = new MenuSapXepMayTinh();
                    menuSapXep.Run();
                    break;
                case ChucNangMayTinh.HienThi:
                    MenuHienThiMayTinh menuHienThi = new MenuHienThiMayTinh();
                    menuHienThi.Run();
                    break;
                case ChucNangMayTinh.CapNhat:
                    MenuCapNhatMayTinh menuCapNhat = new MenuCapNhatMayTinh();
                    menuCapNhat.Run();
                    break;
                case ChucNangMayTinh.Xoa:
                    MenuXoaMayTinh menuXoa = new MenuXoaMayTinh();
                    menuXoa.Run();
                    break;
                case ChucNangMayTinh.LuuDuLieu:
                    Console.Write("Nhập đường dẫn tệp tin để lưu dữ liệu: ");
                    string savePath = Console.ReadLine();
                    mayTinh.LuuDuLieu(savePath);
                    Console.WriteLine("Dữ liệu đã được lưu thành công.");
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangMayTinh menu = ChucNangMayTinh.Thoat;
            do
            {
                menu = this.Select();
                if (menu != ChucNangMayTinh.Thoat)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangMayTinh.Thoat);
        }
    }
}
