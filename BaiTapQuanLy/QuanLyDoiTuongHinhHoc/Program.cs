using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDoiTuongHinhHoc
{
    class Program
    {
        static DanhSachHinhHoc danhSachHinhHoc = new DanhSachHinhHoc();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            bool tiepTuc = true;
            while (tiepTuc)
            {
                Console.WriteLine("----- MENU -----");
                Console.WriteLine("1. Thêm hình vào danh sách");
                Console.WriteLine("2. Hiển thị danh sách hình");
                Console.WriteLine("3. Tìm hình vuông có diện tích lớn nhất");
                Console.WriteLine("4. Tìm hình có diện tích lớn nhất");
                Console.WriteLine("5. Tạo tập tin dữ liệu data.txt và viết phương thức NhapTuFile");
                Console.WriteLine("6. Tìm tất cả hình vuông có diện tích, chu vi là x");
                Console.WriteLine("7. Tìm tất cả hình vuông có diện tích, chu vi nhỏ nhất");
                Console.WriteLine("8. Sắp sếp hình vuông theo chiều tăng, giảm của diện tích");
                Console.WriteLine("9. Tìm hình vuông có cạnh nhỏ nhất, lớn nhất");
                Console.WriteLine("10. Tính tổng diện tích, chu vi hình vuông");
                Console.WriteLine("11. Đếm số lượng hình vuông");
                Console.WriteLine("12. Làm tương tự các câu 6,7,8,9,10,11 cho các hình tròn, hình chữ nhật");
                Console.WriteLine("13. Sắp xếp danh sách hình vuông theo chiều tăng giảm của chu vi");
                Console.WriteLine("14. Sắp xếp danh sách hình tròn theo chiều tăng giảm của chu vi");
                Console.WriteLine("15. Sắp xếp danh sách hình chữ nhật theo chiều tăng giảm của chu vi");
                Console.WriteLine("16. Tìm các hình có diện tích lớn nhất, nhỏ nhất");
                Console.WriteLine("17. Tìm các hình có chu vi lớn nhất, nhỏ nhất");
                Console.WriteLine("18. Hiển thị tất cả các hình theo chiều tăng, giảm của diện tích");
                Console.WriteLine("19. Hiển thị tất cả các hình theo chiều tăng, giảm của chu vi");
                Console.WriteLine("20. Xóa các hình có diện tích nhỏ nhất, lớn nhất");
                Console.WriteLine("21. Xóa các hình có chu vi nhỏ nhất, lớn nhất");
                Console.WriteLine("22. Thêm hình vào vị trí x");
                Console.WriteLine("23. Xóa hình tại vị trí x");
                Console.WriteLine("24. Tính tổng diện tích, chu vi các hình");
                Console.WriteLine("25. Tìm kiểu hình có tổng diện tích, chu vi lớn nhất, nhỏ nhất");
                Console.WriteLine("26. Ghi danh sách các hình xuống file riêng: hinhtron.txt, hinhvuong.txt, hinhchunhat.txt");
                Console.WriteLine("27. Xuất kết quả tổng hợp thông tin");
                Console.WriteLine("28. In nội dung của câu 27 xuống file");
                Console.WriteLine("29. In nội dung của câu 27 ra máy in");
                Console.WriteLine("30. Thoát");
                Console.Write("Chọn chức năng (1-30): ");

                int luaChon;
                if (int.TryParse(Console.ReadLine(), out luaChon))
                {
                    switch (luaChon)
                    {
                        case 1:
                            ThemHinh();
                            break;
                        case 2:
                            Console.WriteLine("----- DANH SÁCH HÌNH -----");
                            Console.WriteLine(danhSachHinhHoc.ToString());
                            break;
                        case 3:
                            var dsHinhVuongMaxDT = danhSachHinhHoc.TimHinhVuongCoDTLonNhat();
                            Console.WriteLine("Hình vuông có diện tích lớn nhất:");
                            Console.WriteLine(dsHinhVuongMaxDT.ToString());
                            break;
                        case 4:
                            var dsHinhMaxDT = danhSachHinhHoc.TimHinhCoDTLonNhat();
                            Console.WriteLine("Hình có diện tích lớn nhất:");
                            Console.WriteLine(dsHinhMaxDT.ToString());
                            break;
                        case 5:
                            danhSachHinhHoc.NhapTuFile("data.txt");
                            Console.WriteLine("Đã nhập dữ liệu từ file data.txt.");
                            break;
                        case 6:
                            Console.Write("Nhập diện tích x: ");
                            float dt = float.Parse(Console.ReadLine());
                            Console.Write("Nhập chu vi y: ");
                            float cv = float.Parse(Console.ReadLine());
                            var dsHinhVuongDTCV = danhSachHinhHoc.TimHinhVuongCoDienTichVaChuVi(dt, cv);
                            Console.WriteLine("Các hình vuông có diện tích và chu vi là x:");
                            Console.WriteLine(dsHinhVuongDTCV.ToString());
                            break;
                        case 7:
                            var dsHinhVuongMinDTCV = danhSachHinhHoc.TimHinhVuongCoDTVaCVNhoNhat();
                            Console.WriteLine("Các hình vuông có diện tích và chu vi nhỏ nhất:");
                            Console.WriteLine(dsHinhVuongMinDTCV.ToString());
                            break;
                        case 8:
                            danhSachHinhHoc.SapXepHinhVuongTheoDienTich(true);
                            Console.WriteLine("Đã sắp xếp hình vuông theo diện tích tăng dần.");
                            break;
                        case 9:
                            var hinhVuongMin = danhSachHinhHoc.TimHinhVuongCoCanhNhoNhat();
                            var hinhVuongMax = danhSachHinhHoc.TimHinhVuongCoCanhLonNhat();
                            Console.WriteLine("Hình vuông có cạnh nhỏ nhất:");
                            Console.WriteLine(hinhVuongMin);
                            Console.WriteLine("Hình vuông có cạnh lớn nhất:");
                            Console.WriteLine(hinhVuongMax);
                            break;
                        case 10:
                            Console.WriteLine("Tổng diện tích hình vuông: " + danhSachHinhHoc.TongDienTichHinhVuong());
                            Console.WriteLine("Tổng chu vi hình vuông: " + danhSachHinhHoc.TongChuViHinhVuong());
                            break;
                        case 11:
                            Console.WriteLine("Số lượng hình vuông: " + danhSachHinhHoc.DemSoLuongHinhVuong());
                            break;
                        case 12:
                            Console.WriteLine("Nhập diện tích và chu vi cho hình tròn hoặc hình chữ nhật:");
                            Console.Write("Nhập diện tích x: ");
                            float dt1 = float.Parse(Console.ReadLine());
                            Console.Write("Nhập chu vi y: ");
                            float cv1 = float.Parse(Console.ReadLine());
                            var dsHinhTronDTCV = danhSachHinhHoc.TimHinhTronCoDienTichVaChuVi(dt1, cv1);
                            var dsHinhChuNhatDTCV = danhSachHinhHoc.TimHinhChuNhatCoDienTichVaChuVi(dt1, cv1);
                            Console.WriteLine("Các hình tròn có diện tích và chu vi là x:");
                            Console.WriteLine(dsHinhTronDTCV.ToString());
                            Console.WriteLine("Các hình chữ nhật có diện tích và chu vi là x:");
                            Console.WriteLine(dsHinhChuNhatDTCV.ToString());
                            break;
                        case 13:
                            danhSachHinhHoc.SapXepHinhVuongTheoChuVi(true);
                            Console.WriteLine("Đã sắp xếp hình vuông theo chu vi tăng dần.");
                            break;
                        case 14:
                            danhSachHinhHoc.SapXepHinhTronTheoChuVi(true);
                            Console.WriteLine("Đã sắp xếp hình tròn theo chu vi tăng dần.");
                            break;
                        case 15:
                            danhSachHinhHoc.SapXepHinhChuNhatTheoChuVi(true);
                            Console.WriteLine("Đã sắp xếp hình chữ nhật theo chu vi tăng dần.");
                            break;
                        case 16:
                            var hinhNhoNhat = danhSachHinhHoc.TimHinhCoDienTichNhoNhat();
                            var hinhLonNhat = danhSachHinhHoc.TimHinhCoDienTichLonNhat();
                            Console.WriteLine("Hình có diện tích nhỏ nhất:");
                            Console.WriteLine(hinhNhoNhat);
                            Console.WriteLine("Hình có diện tích lớn nhất:");
                            Console.WriteLine(hinhLonNhat);
                            break;
                        case 17:
                            var hinhCVNhoNhat = danhSachHinhHoc.TimHinhCoChuViNhoNhat();
                            var hinhCVLonNhat = danhSachHinhHoc.TimHinhCoChuViLonNhat();
                            Console.WriteLine("Hình có chu vi nhỏ nhất:");
                            Console.WriteLine(hinhCVNhoNhat);
                            Console.WriteLine("Hình có chu vi lớn nhất:");
                            Console.WriteLine(hinhCVLonNhat);
                            break;
                        case 18:
                            danhSachHinhHoc.HienThiTheoDienTich(true);
                            break;
                        case 19:
                            danhSachHinhHoc.HienThiTheoChuVi(true);
                            break;
                        case 20:
                            danhSachHinhHoc.XoaHinhCoDienTichNhoNhat();
                            danhSachHinhHoc.XoaHinhCoDienTichLonNhat();
                            Console.WriteLine("Đã xóa các hình có diện tích nhỏ nhất và lớn nhất.");
                            break;
                        case 21:
                            danhSachHinhHoc.XoaHinhCoChuViNhoNhat();
                            danhSachHinhHoc.XoaHinhCoChuViLonNhat();
                            Console.WriteLine("Đã xóa các hình có chu vi nhỏ nhất và lớn nhất.");
                            break;
                        case 22:
                            Console.Write("Nhập vị trí x: ");
                            int viTri = int.Parse(Console.ReadLine());
                            ThemHinh();
                            var hinhCuoi = danhSachHinhHoc.LayPhanTuCuoi();
                            if (hinhCuoi != null)
                            {
                                danhSachHinhHoc.ThemHinhTaiViTri(viTri, hinhCuoi);
                            }
                            break;
                        case 23:
                            Console.Write("Nhập vị trí x: ");
                            int viTriXoa = int.Parse(Console.ReadLine());
                            danhSachHinhHoc.XoaHinhTaiViTri(viTriXoa);
                            break;
                        case 24:
                            Console.WriteLine("Tổng diện tích các hình: " + danhSachHinhHoc.TongDienTichTatCaHinh());
                            Console.WriteLine("Tổng chu vi các hình: " + danhSachHinhHoc.TongChuViTatCaHinh());
                            break;
                        case 25:
                            Console.WriteLine("Kiểu hình có tổng diện tích lớn nhất: " + danhSachHinhHoc.KieuHinhCoTongDienTichLonNhat());
                            Console.WriteLine("Kiểu hình có tổng chu vi lớn nhất: " + danhSachHinhHoc.KieuHinhCoTongChuViLonNhat());
                            Console.WriteLine("Kiểu hình có tổng diện tích nhỏ nhất: " + danhSachHinhHoc.KieuHinhCoTongDienTichNhoNhat());
                            Console.WriteLine("Kiểu hình có tổng chu vi nhỏ nhất: " + danhSachHinhHoc.KieuHinhCoTongChuViNhoNhat());
                            break;
                        case 26:
                            danhSachHinhHoc.GhiDanhSachHinhXuongFile();
                            Console.WriteLine("Đã ghi danh sách các hình xuống file.");
                            break;
                        case 27:
                            danhSachHinhHoc.XuatKetQua();
                            break;
                        case 28:
                            danhSachHinhHoc.LuuKetQuaXuongFile("ketqua.txt");
                            Console.WriteLine("Đã lưu kết quả xuống file ketqua.txt.");
                            break;
                        case 29:
                            danhSachHinhHoc.InKetQua();
                            Console.WriteLine("Đã in kết quả.");
                            break;
                        case 30:
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

        static void ThemHinh()
        {
            Console.WriteLine("Chọn loại hình để thêm:");
            Console.WriteLine("1. Hình vuông");
            Console.WriteLine("2. Hình tròn");
            Console.WriteLine("3. Hình chữ nhật");
            Console.Write("Chọn loại hình (1-3): ");

            int loaiHinh;
            if (int.TryParse(Console.ReadLine(), out loaiHinh))
            {
                switch (loaiHinh)
                {
                    case 1:
                        Console.Write("Nhập cạnh của hình vuông: ");
                        float canh = float.Parse(Console.ReadLine());
                        HinhVuong hv = new HinhVuong(canh);
                        danhSachHinhHoc.Them(hv);
                        break;
                    case 2:
                        Console.Write("Nhập bán kính của hình tròn: ");
                        float banKinh = float.Parse(Console.ReadLine());
                        HinhTron ht = new HinhTron(banKinh);
                        danhSachHinhHoc.Them(ht);
                        break;
                    case 3:
                        Console.Write("Nhập chiều dài của hình chữ nhật: ");
                        float chieuDai = float.Parse(Console.ReadLine());
                        Console.Write("Nhập chiều rộng của hình chữ nhật: ");
                        float chieuRong = float.Parse(Console.ReadLine());
                        HinhChuNhat hcn = new HinhChuNhat(chieuDai, chieuRong);
                        danhSachHinhHoc.Them(hcn);
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
        }
    }
}
