using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class MenuDanhBa
    {
        private DanhBa danhBa;

        public MenuDanhBa()
        {
            danhBa = new DanhBa();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Nhập dữ liệu từ file.", (int)ChucNangDanhBa.NhapTuFile);
            Console.WriteLine("{0}. Xuất dữ liệu danh sách các danh bạ.", (int)ChucNangDanhBa.Xuat);
            Console.WriteLine("{0}. Tìm kiếm danh bạ.", (int)ChucNangDanhBa.TimKiem);
            Console.WriteLine("{0}. Sắp xếp danh bạ.", (int)ChucNangDanhBa.SapXep);
            Console.WriteLine("{0}. Xóa danh bạ.", (int)ChucNangDanhBa.Xoa);
            Console.WriteLine("{0}. Hiển thị thông tin danh bạ.", (int)ChucNangDanhBa.HienThiThongTin);
            Console.WriteLine("{0}. Tặng số điện thoại mới cho các khách hàng sinh vào tháng 1.", (int)ChucNangDanhBa.TangSoDienThoaiChoSinhThang1);
            Console.WriteLine("{0}. Thống kê và hiển thị số lượng thuê bao theo tỉnh và thành phố.", (int)ChucNangDanhBa.ThongKeTheoTinhVaThanhPho);
            Console.WriteLine("==================================================");
        }

        private ChucNangDanhBa Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangDanhBa)).Length;

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

            return (ChucNangDanhBa)menu;
        }

        private void Process(ChucNangDanhBa menu)
        {
            switch (menu)
            {
                case ChucNangDanhBa.Thoat:
                    Console.WriteLine("Kết thúc chương trình!");
                    break;
                case ChucNangDanhBa.NhapTuFile:
                    Console.Write("Nhập đường dẫn tới file: ");
                    string path = Console.ReadLine();
                    danhBa.NhapTuFile(path);
                    Console.WriteLine("Dữ liệu đã được nhập thành công.");
                    break;
                case ChucNangDanhBa.Xuat:
                    Console.WriteLine("Danh sách các thuê bao:");
                    Console.WriteLine(danhBa);
                    break;
                case ChucNangDanhBa.TimKiem:
                    MenuTimKiemDanhBa menuTimKiem = new MenuTimKiemDanhBa();
                    menuTimKiem.Run();
                    break;
                case ChucNangDanhBa.SapXep:
                    MenuSapXepDanhBa menuSapXep = new MenuSapXepDanhBa();
                    menuSapXep.Run();
                    break;
                case ChucNangDanhBa.Xoa:
                    MenuXoaDanhBa menuXoa = new MenuXoaDanhBa();
                    menuXoa.Run();
                    break;
                case ChucNangDanhBa.HienThiThongTin:
                    MenuHienThiThongTinDanhBa menuHienThiThongTin = new MenuHienThiThongTinDanhBa();
                    menuHienThiThongTin.Run();
                    break;
                case ChucNangDanhBa.TangSoDienThoaiChoSinhThang1:
                    danhBa.TangSoDienThoaiChoSinhThang1();
                    Console.WriteLine("Đã tặng số mới cho khách hàng sinh vào tháng 1.");
                    break;
                case ChucNangDanhBa.ThongKeTheoTinhVaThanhPho:
                    danhBa.ThongKeTheoTinhVaThanhPho();
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangDanhBa menu = ChucNangDanhBa.Thoat;
            do
            {
                menu = this.Select();
                if (menu != ChucNangDanhBa.Thoat)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangDanhBa.Thoat);
        }
    }
}
