using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class MenuThemPhanSo
    {
        private MangPhanSo mangPhanSo;

        public MenuThemPhanSo()
        {
            mangPhanSo = new MangPhanSo();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("=================== MENU THÊM ====================");
            Console.WriteLine("{0}. Thêm phân số vào cuối mảng", (int)ChucNangThemPhanSo.Them);
            Console.WriteLine("{0}. Thêm phân số tại vị trí chỉ định", (int)ChucNangThemPhanSo.ThemPhanSoTaiViTri);
            Console.WriteLine("{0}. Thêm phân số vào đầu mảng", (int)ChucNangThemPhanSo.ThemPhanSoDauTien);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangThemPhanSo.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangThemPhanSo Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangThemPhanSo)).Length;

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

            return (ChucNangThemPhanSo)menu;
        }

        private void Process(ChucNangThemPhanSo menu)
        {
            switch (menu)
            {
                case ChucNangThemPhanSo.Thoat:
                    Console.WriteLine("Kết thúc chương trình thêm!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangThemPhanSo.Them:
                    Console.WriteLine("Nhập phân số để thêm vào cuối mảng:");
                    PhanSo psThem = mangPhanSo.NhapPhanSo();
                    mangPhanSo.Them(psThem);
                    break;
                case ChucNangThemPhanSo.ThemPhanSoTaiViTri:
                    Console.WriteLine("Nhập phân số và vị trí để thêm:");
                    PhanSo psViTri = mangPhanSo.NhapPhanSo();
                    Console.Write("Nhập vị trí: ");
                    int viTri = int.Parse(Console.ReadLine());
                    mangPhanSo.ThemPhanSoTaiViTri(psViTri, viTri);
                    break;
                case ChucNangThemPhanSo.ThemPhanSoDauTien:
                    Console.WriteLine("Nhập phân số để thêm vào đầu mảng:");
                    PhanSo psDau = mangPhanSo.NhapPhanSo();
                    mangPhanSo.ThemPhanSoDauTien(psDau);
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangThemPhanSo menu = ChucNangThemPhanSo.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangThemPhanSo.Thoat);
        }
    }
}
