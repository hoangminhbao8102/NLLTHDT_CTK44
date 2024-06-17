using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai2_QuanLyNhanVien_
{
    public class Menu
    {
        private DanhSachChamCong danhSachChamCong;
        private DanhSachNhanVien danhSachNhanVien;

        public Menu()
        {
            danhSachNhanVien = new DanhSachNhanVien();
            danhSachChamCong = new DanhSachChamCong();
        }

        private void Show()
        {
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Nhập dữ liệu nguồn", (int)ChucNang.NhapDuLieuNguon);
            Console.WriteLine("{0}. Xuất danh sách nhân viên", (int)ChucNang.XuatDanhSachNhanVien);
            Console.WriteLine("{0}. Xuất danh sách chấm công", (int)ChucNang.XuatDanhSachChamCong);
            Console.WriteLine("{0}. Xuất danh sách toàn bộ nhân viên (Yêu cầu: Canh lề các cột).", (int)ChucNang.XuatDanhSachCanhLe);
            Console.WriteLine("{0}. Sắp xếp danh sách nhân viên tăng dần theo họ tên.", (int)ChucNang.SapXepNhanVienTheoTen);
            Console.WriteLine("{0}. Xuất danh sách nhân viên, phân loại theo nhân viên hợp đồng và nhân viên theo giờ", (int)ChucNang.XuatNhanVienTheoLoai);
            Console.WriteLine("{0}. Xuất bảng lương của nhân viên có mã (manv) cho trước. Trong đó có các cột: tháng, số ngày/giờ công, tiền lương tháng đó.", (int)ChucNang.XuatBangLuongTheoMaNhanVien);
            Console.WriteLine("{0}. Tính tổng tiền lương của nhân viên", (int)ChucNang.TinhTongLuongNhanVien);
            Console.WriteLine("{0}. Xuất thông tin chi tiết về nhân viên có mã (manv), kể cả bảng lương và tổng lương.", (int)ChucNang.XuatThongTinChiTietNhanVien);
            Console.WriteLine("{0}. Tìm các nhân viên nữ có thâm niên công tác ít nhất là 2 năm.", (int)ChucNang.TimNhanVienNuThamNien);
            Console.WriteLine("{0}. Tìm các nhân viên theo tháng không làm việc trong tháng 7.", (int)ChucNang.TimNhanVienKhongLamViecThang7);
            Console.WriteLine("{0}. Tìm nhân viên (hợp đồng) có hệ số lương cao nhất tại công ty", (int)ChucNang.TimNhanVienHopDongHeSoLuongCaoNhat);
            Console.WriteLine("{0}. Tìm nhân viên (theo giờ) có mức thưởng cao nhất trong tháng 12.", (int)ChucNang.TimNhanVienTheoGioThuongCaoNhatThang12);
            Console.WriteLine("{0}. Tìm nhân viên được trả lương nhiều nhất trong tháng 12.", (int)ChucNang.TimNhanVienLuongCaoNhatThang12);
            Console.WriteLine("{0}. Tìm những nhân viên đến hạn được nâng lương (có thâm niên là 3, 6, 9, … năm).", (int)ChucNang.TimNhanVienDenHanNangLuong);
            Console.WriteLine("{0}. Nâng hệ số lương lên 0.33 cho tất cả các nhân viên đến hạn được nâng lương.", (int)ChucNang.NangHeSoLuong);
            Console.WriteLine("{0}. Liệt kê danh sách nhân viên có họ (honv) cho trước", (int)ChucNang.LietKeNhanVienTheoHo);
            Console.WriteLine("{0}. Tìm tháng có số tiền lương phải trả cao nhất.", (int)ChucNang.TimThangLuongCaoNhat);
            Console.WriteLine("{0}. Tìm nhân viên có phụ cấp cao nhất.", (int)ChucNang.TimNhanVienPhuCapCaoNhat);
            Console.WriteLine("{0}. Tính tổng tiền lương phải trả cho các nhân viên hợp đồng trong tháng cho trước.", (int)ChucNang.TinhTongLuongHopDongThang);
            Console.WriteLine("{0}. Tính tổng tiền lương phải trả cho các nhân viên làm việc theo giờ trong tháng cho trước.", (int)ChucNang.TinhTongLuongTheoGioThang);
            Console.WriteLine("{0}. Tính tổng tiền lương phải trả cho tất cả nhân viên trong một năm.", (int)ChucNang.TinhTongLuongNam);
            Console.WriteLine("{0}. Tính tổng số giờ công của tất cả các nhân viên làm việc theo giờ trong tháng 12", (int)ChucNang.TinhTongGioCongThang12);
            Console.WriteLine("{0}. Tính tổng số ngày công của các nhân viên hợp đồng trong một năm.", (int)ChucNang.TinhTongNgayCongHopDongNam);
            Console.WriteLine("{0}. Xóa tất cả những nhân viên làm việc theo giờ.", (int)ChucNang.XoaNhanVienTheoGio);
            Console.WriteLine("{0}. Thoat", (int)ChucNang.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNang Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNang)).Length;

            int menu = 0;

            do
            {
                this.Show();
                Console.Write("Nhap so de chon menu (0..{0}) : ", SoMenu);
            } while (menu < 0 || menu >= SoMenu);

            return (ChucNang)menu;
        }

        private void Process(ChucNang menu)
        {
            switch (menu)
            {
                case ChucNang.NhapDuLieuNguon:
                    danhSachNhanVien = DuLieuNguon.TaoDanhSachNhanVien();
                    danhSachChamCong = DuLieuNguon.TaoDanhSachChamCong();
                    break;
                case ChucNang.XuatDanhSachNhanVien:
                    Console.WriteLine(danhSachNhanVien);
                    break;
                case ChucNang.XuatDanhSachChamCong:
                    Console.WriteLine(danhSachChamCong);
                    break;
                case ChucNang.XuatDanhSachCanhLe:
                    danhSachNhanVien.XuatDanhSachCanhLe();
                    break;
                case ChucNang.SapXepNhanVienTheoTen:
                    danhSachNhanVien.SapXepTheoTen();
                    break;
                case ChucNang.XuatNhanVienTheoLoai:
                    danhSachNhanVien.XuatNhanVienTheoLoai();
                    break;
                case ChucNang.XuatBangLuongTheoMaNhanVien:
                    Console.Write("Nhập mã NV cần xuất bảng lương: ");
                    int maNV = int.Parse(Console.ReadLine());
                    danhSachNhanVien.XuatBangLuong(maNV, danhSachChamCong);
                    break;
                case ChucNang.TinhTongLuongNhanVien:
                    Console.Write("Nhập mã NV cần tính tổng lương: ");
                    int maNVTinhLuong = int.Parse(Console.ReadLine());
                    double tongLuong = danhSachNhanVien.TinhTongLuong(maNVTinhLuong, danhSachChamCong);
                    Console.WriteLine($"Tổng lương: {tongLuong}");
                    break;
                case ChucNang.XuatThongTinChiTietNhanVien:
                    Console.Write("Nhập mã NV cần xuất thông tin chi tiết: ");
                    int maNVChiTiet = int.Parse(Console.ReadLine());
                    danhSachNhanVien.XuatThongTinChiTiet(maNVChiTiet, danhSachChamCong);
                    break;
                case ChucNang.TimNhanVienNuThamNien:
                    danhSachNhanVien.TimNhanVienNuThamNien();
                    break;
                case ChucNang.TimNhanVienKhongLamViecThang7:
                    danhSachNhanVien.TimNhanVienKhongLamViecThang7(danhSachChamCong);
                    break;
                case ChucNang.TimNhanVienHopDongHeSoLuongCaoNhat:
                    danhSachNhanVien.TimNhanVienHopDongHeSoLuongCaoNhat();
                    break;
                case ChucNang.TimNhanVienTheoGioThuongCaoNhatThang12:
                    danhSachNhanVien.TimNhanVienTheoGioThuongCaoNhatThang12(danhSachChamCong);
                    break;
                case ChucNang.TimNhanVienLuongCaoNhatThang12:
                    var nvLuongCao = danhSachNhanVien.TimNhanVienLuongCaoNhatThang12();
                    if (nvLuongCao != null)
                        Console.WriteLine($"Nhân viên lương cao nhất tháng 12: {nvLuongCao}");
                    else
                        Console.WriteLine("Không tìm thấy nhân viên lương cao nhất tháng 12.");
                    break;
                case ChucNang.TimNhanVienDenHanNangLuong:
                    danhSachNhanVien.TimNhanVienDenHanNangLuong();
                    break;
                case ChucNang.NangHeSoLuong:
                    danhSachNhanVien.NangHeSoLuong();
                    break;
                case ChucNang.LietKeNhanVienTheoHo:
                    Console.Write("Nhập họ nhân viên cần liệt kê: ");
                    string ho = Console.ReadLine();
                    danhSachNhanVien.LietKeNhanVienTheoHo(ho);
                    break;
                case ChucNang.TimThangLuongCaoNhat:
                    danhSachNhanVien.TimThangLuongCaoNhat(danhSachChamCong);
                    break;
                case ChucNang.TimNhanVienPhuCapCaoNhat:
                    danhSachNhanVien.TimNhanVienPhuCapCaoNhat();
                    break;
                case ChucNang.TinhTongLuongHopDongThang:
                    Console.Write("Nhập tháng cần tính tổng lương hợp đồng: ");
                    int thangHD = int.Parse(Console.ReadLine());
                    double tongLuongHD = danhSachNhanVien.TinhTongLuongHopDongThang(thangHD, danhSachChamCong);
                    Console.WriteLine($"Tổng lương hợp đồng tháng {thangHD}: {tongLuongHD}");
                    break;
                case ChucNang.TinhTongLuongTheoGioThang:
                    Console.Write("Nhập tháng cần tính tổng lương theo giờ: ");
                    int thangTG = int.Parse(Console.ReadLine());
                    double tongLuongTG = danhSachNhanVien.TinhTongLuongTheoGioThang(thangTG, danhSachChamCong);
                    Console.WriteLine($"Tổng lương theo giờ tháng {thangTG}: {tongLuongTG}");
                    break;
                case ChucNang.TinhTongLuongNam:
                    double tongLuongNam = danhSachNhanVien.TinhTongLuongNam();
                    Console.WriteLine($"Tổng lương năm: {tongLuongNam}");
                    break;
                case ChucNang.TinhTongGioCongThang12:
                    int tongGioThang12 = danhSachNhanVien.TinhTongGioCongThang12(danhSachChamCong);
                    Console.WriteLine($"Tổng số giờ công tháng 12: {tongGioThang12}");
                    break;
                case ChucNang.TinhTongNgayCongHopDongNam:
                    int tongNgayHDNam = danhSachNhanVien.TinhTongNgayCongHopDongNam(danhSachChamCong);
                    Console.WriteLine($"Tổng số ngày công hợp đồng trong năm: {tongNgayHDNam}");
                    break;
                case ChucNang.XoaNhanVienTheoGio:
                    danhSachNhanVien.XoaNhanVienTheoGio();
                    Console.WriteLine("Đã xóa tất cả nhân viên làm việc theo giờ.");
                    break;
                case ChucNang.Thoat:
                    Console.WriteLine("Kết thúc chương trình");
                    break;
                default:
                    Console.WriteLine("Chức năng không hợp lệ");
                    break;
            }
        }

        public void Run()
        {
            ChucNang menu = ChucNang.Thoat;
            do
            {
                menu = this.Select();
                this.Process(menu);
            } while (menu != ChucNang.Thoat);
        }
    }
}
