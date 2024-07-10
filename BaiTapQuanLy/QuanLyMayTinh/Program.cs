using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            // Khởi tạo danh sách máy tính và đọc dữ liệu từ file
            DanhSachMayTinh danhSachMayTinh = new DanhSachMayTinh();
            danhSachMayTinh.NhapTuFile();

            // Thực hiện các phương thức đã thêm vào lớp DanhSachMayTinh

            // 1. Tìm máy tính có giá rẻ nhất
            MayTinh mayTinhReNhat = danhSachMayTinh.TimMayTinhCoGiaReNhat();
            Console.WriteLine("Máy tính có giá rẻ nhất:");
            Console.WriteLine(mayTinhReNhat);

            // 2. Tìm máy tính có CPU có giá rẻ nhất và cao nhất
            MayTinh mayTinhCPUReNhat = danhSachMayTinh.TimMayTinhTheoGiaCPU(false);
            MayTinh mayTinhCPUcaoNhat = danhSachMayTinh.TimMayTinhTheoGiaCPU(true);
            Console.WriteLine("Máy tính có CPU rẻ nhất:");
            Console.WriteLine(mayTinhCPUReNhat);
            Console.WriteLine("Máy tính có CPU cao nhất:");
            Console.WriteLine(mayTinhCPUcaoNhat);

            // 3. Tìm máy tính có RAM có giá rẻ nhất và cao nhất
            MayTinh mayTinhRAMReNhat = danhSachMayTinh.TimMayTinhTheoGiaRAM(false);
            MayTinh mayTinhRAMcaoNhat = danhSachMayTinh.TimMayTinhTheoGiaRAM(true);
            Console.WriteLine("Máy tính có RAM rẻ nhất:");
            Console.WriteLine(mayTinhRAMReNhat);
            Console.WriteLine("Máy tính có RAM cao nhất:");
            Console.WriteLine(mayTinhRAMcaoNhat);

            // 4. Tìm hãng có nhiều CPU sử dụng nhất và ít CPU sử dụng nhất
            string hangNhieuCPU = danhSachMayTinh.TimHangCoNhieuCPU();
            string hangItCPU = danhSachMayTinh.TimHangCoItCPU();
            Console.WriteLine($"Hãng có nhiều CPU nhất: {hangNhieuCPU}");
            Console.WriteLine($"Hãng có ít CPU nhất: {hangItCPU}");

            // 5. Tìm hãng có nhiều RAM sử dụng nhất và ít RAM sử dụng nhất
            string hangNhieuRAM = danhSachMayTinh.TimHangCoNhieuRAM();
            string hangItRAM = danhSachMayTinh.TimHangCoItRAM();
            Console.WriteLine($"Hãng có nhiều RAM nhất: {hangNhieuRAM}");
            Console.WriteLine($"Hãng có ít RAM nhất: {hangItRAM}");

            // 6. Sắp xếp danh sách máy tính
            danhSachMayTinh.SapXepTheoSoLuongThietBi();
            Console.WriteLine("Danh sách máy tính sắp xếp theo số lượng thiết bị:");
            Console.WriteLine(danhSachMayTinh);

            danhSachMayTinh.SapXepTheoGiaThietBi();
            Console.WriteLine("Danh sách máy tính sắp xếp theo giá thiết bị:");
            Console.WriteLine(danhSachMayTinh);

            danhSachMayTinh.SapXepTheoGiaCPU();
            Console.WriteLine("Danh sách máy tính sắp xếp theo giá CPU:");
            Console.WriteLine(danhSachMayTinh);

            danhSachMayTinh.SapXepTheoGiaRAM();
            Console.WriteLine("Danh sách máy tính sắp xếp theo giá RAM:");
            Console.WriteLine(danhSachMayTinh);

            danhSachMayTinh.SapXepTheoSoLuongCPU();
            Console.WriteLine("Danh sách máy tính sắp xếp theo số lượng CPU:");
            Console.WriteLine(danhSachMayTinh);

            danhSachMayTinh.SapXepTheoSoLuongRAM();
            Console.WriteLine("Danh sách máy tính sắp xếp theo số lượng RAM:");
            Console.WriteLine(danhSachMayTinh);

            // 7. Hiển thị danh sách máy tính theo hãng sản xuất
            Console.WriteLine("Hiển thị danh sách máy tính theo hãng sản xuất:");
            danhSachMayTinh.HienThiTheoHangSX();

            // 8. Xóa tất cả máy tính có CPU theo hãng nào đó (ví dụ Intel)
            danhSachMayTinh.XoaMayTinhCoCPUHang("Intel");
            Console.WriteLine("Danh sách máy tính sau khi xóa tất cả máy tính có CPU của hãng Intel:");
            Console.WriteLine(danhSachMayTinh);

            // 9. Cập nhật máy tính nếu CPU của Intel thì giá là 700
            danhSachMayTinh.CapNhatGiaCPUIntel();
            Console.WriteLine("Danh sách máy tính sau khi cập nhật giá CPU của Intel:");
            Console.WriteLine(danhSachMayTinh);

            Console.ReadKey();
        }
    }
}
