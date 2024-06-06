using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_D_Bai3
{
    class Menu
    {
        private MangDonThuc mangDonThuc;

        public Menu()
        {
            mangDonThuc = new MangDonThuc();
        }

        private void Show()
        {
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Thoát", (int)ChucNang.Thoat);
            Console.WriteLine("{0}. Nhập cố định đơn thức", (int)ChucNang.NhapCoDinh);
            Console.WriteLine("{0}. Thêm đơn thức mới", (int)ChucNang.ThemDonThuc);
            Console.WriteLine("{0}. Xuất danh sách đơn thức", (int)ChucNang.XuatDanhSach);
            Console.WriteLine("{0}. Tính tổng giá trị tất cả đơn thức tại x", (int)ChucNang.TinhTongGiaTri);
            Console.WriteLine("{0}. Tính giá trị trung bình của các đơn thức tại x", (int)ChucNang.TinhGiaTriTrungBinh);
            Console.WriteLine("{0}. Đếm số đơn thức có hệ số là phân số", (int)ChucNang.DemDonThucHeSoPhanSo);
            Console.WriteLine("{0}. Tìm số mũ lớn nhất trong các đơn thức", (int)ChucNang.TimSoMuLonNhat);
            Console.WriteLine("{0}. Tìm đơn thức với hệ số nhỏ nhất", (int)ChucNang.TimDonThucHeSoNhoNhat);
            Console.WriteLine("==================================================");
        }

        private ChucNang Select()
        {
            int soMenu = Enum.GetNames(typeof(ChucNang)).Length;
            int menu = -1;
            do
            {
                Show();
                Console.Write("Nhập số để chọn menu (0..{0}): ", soMenu - 1);
                if (!int.TryParse(Console.ReadLine(), out menu) || menu < 0 || menu >= soMenu)
                {
                    Console.WriteLine("Lựa chọn không hợp lệ, vui lòng nhập lại!");
                }
            } while (menu < 0 || menu >= soMenu);

            return (ChucNang)menu;
        }

        private void Process(ChucNang menu)
        {
            switch (menu)
            {
                case ChucNang.Thoat:
                    Console.WriteLine("Kết thúc chương trình");
                    break;
                case ChucNang.NhapCoDinh:
                    mangDonThuc.NhapCoDinh();
                    Console.WriteLine("Đã nhập cố định các đơn thức");
                    break;
                case ChucNang.ThemDonThuc:
                    Console.WriteLine("Nhập hệ số của đơn thức (thực hoặc phân số):");
                    string input = Console.ReadLine();
                    HeSo heSo;
                    if (input.Contains("/"))
                    {
                        var parts = input.Split('/');
                        int tu = int.Parse(parts[0]);
                        int mau = int.Parse(parts[1]);
                        heSo = new HeSoPhanSo(new PhanSo(tu, mau));
                    }
                    else
                    {
                        double soThuc = double.Parse(input);
                        heSo = new HeSoThuc(soThuc);
                    }
                    Console.WriteLine("Nhập số mũ của đơn thức:");
                    int soMu = int.Parse(Console.ReadLine());
                    DonThuc newDonThuc = new DonThuc(heSo, soMu);
                    mangDonThuc.ThemDonThuc(newDonThuc);
                    Console.WriteLine("Đơn thức mới đã được thêm vào.");
                    break;
                case ChucNang.XuatDanhSach:
                    mangDonThuc.Xuat();
                    break;
                case ChucNang.TinhTongGiaTri:
                    Console.WriteLine("Nhập giá trị x:");
                    double x = double.Parse(Console.ReadLine());
                    double tongGiaTri = mangDonThuc.TinhTongGiaTri(x);
                    Console.WriteLine($"Tổng giá trị của các đơn thức tại x = {x} là: {tongGiaTri}");
                    break;
                case ChucNang.TinhGiaTriTrungBinh:
                    Console.WriteLine("Nhập giá trị x:");
                    x = double.Parse(Console.ReadLine());
                    double trungBinh = mangDonThuc.TinhGiaTriTrungBinh(x);
                    Console.WriteLine($"Giá trị trung bình của các đơn thức tại x = {x} là: {trungBinh}");
                    break;
                case ChucNang.DemDonThucHeSoPhanSo:
                    int demPhanSo = mangDonThuc.DemDonThucPhanSo();
                    Console.WriteLine($"Số lượng đơn thức có hệ số là phân số là: {demPhanSo}");
                    break;
                case ChucNang.TimSoMuLonNhat:
                    int soMuLonNhat = mangDonThuc.TimSoMuLonNhat();
                    Console.WriteLine($"Số mũ lớn nhất trong các đơn thức là: {soMuLonNhat}");
                    break;
                case ChucNang.TimDonThucHeSoNhoNhat:
                    var donThucHeSoNhoNhat = mangDonThuc.TimDonThucHeSoNhoNhat();
                    if (donThucHeSoNhoNhat != null)
                    {
                        Console.WriteLine($"Đơn thức với hệ số nhỏ nhất: {donThucHeSoNhoNhat.HeSo.LayGiaTri()}x^{donThucHeSoNhoNhat.SoMu}");
                    }
                    else
                    {
                        Console.WriteLine("Không có đơn thức nào trong danh sách.");
                    }
                    break;
            }
        }

        public void Run()
        {
            ChucNang menu;
            do
            {
                menu = Select();
                Process(menu);
            } while (menu != ChucNang.Thoat);
        }
    }
}
