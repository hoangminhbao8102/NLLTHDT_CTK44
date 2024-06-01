using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_D_Bai8
{
    public class Menu
    {
        private DanhSachHocSinh ds;

        public Menu()
        {
            ds = new DanhSachHocSinh();
        }

        private void Show()
        {
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Thoát", (int)ChucNang.Thoat);
            Console.WriteLine("{0}. Nhập học sinh cố định", (int)ChucNang.NhapCoDinh);
            Console.WriteLine("{0}. Nhập học sinh từ bàn phím", (int)ChucNang.NhapTuBanPhim);
            Console.WriteLine("{0}. Sắp xếp học sinh", (int)ChucNang.SapXep);
            Console.WriteLine("{0}. So sánh hai học sinh", (int)ChucNang.SoSanh);
            Console.WriteLine("{0}. Tìm danh sách lớp", (int)ChucNang.TimDanhSachLop);
            Console.WriteLine("{0}. Tìm điểm TB cao nhất", (int)ChucNang.TimDiemTBCaoNhat);
            Console.WriteLine("{0}. Tìm học sinh theo lớp", (int)ChucNang.TimHocSinhTheoLop);
            Console.WriteLine("{0}. Tìm học sinh theo xếp loại", (int)ChucNang.TimHocSinhTheoXepLoai);
            Console.WriteLine("{0}. Tìm học sinh có ĐTB cao nhất", (int)ChucNang.TimHocSinhCoDTBCaoNhat);
            Console.WriteLine("{0}. Tìm lớp nhiều học sinh giỏi nhất", (int)ChucNang.TimLopNhieuHSGioiNhat);
            Console.WriteLine("{0}. Tìm học sinh thi lại môn toán theo lớp", (int)ChucNang.TimHocSinhThiLaiMonToanTheoLop);
            Console.WriteLine("{0}. Tìm học sinh không thi lại môn nào", (int)ChucNang.TimHocSinhKhongThiLai);
            Console.WriteLine("{0}. Tìm học sinh họ Nguyễn loại Khá", (int)ChucNang.TimHocSinhHoNguyenLoaiKha);
            Console.WriteLine("{0}. Tính điểm TB theo lớp", (int)ChucNang.TinhDiemTBTheoLop);
            Console.WriteLine("{0}. Xóa học sinh có điểm TB dưới 2", (int)ChucNang.XoaHocSinhDiemTBThap);
            Console.WriteLine("{0}. Thống kê học sinh theo xếp loại", (int)ChucNang.ThongKeHocSinhTheoXepLoai);
            Console.WriteLine("{0}. Tìm học sinh lớn hơn 15 tuổi", (int)ChucNang.TimHocSinhLonHon15Tuoi);
            Console.WriteLine("{0}. Tìm học sinh có tên dài nhất", (int)ChucNang.TimHocSinhTenDaiNhat);
            Console.WriteLine("{0}. Tìm học sinh xếp vị thứ nhất của mỗi lớp", (int)ChucNang.TimHocSinhXepViThu1);
            Console.WriteLine("{0}. Tìm học sinh xếp loại TB trở xuống", (int)ChucNang.TimHocSinhXepLoaiTBTrXuong);
            Console.WriteLine("{0}. Cộng điểm cho học sinh không rớt môn nào", (int)ChucNang.CongDiemChoHocSinhKhongRotMon);
            Console.WriteLine("{0}. Xóa học sinh có họ Trần", (int)ChucNang.XoaHocSinhHoTran);
            Console.WriteLine("{0}. Xuất danh sách học sinh theo lớp", (int)ChucNang.XuatDanhSachTheoLop);
            Console.WriteLine("{0}. Xuất danh sách học sinh theo xếp loại", (int)ChucNang.XuatDanhSachTheoXepLoai);
            Console.WriteLine("{0}. Xuất danh sách học sinh theo năm sinh", (int)ChucNang.XuatDanhSachTheoNamSinh);
            Console.WriteLine("==================================================");
        }

        private ChucNang Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNang)).Length;

            int menu = 0;

            do
            {
                this.Show();
                Console.Write("Nhập số để chọn nenu (0..{0}) : ", SoMenu);
            } while (menu < 0 || menu >= SoMenu);

            return (ChucNang)menu;
        }

        private void Process(ChucNang menu)
        {
            switch (menu)
            {
                case ChucNang.Thoat:
                    Console.WriteLine("Kết thúc chương trình");
                    break;
                case ChucNang.NhapCoDinh:
                    ds.NhapCoDinh();
                    break;
                case ChucNang.NhapTuBanPhim:
                    ds.NhapTuBanPhim();
                    break;
                case ChucNang.SapXep:
                    Console.WriteLine("Chon kieu sap xep: 0. Giam DTB, 1. Tang Ho Ten, 2. Tang Vi Thu, 3. Giam Lop");
                    int ksxChoice = Convert.ToInt32(Console.ReadLine());
                    ds.SapXep((KieuSapXep)ksxChoice);
                    break;
                case ChucNang.SoSanh:
                    // Giả sử đã có cách nhập thông tin hai học sinh và kiểu so sánh
                    HocSinh a = new HocSinh(); // Cần có cơ chế nhập học sinh a
                    HocSinh b = new HocSinh(); // Cần có cơ chế nhập học sinh b
                    Console.WriteLine("Nhap kieu sap xep: 0. Giam DTB, 1. Tang Ho Ten, 2. Tang Vi Thu, 3. Giam Lop");
                    KieuSapXep kieu = (KieuSapXep)Convert.ToInt32(Console.ReadLine());
                    ds.SoSanh(a, b, kieu);
                    break;
                case ChucNang.TimDanhSachLop:
                    var mangChuoi = ds.TimDanhSachLop();
                    Console.WriteLine(mangChuoi.ToString());
                    break;
                case ChucNang.TimDiemTBCaoNhat:
                    float maxDiemTB = ds.TimDiemTBCaoNhat();
                    Console.WriteLine($"Diem TB cao nhat la: {maxDiemTB}");
                    break;
                case ChucNang.TimHocSinhTheoLop:
                    Console.WriteLine("Nhap lop:");
                    string lop = Console.ReadLine();
                    var dsLop = ds.TimHocSinhTheoLop(lop);
                    Console.WriteLine(dsLop.ToString());
                    break;
                case ChucNang.TimHocSinhTheoXepLoai:
                    Console.WriteLine("Nhap xep loai (0: Xuất Sắc, 1: Giỏi, 2: Khá, 3: Trung Bình, 4: Yếu):");
                    XepLoai xl = (XepLoai)Convert.ToInt32(Console.ReadLine());
                    var dsXepLoai = ds.TimHocSinhTheoXepLoai(xl);
                    Console.WriteLine(dsXepLoai.ToString());
                    break;
                case ChucNang.TimHocSinhCoDTBCaoNhat:
                    var dsDTBCaoNhat = ds.TimHocSinhCoDTBCaoNhat();
                    Console.WriteLine(dsDTBCaoNhat.ToString());
                    break;
                case ChucNang.TimLopNhieuHSGioiNhat:
                    var lopHSGioiNhat = ds.TimLopNhieuHSGioiNhat();
                    Console.WriteLine(lopHSGioiNhat.ToString());
                    break;
                case ChucNang.TimHocSinhThiLaiMonToanTheoLop:
                    Console.WriteLine("Nhap lop:");
                    string lopThiLai = Console.ReadLine();
                    var dsThiLai = ds.TimHocSinhThiLaiMonToanTheoLop(lopThiLai);
                    Console.WriteLine(dsThiLai.ToString());
                    break;
                case ChucNang.TimHocSinhKhongThiLai:
                    var dsKhongThiLai = ds.TimHocSinhKhongThiLai();
                    Console.WriteLine(dsKhongThiLai.ToString());
                    break;
                case ChucNang.TimHocSinhHoNguyenLoaiKha:
                    var dsNguyenKha = ds.TimHocSinhHoNguyenLoaiKha();
                    Console.WriteLine(dsNguyenKha.ToString());
                    break;
                case ChucNang.TinhDiemTBTheoLop:
                    var diemTBTheoLop = ds.TinhDiemTBTheoLop();
                    foreach (var lopDiemTB in diemTBTheoLop)
                    {
                        Console.WriteLine($"Lop {lopDiemTB.Key} co diem TB la {lopDiemTB.Value}");
                    }
                    break;
                case ChucNang.XoaHocSinhDiemTBThap:
                    ds.XoaHocSinhDiemTBThap();
                    Console.WriteLine("Da xoa hoc sinh co diem TB thap.");
                    break;
                case ChucNang.ThongKeHocSinhTheoXepLoai:
                    var thongKe = ds.ThongKeHocSinhTheoXepLoai();
                    foreach (var lopThongKe in thongKe)
                    {
                        Console.WriteLine($"Lop {lopThongKe.Key}:");
                        foreach (var xepLoai in lopThongKe.Value)
                        {
                            Console.WriteLine($"  {xepLoai.Key}: {xepLoai.Value} hoc sinh");
                        }
                    }
                    break;

                case ChucNang.TimHocSinhLonHon15Tuoi:
                    var dsLonHon15 = ds.TimHocSinhLonHon15Tuoi();
                    Console.WriteLine(dsLonHon15.ToString());
                    break;
                case ChucNang.TimHocSinhTenDaiNhat:
                    var hocSinhTenDaiNhat = ds.TimHocSinhTenDaiNhat();
                    Console.WriteLine($"Hoc sinh co ten dai nhat: {hocSinhTenDaiNhat.HoVaTen}");
                    break;
                case ChucNang.TimHocSinhXepViThu1:
                    var hsViThu1 = ds.TimHocSinhXepViThu1();
                    Console.WriteLine("Hoc sinh xep vi thu nhat theo lop:");
                    foreach (var item in hsViThu1)
                    {
                        Console.WriteLine($"Lop {item.Key}: {item.Value.HoVaTen}");
                    }
                    break;
                case ChucNang.TimHocSinhXepLoaiTBTrXuong:
                    var dsXepLoaiTBXuong = ds.TimHocSinhXepLoaiTBTrXuong();
                    Console.WriteLine(dsXepLoaiTBXuong.ToString());
                    break;
                case ChucNang.CongDiemChoHocSinhKhongRotMon:
                    ds.CongDiemChoHocSinhKhongRotMon();
                    Console.WriteLine("Da cong diem cho hoc sinh khong rot mon.");
                    break;
                case ChucNang.XoaHocSinhHoTran:
                    ds.XoaHocSinhHoTran();
                    Console.WriteLine("Da xoa hoc sinh ho Tran.");
                    break;
                case ChucNang.XuatDanhSachTheoLop:
                    ds.XuatDanhSachTheoLop();
                    break;
                case ChucNang.XuatDanhSachTheoXepLoai:
                    ds.XuatDanhSachTheoXepLoai();
                    break;
                case ChucNang.XuatDanhSachTheoNamSinh:
                    ds.XuatDanhSachTheoNamSinh();
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ");
                    break;
            }
            Console.WriteLine("Nhấn Enter để tiếp tục..");
            Console.ReadLine();
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
