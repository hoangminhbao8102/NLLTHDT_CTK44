using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class MenuTimKiemDanhBa
    {
        private DanhBa danhBa;

        public MenuTimKiemDanhBa()
        {
            danhBa = new DanhBa();
        }

        private void Show()
        {
            Console.Clear();
            Console.WriteLine("================= MENU TÌM KIẾM ==================");
            Console.WriteLine("{0}. Tìm thuê bao có nhiều số điện thoại nhất.", (int)ChucNangTimKiemDanhBa.TimThueBaoCoNhieuSDT);
            Console.WriteLine("{0}. Tìm thành phố có nhiều thuê bao nhất, có ít thuê bao nhất.", (int)ChucNangTimKiemDanhBa.TimThanhPhoNhieuItThueBaoNhat);
            Console.WriteLine("{0}. Tìm thuê bao sở hữu ít số điện thoại nhất.", (int)ChucNangTimKiemDanhBa.TimThueBaoItSDTNhat);
            Console.WriteLine("{0}. Tìm tháng không có thuê bao nào đăng ký.", (int)ChucNangTimKiemDanhBa.TimThangKhongCoDangKy);
            Console.WriteLine("{0}. Tìm tất cả các khách hàng theo giới tính.", (int)ChucNangTimKiemDanhBa.TimKhachHangTheoGioiTinh);
            Console.WriteLine("{0}. Tìm ngày có nhiều khách hàng đăng ký nhất, ít người đăng ký nhất.", (int)ChucNangTimKiemDanhBa.TimNgayDangKyNhieuItNhat);
            Console.WriteLine("{0}. Tìm thành phố có nhiều thuê bao cố định nhất, có ít thuê bao nhất di động nhất.", (int)ChucNangTimKiemDanhBa.TimThanhPhoNhieuItThueBaoCoDinhDiDong);
            Console.WriteLine("{0}. Tìm thuê bao sở hữu ít số điện thoại cố định nhất.", (int)ChucNangTimKiemDanhBa.TimThueBaoItSoCoDinhNhat);
            Console.WriteLine("{0}. Tìm tháng không có thuê bao nào đăng ký số cố định, di động.", (int)ChucNangTimKiemDanhBa.TimThangKhongCoDangKyLoaiThueBao);
            Console.WriteLine("{0}. Tìm tất cả các thuê bao di động theo giới tính.", (int)ChucNangTimKiemDanhBa.TimThueBaoDiDongTheoGioiTinh);
            Console.WriteLine("{0}. Tìm khách hàng di động theo nhà cung cấp dịch vụ.", (int)ChucNangTimKiemDanhBa.TimKhachHangDiDongTheoNhaCungCap);
            Console.WriteLine("{0}. Thoát.", (int)ChucNangTimKiemDanhBa.Thoat);
            Console.WriteLine("==================================================");
        }

        private ChucNangTimKiemDanhBa Select()
        {
            int SoMenu = Enum.GetNames(typeof(ChucNangTimKiemDanhBa)).Length;

            int menu;
            bool isValid;
            do
            {
                this.Show();
                Console.Write("Nhập số để chọn menu tìm kiếm (0..{0}) : ", SoMenu - 1);
                isValid = int.TryParse(Console.ReadLine(), out menu);

                if (!isValid || menu < 0 || menu >= SoMenu)
                {
                    Console.WriteLine("Giá trị nhập không hợp lệ, vui lòng nhập lại!");
                    isValid = false;
                }

            } while (!isValid);

            return (ChucNangTimKiemDanhBa)menu;
        }

        private void Process(ChucNangTimKiemDanhBa menu)
        {
            switch (menu)
            {
                case ChucNangTimKiemDanhBa.Thoat:
                    Console.WriteLine("Kết thúc chương trình tìm kiếm!");
                    Console.WriteLine("Nhấn phím bất kỳ để quay lại menu chính...");
                    Console.ReadKey();
                    break;
                case ChucNangTimKiemDanhBa.TimThueBaoCoNhieuSDT:
                    var thueBaoNhieuSDT = danhBa.TimThueBaoCoNhieuSDT();
                    Console.WriteLine("Thuê bao có nhiều số điện thoại nhất:");
                    Console.WriteLine(thueBaoNhieuSDT);
                    break;
                case ChucNangTimKiemDanhBa.TimThanhPhoNhieuItThueBaoNhat:
                    danhBa.TimThanhPhoNhieuItThueBaoNhat();
                    break;
                case ChucNangTimKiemDanhBa.TimThueBaoItSDTNhat:
                    var thueBaoItSDT = danhBa.TimThueBaoItSDTNhat();
                    Console.WriteLine("Thuê bao sở hữu ít số điện thoại nhất:");
                    Console.WriteLine(thueBaoItSDT);
                    break;
                case ChucNangTimKiemDanhBa.TimThangKhongCoDangKy:
                    danhBa.TimThangKhongCoDangKy();
                    break;
                case ChucNangTimKiemDanhBa.TimKhachHangTheoGioiTinh:
                    Console.Write("Nhập giới tính (Nam=0, Nữ=1, Khác=2): ");
                    GioiTinh gioiTinh = (GioiTinh)int.Parse(Console.ReadLine());
                    danhBa.TimKhachHangTheoGioiTinh(gioiTinh);
                    break;
                case ChucNangTimKiemDanhBa.TimNgayDangKyNhieuItNhat:
                    danhBa.TimNgayDangKyNhieuItNhat();
                    break;
                case ChucNangTimKiemDanhBa.TimThanhPhoNhieuItThueBaoCoDinhDiDong:
                    danhBa.TimThanhPhoNhieuItThueBaoCoDinhDiDong();
                    break;
                case ChucNangTimKiemDanhBa.TimThueBaoItSoCoDinhNhat:
                    var thueBaoItSoCoDinh = danhBa.TimThueBaoItSoCoDinhNhat();
                    Console.WriteLine("Thuê bao sở hữu ít số điện thoại cố định nhất:");
                    Console.WriteLine(thueBaoItSoCoDinh);
                    break;
                case ChucNangTimKiemDanhBa.TimThangKhongCoDangKyLoaiThueBao:
                    Console.Write("Chọn loại thuê bao (Cố định=0, Di động=1): ");
                    ThueBaoType loaiThueBao = (ThueBaoType)int.Parse(Console.ReadLine());
                    danhBa.TimThangKhongCoDangKyLoaiThueBao(loaiThueBao);
                    break;
                case ChucNangTimKiemDanhBa.TimThueBaoDiDongTheoGioiTinh:
                    Console.Write("Nhập giới tính (Nam=0, Nữ=1, Khác=2) cho thuê bao di động: ");
                    GioiTinh gioiTinhDiDong = (GioiTinh)int.Parse(Console.ReadLine());
                    var danhBaDiDong = danhBa.TimThueBaoDiDongTheoGioiTinh(gioiTinhDiDong);
                    Console.WriteLine("Danh sách thuê bao di động theo giới tính:");
                    Console.WriteLine(danhBaDiDong);
                    break;
                case ChucNangTimKiemDanhBa.TimKhachHangDiDongTheoNhaCungCap:
                    Console.Write("Nhập nhà cung cấp dịch vụ (VD: VNPT, Viettel): ");
                    string nhaCungCap = Console.ReadLine();
                    var danhBaNhaCungCap = danhBa.TimKhachHangDiDongTheoNhaCungCap(nhaCungCap);
                    Console.WriteLine("Danh sách khách hàng di động theo nhà cung cấp:");
                    Console.WriteLine(danhBaNhaCungCap);
                    break;
                default:
                    Console.WriteLine("Chức năng không được hỗ trợ!");
                    break;
            }
        }

        public void Run()
        {
            ChucNangTimKiemDanhBa menu = ChucNangTimKiemDanhBa.Thoat;
            do
            {
                menu = this.Select();
                if (menu != 0)
                {
                    this.Process(menu);
                }
            } while (menu != ChucNangTimKiemDanhBa.Thoat);
        }
    }
}
