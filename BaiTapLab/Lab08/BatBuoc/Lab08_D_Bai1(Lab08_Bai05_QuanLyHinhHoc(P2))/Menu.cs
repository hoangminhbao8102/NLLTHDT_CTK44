using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai1_Lab08_Bai05_QuanLyHinhHoc_P2__
{
    public class Menu
    {
        private DanhSachHinhHoc danhSachHinhHoc;
        public Menu()
        {
            danhSachHinhHoc = new DanhSachHinhHoc();
        }

        private void Show()
        {
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Nhap cac hinh hoc", (int)ChucNang.NhapCoDinh);
            Console.WriteLine("{0}. Xuat danh sach hinh hoc", (int)ChucNang.Xuat);
            Console.WriteLine("{0}. Sap xep theo dien tich va chu vi", (int)ChucNang.SapXep);
            Console.WriteLine("{0}. Tim cac doi tuong hinh hoc theo nguyen mau", (int)ChucNang.TimKiem);
            Console.WriteLine("{0}. Tinh tong dien tich cac hinh hoc", (int)ChucNang.TinhTongDienTich);
            Console.WriteLine("{0}. Tinh tong chu vi cac hinh hoc", (int)ChucNang.TinhTongChuVi);
            Console.WriteLine("{0}. Tinh tong chu vi cua cac hinh vuong", (int)ChucNang.TinhTongChuViHinhVuong);
            Console.WriteLine("{0}. Tim hinh theo loai", (int)ChucNang.TimKiemTheoLoai);
            Console.WriteLine("{0}. Tim dien tich cua hinh lon nhat", (int)ChucNang.TimDienTichLonNhat);
            Console.WriteLine("{0}. Tim hinh chu nhat co dien tich lon nhat", (int)ChucNang.TimHinhChuNhatCoDienTichLonNhat);
            Console.WriteLine("{0}. Tim hinh co chu vi lon hon dien tich", (int)ChucNang.TimHinhCoChuViLonHonDienTich);
            Console.WriteLine("{0}. Xoa hinh tai vi tri", (int)ChucNang.XoaHinhTaiViTri);
            Console.WriteLine("{0}. Xoa mot hinh hoc", (int)ChucNang.XoaHinh);
            Console.WriteLine("{0}. Xoa cac hinh thoa dieu kien", (int)ChucNang.XoaTheoDieuKien);
            Console.WriteLine("{0}. Dem so luong hinh hoc moi loai", (int)ChucNang.DemSoLuongHinhHocMoiLoai);
            Console.WriteLine("{0}. Tim hinh co chu vi nho nhat", (int)ChucNang.TimHinhCoChuViNhoNhat);
            Console.WriteLine("{0}. Xuat danh sach hinh chu nhat tang dan theo chu vi", (int)ChucNang.XuatDanhSachHinhChuNhatTangDanTheoChuVi);
            Console.WriteLine("{0}. Liet ke cac hinh chu vuong hoac hinh tron giam dan theo dien tich", (int)ChucNang.LietKeHinhChuVuongVaHinhTronGiamDanTheoDienTich);
            Console.WriteLine("{0}. Tim hinh tron co ban kinh nho nhat", (int)ChucNang.TimHinhTronCoBanKinhNhoNhat);
            Console.WriteLine("{0}. Tim hinh tron co kha nang noi tiep mot hinh vuong", (int)ChucNang.TimHinhTronNoiTiepHinhVuong);
            Console.WriteLine("{0}. Dem so luong hinh vuong co dien tich lon hon dien tich moi hinh tron", (int)ChucNang.DemSoLuongHinhVuongCoDienTichLonHonHinhTron);
            Console.WriteLine("{0}. Tinh dien tich trung binh cua cac hinh chu nhat", (int)ChucNang.TinhDienTichTrungBinhHinhChuNhat);
            Console.WriteLine("{0}. Tinh do chenh lech nho nhat ve dien tich giua cac hinh", (int)ChucNang.TinhDoChenhLechNhoNhatVeDienTich);
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
                case ChucNang.NhapCoDinh:
                    danhSachHinhHoc.NhapCoDinh();
                    break;
                case ChucNang.Xuat:
                    Console.WriteLine(danhSachHinhHoc);
                    break;
                case ChucNang.SapXep:
                    danhSachHinhHoc.SapXep(new SoSanhTheoChuVi(), ThuTu.Tang);
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Sau khi sap tang theo chu vi");
                    Console.WriteLine(danhSachHinhHoc);
                    danhSachHinhHoc.SapXep(new SoSanhTheoChuVi(), ThuTu.Giam);
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Sau khi sap giam theo chu vi");
                    Console.WriteLine(danhSachHinhHoc);
                    danhSachHinhHoc.SapXep(new SoSanhTheoDienTich(), ThuTu.Tang);
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Sau khi sap tang theo dien tich");
                    Console.WriteLine(danhSachHinhHoc);
                    danhSachHinhHoc.SapXep(new SoSanhTheoDienTich(), ThuTu.Giam);
                    Console.WriteLine("=========================================");
                    Console.WriteLine("Sau khi sap giam theo dien tich");
                    Console.WriteLine(danhSachHinhHoc);
                    break;
                case ChucNang.TimKiem:
                    Console.WriteLine("Nhap loai hinh (1: HinhTron, 2: HinhVuong, 3: HinhChuNhat):");
                    int loaiHinh = int.Parse(Console.ReadLine());
                    LoaiHinh kieuHinh = (LoaiHinh)loaiHinh;
                    DanhSachHinhHoc ketQuaTimKiem;
                    switch (kieuHinh)
                    {
                        case LoaiHinh.HinhTron:
                            ketQuaTimKiem = danhSachHinhHoc.TimKiem(new DieuKienKiemTraHinhTron());
                            break;
                        case LoaiHinh.HinhChuNhat:
                            ketQuaTimKiem = danhSachHinhHoc.TimKiem(new DieuKienKiemTraHinhChuNhat());
                            break;
                        case LoaiHinh.HinhVuong:
                            ketQuaTimKiem = danhSachHinhHoc.TimKiem(new DieuKienKiemTraHinhVuong());
                            break;
                        default:
                            Console.WriteLine("Loai hinh khong hop le!");
                            return;
                    }
                    break;
                case ChucNang.TinhTongDienTich:
                    Console.WriteLine("Tong dien tich: " + danhSachHinhHoc.TinhTongDienTich());
                    break;
                case ChucNang.TinhTongChuVi:
                    Console.WriteLine("Tong chu vi: " + danhSachHinhHoc.TinhTongChuVi());
                    break;
                case ChucNang.TinhTongChuViHinhVuong:
                    Console.WriteLine("Tong chu vi hinh vuong: " + danhSachHinhHoc.TinhTongChuViHinhVuong());
                    break;
                case ChucNang.TimKiemTheoLoai:
                    Console.WriteLine("Nhap loai hinh (1: HinhTron, 2: HinhVuong, 3: HinhChuNhat):");
                    loaiHinh = int.Parse(Console.ReadLine());
                    ketQuaTimKiem = danhSachHinhHoc.TimKiemTheoLoai((LoaiHinh)loaiHinh);
                    Console.WriteLine(ketQuaTimKiem.ToString());
                    break;
                case ChucNang.TimDienTichLonNhat:
                    Console.WriteLine("Dien tich lon nhat: " + danhSachHinhHoc.TimDienTichLonNhat());
                    break;
                case ChucNang.TimHinhChuNhatCoDienTichLonNhat:
                    HinhChuNhat hcn = danhSachHinhHoc.TimHinhChuNhatCoDienTichLonNhat();
                    if (hcn != null)
                        Console.WriteLine("Hinh chu nhat co dien tich lon nhat: " + hcn.ToString());
                    else
                        Console.WriteLine("Khong tim thay hinh chu nhat.");
                    break;
                case ChucNang.TimHinhCoChuViLonHonDienTich:
                    IHinhHoc hinh = danhSachHinhHoc.TimHinhCoChuViLonHonDienTich();
                    if (hinh != null)
                        Console.WriteLine("Hinh co chu vi lon hon dien tich: " + hinh.ToString());
                    else
                        Console.WriteLine("Khong tim thay hinh.");
                    break;
                case ChucNang.XoaHinhTaiViTri:
                    Console.WriteLine("Nhap vi tri can xoa:");
                    int viTri = int.Parse(Console.ReadLine());
                    danhSachHinhHoc.XoaHinhTaiViTri(viTri);
                    break;
                case ChucNang.XoaHinh:
                    Console.WriteLine("Nhap thong tin hinh can xoa:");
                    Console.WriteLine("Nhap loai hinh (1: HinhTron, 2: HinhVuong, 3: HinhChuNhat):");
                    loaiHinh = int.Parse(Console.ReadLine());
                    Console.WriteLine("Nhap thong tin hinh:");
                    switch (loaiHinh)
                    {
                        case 1:
                            Console.WriteLine("Nhap ban kinh:");
                            double banKinh = double.Parse(Console.ReadLine());
                            danhSachHinhHoc.XoaHinh(new HinhTron(banKinh));
                            break;
                        case 2:
                            Console.WriteLine("Nhap chieu dai:");
                            double chieuDai = double.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap chieu rong:");
                            double chieuRong = double.Parse(Console.ReadLine());
                            danhSachHinhHoc.XoaHinh(new HinhChuNhat(chieuDai, chieuRong));
                            break;
                        case 3:
                            Console.WriteLine("Nhap canh:");
                            double canh = double.Parse(Console.ReadLine());
                            danhSachHinhHoc.XoaHinh(new HinhVuong(canh));
                            break;
                        default:
                            Console.WriteLine("Loai hinh khong hop le.");
                            break;
                    }
                    break;
                case ChucNang.XoaTheoDieuKien:
                    Console.WriteLine("Nhap loai hinh (1: HinhTron, 2: HinhVuong, 3: HinhChuNhat):");
                    loaiHinh = int.Parse(Console.ReadLine());
                    kieuHinh = (LoaiHinh)loaiHinh;

                    switch (kieuHinh)
                    {
                        case LoaiHinh.HinhTron:
                            ketQuaTimKiem = danhSachHinhHoc.TimKiemTheoLoai(LoaiHinh.HinhTron);
                            break;

                        case LoaiHinh.HinhVuong:
                            ketQuaTimKiem = danhSachHinhHoc.TimKiemTheoLoai(LoaiHinh.HinhVuong);
                            break;

                        case LoaiHinh.HinhChuNhat:
                            ketQuaTimKiem = danhSachHinhHoc.TimKiemTheoLoai(LoaiHinh.HinhChuNhat);
                            break;

                        default:
                            Console.WriteLine("Loai hinh khong hop le!");
                            return;
                    }

                    danhSachHinhHoc.XoaTheoDieuKien((IDieuKienTimKiem)ketQuaTimKiem);
                    break;
                case ChucNang.DemSoLuongHinhHocMoiLoai:
                    danhSachHinhHoc.DemSoLuongHinhHocMoiLoai();
                    break;
                case ChucNang.TimHinhCoChuViNhoNhat:
                    hinh = danhSachHinhHoc.TimHinhCoChuViNhoNhat();
                    if (hinh != null)
                        Console.WriteLine("Hinh co chu vi nho nhat: " + hinh.ToString());
                    else
                        Console.WriteLine("Khong tim thay hinh.");
                    break;
                case ChucNang.XuatDanhSachHinhChuNhatTangDanTheoChuVi:
                    danhSachHinhHoc.XuatDanhSachHinhChuNhatTangDanTheoChuVi();
                    break;
                case ChucNang.LietKeHinhChuVuongVaHinhTronGiamDanTheoDienTich:
                    danhSachHinhHoc.LietKeHinhChuVuongVaHinhTronGiamDanTheoDienTich();
                    break;
                case ChucNang.TimHinhTronCoBanKinhNhoNhat:
                    HinhTron ht = danhSachHinhHoc.TimHinhTronCoBanKinhNhoNhat();
                    if (ht != null)
                        Console.WriteLine("Hinh tron co ban kinh nho nhat: " + ht.ToString());
                    else
                        Console.WriteLine("Khong tim thay hinh tron.");
                    break;
                case ChucNang.TimHinhTronNoiTiepHinhVuong:
                    Console.WriteLine("Nhap chieu dai canh hinh vuong:");
                    double chieuDaiCanh = double.Parse(Console.ReadLine());
                    HinhVuong hv = new HinhVuong(chieuDaiCanh);
                    HinhTron htn = danhSachHinhHoc.TimHinhTronNoiTiepHinhVuong(hv);
                    if (htn != null)
                        Console.WriteLine("Hinh tron noi tiep hinh vuong: " + htn.ToString());
                    else
                        Console.WriteLine("Khong tim thay hinh tron.");
                    break;
                case ChucNang.DemSoLuongHinhVuongCoDienTichLonHonHinhTron:
                    int soLuong = danhSachHinhHoc.DemSoLuongHinhVuongCoDienTichLonHonHinhTron();
                    Console.WriteLine("So luong hinh vuong co dien tich lon hon tat ca hinh tron: " + soLuong);
                    break;
                case ChucNang.TinhDienTichTrungBinhHinhChuNhat:
                    double dienTichTB = danhSachHinhHoc.TinhDienTichTrungBinhHinhChuNhat();
                    Console.WriteLine("Dien tich trung binh cua cac hinh chu nhat: " + dienTichTB);
                    break;
                case ChucNang.TinhDoChenhLechNhoNhatVeDienTich:
                    double doChenhLech = danhSachHinhHoc.TinhDoChenhLechNhoNhatVeDienTich();
                    Console.WriteLine("Do chenh lech nho nhat ve dien tich: " + doChenhLech);
                    break;
                case ChucNang.Thoat:
                    Console.WriteLine("Ket thuc chuong trinh");
                    break;
                default:
                    Console.WriteLine("Chuc nang khong hop le");
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
