using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    public class MenuThemMayTinh
    {
        private DanhSachMayTinh mayTinh;

        public MenuThemMayTinh() 
        {
            mayTinh = new DanhSachMayTinh();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("=================== MENU THÊM ====================");
            Console.WriteLine("{0}. Thêm một máy tính vào danh sách.", (int)ChucNangThemMayTinh.Them);
            Console.WriteLine("{0}. Thêm danh sách hãng vào danh sách tổng.", (int)ChucNangThemMayTinh.ThemDanhSachHang);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangThemMayTinh.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangThemMayTinh Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangThemMayTinh)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu thêm (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangThemMayTinh)menu;
        }

        private void Process(ChucNangThemMayTinh menu)
        {
            switch (menu)
            {
                case ChucNangThemMayTinh.Thoat:
                    Console.WriteLine("Kết thúc chương trình thêm!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangThemMayTinh.Them:
                    mayTinh.ThemMayTinh();
                    break;
                case ChucNangThemMayTinh.ThemDanhSachHang:
                    mayTinh.ThemDanhSachHang();
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangThemMayTinh menu = ChucNangThemMayTinh.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangThemMayTinh.Thoat);
        }
    }
}
