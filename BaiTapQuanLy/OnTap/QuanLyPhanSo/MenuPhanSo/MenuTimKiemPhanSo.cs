using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyPhanSo
{
    class MenuTimKiemPhanSo
    {
        private MangPhanSo mangPhanSo;

        public MenuTimKiemPhanSo()
        {
            mangPhanSo = new MangPhanSo();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("================= MENU TÌM KIẾM ==================");
            Console.WriteLine("{0}. Tìm phân số lớn nhất.", (int)ChucNangTimKiemPhanSo.TimMax);
            Console.WriteLine("{0}. Tìm các phân số có mẫu là x.", (int)ChucNangTimKiemPhanSo.TimPhanSoCoMauLa);
            Console.WriteLine("{0}. Tìm phân số âm lớn nhất.", (int)ChucNangTimKiemPhanSo.TimPhanSoAmLonNhat);
            Console.WriteLine("{0}. Tìm phân số âm nhỏ nhất.", (int)ChucNangTimKiemPhanSo.TimPhanSoAmNhoNhat);
            Console.WriteLine("{0}. Tìm phân số dương lớn nhất.", (int)ChucNangTimKiemPhanSo.TimPhanSoDuongLonNhat);
            Console.WriteLine("{0}. Tìm phân số dương nhỏ nhất.", (int)ChucNangTimKiemPhanSo.TimPhanSoDuongNhoNhat);
            Console.WriteLine("{0}. Tìm tất cả các phân số âm.", (int)ChucNangTimKiemPhanSo.TimTatCaPhanSoAm);
            Console.WriteLine("{0}. Tìm tất cả các phân số dương.", (int)ChucNangTimKiemPhanSo.TimTatCaPhanSoDuong);
            Console.WriteLine("{0}. Tìm tất cả vị trí của phân số có tử là x.", (int)ChucNangTimKiemPhanSo.TimViTriCuaPhanSo);
            Console.WriteLine("{0}. Tìm vị trí của tất cả phân số âm và dương.", (int)ChucNangTimKiemPhanSo.TimViTriCuaPhanSoAmDuong);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangTimKiemPhanSo.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangTimKiemPhanSo Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangTimKiemPhanSo)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu tìm kiếm (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangTimKiemPhanSo)menu;
        }

        private void Process(ChucNangTimKiemPhanSo menu)
        {
            switch (menu)
            {
                case ChucNangTimKiemPhanSo.Thoat:
                    Console.WriteLine("Kết thúc chương trình tìm kiếm!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangTimKiemPhanSo.TimMax:
                    PhanSo max = mangPhanSo.TimMax();
                    Console.WriteLine("Phân số lớn nhất: " + max);
                    break;
                case ChucNangTimKiemPhanSo.TimPhanSoCoMauLa:
                    Console.Write("Nhập mẫu số để tìm các phân số có mẫu này: ");
                    int mau = int.Parse(Console.ReadLine());
                    MangPhanSo kq = mangPhanSo.TimPhanSoCoMauLa(mau);
                    kq.Xuat();
                    break;
                case ChucNangTimKiemPhanSo.TimPhanSoAmLonNhat:
                    PhanSo amMax = mangPhanSo.TimPhanSoAmLonNhat();
                    Console.WriteLine("Phân số âm lớn nhất: " + amMax);
                    break;
                case ChucNangTimKiemPhanSo.TimPhanSoAmNhoNhat:
                    PhanSo amMin = mangPhanSo.TimPhanSoAmNhoNhat();
                    Console.WriteLine("Phân số âm nhỏ nhất: " + amMin);
                    break;
                case ChucNangTimKiemPhanSo.TimPhanSoDuongLonNhat:
                    PhanSo duongMax = mangPhanSo.TimPhanSoDuongLonNhat();
                    Console.WriteLine("Phân số dương lớn nhất: " + duongMax);
                    break;
                case ChucNangTimKiemPhanSo.TimPhanSoDuongNhoNhat:
                    PhanSo duongMin = mangPhanSo.TimPhanSoDuongNhoNhat();
                    Console.WriteLine("Phân số dương nhỏ nhất: " + duongMin);
                    break;
                case ChucNangTimKiemPhanSo.TimTatCaPhanSoAm:
                    MangPhanSo tatCaAm = mangPhanSo.TimTatCaPhanSoAm();
                    Console.WriteLine("Tất cả các phân số âm:");
                    tatCaAm.Xuat();
                    break;
                case ChucNangTimKiemPhanSo.TimTatCaPhanSoDuong:
                    MangPhanSo tatCaDuong = mangPhanSo.TimTatCaPhanSoDuong();
                    Console.WriteLine("Tất cả các phân số dương:");
                    tatCaDuong.Xuat();
                    break;
                case ChucNangTimKiemPhanSo.TimViTriCuaPhanSo:
                    Console.Write("Nhập tử số của phân số cần tìm vị trí: ");
                    int tu = int.Parse(Console.ReadLine());
                    List<int> viTriList = mangPhanSo.TimViTriCuaPhanSo(tu);
                    int[] viTri = viTriList.ToArray();
                    Console.WriteLine("Vị trí của phân số có tử là {0} trong mảng: {1}", tu, string.Join(", ", viTri));
                    break;
                case ChucNangTimKiemPhanSo.TimViTriCuaPhanSoAmDuong:
                    List<int> viTriAmDuongList = mangPhanSo.TimViTriCuaPhanSoAmDuong();
                    int[] viTriAmDuong = viTriAmDuongList.ToArray();
                    Console.WriteLine("Vị trí của tất cả phân số âm và dương trong mảng: " + string.Join(", ", viTriAmDuong));
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangTimKiemPhanSo menu = ChucNangTimKiemPhanSo.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangTimKiemPhanSo.Thoat);
        }
    }
}
