using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class MenuTinhToanPhanSo
    {
        private MangPhanSo mangPhanSo;

        public MenuTinhToanPhanSo()
        {
            mangPhanSo = new MangPhanSo();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("================= MENU TÍNH TOÁN ==================");
            Console.WriteLine("{0}. Tính tổng các phân số âm.", (int)ChucNangTinhToanPhanSo.TinhTongTatCaPhanSoAm);
            Console.WriteLine("{0}. Tính tổng các phân số dương.", (int)ChucNangTinhToanPhanSo.TinhTongTatCaPhanSoDuong);
            Console.WriteLine("{0}. Tính tổng các phân số có tử là x.", (int)ChucNangTinhToanPhanSo.TinhTongTatCaPhanSoCoTuLa);
            Console.WriteLine("{0}. Tính tổng các phân số có mẫu là x.", (int)ChucNangTinhToanPhanSo.TinhTongTatCaPhanSoCoMauLa);
            Console.WriteLine("{0}. Thoát", (int)ChucNangTinhToanPhanSo.Thoat);
            Console.WriteLine("===================================================");
        }

        private ChucNangTinhToanPhanSo Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangTinhToanPhanSo)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu tính toán (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangTinhToanPhanSo)menu;
        }

        private void Process(ChucNangTinhToanPhanSo menu)
        {
            switch (menu)
            {
                case ChucNangTinhToanPhanSo.Thoat:
                    Console.WriteLine("Kết thúc chương trình tính toán!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangTinhToanPhanSo.TinhTongTatCaPhanSoAm:
                    int tongAm = mangPhanSo.TinhTongTatCaPhanSoAm();
                    Console.WriteLine("Tổng các phân số âm trong mảng là: {0}", tongAm);
                    break;
                case ChucNangTinhToanPhanSo.TinhTongTatCaPhanSoDuong:
                    int tongDuong = mangPhanSo.TinhTongTatCaPhanSoDuong();
                    Console.WriteLine("Tổng các phân số dương trong mảng là: {0}", tongDuong);
                    break;
                case ChucNangTinhToanPhanSo.TinhTongTatCaPhanSoCoTuLa:
                    Console.Write("Nhập tử số của các phân số để tính tổng: ");
                    int tu = int.Parse(Console.ReadLine());
                    int tongTu = mangPhanSo.TinhTongTatCaPhanSoCoTuLa(tu);
                    Console.WriteLine("Tổng các phân số có tử số {0} trong mảng là: {1}", tu, tongTu);
                    break;
                case ChucNangTinhToanPhanSo.TinhTongTatCaPhanSoCoMauLa:
                    Console.Write("Nhập mẫu số của các phân số để tính tổng: ");
                    int mau = int.Parse(Console.ReadLine());
                    int tongMau = mangPhanSo.TinhTongTatCaPhanSoCoMauLa(mau);
                    Console.WriteLine("Tổng các phân số có mẫu số {0} trong mảng là: {1}", mau, tongMau);
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangTinhToanPhanSo menu = ChucNangTinhToanPhanSo.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangTinhToanPhanSo.Thoat);
        }
    }
}
