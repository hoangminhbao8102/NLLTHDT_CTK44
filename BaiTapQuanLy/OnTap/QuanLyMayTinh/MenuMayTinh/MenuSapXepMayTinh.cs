using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    public class MenuSapXepMayTinh
    {
        private DanhSachMayTinh mayTinh;

        public MenuSapXepMayTinh()
        {
            mayTinh = new DanhSachMayTinh();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("================== MENU SẮP XẾP ==================");
            Console.WriteLine("{0}. Sắp xếp danh sách máy tính theo số lượng thiết bị.", (int)ChucNangSapXepMayTinh.SapXepTheoSoLuongThietBi);
            Console.WriteLine("{0}. Sắp xếp danh sách máy tính theo giá thiết bị.", (int)ChucNangSapXepMayTinh.SapXepTheoGiaThietBi);
            Console.WriteLine("{0}. Sắp xếp danh sách máy tính theo giá CPU.", (int)ChucNangSapXepMayTinh.SapXepTheoGiaCPU);
            Console.WriteLine("{0}. Sắp xếp danh sách máy tính theo giá RAM.", (int)ChucNangSapXepMayTinh.SapXepTheoGiaRAM);
            Console.WriteLine("{0}. Sắp xếp danh sách máy tính theo số lượng CPU.", (int)ChucNangSapXepMayTinh.SapXepTheoSoLuongCPU);
            Console.WriteLine("{0}. Sắp xếp danh sách máy tính theo số lượng RAM.", (int)ChucNangSapXepMayTinh.SapXepTheoSoLuongRAM);
            Console.WriteLine("{0}. Sắp xếp danh sách máy tính theo dung lượng RAM.", (int)ChucNangSapXepMayTinh.SapXepTheoDungLuongRAM);
            Console.WriteLine("{0}. Sắp xếp danh sách máy tính theo tốc độ CPU.", (int)ChucNangSapXepMayTinh.SapXepTheoTocDoCPU);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangSapXepMayTinh.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangSapXepMayTinh Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangSapXepMayTinh)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu sắp xếp (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangSapXepMayTinh)menu;
        }

        private void Process(ChucNangSapXepMayTinh menu)
        {
            switch (menu)
            {
                case ChucNangSapXepMayTinh.Thoat:
                    Console.WriteLine("Kết thúc chương trình sắp xếp!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangSapXepMayTinh.SapXepTheoSoLuongThietBi:
                    mayTinh.SapXepTheoSoLuongThietBi();
                    Console.WriteLine("Danh sách máy tính đã được sắp xếp theo số lượng thiết bị.");
                    Console.WriteLine(mayTinh);
                    break;
                case ChucNangSapXepMayTinh.SapXepTheoGiaThietBi:
                    mayTinh.SapXepTheoGiaThietBi();
                    Console.WriteLine("Danh sách máy tính đã được sắp xếp theo giá thiết bị.");
                    Console.WriteLine(mayTinh);
                    break;
                case ChucNangSapXepMayTinh.SapXepTheoGiaCPU:
                    mayTinh.SapXepTheoGiaCPU();
                    Console.WriteLine("Danh sách máy tính đã được sắp xếp theo giá CPU.");
                    Console.WriteLine(mayTinh);
                    break;
                case ChucNangSapXepMayTinh.SapXepTheoGiaRAM:
                    mayTinh.SapXepTheoGiaRAM();
                    Console.WriteLine("Danh sách máy tính đã được sắp xếp theo giá RAM.");
                    Console.WriteLine(mayTinh);
                    break;
                case ChucNangSapXepMayTinh.SapXepTheoSoLuongCPU:
                    mayTinh.SapXepTheoSoLuongCPU();
                    Console.WriteLine("Danh sách máy tính đã được sắp xếp theo số lượng CPU.");
                    Console.WriteLine(mayTinh);
                    break;
                case ChucNangSapXepMayTinh.SapXepTheoSoLuongRAM:
                    mayTinh.SapXepTheoSoLuongRAM();
                    Console.WriteLine("Danh sách máy tính đã được sắp xếp theo số lượng RAM.");
                    Console.WriteLine(mayTinh);
                    break;
                case ChucNangSapXepMayTinh.SapXepTheoDungLuongRAM:
                    mayTinh.SapXepTheoDungLuongRAM(true); // Giả sử bạn cần sắp xếp tăng dần
                    Console.WriteLine("Danh sách máy tính đã được sắp xếp theo dung lượng RAM.");
                    Console.WriteLine(mayTinh);
                    break;
                case ChucNangSapXepMayTinh.SapXepTheoTocDoCPU:
                    mayTinh.SapXepTheoTocDoCPU(true); // Giả sử bạn cần sắp xếp tăng dần
                    Console.WriteLine("Danh sách máy tính đã được sắp xếp theo tốc độ CPU.");
                    Console.WriteLine(mayTinh);
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangSapXepMayTinh menu = ChucNangSapXepMayTinh.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangSapXepMayTinh.Thoat);
        }
    }
}
