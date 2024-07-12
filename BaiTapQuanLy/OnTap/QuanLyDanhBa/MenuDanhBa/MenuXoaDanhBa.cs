using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class MenuXoaDanhBa
    {
        private DanhBa danhBa;

        public MenuXoaDanhBa()
        {
            danhBa = new DanhBa();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("=================== MENU XÓA =====================");
            Console.WriteLine("{0}. Xóa tất cả khách hàng thuộc một tỉnh nào đó.", (int)ChucNangXoaDanhBa.XoaKhachHangTheoTinh);
            Console.WriteLine("{0}. Xóa tất cả thuê bao theo ngày lắp đặt.", (int)ChucNangXoaDanhBa.XoaThueBaoTheoNgayLapDat);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangXoaDanhBa.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangXoaDanhBa Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangXoaDanhBa)).Length;

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

            return (ChucNangXoaDanhBa)menu;
        }

        private void Process(ChucNangXoaDanhBa menu)
        {
            switch (menu)
            {
                case ChucNangXoaDanhBa.Thoat:
                    Console.WriteLine("Kết thúc chương trình xóa!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangXoaDanhBa.XoaKhachHangTheoTinh:
                    Console.Write("Nhập tên tỉnh mà bạn muốn xóa tất cả khách hàng: ");
                    string tinh = Console.ReadLine();
                    danhBa.XoaKhachHangTheoTinh(tinh);
                    Console.WriteLine($"Đã xóa tất cả khách hàng thuộc tỉnh {tinh}.");
                    break;
                case ChucNangXoaDanhBa.XoaThueBaoTheoNgayLapDat:
                    Console.Write("Nhập ngày lắp đặt (định dạng YYYY-MM-DD) để xóa các thuê bao: ");
                    string inputDate = Console.ReadLine();
                    DateTime ngayLapDat;
                    if (DateTime.TryParse(inputDate, out ngayLapDat))
                    {
                        danhBa.XoaThueBaoTheoNgayLapDat(ngayLapDat);
                        Console.WriteLine($"Đã xóa các thuê bao lắp đặt vào ngày {ngayLapDat.ToShortDateString()}.");
                    }
                    else
                    {
                        Console.WriteLine("Ngày nhập không hợp lệ, vui lòng nhập lại đúng định dạng YYYY-MM-DD.");
                    }
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangXoaDanhBa menu = ChucNangXoaDanhBa.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangXoaDanhBa.Thoat);
        }
    }
}
