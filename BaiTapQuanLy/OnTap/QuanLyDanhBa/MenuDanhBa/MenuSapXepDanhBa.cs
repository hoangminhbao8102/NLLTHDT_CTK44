using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class MenuSapXepDanhBa
    {
        private DanhBa danhBa;

        public MenuSapXepDanhBa()
        {
            danhBa = new DanhBa();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("================== MENU SẮP XẾP ==================");
            Console.WriteLine("{0}. Sắp xếp thuê bao theo các tiêu chí như họ tên, ngày sinh.", (int)ChucNangSapXepDanhBa.SapXep);
            Console.WriteLine("{0}. Sắp xếp khách hàng tăng giảm theo họ tên, số lượng số điện thoại sở hữu.", (int)ChucNangSapXepDanhBa.SapXepTheoHoTenVaSoDienThoai);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangSapXepDanhBa.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangSapXepDanhBa Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangSapXepDanhBa)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu sắp xếp (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangSapXepDanhBa)menu;
        }

        private void Process(ChucNangSapXepDanhBa menu)
        {
            switch (menu)
            {
                case ChucNangSapXepDanhBa.Thoat:
                    Console.WriteLine("Kết thúc chương trình sắp xếp!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangSapXepDanhBa.SapXep:
                    Console.WriteLine("Chọn kiểu sắp xếp:");
                    Console.WriteLine("1. Tăng theo họ tên");
                    Console.WriteLine("2. Giảm theo họ tên");
                    Console.WriteLine("3. Tăng theo ngày sinh");
                    Console.WriteLine("4. Giảm theo ngày sinh");
                    Console.Write("Lựa chọn của bạn (1-4): ");
                    int kieuSapXep = int.Parse(Console.ReadLine());

                    KieuSapXep kieu;
                    switch (kieuSapXep)
                    {
                        case 1:
                            kieu = KieuSapXep.TangTheoHoTen;
                            break;
                        case 2:
                            kieu = KieuSapXep.GiamTheoHoTen;
                            break;
                        case 3:
                            kieu = KieuSapXep.TangTheoNgaySinh;
                            break;
                        case 4:
                            kieu = KieuSapXep.GiamTheoNgaySinh;
                            break;
                        default:
                            Console.WriteLine("Lựa chọn không hợp lệ.");
                            return;
                    }

                    danhBa.SapXep(kieu);
                    Console.WriteLine("Danh sách sau khi sắp xếp:");
                    Console.WriteLine(danhBa);
                    break;
                case ChucNangSapXepDanhBa.SapXepTheoHoTenVaSoDienThoai:
                    Console.Write("Bạn muốn sắp xếp tăng dần theo họ tên? (y/n): ");
                    string tangHoTen = Console.ReadLine().ToLower();
                    bool tangTheoHoTen = tangHoTen == "y" || tangHoTen == "yes";

                    danhBa.SapXepTheoHoTenVaSoDienThoai(tangTheoHoTen);
                    Console.WriteLine("Danh sách sau khi sắp xếp:");
                    Console.WriteLine(danhBa);
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangSapXepDanhBa menu = ChucNangSapXepDanhBa.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangSapXepDanhBa.Thoat);
        }
    }
}
