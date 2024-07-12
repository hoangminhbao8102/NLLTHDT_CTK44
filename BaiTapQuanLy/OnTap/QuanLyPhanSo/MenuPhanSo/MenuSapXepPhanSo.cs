using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class MenuSapXepPhanSo
    {
        private MangPhanSo mangPhanSo;

        public MenuSapXepPhanSo()
        {
            mangPhanSo = new MangPhanSo();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("================== MENU SẮP XẾP ==================");
            Console.WriteLine("{0}. Sắp xếp các phân số theo giá trị tăng dần.", (int)ChucNangSapXepPhanSo.SapXepTang);
            Console.WriteLine("{0}. Sắp xếp các phân số theo giá trị giảm dần.", (int)ChucNangSapXepPhanSo.SapXepGiam);
            Console.WriteLine("{0}. Sắp xếp các phân số theo tử số tăng dần.", (int)ChucNangSapXepPhanSo.SapXepTangTheoTu);
            Console.WriteLine("{0}. Sắp xếp các phân số theo tử số giảm dần.", (int)ChucNangSapXepPhanSo.SapXepGiamTheoTu);
            Console.WriteLine("{0}. Sắp xếp các phân số theo mẫu số tăng dần.", (int)ChucNangSapXepPhanSo.SapXepTangTheoMau);
            Console.WriteLine("{0}. Sắp xếp các phân số theo mẫu số giảm dần.", (int)ChucNangSapXepPhanSo.SapXepGiamTheoMau);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangSapXepPhanSo.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangSapXepPhanSo Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangSapXepPhanSo)).Length;

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

            return (ChucNangSapXepPhanSo)menu;
        }

        private void Process(ChucNangSapXepPhanSo menu)
        {
            switch (menu)
            {
                case ChucNangSapXepPhanSo.Thoat:
                    Console.WriteLine("Kết thúc chương trình sắp xếp!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangSapXepPhanSo.SapXepTang:
                    mangPhanSo.SapXepTang();
                    Console.WriteLine("Đã sắp xếp các phân số theo giá trị tăng dần.");
                    mangPhanSo.Xuat();
                    break;
                case ChucNangSapXepPhanSo.SapXepGiam:
                    mangPhanSo.SapXepGiam();
                    Console.WriteLine("Đã sắp xếp các phân số theo giá trị giảm dần.");
                    mangPhanSo.Xuat();
                    break;
                case ChucNangSapXepPhanSo.SapXepTangTheoTu:
                    mangPhanSo.SapXepTangTheoTu();
                    Console.WriteLine("Đã sắp xếp các phân số theo tử số tăng dần.");
                    mangPhanSo.Xuat();
                    break;
                case ChucNangSapXepPhanSo.SapXepGiamTheoTu:
                    mangPhanSo.SapXepGiamTheoTu();
                    Console.WriteLine("Đã sắp xếp các phân số theo tử số giảm dần.");
                    mangPhanSo.Xuat();
                    break;
                case ChucNangSapXepPhanSo.SapXepTangTheoMau:
                    mangPhanSo.SapXepTangTheoMau();
                    Console.WriteLine("Đã sắp xếp các phân số theo mẫu số tăng dần.");
                    mangPhanSo.Xuat();
                    break;
                case ChucNangSapXepPhanSo.SapXepGiamTheoMau:
                    mangPhanSo.SapXepGiamTheoMau();
                    Console.WriteLine("Đã sắp xếp các phân số theo mẫu số giảm dần.");
                    mangPhanSo.Xuat();
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangSapXepPhanSo menu = ChucNangSapXepPhanSo.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangSapXepPhanSo.Thoat);
        }
    }
}
