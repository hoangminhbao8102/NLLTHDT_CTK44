using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class MenuXoaPhanSo
    {
        private MangPhanSo mangPhanSo;

        public MenuXoaPhanSo()
        {
            mangPhanSo = new MangPhanSo();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("=================== MENU XÓA =====================");
            Console.WriteLine("{0}. Xóa phân số tại vị trí chỉ định.", (int)ChucNangXoaPhanSo.XoaPhanSoTaiViTri);
            Console.WriteLine("{0}. Xóa phân số đầu tiên trong mảng.", (int)ChucNangXoaPhanSo.XoaPhanSoDauTien);
            Console.WriteLine("{0}. Xóa phân số cuối cùng trong mảng.", (int)ChucNangXoaPhanSo.XoaPhanSoCuoiCung);
            Console.WriteLine("{0}. Xóa phân số có tử và mẫu chỉ định.", (int)ChucNangXoaPhanSo.XoaPhanSoX);
            Console.WriteLine("{0}. Xóa tất cả các phân số có tử là x.", (int)ChucNangXoaPhanSo.XoaPhanSoCoTuLa);
            Console.WriteLine("{0}. Xóa tất cả các phân số có mẫu là x.", (int)ChucNangXoaPhanSo.XoaPhanSoCoMauLa);
            Console.WriteLine("{0}. Xóa tất cả các phân số giống với phân số đầu tiên.", (int)ChucNangXoaPhanSo.XoaPhanSoGiongPhanSoDauTien);
            Console.WriteLine("{0}. Xóa tất cả các phân số giống với phân số cuối cùng.", (int)ChucNangXoaPhanSo.XoaPhanSoGiongPhanSoCuoiCung);
            Console.WriteLine("{0}. Xóa tất cả các phân số nhỏ nhất trong mảng.", (int)ChucNangXoaPhanSo.XoaTatCaPhanSoNhoNhat);
            Console.WriteLine("{0}. Xóa các phân số tại vị trí được chỉ định.", (int)ChucNangXoaPhanSo.XoaTaiCacViTri);
            Console.WriteLine("{0}. Xóa tất cả các phân số âm trong mảng.", (int)ChucNangXoaPhanSo.XoaTatCaPhanSoAm);
            Console.WriteLine("{0}. Xóa tất cả các phân số dương trong mảng.", (int)ChucNangXoaPhanSo.XoaTatCaPhanSoDuong);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangXoaPhanSo.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangXoaPhanSo Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangXoaPhanSo)).Length;

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

            return (ChucNangXoaPhanSo)menu;
        }

        private void Process(ChucNangXoaPhanSo menu)
        {
            switch (menu)
            {
                case ChucNangXoaPhanSo.Thoat:
                    Console.WriteLine("Kết thúc chương trình xóa!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangXoaPhanSo.XoaPhanSoTaiViTri:
                    Console.Write("Nhập vị trí cần xóa: ");
                    int vt = int.Parse(Console.ReadLine());
                    mangPhanSo.XoaPhanSoTaiViTri(vt);
                    break;
                case ChucNangXoaPhanSo.XoaPhanSoDauTien:
                    mangPhanSo.XoaPhanSoDauTien();
                    break;
                case ChucNangXoaPhanSo.XoaPhanSoCuoiCung:
                    mangPhanSo.XoaPhanSoCuoiCung();
                    break;
                case ChucNangXoaPhanSo.XoaPhanSoX:
                    Console.Write("Nhập tử số của phân số cần xóa: ");
                    int tuX = int.Parse(Console.ReadLine());
                    Console.Write("Nhập mẫu số của phân số cần xóa: ");
                    int mauX = int.Parse(Console.ReadLine());
                    mangPhanSo.XoaPhanSoX(tuX, mauX);
                    break;
                case ChucNangXoaPhanSo.XoaPhanSoCoTuLa:
                    Console.Write("Nhập tử số của các phân số cần xóa: ");
                    int tu = int.Parse(Console.ReadLine());
                    mangPhanSo.XoaPhanSoCoTuLa(tu);
                    break;
                case ChucNangXoaPhanSo.XoaPhanSoCoMauLa:
                    Console.Write("Nhập mẫu số của các phân số cần xóa: ");
                    int mau = int.Parse(Console.ReadLine());
                    mangPhanSo.XoaPhanSoCoMauLa(mau);
                    break;
                case ChucNangXoaPhanSo.XoaPhanSoGiongPhanSoDauTien:
                    mangPhanSo.XoaPhanSoGiongPhanSoDauTien();
                    break;
                case ChucNangXoaPhanSo.XoaPhanSoGiongPhanSoCuoiCung:
                    mangPhanSo.XoaPhanSoGiongPhanSoCuoiCung();
                    break;
                case ChucNangXoaPhanSo.XoaTatCaPhanSoNhoNhat:
                    mangPhanSo.XoaTatCaPhanSoNhoNhat();
                    break;
                case ChucNangXoaPhanSo.XoaTaiCacViTri:
                    Console.Write("Nhập các vị trí cần xóa (cách nhau bằng dấu phẩy): ");
                    string[] inputPositions = Console.ReadLine().Split(',');
                    int[] positions = Array.ConvertAll(inputPositions, int.Parse);
                    // Chuyển đổi mảng int[] sang List<int>
                    List<int> positionList = new List<int>(positions);
                    mangPhanSo.XoaTaiCacViTri(positionList);
                    break;
                case ChucNangXoaPhanSo.XoaTatCaPhanSoAm:
                    mangPhanSo.XoaTatCaPhanSoAm();
                    break;
                case ChucNangXoaPhanSo.XoaTatCaPhanSoDuong:
                    mangPhanSo.XoaTatCaPhanSoDuong();
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangXoaPhanSo menu = ChucNangXoaPhanSo.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangXoaPhanSo.Thoat);
        }
    }
}
