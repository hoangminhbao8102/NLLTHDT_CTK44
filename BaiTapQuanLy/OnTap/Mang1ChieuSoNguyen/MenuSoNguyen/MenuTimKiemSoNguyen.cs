using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    class MenuTimKiemSoNguyen
    {
        private MangSoNguyen MangNguyen;

        public MenuTimKiemSoNguyen()
        {
            MangNguyen = new MangSoNguyen();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("================= MENU TÌM KIẾM ==================");
            Console.WriteLine("{0}. Tìm vị trí đầu tiên của mảng", (int)ChucNangTimKiemSoNguyen.TimViTriDauTien);
            Console.WriteLine("{0}. Tìm vị trí cuối cùng của mảng", (int)ChucNangTimKiemSoNguyen.TimViTriCuoiCung);
            Console.WriteLine("{0}. Tìm phần tử lớn nhất của mảng", (int)ChucNangTimKiemSoNguyen.TimPhanTuLonNhat);
            Console.WriteLine("{0}. Tìm phần tử nhỏ nhất của mảng", (int)ChucNangTimKiemSoNguyen.TimPhanTuNhoNhat);
            Console.WriteLine("{0}. Tìm tất cả các số âm của mảng", (int)ChucNangTimKiemSoNguyen.TimTatCaCacSoAm);
            Console.WriteLine("{0}. Tìm tất cả các số dương của mảng", (int)ChucNangTimKiemSoNguyen.TimTatCaCacSoDuong);
            Console.WriteLine("{0}. Tìm tất cả các số chẵn của mảng", (int)ChucNangTimKiemSoNguyen.TimTatCaCacSoChan);
            Console.WriteLine("{0}. Tìm tất cả các số lẻ của mảng", (int)ChucNangTimKiemSoNguyen.TimTatCaCacSoLe);
            Console.WriteLine("{0}. Tìm tất cả các số nguyên tố của mảng", (int)ChucNangTimKiemSoNguyen.TimTatCaCacSoNguyenTo);
            Console.WriteLine("{0}. Tìm phần tử xuất hiện nhiều nhất của mảng", (int)ChucNangTimKiemSoNguyen.TimPhanTuXuatHienNhieuNhat);
            Console.WriteLine("{0}. Tìm phần tử xuất hiện ít nhất của mảng", (int)ChucNangTimKiemSoNguyen.TimPhanTuXuatHienItNhat);
            Console.WriteLine("{0}. Tìm tất cả các phần tử lớn hơn của mảng", (int)ChucNangTimKiemSoNguyen.TimTatCaPhanTuLonHon);
            Console.WriteLine("{0}. Tìm tất cả các phần tử nhỏ hơn của mảng", (int)ChucNangTimKiemSoNguyen.TimTatCaPhanTuNhoHon);
            Console.WriteLine("{0}. Tìm tất cả các phần tử tại vị trí vt của mảng", (int)ChucNangTimKiemSoNguyen.TimTatCaPhanTuViTri);
            Console.WriteLine("{0}. Thoát", (int)ChucNangTimKiemSoNguyen.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangTimKiemSoNguyen Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangTimKiemSoNguyen)).Length;

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

            return (ChucNangTimKiemSoNguyen)menu;
        }

        private void Process(ChucNangTimKiemSoNguyen menu)
        {
            int x, vt, soLuong;
            int[] kq;
            int lengthkq = 0; // Khởi tạo biến lengthkq

            switch (menu)
            {
                case ChucNangTimKiemSoNguyen.Thoat:
                    Console.WriteLine("Kết thúc chương trình tìm kiếm!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangTimKiemSoNguyen.TimViTriDauTien:
                    Console.Write("Nhập giá trị cần tìm: ");
                    x = int.Parse(Console.ReadLine());
                    vt = MangNguyen.TimViTriDauTien(x);
                    Console.WriteLine("Vị trí đầu tiên của {0} là: {1}", x, vt);
                    break;
                case ChucNangTimKiemSoNguyen.TimViTriCuoiCung:
                    Console.Write("Nhập giá trị cần tìm: ");
                    x = int.Parse(Console.ReadLine());
                    vt = MangNguyen.TimViTriCuoiCung(x);
                    Console.WriteLine("Vị trí cuối cùng của {0} là: {1}", x, vt);
                    break;
                case ChucNangTimKiemSoNguyen.TimPhanTuLonNhat:
                    x = MangNguyen.TimPhanTuLonNhat();
                    Console.WriteLine("Phần tử lớn nhất là: {0}", x);
                    break;
                case ChucNangTimKiemSoNguyen.TimPhanTuNhoNhat:
                    x = MangNguyen.TimPhanTuNhoNhat();
                    Console.WriteLine("Phần tử nhỏ nhất là: {0}", x);
                    break;
                case ChucNangTimKiemSoNguyen.TimTatCaCacSoAm:
                    kq = MangNguyen.TimTatCaCacSoAm(ref lengthkq);
                    Console.WriteLine("Các số âm là:");
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiemSoNguyen.TimTatCaCacSoDuong:
                    kq = MangNguyen.TimTatCaCacSoDuong(ref lengthkq);
                    Console.WriteLine("Các số dương là:");
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiemSoNguyen.TimTatCaCacSoChan:
                    kq = MangNguyen.TimTatCaCacSoChan(ref lengthkq);
                    Console.WriteLine("Các số chẵn là:");
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiemSoNguyen.TimTatCaCacSoLe:
                    kq = MangNguyen.TimTatCaCacSoLe(ref lengthkq);
                    Console.WriteLine("Các số lẻ là:");
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiemSoNguyen.TimTatCaCacSoNguyenTo:
                    kq = MangNguyen.TimTatCaCacSoNguyenTo(ref lengthkq);
                    Console.WriteLine("Các số nguyên tố là:");
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiemSoNguyen.TimPhanTuXuatHienNhieuNhat:
                    kq = MangNguyen.TimPhanTuXuatHienNhieuNhat(ref lengthkq);
                    Console.WriteLine("Các phần tử xuất hiện nhiều nhất là:");
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiemSoNguyen.TimPhanTuXuatHienItNhat:
                    kq = MangNguyen.TimPhanTuXuatHienItNhat(ref lengthkq);
                    Console.WriteLine("Các phần tử xuất hiện ít nhất là:");
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiemSoNguyen.TimTatCaPhanTuLonHon:
                    Console.Write("Nhập giá trị cần so sánh: ");
                    x = int.Parse(Console.ReadLine());
                    kq = MangNguyen.TimTatCaPhanTuLonHon(ref lengthkq, x);
                    Console.WriteLine("Các phần tử lớn hơn {0} là:", x);
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiemSoNguyen.TimTatCaPhanTuNhoHon:
                    Console.Write("Nhập giá trị cần so sánh: ");
                    x = int.Parse(Console.ReadLine());
                    kq = MangNguyen.TimTatCaPhanTuNhoHon(ref lengthkq, x);
                    Console.WriteLine("Các phần tử nhỏ hơn {0} là:", x);
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiemSoNguyen.TimTatCaPhanTuViTri:
                    Console.Write("Nhập vị trí bắt đầu: ");
                    vt = int.Parse(Console.ReadLine());
                    Console.Write("Nhập số lượng phần tử: ");
                    soLuong = int.Parse(Console.ReadLine());
                    kq = MangNguyen.TimTatCaPhanTuViTri(ref lengthkq, vt, soLuong);
                    Console.WriteLine("Các phần tử từ vị trí {0} là:", vt);
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ");
                    break;
            }
        }

        public void Run()
        {
            ChucNangTimKiemSoNguyen menu = ChucNangTimKiemSoNguyen.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangTimKiemSoNguyen.Thoat);
        }
    }
}
