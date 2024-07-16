using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    public class MenuXoaMayTinh
    {
        private DanhSachMayTinh mayTinh;

        public MenuXoaMayTinh()
        {
            mayTinh = new DanhSachMayTinh();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("=================== MENU XÓA =====================");
            Console.WriteLine("{0}. Xóa máy tính theo hãng CPU.", (int)ChucNangXoaMayTinh.XoaMayTinhCoCPUHang);
            Console.WriteLine("{0}. Xóa máy tính theo dung lượng RAM.", (int)ChucNangXoaMayTinh.XoaMayTinhCoDungLuongRAM);
            Console.WriteLine("{0}. Xóa máy tính theo tốc độ CPU.", (int)ChucNangXoaMayTinh.XoaMayTinhCoCPUTocDo);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangXoaMayTinh.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangXoaMayTinh Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangXoaMayTinh)).Length;

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

            return (ChucNangXoaMayTinh)menu;
        }

        private void Process(ChucNangXoaMayTinh menu)
        {
            switch (menu)
            {
                case ChucNangXoaMayTinh.Thoat:
                    Console.WriteLine("Kết thúc chương trình xóa!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangXoaMayTinh.XoaMayTinhCoCPUHang:
                    Console.Write("Nhập hãng CPU cần xóa: ");
                    string hangCPU = Console.ReadLine();
                    mayTinh.XoaMayTinhCoCPUHang(hangCPU);
                    Console.WriteLine($"Đã xóa tất cả máy tính có CPU hãng {hangCPU}.");
                    break;
                case ChucNangXoaMayTinh.XoaMayTinhCoDungLuongRAM:
                    Console.Write("Nhập dung lượng RAM cần xóa: ");
                    float dungLuong = float.Parse(Console.ReadLine());
                    mayTinh.XoaMayTinhCoDungLuongRAM(dungLuong);
                    Console.WriteLine($"Đã xóa tất cả máy tính có dung lượng RAM là {dungLuong}.");
                    break;
                case ChucNangXoaMayTinh.XoaMayTinhCoCPUTocDo:
                    Console.Write("Nhập tốc độ CPU cần xóa: ");
                    float tocDo = float.Parse(Console.ReadLine());
                    mayTinh.XoaMayTinhCoCPUTocDo(tocDo);
                    Console.WriteLine($"Đã xóa tất cả máy tính có tốc độ CPU là {tocDo}.");
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangXoaMayTinh menu = ChucNangXoaMayTinh.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangXoaMayTinh.Thoat);
        }
    }
}
