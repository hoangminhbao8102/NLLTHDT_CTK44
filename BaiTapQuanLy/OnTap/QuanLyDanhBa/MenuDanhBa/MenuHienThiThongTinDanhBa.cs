using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class MenuHienThiThongTinDanhBa
    {
        private DanhBa danhBa;

        public MenuHienThiThongTinDanhBa()
        {
            danhBa = new DanhBa();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("============ MENU HIỂN THỊ THÔNG TIN =============");
            Console.WriteLine("{0}. Hiển thị danh sách các thành phố theo chiều tăng, giảm của số lượng thuê bao.", (int)ChucNangHienThiThongTinDanhBa.HienThiThanhPhoTheoSoLuongThueBao);
            Console.WriteLine("{0}. Hiển thị số lượng thuê bao của từng loại hình thuê bao.", (int)ChucNangHienThiThongTinDanhBa.HienThiSoLuongThueBaoTheoLoai);
            Console.WriteLine("{0}. Hiển thị số lượng thuê bao cố định theo từng nhà cung cấp dịch vụ.", (int)ChucNangHienThiThongTinDanhBa.HienThiSoLuongThueBaoCoDinhTheoNhaCungCap);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangHienThiThongTinDanhBa.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangHienThiThongTinDanhBa Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangHienThiThongTinDanhBa)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu hiển thị thông tin (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangHienThiThongTinDanhBa)menu;
        }

        private void Process(ChucNangHienThiThongTinDanhBa menu)
        {
            switch (menu)
            {
                case ChucNangHienThiThongTinDanhBa.Thoat:
                    Console.WriteLine("Kết thúc chương trình hiển thị thông tin!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangHienThiThongTinDanhBa.HienThiThanhPhoTheoSoLuongThueBao:
                    Console.WriteLine("Chọn cách hiển thị số lượng thuê bao theo thành phố:");
                    Console.WriteLine("1. Tăng dần");
                    Console.WriteLine("2. Giảm dần");
                    Console.Write("Lựa chọn của bạn (1-2): ");
                    int option = int.Parse(Console.ReadLine());

                    var cities = danhBa.HienThiThanhPhoTheoSoLuongThueBao(); // Get the cities list

                    if (option == 1)
                    {
                        var ascendingCities = cities.OrderBy(item => item.SoLuong);
                        foreach (var item in ascendingCities)
                        {
                            Console.WriteLine($"Thành phố: {item.ThanhPho}, Số lượng thuê bao: {item.SoLuong}");
                        }
                    }
                    else if (option == 2)
                    {
                        var descendingCities = cities.OrderByDescending(item => item.SoLuong);
                        foreach (var item in descendingCities)
                        {
                            Console.WriteLine($"Thành phố: {item.ThanhPho}, Số lượng thuê bao: {item.SoLuong}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Lựa chọn không hợp lệ.");
                    }
                    break;
                case ChucNangHienThiThongTinDanhBa.HienThiSoLuongThueBaoTheoLoai:
                    danhBa.HienThiSoLuongThueBaoTheoLoai();
                    break;
                case ChucNangHienThiThongTinDanhBa.HienThiSoLuongThueBaoCoDinhTheoNhaCungCap:
                    danhBa.HienThiSoLuongThueBaoCoDinhTheoNhaCungCap();
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangHienThiThongTinDanhBa menu = ChucNangHienThiThongTinDanhBa.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangHienThiThongTinDanhBa.Thoat);
        }
    }
}
