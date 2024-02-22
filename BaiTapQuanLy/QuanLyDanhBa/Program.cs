using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class Program
    {
        static DanhBa danhBa = new DanhBa();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool tiepTuc = true;
            while (tiepTuc)
            {
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1. Thêm thuê bao từ file");
                Console.WriteLine("2. Hiển thị danh sách thuê bao");
                Console.WriteLine("3. Đếm số điện thoại theo CMND");
                Console.WriteLine("4. Tìm thuê bao có nhiều số điện thoại nhất");
                Console.WriteLine("5. Sắp xếp danh sách thuê bao");
                Console.WriteLine("6. Thoát");
                Console.Write("Chọn chức năng (1-6): ");

                int luaChon;
                if (int.TryParse(Console.ReadLine(), out luaChon))
                {
                    switch (luaChon)
                    {
                        case 1:
                            danhBa.NhapTuFile();
                            Console.WriteLine("Thêm thành công từ file.");
                            break;
                        case 2:
                            Console.WriteLine("----- DANH SÁCH THUÊ BAO -----");
                            Console.WriteLine(danhBa.ToString());
                            break;
                        case 3:
                            Console.Write("Nhập số CMND cần đếm: ");
                            string cmndCanDem = Console.ReadLine();
                            int soLuong = danhBa.DemSoDTTheoThueBao(cmndCanDem);
                            Console.WriteLine($"Số điện thoại thuộc CMND {cmndCanDem}: {soLuong}");
                            break;
                        case 4:
                            DanhBa danhBaNhieuSDT = danhBa.TimThueBaoCoNhieuSDT();
                            Console.WriteLine("Danh sách thuê bao có nhiều số điện thoại nhất:");
                            Console.WriteLine(danhBaNhieuSDT.ToString());
                            break;
                        case 5:
                            Console.WriteLine("Chọn kiểu sắp xếp:");
                            Console.WriteLine("1. Tăng dần theo họ tên");
                            Console.WriteLine("2. Giảm dần theo họ tên");
                            Console.WriteLine("3. Tăng dần theo ngày sinh");
                            Console.WriteLine("4. Giảm dần theo ngày sinh");
                            Console.Write("Chọn kiểu sắp xếp (1-4): ");
                            int kieuSapXep;
                            if (int.TryParse(Console.ReadLine(), out kieuSapXep) && kieuSapXep >= 1 && kieuSapXep <= 4)
                            {
                                danhBa.SapXep((DanhBa.KieuSapXep)(kieuSapXep - 1));
                                Console.WriteLine("Danh sách đã được sắp xếp.");
                            }
                            else
                            {
                                Console.WriteLine("Lựa chọn không hợp lệ.");
                            }
                            break;
                        case 6:
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
    }
}
