using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang1ChieuSoNguyen
{
    class MenuTimKiem
    {
        private MangSoNguyen MangNguyen;

        public MenuTimKiem()
        {
            MangNguyen = new MangSoNguyen();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("====================== MENU TÌM KIẾM =============");
            Console.WriteLine("{0}. Tìm vị trí đầu tiên của mảng", (int)ChucNangTimKiem.TimViTriDauTien);
            Console.WriteLine("{0}. Tìm vị trí cuối cùng của mảng", (int)ChucNangTimKiem.TimViTriCuoiCung);
            Console.WriteLine("{0}. Tìm phần tử lớn nhất của mảng", (int)ChucNangTimKiem.TimPhanTuLonNhat);
            Console.WriteLine("{0}. Tìm phần tử nhỏ nhất của mảng", (int)ChucNangTimKiem.TimPhanTuNhoNhat);
            Console.WriteLine("{0}. Tìm tất cả các số âm của mảng", (int)ChucNangTimKiem.TimTatCaCacSoAm);
            Console.WriteLine("{0}. Tìm tất cả các số dương của mảng", (int)ChucNangTimKiem.TimTatCaCacSoDuong);
            Console.WriteLine("{0}. Tìm tất cả các số chẵn của mảng", (int)ChucNangTimKiem.TimTatCaCacSoChan);
            Console.WriteLine("{0}. Tìm tất cả các số lẻ của mảng", (int)ChucNangTimKiem.TimTatCaCacSoLe);
            Console.WriteLine("{0}. Tìm tất cả các số nguyên tố của mảng", (int)ChucNangTimKiem.TimTatCaCacSoNguyenTo);
            Console.WriteLine("{0}. Tìm phần tử xuất hiện nhiều nhất của mảng", (int)ChucNangTimKiem.TimPhanTuXuatHienNhieuNhat);
            Console.WriteLine("{0}. Tìm phần tử xuất hiện ít nhất của mảng", (int)ChucNangTimKiem.TimPhanTuXuatHienItNhat);
            Console.WriteLine("{0}. Tìm tất cả các phần tử lớn hơn của mảng", (int)ChucNangTimKiem.TimTatCaPhanTuLonHon);
            Console.WriteLine("{0}. Tìm tất cả các phần tử nhỏ hơn của mảng", (int)ChucNangTimKiem.TimTatCaPhanTuNhoHon);
            Console.WriteLine("{0}. Tìm tất cả các phần tử tại vị trí vt của mảng", (int)ChucNangTimKiem.TimTatCaPhanTuViTri);
            Console.WriteLine("{0}. Thoát", (int)ChucNangTimKiem.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangTimKiem Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangTimKiem)).Length;

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

            return (ChucNangTimKiem)menu;
        }

        private void Process(ChucNangTimKiem menu)
        {
            int x, vt, soLuong;
            int[] kq;
            int lengthkq = 0; // Khởi tạo biến lengthkq

            switch (menu)
            {
                case ChucNangTimKiem.Thoat:
                    Console.WriteLine("Kết thúc chương trình tìm kiếm!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    break;
                case ChucNangTimKiem.TimViTriDauTien:
                    Console.Write("Nhập giá trị cần tìm: ");
                    x = int.Parse(Console.ReadLine());
                    vt = MangNguyen.TimViTriDauTien(x);
                    Console.WriteLine("Vị trí đầu tiên của {0} là: {1}", x, vt);
                    break;
                case ChucNangTimKiem.TimViTriCuoiCung:
                    Console.Write("Nhập giá trị cần tìm: ");
                    x = int.Parse(Console.ReadLine());
                    vt = MangNguyen.TimViTriCuoiCung(x);
                    Console.WriteLine("Vị trí cuối cùng của {0} là: {1}", x, vt);
                    break;
                case ChucNangTimKiem.TimPhanTuLonNhat:
                    x = MangNguyen.TimPhanTuLonNhat();
                    Console.WriteLine("Phần tử lớn nhất là: {0}", x);
                    break;
                case ChucNangTimKiem.TimPhanTuNhoNhat:
                    x = MangNguyen.TimPhanTuNhoNhat();
                    Console.WriteLine("Phần tử nhỏ nhất là: {0}", x);
                    break;
                case ChucNangTimKiem.TimTatCaCacSoAm:
                    kq = MangNguyen.TimTatCaCacSoAm(ref lengthkq);
                    Console.WriteLine("Các số âm là:");
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiem.TimTatCaCacSoDuong:
                    kq = MangNguyen.TimTatCaCacSoDuong(ref lengthkq);
                    Console.WriteLine("Các số dương là:");
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiem.TimTatCaCacSoChan:
                    kq = MangNguyen.TimTatCaCacSoChan(ref lengthkq);
                    Console.WriteLine("Các số chẵn là:");
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiem.TimTatCaCacSoLe:
                    kq = MangNguyen.TimTatCaCacSoLe(ref lengthkq);
                    Console.WriteLine("Các số lẻ là:");
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiem.TimTatCaCacSoNguyenTo:
                    kq = MangNguyen.TimTatCaCacSoNguyenTo(ref lengthkq);
                    Console.WriteLine("Các số nguyên tố là:");
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiem.TimPhanTuXuatHienNhieuNhat:
                    kq = MangNguyen.TimPhanTuXuatHienNhieuNhat(ref lengthkq);
                    Console.WriteLine("Các phần tử xuất hiện nhiều nhất là:");
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiem.TimPhanTuXuatHienItNhat:
                    kq = MangNguyen.TimPhanTuXuatHienItNhat(ref lengthkq);
                    Console.WriteLine("Các phần tử xuất hiện ít nhất là:");
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiem.TimTatCaPhanTuLonHon:
                    Console.Write("Nhập giá trị cần so sánh: ");
                    x = int.Parse(Console.ReadLine());
                    kq = MangNguyen.TimTatCaPhanTuLonHon(ref lengthkq, x);
                    Console.WriteLine("Các phần tử lớn hơn {0} là:", x);
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiem.TimTatCaPhanTuNhoHon:
                    Console.Write("Nhập giá trị cần so sánh: ");
                    x = int.Parse(Console.ReadLine());
                    kq = MangNguyen.TimTatCaPhanTuNhoHon(ref lengthkq, x);
                    Console.WriteLine("Các phần tử nhỏ hơn {0} là:", x);
                    MangNguyen.XuatMang(kq, lengthkq);
                    break;
                case ChucNangTimKiem.TimTatCaPhanTuViTri:
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
            ChucNangTimKiem menu = ChucNangTimKiem.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangTimKiem.Thoat);
        }
    }
}
