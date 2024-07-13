using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class MenuTinhTongHinhHoc
    {
        private DanhSachHinhHoc hinhHoc;

        public MenuTinhTongHinhHoc()
        {
            hinhHoc = new DanhSachHinhHoc();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("================= MENU TÍNH TỔNG ==================");
            Console.WriteLine("{0}. Tính tổng diện tích của tất cả các hình.", (int)ChucNangTinhTongHinhHoc.TongDienTichTatCaHinh);
            Console.WriteLine("{0}. Tính tổng chu vi của tất cả các hình.", (int)ChucNangTinhTongHinhHoc.TongChuViTatCaHinh);
            Console.WriteLine("{0}. Tính tổng diện tích của các hình vuông.", (int)ChucNangTinhTongHinhHoc.TongDienTichHinhVuong);
            Console.WriteLine("{0}. Tính tổng chu vi của các hình vuông.", (int)ChucNangTinhTongHinhHoc.TongChuViHinhVuong);
            Console.WriteLine("{0}. Tính tổng diện tích của các hình tròn.", (int)ChucNangTinhTongHinhHoc.TongDienTichHinhTron);
            Console.WriteLine("{0}. Tính tổng chu vi của các hình tròn.", (int)ChucNangTinhTongHinhHoc.TongChuViHinhTron);
            Console.WriteLine("{0}. Tính tổng diện tích của các hình chữ nhật.", (int)ChucNangTinhTongHinhHoc.TongDienTichHinhChuNhat);
            Console.WriteLine("{0}. Tính tổng chu vi của các hình chữ nhật.", (int)ChucNangTinhTongHinhHoc.TongChuViHinhChuNhat);
            Console.WriteLine("{0}. Thoát", (int)ChucNangTinhTongHinhHoc.Thoat);
            Console.WriteLine("===================================================");
        }

        private ChucNangTinhTongHinhHoc Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangTinhTongHinhHoc)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu tính tổng (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangTinhTongHinhHoc)menu;
        }

        private void Process(ChucNangTinhTongHinhHoc menu)
        {
            switch (menu)
            {
                case ChucNangTinhTongHinhHoc.Thoat:
                    Console.WriteLine("Kết thúc chương trình tính tổng!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangTinhTongHinhHoc.TongDienTichTatCaHinh:
                    Console.WriteLine("Tổng diện tích của tất cả các hình là: " + hinhHoc.TongDienTichTatCaHinh() + " đơn vị.");
                    break;
                case ChucNangTinhTongHinhHoc.TongChuViTatCaHinh:
                    Console.WriteLine("Tổng chu vi của tất cả các hình là: " + hinhHoc.TongChuViTatCaHinh() + " đơn vị.");
                    break;
                case ChucNangTinhTongHinhHoc.TongDienTichHinhVuong:
                    Console.WriteLine("Tổng diện tích của các hình vuông là: " + hinhHoc.TongDienTichHinhVuong() + " đơn vị.");
                    break;
                case ChucNangTinhTongHinhHoc.TongChuViHinhVuong:
                    Console.WriteLine("Tổng chu vi của các hình vuông là: " + hinhHoc.TongChuViHinhVuong() + " đơn vị.");
                    break;
                case ChucNangTinhTongHinhHoc.TongDienTichHinhTron:
                    Console.WriteLine("Tổng diện tích của các hình tròn là: " + hinhHoc.TongDienTichHinhTron() + " đơn vị.");
                    break;
                case ChucNangTinhTongHinhHoc.TongChuViHinhTron:
                    Console.WriteLine("Tổng chu vi của các hình tròn là: " + hinhHoc.TongChuViHinhTron() + " đơn vị.");
                    break;
                case ChucNangTinhTongHinhHoc.TongDienTichHinhChuNhat:
                    Console.WriteLine("Tổng diện tích của các hình chữ nhật là: " + hinhHoc.TongDienTichHinhChuNhat() + " đơn vị.");
                    break;
                case ChucNangTinhTongHinhHoc.TongChuViHinhChuNhat:
                    Console.WriteLine("Tổng chu vi của các hình chữ nhật là: " + hinhHoc.TongChuViHinhChuNhat() + " đơn vị.");
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangTinhTongHinhHoc menu = ChucNangTinhTongHinhHoc.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangTinhTongHinhHoc.Thoat);
        }
    }
}
