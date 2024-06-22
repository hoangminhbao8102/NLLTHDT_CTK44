using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_D_Bai1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // c. Tạo một thể hiện của lớp ThuVienSach và thêm 10 cuốn sách khác nhau
            ThuVienSach thuVien = new ThuVienSach();
            thuVien.Them(new Sach("Book 1", "Author 1", 100, 50));
            thuVien.Them(new Sach("Book 2", "Author 2", 150, 75));
            thuVien.Them(new Sach("Book 3", "Author 3", 200, 100));
            thuVien.Them(new Sach("Book 4", "Author 4", 250, 125));
            thuVien.Them(new Sach("Book 5", "Author 1", 300, 150));
            thuVien.Them(new Sach("Book 6", "Author 2", 350, 175));
            thuVien.Them(new Sach("Book 7", "Author 3", 400, 200));
            thuVien.Them(new Sach("Book 8", "Author 4", 450, 225));
            thuVien.Them(new Sach("Book 9", "Author 5", 500, 250));
            thuVien.Them(new Sach("Book 10", "Author 5", 550, 275));

            // d. Gọi hàm để thực hiện việc thống kê
            ThongKe thongKe = new ThongKe();
            thuVien.KiemDuyet(thongKe.KiemDuyet);

            // e. Xuất danh sách tên tác giả của các cuốn sách
            Console.WriteLine("Danh sách tác giả: " + thongKe.LayDanhSachTacGia());

            // f. Xuất số lượng tác giả
            Console.WriteLine("Số lượng tác giả: " + thongKe.DemSoLuongTacGia());

            // g. Xuất giá bán trung bình của mỗi cuốn sách
            Console.WriteLine("Giá bán trung bình mỗi cuốn sách: " + thongKe.TinhGiaTrungBinhMoiSach());

            // h. Xuất giá trung bình của mỗi trang sách
            Console.WriteLine("Giá trung bình mỗi trang sách: " + thongKe.TinhGiaTrungBinhMoiTrang());

            // i. Tính số lượng trang trung bình trên mỗi cuốn sách
            Console.WriteLine("Số lượng trang trung bình mỗi cuốn sách: " + thongKe.TinhSoTrangTrungBinhMoiSach());

            // j. Xuất giá sách lớn nhất
            Console.WriteLine("Giá sách lớn nhất: " + thongKe.GiaMax());

            // k. Xuất giá sách rẻ nhất
            Console.WriteLine("Giá sách rẻ nhất: " + thongKe.GiaMin());

            Console.ReadKey();
        }
    }
}
