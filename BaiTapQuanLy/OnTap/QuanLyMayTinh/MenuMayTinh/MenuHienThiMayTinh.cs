using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    public class MenuHienThiMayTinh
    {
        private DanhSachMayTinh mayTinh;

        public MenuHienThiMayTinh()
        {
            mayTinh = new DanhSachMayTinh();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("================= MENU HIỂN THỊ ==================");
            Console.WriteLine("{0}. Tìm máy tính có giá cao nhất.", (int)ChucNangHienThiMayTinh.HienThiTheoHangSX);
            Console.WriteLine("{0}. Truy vấn giá cao nhất trong danh sách.", (int)ChucNangHienThiMayTinh.HienThiTheoTocDoCPU);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangHienThiMayTinh.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangHienThiMayTinh Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangHienThiMayTinh)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu hiển thị (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangHienThiMayTinh)menu;
        }

        private void Process(ChucNangHienThiMayTinh menu)
        {
            switch (menu)
            {
                case ChucNangHienThiMayTinh.Thoat:
                    Console.WriteLine("Kết thúc chương trình hiển thị!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangHienThiMayTinh.HienThiTheoHangSX:
                    mayTinh.HienThiTheoHangSX();
                    break;
                case ChucNangHienThiMayTinh.HienThiTheoTocDoCPU:
                    mayTinh.HienThiTheoTocDoCPU();
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangHienThiMayTinh menu = ChucNangHienThiMayTinh.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangHienThiMayTinh.Thoat);
        }
    }
}
