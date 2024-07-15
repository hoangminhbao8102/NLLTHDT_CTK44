using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class MenuDemHinhHoc
    {
        private DanhSachHinhHoc hinhHoc;

        public MenuDemHinhHoc()
        {
            hinhHoc = new DanhSachHinhHoc();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("=================== MENU ĐẾM =====================");
            Console.WriteLine("{0}. Đếm số lượng hình vuông.", (int)ChucNangDemHinhHoc.DemSoLuongHinhVuong);
            Console.WriteLine("{0}. Đếm số lượng hình tròn.", (int)ChucNangDemHinhHoc.DemSoLuongHinhTron);
            Console.WriteLine("{0}. Đếm số lượng hình chữ nhật.", (int)ChucNangDemHinhHoc.DemSoLuongHinhChuNhat);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangDemHinhHoc.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangDemHinhHoc Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangDemHinhHoc)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu đếm (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangDemHinhHoc)menu;
        }

        private void Process(ChucNangDemHinhHoc menu)
        {
            switch (menu)
            {
                case ChucNangDemHinhHoc.Thoat:
                    Console.WriteLine("Kết thúc chương trình đếm!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangDemHinhHoc.DemSoLuongHinhVuong:
                    int countVuong = hinhHoc.DemSoLuongHinhVuong();
                    Console.WriteLine("Số lượng hình vuông là: " + countVuong);
                    break;
                case ChucNangDemHinhHoc.DemSoLuongHinhTron:
                    int countTron = hinhHoc.DemSoLuongHinhTron();
                    Console.WriteLine("Số lượng hình tròn là: " + countTron);
                    break;
                case ChucNangDemHinhHoc.DemSoLuongHinhChuNhat:
                    int countChuNhat = hinhHoc.DemSoLuongHinhChuNhat();
                    Console.WriteLine("Số lượng hình chữ nhật là: " + countChuNhat);
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangDemHinhHoc menu = ChucNangDemHinhHoc.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangDemHinhHoc.Thoat);
        }
    }
}
