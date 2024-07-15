using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class MenuXoaHinhHoc
    {
        private DanhSachHinhHoc hinhHoc;

        public MenuXoaHinhHoc()
        {
            hinhHoc = new DanhSachHinhHoc();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("=================== MENU XÓA =====================");
            Console.WriteLine("{0}. Xóa các hình có diện tích nhỏ nhất.", (int)ChucNangXoaHinhHoc.XoaHinhCoDienTichNhoNhat);
            Console.WriteLine("{0}. Xóa các hình có diện tích lớn nhất.", (int)ChucNangXoaHinhHoc.XoaHinhCoDienTichLonNhat);
            Console.WriteLine("{0}. Xóa các hình có chu vi nhỏ nhất.", (int)ChucNangXoaHinhHoc.XoaHinhCoChuViNhoNhat);
            Console.WriteLine("{0}. Xóa các hình có chu vi lớn nhất.", (int)ChucNangXoaHinhHoc.XoaHinhCoChuViLonNhat);
            Console.WriteLine("{0}. Xóa hình tại vị trí x.", (int)ChucNangXoaHinhHoc.XoaHinhTaiViTri);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangXoaHinhHoc.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangXoaHinhHoc Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangXoaHinhHoc)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu xóa (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangXoaHinhHoc)menu;
        }

        private void Process(ChucNangXoaHinhHoc menu)
        {
            switch (menu)
            {
                case ChucNangXoaHinhHoc.Thoat:
                    Console.WriteLine("Kết thúc chương trình xóa!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangXoaHinhHoc.XoaHinhCoDienTichNhoNhat:
                    hinhHoc.XoaHinhCoDienTichNhoNhat();
                    Console.WriteLine("Đã xóa hình có diện tích nhỏ nhất.");
                    break;
                case ChucNangXoaHinhHoc.XoaHinhCoDienTichLonNhat:
                    hinhHoc.XoaHinhCoDienTichLonNhat();
                    Console.WriteLine("Đã xóa hình có diện tích lớn nhất.");
                    break;
                case ChucNangXoaHinhHoc.XoaHinhCoChuViNhoNhat:
                    hinhHoc.XoaHinhCoChuViNhoNhat();
                    Console.WriteLine("Đã xóa hình có chu vi nhỏ nhất.");
                    break;
                case ChucNangXoaHinhHoc.XoaHinhCoChuViLonNhat:
                    hinhHoc.XoaHinhCoChuViLonNhat();
                    Console.WriteLine("Đã xóa hình có chu vi lớn nhất.");
                    break;
                case ChucNangXoaHinhHoc.XoaHinhTaiViTri:
                    Console.Write("Nhập vị trí cần xóa: ");
                    int viTri;
                    if (int.TryParse(Console.ReadLine(), out viTri) && viTri >= 0 && viTri < hinhHoc.SoLuong())
                    {
                        hinhHoc.XoaHinhTaiViTri(viTri);
                        Console.WriteLine($"Đã xóa hình tại vị trí {viTri}.");
                    }
                    else
                    {
                        Console.WriteLine("Vị trí không hợp lệ.");
                    }
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangXoaHinhHoc menu = ChucNangXoaHinhHoc.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangXoaHinhHoc.Thoat);
        }
    }
}
