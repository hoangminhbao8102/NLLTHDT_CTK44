using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    public class MenuCapNhatMayTinh
    {
        private DanhSachMayTinh mayTinh;

        public MenuCapNhatMayTinh()
        {
            mayTinh = new DanhSachMayTinh();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("================= MENU CẬP NHẬT ==================");
            Console.WriteLine("{0}. Cập nhật giá CPU của Intel.", (int)ChucNangCapNhatMayTinh.CapNhatGiaCPUIntel);
            Console.WriteLine("{0}. Cập nhật dung lượng RAM.", (int)ChucNangCapNhatMayTinh.CapNhatDungLuongRAM);
            Console.WriteLine("{0}. Cập nhật tốc độ CPU.", (int)ChucNangCapNhatMayTinh.CapNhatTocDoCPU);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangCapNhatMayTinh.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangCapNhatMayTinh Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangCapNhatMayTinh)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu cập nhật (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangCapNhatMayTinh)menu;
        }

        private void Process(ChucNangCapNhatMayTinh menu)
        {
            switch (menu)
            {
                case ChucNangCapNhatMayTinh.Thoat:
                    Console.WriteLine("Kết thúc chương trình cập nhật!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangCapNhatMayTinh.CapNhatGiaCPUIntel:
                    mayTinh.CapNhatGiaCPUIntel();
                    Console.WriteLine("Đã cập nhật giá CPU của Intel thành 700.");
                    break;
                case ChucNangCapNhatMayTinh.CapNhatDungLuongRAM:
                    Console.Write("Nhập dung lượng RAM hiện tại: ");
                    float currentCapacity = float.Parse(Console.ReadLine());
                    Console.Write("Nhập dung lượng RAM mới: ");
                    float newCapacity = float.Parse(Console.ReadLine());
                    mayTinh.CapNhatDungLuongRAM(currentCapacity, newCapacity);
                    Console.WriteLine($"Đã cập nhật dung lượng RAM từ {currentCapacity} thành {newCapacity}.");
                    break;
                case ChucNangCapNhatMayTinh.CapNhatTocDoCPU:
                    Console.Write("Nhập tốc độ CPU hiện tại: ");
                    float currentSpeed = float.Parse(Console.ReadLine());
                    Console.Write("Nhập tốc độ CPU mới: ");
                    float newSpeed = float.Parse(Console.ReadLine());
                    mayTinh.CapNhatTocDoCPU(currentSpeed, newSpeed);
                    Console.WriteLine($"Đã cập nhật tốc độ CPU từ {currentSpeed} thành {newSpeed}.");
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangCapNhatMayTinh menu = ChucNangCapNhatMayTinh.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangCapNhatMayTinh.Thoat);
        }
    }
}
