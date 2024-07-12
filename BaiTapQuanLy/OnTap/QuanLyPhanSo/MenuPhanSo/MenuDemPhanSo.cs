using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class MenuDemPhanSo
    {
        private MangPhanSo mangPhanSo;

        public MenuDemPhanSo()
        {
            mangPhanSo = new MangPhanSo();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("=================== MENU ĐẾM =====================");
            Console.WriteLine("{0}. Đếm số lượng phân số âm.", (int)ChucNangDemPhanSo.DemPhanSoAm);
            Console.WriteLine("{0}. Đếm số lượng phân số dương.", (int)ChucNangDemPhanSo.DemPhanSoDuong);
            Console.WriteLine("{0}. Đếm số lượng phân số có tử là x.", (int)ChucNangDemPhanSo.DemPhanSoCoTuLa);
            Console.WriteLine("{0}. Đếm số lượng phân số có mẫu là x.", (int)ChucNangDemPhanSo.DemPhanSoCoMauLa);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangDemPhanSo.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangDemPhanSo Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangDemPhanSo)).Length;

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

            return (ChucNangDemPhanSo)menu;
        }

        private void Process(ChucNangDemPhanSo menu)
        {
            switch (menu)
            {
                case ChucNangDemPhanSo.Thoat:
                    Console.WriteLine("Kết thúc chương trình đếm!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangDemPhanSo.DemPhanSoAm:
                    int soLuongAm = mangPhanSo.DemPhanSoAm();
                    Console.WriteLine("Số lượng phân số âm trong mảng: {0}", soLuongAm);
                    break;
                case ChucNangDemPhanSo.DemPhanSoDuong:
                    int soLuongDuong = mangPhanSo.DemPhanSoDuong();
                    Console.WriteLine("Số lượng phân số dương trong mảng: {0}", soLuongDuong);
                    break;
                case ChucNangDemPhanSo.DemPhanSoCoTuLa:
                    Console.Write("Nhập tử số cần đếm: ");
                    int tu = int.Parse(Console.ReadLine());
                    int soLuongCoTu = mangPhanSo.DemPhanSoCoTuLa(tu);
                    Console.WriteLine("Số lượng phân số có tử số {0} trong mảng: {1}", tu, soLuongCoTu);
                    break;
                case ChucNangDemPhanSo.DemPhanSoCoMauLa:
                    Console.Write("Nhập mẫu số cần đếm: ");
                    int mau = int.Parse(Console.ReadLine());
                    int soLuongCoMau = mangPhanSo.DemPhanSoCoMauLa(mau);
                    Console.WriteLine("Số lượng phân số có mẫu số {0} trong mảng: {1}", mau, soLuongCoMau);
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangDemPhanSo menu = ChucNangDemPhanSo.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangDemPhanSo.Thoat);
        }
    }
}
