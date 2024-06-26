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
                Console.WriteLine("6. Tìm thành phố có nhiều thuê bao nhất, có ít thuê bao nhất.");
                Console.WriteLine("7. Tìm thuê bao sở hữu ít số điện thoại nhất.");
                Console.WriteLine("8. Sắp xếp khách hàng tăng giảm theo họ tên, số lượng số điện thoại sở hữu.");
                Console.WriteLine("9. Hiển thị danh sách các thành phố theo chiều tăng, giảm của số lượng thuê bao.");
                Console.WriteLine("10. Tìm tháng không có thuê bao nào đăng ký.");
                Console.WriteLine("11. Tìm tất cả các khách hàng theo giới tính.");
                Console.WriteLine("12. Xóa tất cả khách hàng thuộc một tỉnh nào đó.");
                Console.WriteLine("13. Tất cả khách hàng nào sinh tháng 1 thì được tặng thêm một số điện thoại mới có số là cmnd.");
                Console.WriteLine("14. Tìm ngày có nhiều khách hàng đăng ký nhất, ít người đăng ký nhất.");
                Console.WriteLine("15. Thống kê và hiển thị dữ liệu theo từng tỉnh và mỗi tỉnh hiển thị theo thành phố");
                Console.WriteLine("16. Tìm thành phố có nhiều thuê bao cố định nhất, có ít thuê bao nhất di động nhất.");
                Console.WriteLine("17. Tìm thuê bao sở hữu ít số điện thoại cố định nhất.");
                Console.WriteLine("18. Tìm tháng không có thuê bao nào đăng ký số cố định, di động.");
                Console.WriteLine("19. Tìm tất cả các thuê bao di động theo giới tính.");
                Console.WriteLine("20. Xóa tất cả thuê bao theo ngày lắp đặt.");
                Console.WriteLine("21. Tìm khách hàng di động theo nhà cung cấp dịch vụ");
                Console.WriteLine("22. Hiển thị số lượng thuê bao của từng loại hình thuê bao");
                Console.WriteLine("23. Hiển thị số lượng thuê bao cố định theo từng nhà cung cấp dịch vụ");
                Console.WriteLine("24. Thoát");
                Console.Write("Chọn chức năng (1-24): ");

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
                            danhBa.TimThanhPhoNhieuItThueBaoNhat();
                            break;
                        case 7:
                            var itSDTNhat = danhBa.TimThueBaoItSDTNhat();
                            if (itSDTNhat != null)
                            {
                                Console.WriteLine($"Thuê bao sở hữu ít số điện thoại nhất là: {itSDTNhat.HoTen} - Số ĐT: {itSDTNhat.SDT}");
                            }
                            else
                            {
                                Console.WriteLine("Không tìm thấy thuê bao nào.");
                            }
                            break;
                        case 8:
                            Console.WriteLine("Chọn kiểu sắp xếp tăng hoặc giảm theo họ tên:");
                            Console.WriteLine("1. Tăng dần theo họ tên");
                            Console.WriteLine("2. Giảm dần theo họ tên");
                            Console.Write("Chọn (1-2): ");
                            int chonSapXepHoTen = int.Parse(Console.ReadLine());
                            danhBa.SapXepTheoHoTenVaSoDienThoai(chonSapXepHoTen == 1);
                            Console.WriteLine("Danh sách đã được sắp xếp theo họ tên.");
                            break;
                        case 9:
                            danhBa.HienThiThanhPhoTheoSoLuongThueBao();
                            break;
                        case 10:
                            danhBa.TimThangKhongCoDangKy();
                            break;
                        case 11:
                            Console.Write("Nhập giới tính cần tìm (Nam/Nu): ");
                            GioiTinh gioiTinh = (GioiTinh)Enum.Parse(typeof(GioiTinh), Console.ReadLine(), true);
                            danhBa.TimKhachHangTheoGioiTinh(gioiTinh);
                            break;
                        case 12:
                            Console.Write("Nhập tên tỉnh cần xóa khách hàng: ");
                            string tinhXoa = Console.ReadLine();
                            danhBa.XoaKhachHangTheoTinh(tinhXoa);
                            Console.WriteLine($"Đã xóa tất cả khách hàng từ tỉnh {tinhXoa}.");
                            break;
                        case 13:
                            danhBa.TangSoDienThoaiChoSinhThang1();
                            Console.WriteLine("Đã tặng số điện thoại mới cho khách hàng sinh vào tháng 1.");
                            break;
                        case 14:
                            danhBa.TimNgayDangKyNhieuItNhat();
                            break;
                        case 15:
                            danhBa.ThongKeTheoTinhVaThanhPho();
                            break;
                        case 16:
                            danhBa.TimThanhPhoNhieuItThueBaoCoDinhDiDong();
                            break;
                        case 17:
                            var itSoCoDinhNhat = danhBa.TimThueBaoItSoCoDinhNhat();
                            if (itSoCoDinhNhat != null)
                            {
                                Console.WriteLine($"Thuê bao cố định sở hữu ít số điện thoại nhất là: {itSoCoDinhNhat.HoTen} - Số ĐT: {itSoCoDinhNhat.SDT}");
                            }
                            else
                            {
                                Console.WriteLine("Không tìm thấy thuê bao cố định nào.");
                            }
                            break;
                        case 18:
                            Console.WriteLine("Chọn loại thuê bao để tìm tháng không có đăng ký:");
                            Console.WriteLine("1. Cố định");
                            Console.WriteLine("2. Di động");
                            int loaiThueBao = int.Parse(Console.ReadLine());
                            danhBa.TimThangKhongCoDangKyLoaiThueBao((ThueBaoType)(loaiThueBao - 1));
                            break;
                        case 19:
                            Console.Write("Nhập giới tính cần tìm cho thuê bao di động (Nam/Nu): ");
                            GioiTinh gioiTinhMobile = (GioiTinh)Enum.Parse(typeof(GioiTinh), Console.ReadLine(), true);
                            var danhBaMobile = danhBa.TimThueBaoDiDongTheoGioiTinh(gioiTinhMobile);
                            Console.WriteLine($"Danh sách thuê bao di động theo giới tính {gioiTinhMobile}:");
                            Console.WriteLine(danhBaMobile.ToString());
                            break;
                        case 20:
                            Console.Write("Nhập ngày lắp đặt cần xóa (yyyy-MM-dd): ");
                            DateTime ngayLapDat = DateTime.Parse(Console.ReadLine());
                            danhBa.XoaThueBaoTheoNgayLapDat(ngayLapDat);
                            Console.WriteLine("Đã xóa các thuê bao theo ngày lắp đặt.");
                            break;
                        case 21:
                            Console.Write("Nhập nhà cung cấp dịch vụ cho thuê bao di động cần tìm: ");
                            string nhaCungCap = Console.ReadLine();
                            var danhBaNCC = danhBa.TimKhachHangDiDongTheoNhaCungCap(nhaCungCap);
                            Console.WriteLine($"Danh sách khách hàng di động từ nhà cung cấp {nhaCungCap}:");
                            Console.WriteLine(danhBaNCC.ToString());
                            break;
                        case 22:
                            danhBa.HienThiSoLuongThueBaoTheoLoai();
                            break;
                        case 23:
                            danhBa.HienThiSoLuongThueBaoCoDinhTheoNhaCungCap();
                            break;
                        case 24:
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

                Console.ReadKey();
            }
        }
    }
}
