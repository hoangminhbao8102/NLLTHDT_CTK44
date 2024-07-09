using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class Program
    {
        static DanhSachHinhHoc danhSachHinhHoc = new DanhSachHinhHoc();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool tiepTuc = true;
            while (tiepTuc)
            {
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1. Thêm hình vào danh sách");
                Console.WriteLine("2. Hiển thị danh sách hình");
                Console.WriteLine("3. Tìm hình vuông có diện tích lớn nhất");
                Console.WriteLine("4. Tìm hình có diện tích lớn nhất");
                Console.WriteLine("5. Thoát");
                Console.Write("Chọn chức năng (1-5): ");

                int luaChon;
                if (int.TryParse(Console.ReadLine(), out luaChon))
                {
                    switch (luaChon)
                    {
                        case 1:
                            ThemHinh();
                            break;
                        case 2:
                            Console.WriteLine("----- DANH SÁCH HÌNH -----");
                            Console.WriteLine(danhSachHinhHoc.ToString());
                            break;
                        case 3:
                            var dsHinhVuongMaxDT = danhSachHinhHoc.TimHinhVuongCoDTLonNhat();
                            Console.WriteLine("Hình vuông có diện tích lớn nhất:");
                            Console.WriteLine(dsHinhVuongMaxDT.ToString());
                            break;
                        case 4:
                            var dsHinhMaxDT = danhSachHinhHoc.TimHinhCoDTLonNhat();
                            Console.WriteLine("Hình có diện tích lớn nhất:");
                            Console.WriteLine(dsHinhMaxDT.ToString());
                            break;
                        case 5:
                            tiepTuc = false;
                            break;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ.");
                }

                Console.WriteLine();
            }
        }

        static void ThemHinh()
        {
            Console.WriteLine("Chọn loại hình để thêm:");
            Console.WriteLine("1. Hình vuông");
            Console.WriteLine("2. Hình tròn");
            Console.WriteLine("3. Hình chữ nhật");
            Console.Write("Chọn loại hình (1-3): ");

            int loaiHinh;
            if (int.TryParse(Console.ReadLine(), out loaiHinh))
            {
                switch (loaiHinh)
                {
                    case 1:
                        Console.Write("Nhập cạnh của hình vuông: ");
                        float canh = float.Parse(Console.ReadLine());
                        HinhVuong hv = new HinhVuong(canh);
                        danhSachHinhHoc.Them(hv);
                        break;
                    case 2:
                        Console.Write("Nhập bán kính của hình tròn: ");
                        float banKinh = float.Parse(Console.ReadLine());
                        HinhTron ht = new HinhTron(banKinh);
                        danhSachHinhHoc.Them(ht);
                        break;
                    case 3:
                        Console.Write("Nhập chiều dài của hình chữ nhật: ");
                        float chieuDai = float.Parse(Console.ReadLine());
                        Console.Write("Nhập chiều rộng của hình chữ nhật: ");
                        float chieuRong = float.Parse(Console.ReadLine());
                        HinhChuNhat hcn = new HinhChuNhat(chieuDai, chieuRong);
                        danhSachHinhHoc.Them(hcn);
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Lựa chọn không hợp lệ.");
            }
        }
    }
}
