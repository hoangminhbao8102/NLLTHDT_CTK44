using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class MenuTimKiemHinhHoc
    {
        private DanhSachHinhHoc hinhHoc;

        public MenuTimKiemHinhHoc()
        {
            hinhHoc = new DanhSachHinhHoc();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("================= MENU TÌM KIẾM ==================");
            Console.WriteLine("{0}. Tìm hình có diện tích nhỏ nhất.", (int)ChucNangTimKiemHinhHoc.TimHinhCoDienTichNhoNhat);
            Console.WriteLine("{0}. Tìm hình có diện tích lớn nhất.", (int)ChucNangTimKiemHinhHoc.TimHinhCoDienTichLonNhat);
            Console.WriteLine("{0}. Tìm hình có chu vi nhỏ nhất.", (int)ChucNangTimKiemHinhHoc.TimHinhCoChuViNhoNhat);
            Console.WriteLine("{0}. Tìm hình có chu vi lớn nhất.", (int)ChucNangTimKiemHinhHoc.TimHinhCoChuViLonNhat);
            Console.WriteLine("{0}. Tìm hình vuông có diện tích lớn nhất.", (int)ChucNangTimKiemHinhHoc.TimHinhVuongCoDTLonNhat);
            Console.WriteLine("{0}. Tìm tất cả hình vuông có diện tích, chu vi nhỏ nhất.", (int)ChucNangTimKiemHinhHoc.TimHinhVuongCoDTVaCVNhoNhat);
            Console.WriteLine("{0}. Tìm tất cả hình vuông có diện tích, chu vi là x.", (int)ChucNangTimKiemHinhHoc.TimHinhVuongCoDienTichVaChuVi);
            Console.WriteLine("{0}. Tìm hình vuông có cạnh nhỏ nhất.", (int)ChucNangTimKiemHinhHoc.TimHinhVuongCoCanhNhoNhat);
            Console.WriteLine("{0}. Tìm hình vuông có cạnh lớn nhất.", (int)ChucNangTimKiemHinhHoc.TimHinhVuongCoCanhLonNhat);
            Console.WriteLine("{0}. Tìm tất cả hình tròn có diện tích, chu vi là x.", (int)ChucNangTimKiemHinhHoc.TimHinhTronCoDienTichVaChuVi);
            Console.WriteLine("{0}. Tìm hình tròn có bán kinh nhỏ nhất.", (int)ChucNangTimKiemHinhHoc.TimHinhTronCoBanKinhNhoNhat);
            Console.WriteLine("{0}. Tìm hình tròn có bán kính lớn nhất.", (int)ChucNangTimKiemHinhHoc.TimHinhTronCoBanKinhLonNhat);
            Console.WriteLine("{0}. Tìm tất cả hình chữ nhật có diện tích, chu vi là x.", (int)ChucNangTimKiemHinhHoc.TimHinhChuNhatCoDienTichVaChuVi);
            Console.WriteLine("{0}. Tìm hình chữ nhật có chiều dài nhỏ nhất.", (int)ChucNangTimKiemHinhHoc.TimHinhChuNhatCoChieuDaiNhoNhat);
            Console.WriteLine("{0}. Tìm hình chữ nhật có chiều dài lớn nhất.", (int)ChucNangTimKiemHinhHoc.TimHinhChuNhatCoChieuDaiLonNhat);
            Console.WriteLine("{0}. Tìm hình chữ nhật có chiều rộng nhỏ nhất.", (int)ChucNangTimKiemHinhHoc.TimHinhChuNhatCoChieuRongNhoNhat);
            Console.WriteLine("{0}. Tìm hình chữ nhật có chiều rộng lớn nhất.", (int)ChucNangTimKiemHinhHoc.TimHinhChuNhatCoChieuRongLonNhat);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangTimKiemHinhHoc.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangTimKiemHinhHoc Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangTimKiemHinhHoc)).Length;

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

            return (ChucNangTimKiemHinhHoc)menu;
        }

        private void Process(ChucNangTimKiemHinhHoc menu)
        {
            switch (menu)
            {
                case ChucNangTimKiemHinhHoc.Thoat:
                    Console.WriteLine("Kết thúc chương trình tìm kiếm!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhCoDienTichNhoNhat:
                    var minAreaShape = hinhHoc.TimHinhCoDienTichNhoNhat();
                    Console.WriteLine($"Hình có diện tích nhỏ nhất: {minAreaShape}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhCoDienTichLonNhat:
                    var maxAreaShape = hinhHoc.TimHinhCoDienTichLonNhat();
                    Console.WriteLine($"Hình có diện tích lớn nhất: {maxAreaShape}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhCoChuViNhoNhat:
                    var minPerimeterShape = hinhHoc.TimHinhCoChuViNhoNhat();
                    Console.WriteLine($"Hình có chu vi nhỏ nhất: {minPerimeterShape}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhCoChuViLonNhat:
                    var maxPerimeterShape = hinhHoc.TimHinhCoChuViLonNhat();
                    Console.WriteLine($"Hình có chu vi lớn nhất: {maxPerimeterShape}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhVuongCoDTLonNhat:
                    var maxSquare = hinhHoc.TimHinhVuongCoDTLonNhat();
                    Console.WriteLine($"Hình vuông có diện tích lớn nhất: {maxSquare}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhVuongCoDTVaCVNhoNhat:
                    var minSquare = hinhHoc.TimHinhVuongCoDTVaCVNhoNhat();
                    Console.WriteLine($"Hình vuông có diện tích và chu vi nhỏ nhất: {minSquare}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhVuongCoDienTichVaChuVi:
                    Console.Write("Nhập diện tích: ");
                    float area = float.Parse(Console.ReadLine());
                    Console.Write("Nhập chu vi: ");
                    float perimeter = float.Parse(Console.ReadLine());
                    var specificSquare = hinhHoc.TimHinhVuongCoDienTichVaChuVi(area, perimeter);
                    Console.WriteLine($"Hình vuông có diện tích {area} và chu vi {perimeter}: {specificSquare}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhVuongCoCanhNhoNhat:
                    var smallestSquare = hinhHoc.TimHinhVuongCoCanhNhoNhat();
                    Console.WriteLine($"Hình vuông có cạnh nhỏ nhất: {smallestSquare}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhVuongCoCanhLonNhat:
                    var largestSquare = hinhHoc.TimHinhVuongCoCanhLonNhat();
                    Console.WriteLine($"Hình vuông có cạnh lớn nhất: {largestSquare}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhTronCoDienTichVaChuVi:
                    Console.Write("Nhập diện tích: ");
                    float circleArea = float.Parse(Console.ReadLine());
                    Console.Write("Nhập chu vi: ");
                    float circlePerimeter = float.Parse(Console.ReadLine());
                    var specificCircle = hinhHoc.TimHinhTronCoDienTichVaChuVi(circleArea, circlePerimeter);
                    Console.WriteLine($"Hình tròn có diện tích {circleArea} và chu vi {circlePerimeter}: {specificCircle}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhTronCoBanKinhNhoNhat:
                    var smallestCircle = hinhHoc.TimHinhTronCoBanKinhNhoNhat();
                    Console.WriteLine($"Hình tròn có bán kính nhỏ nhất: {smallestCircle}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhTronCoBanKinhLonNhat:
                    var largestCircle = hinhHoc.TimHinhTronCoBanKinhLonNhat();
                    Console.WriteLine($"Hình tròn có bán kính lớn nhất: {largestCircle}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhChuNhatCoDienTichVaChuVi:
                    Console.Write("Nhập diện tích: ");
                    float rectArea = float.Parse(Console.ReadLine());
                    Console.Write("Nhập chu vi: ");
                    float rectPerimeter = float.Parse(Console.ReadLine());
                    var specificRectangle = hinhHoc.TimHinhChuNhatCoDienTichVaChuVi(rectArea, rectPerimeter);
                    Console.WriteLine($"Hình chữ nhật có diện tích {rectArea} và chu vi {rectPerimeter}: {specificRectangle}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhChuNhatCoChieuDaiNhoNhat:
                    var shortestRectangle = hinhHoc.TimHinhChuNhatCoChieuDaiNhoNhat();
                    Console.WriteLine($"Hình chữ nhật có chiều dài nhỏ nhất: {shortestRectangle}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhChuNhatCoChieuDaiLonNhat:
                    var longestRectangle = hinhHoc.TimHinhChuNhatCoChieuDaiLonNhat();
                    Console.WriteLine($"Hình chữ nhật có chiều dài lớn nhất: {longestRectangle}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhChuNhatCoChieuRongNhoNhat:
                    var narrowestRectangle = hinhHoc.TimHinhChuNhatCoChieuRongNhoNhat();
                    Console.WriteLine($"Hình chữ nhật có chiều rộng nhỏ nhất: {narrowestRectangle}");
                    break;
                case ChucNangTimKiemHinhHoc.TimHinhChuNhatCoChieuRongLonNhat:
                    var widestRectangle = hinhHoc.TimHinhChuNhatCoChieuRongLonNhat();
                    Console.WriteLine($"Hình chữ nhật có chiều rộng lớn nhất: {widestRectangle}");
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangTimKiemHinhHoc menu = ChucNangTimKiemHinhHoc.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangTimKiemHinhHoc.Thoat);
        }
    }
}
