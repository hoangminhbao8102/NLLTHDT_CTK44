using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyMayTinh
{
    class Program
    {
        static DanhSachMayTinh danhSachMayTinh = new DanhSachMayTinh();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool tiepTuc = true;
            while (tiepTuc)
            {
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1. Nhập danh sách máy tính từ file");
                Console.WriteLine("2. Hiển thị danh sách máy tính");
                Console.WriteLine("3. Tìm máy tính có giá cao nhất");
                Console.WriteLine("4. Tìm máy tính có giá rẻ nhất");
                Console.WriteLine("5. Tìm máy tính có CPU giá cao nhất");
                Console.WriteLine("6. Tìm máy tính có CPU giá rẻ nhất");
                Console.WriteLine("7. Tìm máy tính có RAM giá cao nhất");
                Console.WriteLine("8. Tìm máy tính có RAM giá rẻ nhất");
                Console.WriteLine("9. Tìm hãng có nhiều CPU nhất");
                Console.WriteLine("10. Tìm hãng có ít CPU nhất");
                Console.WriteLine("11. Tìm hãng có nhiều RAM nhất");
                Console.WriteLine("12. Tìm hãng có ít RAM nhất");
                Console.WriteLine("13. Sắp xếp danh sách máy tính theo số lượng thiết bị");
                Console.WriteLine("14. Sắp xếp danh sách máy tính theo giá thiết bị");
                Console.WriteLine("15. Sắp xếp danh sách máy tính theo giá CPU");
                Console.WriteLine("16. Sắp xếp danh sách máy tính theo giá RAM");
                Console.WriteLine("17. Sắp xếp danh sách máy tính theo số lượng CPU");
                Console.WriteLine("18. Sắp xếp danh sách máy tính theo số lượng RAM");
                Console.WriteLine("19. Hiển thị danh sách máy tính theo hãng sản xuất");
                Console.WriteLine("20. Xóa tất cả máy tính có CPU theo hãng nào đó");
                Console.WriteLine("21. Cập nhật giá CPU của Intel thành 700");
                Console.WriteLine("22. Tìm máy tính theo dung lượng RAM và hãng sản xuất");
                Console.WriteLine("23. Tìm máy tính có dung lượng RAM cao nhất");
                Console.WriteLine("24. Tìm máy tính có dung lượng RAM thấp nhất");
                Console.WriteLine("25. Tìm máy tính có dung lượng RAM lớn hơn x");
                Console.WriteLine("26. Xóa tất cả máy tính có dung lượng RAM x");
                Console.WriteLine("27. Cập nhật dung lượng RAM x thành y");
                Console.WriteLine("28. Lưu dữ liệu hiện tại vào file");
                Console.WriteLine("29. Sắp xếp danh sách máy tính theo chiều tăng giảm của dung lượng RAM");
                Console.WriteLine("30. Tìm hãng sản xuất RAM có dung lượng cao nhất");
                Console.WriteLine("31. Tìm hãng sản xuất RAM có dung lượng thấp nhất");
                Console.WriteLine("32. Tìm máy tính có CPU tốc độ cao nhất");
                Console.WriteLine("33. Tìm máy tính có CPU tốc độ thấp nhất");
                Console.WriteLine("34. Tìm hãng có nhiều CPU tốc độ cao nhất");
                Console.WriteLine("35. Tìm hãng có ít CPU tốc độ thấp nhất");
                Console.WriteLine("36. Sắp xếp danh sách máy tính theo tốc độ CPU");
                Console.WriteLine("37. Hiển thị danh sách máy tính theo tốc độ CPU");
                Console.WriteLine("38. Xóa tất cả máy tính có CPU tốc độ x");
                Console.WriteLine("39. Cập nhật tốc độ CPU x thành y");
                Console.WriteLine("40. Thoát");
                Console.Write("Chọn chức năng (1-40): ");

                int luaChon;
                if (int.TryParse(Console.ReadLine(), out luaChon))
                {
                    switch (luaChon)
                    {
                        case 1:
                            danhSachMayTinh.NhapTuFile();
                            Console.WriteLine("Đã nhập dữ liệu từ file.");
                            break;
                        case 2:
                            Console.WriteLine("----- DANH SÁCH MÁY TÍNH -----");
                            Console.WriteLine(danhSachMayTinh.ToString());
                            break;
                        case 3:
                            var dsMayTinhMaxGia = danhSachMayTinh.TimMayTinhCoGiaCaoNhat();
                            Console.WriteLine("Máy tính có giá cao nhất:");
                            Console.WriteLine(dsMayTinhMaxGia.ToString());
                            break;
                        case 4:
                            var mayTinhReNhat = danhSachMayTinh.TimMayTinhCoGiaReNhat();
                            Console.WriteLine("Máy tính có giá rẻ nhất:");
                            Console.WriteLine(mayTinhReNhat);
                            break;
                        case 5:
                            var mayTinhCPUMaxGia = danhSachMayTinh.TimMayTinhTheoGiaCPU(true);
                            Console.WriteLine("Máy tính có CPU giá cao nhất:");
                            Console.WriteLine(mayTinhCPUMaxGia);
                            break;
                        case 6:
                            var mayTinhCPUReNhat = danhSachMayTinh.TimMayTinhTheoGiaCPU(false);
                            Console.WriteLine("Máy tính có CPU giá rẻ nhất:");
                            Console.WriteLine(mayTinhCPUReNhat);
                            break;
                        case 7:
                            var mayTinhRAMMaxGia = danhSachMayTinh.TimMayTinhTheoGiaRAM(true);
                            Console.WriteLine("Máy tính có RAM giá cao nhất:");
                            Console.WriteLine(mayTinhRAMMaxGia);
                            break;
                        case 8:
                            var mayTinhRAMReNhat = danhSachMayTinh.TimMayTinhTheoGiaRAM(false);
                            Console.WriteLine("Máy tính có RAM giá rẻ nhất:");
                            Console.WriteLine(mayTinhRAMReNhat);
                            break;
                        case 9:
                            var hangNhieuCPU = danhSachMayTinh.TimHangCoNhieuCPU();
                            Console.WriteLine($"Hãng có nhiều CPU nhất: {hangNhieuCPU}");
                            break;
                        case 10:
                            var hangItCPU = danhSachMayTinh.TimHangCoItCPU();
                            Console.WriteLine($"Hãng có ít CPU nhất: {hangItCPU}");
                            break;
                        case 11:
                            var hangNhieuRAM = danhSachMayTinh.TimHangCoNhieuRAM();
                            Console.WriteLine($"Hãng có nhiều RAM nhất: {hangNhieuRAM}");
                            break;
                        case 12:
                            var hangItRAM = danhSachMayTinh.TimHangCoItRAM();
                            Console.WriteLine($"Hãng có ít RAM nhất: {hangItRAM}");
                            break;
                        case 13:
                            danhSachMayTinh.SapXepTheoSoLuongThietBi();
                            Console.WriteLine("Đã sắp xếp theo số lượng thiết bị.");
                            break;
                        case 14:
                            danhSachMayTinh.SapXepTheoGiaThietBi();
                            Console.WriteLine("Đã sắp xếp theo giá thiết bị.");
                            break;
                        case 15:
                            danhSachMayTinh.SapXepTheoGiaCPU();
                            Console.WriteLine("Đã sắp xếp theo giá CPU.");
                            break;
                        case 16:
                            danhSachMayTinh.SapXepTheoGiaRAM();
                            Console.WriteLine("Đã sắp xếp theo giá RAM.");
                            break;
                        case 17:
                            danhSachMayTinh.SapXepTheoSoLuongCPU();
                            Console.WriteLine("Đã sắp xếp theo số lượng CPU.");
                            break;
                        case 18:
                            danhSachMayTinh.SapXepTheoSoLuongRAM();
                            Console.WriteLine("Đã sắp xếp theo số lượng RAM.");
                            break;
                        case 19:
                            danhSachMayTinh.HienThiTheoHangSX();
                            break;
                        case 20:
                            Console.Write("Nhập hãng CPU cần xóa: ");
                            string hangXoa = Console.ReadLine();
                            danhSachMayTinh.XoaMayTinhCoCPUHang(hangXoa);
                            Console.WriteLine($"Đã xóa tất cả máy tính có CPU hãng {hangXoa}.");
                            break;
                        case 21:
                            danhSachMayTinh.CapNhatGiaCPUIntel();
                            Console.WriteLine("Đã cập nhật giá CPU của Intel thành 700.");
                            break;
                        case 22:
                            Console.Write("Nhập dung lượng RAM: ");
                            float dungLuong = float.Parse(Console.ReadLine());
                            Console.Write("Nhập hãng sản xuất RAM: ");
                            string hangSX = Console.ReadLine();
                            var mayTinhDungLuongRAMVaHang = danhSachMayTinh.TimMayTinhTheoDungLuongRAMVaHang(dungLuong, hangSX);
                            Console.WriteLine("Máy tính theo dung lượng RAM và hãng sản xuất:");
                            mayTinhDungLuongRAMVaHang.ForEach(mt => Console.WriteLine(mt));
                            break;
                        case 23:
                            var mayTinhRamCaoNhat = danhSachMayTinh.TimMayTinhCoDungLuongRAMCaoNhat();
                            Console.WriteLine("Máy tính có dung lượng RAM cao nhất:");
                            Console.WriteLine(mayTinhRamCaoNhat);
                            break;
                        case 24:
                            var mayTinhRamThapNhat = danhSachMayTinh.TimMayTinhCoDungLuongRAMThapNhat();
                            Console.WriteLine("Máy tính có dung lượng RAM thấp nhất:");
                            Console.WriteLine(mayTinhRamThapNhat);
                            break;
                        case 25:
                            Console.Write("Nhập dung lượng RAM x: ");
                            float ramLonHon = float.Parse(Console.ReadLine());
                            var mayTinhRamLonHon = danhSachMayTinh.TimMayTinhCoDungLuongRAMLonHon(ramLonHon);
                            Console.WriteLine("Máy tính có dung lượng RAM lớn hơn x:");
                            mayTinhRamLonHon.ForEach(mt => Console.WriteLine(mt));
                            break;
                        case 26:
                            Console.Write("Nhập dung lượng RAM x: ");
                            float ramXoa = float.Parse(Console.ReadLine());
                            danhSachMayTinh.XoaMayTinhCoDungLuongRAM(ramXoa);
                            Console.WriteLine($"Đã xóa tất cả máy tính có dung lượng RAM {ramXoa}.");
                            break;
                        case 27:
                            Console.Write("Nhập dung lượng RAM cũ: ");
                            float ramCu = float.Parse(Console.ReadLine());
                            Console.Write("Nhập dung lượng RAM mới: ");
                            float ramMoi = float.Parse(Console.ReadLine());
                            danhSachMayTinh.CapNhatDungLuongRAM(ramCu, ramMoi);
                            Console.WriteLine($"Đã cập nhật tất cả máy tính có dung lượng RAM {ramCu} thành {ramMoi}.");
                            break;
                        case 28:
                            Console.Write("Nhập đường dẫn file để lưu dữ liệu: ");
                            string path = Console.ReadLine();
                            danhSachMayTinh.LuuDuLieu(path);
                            Console.WriteLine($"Đã lưu dữ liệu hiện tại vào file {path}.");
                            break;
                        case 29:
                            Console.Write("Chọn chiều sắp xếp (1: Tăng dần, 2: Giảm dần): ");
                            int sapXepTangDan = int.Parse(Console.ReadLine());
                            bool tangDan = sapXepTangDan == 1;
                            danhSachMayTinh.SapXepTheoDungLuongRAM(tangDan);
                            Console.WriteLine("Đã sắp xếp danh sách máy tính theo chiều tăng giảm của dung lượng RAM.");
                            break;
                        case 30:
                            var hangRamCaoNhat = danhSachMayTinh.TimHangSanXuatRAMCoDungLuongCaoNhat();
                            Console.WriteLine($"Hãng sản xuất RAM có dung lượng cao nhất: {hangRamCaoNhat}");
                            break;
                        case 31:
                            var hangRamThapNhat = danhSachMayTinh.TimHangSanXuatRAMCoDungLuongThapNhat();
                            Console.WriteLine($"Hãng sản xuất RAM có dung lượng thấp nhất: {hangRamThapNhat}");
                            break;
                        case 32:
                            var mayTinhCPUTocDoCaoNhat = danhSachMayTinh.TimMayTinhTheoTocDoCPU(true);
                            Console.WriteLine("Máy tính có CPU tốc độ cao nhất:");
                            Console.WriteLine(mayTinhCPUTocDoCaoNhat);
                            break;
                        case 33:
                            var mayTinhCPUTocDoThapNhat = danhSachMayTinh.TimMayTinhTheoTocDoCPU(false);
                            Console.WriteLine("Máy tính có CPU tốc độ thấp nhất:");
                            Console.WriteLine(mayTinhCPUTocDoThapNhat);
                            break;
                        case 34:
                            var hangNhieuCPUTocDoCaoNhat = danhSachMayTinh.TimHangCoNhieuCPUTocDoCaoNhat();
                            Console.WriteLine($"Hãng có nhiều CPU tốc độ cao nhất: {hangNhieuCPUTocDoCaoNhat}");
                            break;
                        case 35:
                            var hangItCPUTocDoThapNhat = danhSachMayTinh.TimHangCoItCPUTocDoThapNhat();
                            Console.WriteLine($"Hãng có ít CPU tốc độ thấp nhất: {hangItCPUTocDoThapNhat}");
                            break;
                        case 36:
                            Console.Write("Chọn chiều sắp xếp (1: Tăng dần, 2: Giảm dần): ");
                            int sapXepTocDoTangDan = int.Parse(Console.ReadLine());
                            bool sapXepTocDoTang = sapXepTocDoTangDan == 1;
                            danhSachMayTinh.SapXepTheoTocDoCPU(sapXepTocDoTang);
                            Console.WriteLine("Đã sắp xếp danh sách máy tính theo chiều tăng giảm của tốc độ CPU.");
                            break;
                        case 37:
                            danhSachMayTinh.HienThiTheoTocDoCPU();
                            break;
                        case 38:
                            Console.Write("Nhập tốc độ CPU x: ");
                            float tocDoXoa = float.Parse(Console.ReadLine());
                            danhSachMayTinh.XoaMayTinhCoCPUTocDo(tocDoXoa);
                            Console.WriteLine($"Đã xóa tất cả máy tính có CPU tốc độ {tocDoXoa}.");
                            break;
                        case 39:
                            Console.Write("Nhập tốc độ CPU cũ: ");
                            float tocDoCu = float.Parse(Console.ReadLine());
                            Console.Write("Nhập tốc độ CPU mới: ");
                            float tocDoMoi = float.Parse(Console.ReadLine());
                            danhSachMayTinh.CapNhatTocDoCPU(tocDoCu, tocDoMoi);
                            Console.WriteLine($"Đã cập nhật tất cả máy tính có CPU tốc độ {tocDoCu} thành {tocDoMoi}.");
                            break;
                        case 40:
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
