using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_D_Bai1_Lab07_QuanLySachBao_P2__
{
    public class Menu
    {
        private DanhSachTaiLieu danhSachTaiLieu;

        public Menu()
        {
            danhSachTaiLieu = new DanhSachTaiLieu();
        }

        private void Show()
        {
            Console.WriteLine("====================== MENU ======================");
            Console.WriteLine("{0}. Nhap du lieu nguon", (int)ChucNang.NhapDuLieuNguon);
            Console.WriteLine("{0}. Xuat", (int)ChucNang.Xuat);
            Console.WriteLine("{0}. Tim vi tri tai lieu theo ma so", (int)ChucNang.TimViTriTaiLieuTheoMaSoTaiLieu);
            Console.WriteLine("{0}. Tim vi tri tai lieu theo tai lieu", (int)ChucNang.TimViTriTaiLieuTheoTaiLieu);
            Console.WriteLine("{0}. Xoa tai lieu theo vi tri", (int)ChucNang.XoaTaiLieuTaiViTri);
            Console.WriteLine("{0}. Xoa tai lieu theo ma so", (int)ChucNang.XoaTaiLieuTheoMaSoTaiLieu);
            Console.WriteLine("{0}. Xoa tai lieu theo tai lieu", (int)ChucNang.XoaTaiLieuTheoTaiLieu);
            Console.WriteLine("{0}. Tim tai lieu theo tac gia", (int)ChucNang.TimTaiLieuTheoTacGia);
            Console.WriteLine("{0}. Tim sach theo nha xuat ban", (int)ChucNang.TimSachTheoNhaXuatBan);
            Console.WriteLine("{0}. Xoa sach theo nha xuat ban va so nam", (int)ChucNang.XoaSachTheoNhaXuatBan);
            Console.WriteLine("{0}. Lay danh sach nha xuat ban", (int)ChucNang.LayDanhSachNhaXuatBan);
            Console.WriteLine("{0}. Tim nha xuat ban co nhieu sach nhat", (int)ChucNang.TimNhieuSachNhat);
            Console.WriteLine("{0}. Liet ke so sach theo nha xuat ban", (int)ChucNang.LietKeSoSachTheoNhaXuatBan);
            Console.WriteLine("{0}. Sap xep sach va bao khoa hoc giam dan theo nam xuat ban", (int)ChucNang.SapXepSachVaBaoKhoaHocGiamTheoNamXuatBan);
            Console.WriteLine("{0}. Sap xep danh sach tai lieu tang dan theo nhan de", (int)ChucNang.SapXepDanhSachTangDanTheoNhanDe);
            Console.WriteLine("{0}. Tim bai bao theo hoi nghi va nam", (int)ChucNang.TimBaiBaoTheoHoiNghiVaNam);
            Console.WriteLine("{0}. Tim bai bao khoa hoc cua mot tac gia", (int)ChucNang.TimBaiBaoKhoaHocMotTacGia);
            Console.WriteLine("{0}. Tim bai bao khoa hoc co nhieu tac gia nhat", (int)ChucNang.TimBaiBaoKhoaHocNhieuTacGiaNhat);
            Console.WriteLine("{0}. Liet ke bai bao khoa hoc cua mot tac gia", (int)ChucNang.LietKeBaiBaoKhoaHocTheoTacGia);
            Console.WriteLine("{0}. Sap xep bai bao khoa hoc giam dan theo nam xuat ban", (int)ChucNang.SapXepBaiBaoKhoaHocGiamTheoNamXuatBan);
            Console.WriteLine("{0}. Liet ke bai bao khoa hoc cua mot tac gia theo ABC", (int)ChucNang.LietKeBaiBaoKhoaHocTheoTacGiaSapTheoABC);
            Console.WriteLine("{0}. Xoa tai lieu theo tac gia", (int)ChucNang.XoaTaiLieuTheoTacGia);
            Console.WriteLine("{0}. Tim tac gia cua luan van", (int)ChucNang.TimTacGiaLuanVan);
            Console.WriteLine("{0}. Tim tac gia viet sach, co đang bao khoa hoc va lam luan van", (int)ChucNang.TimTacGiaVietSachBaoKhoaHocLuanVan);
            Console.WriteLine("{0}. Liet ke tac gia", (int)ChucNang.LietKeTacGia);
            Console.WriteLine("{0}. Liet ke so luong tai lieu theo loai", (int)ChucNang.LietKeSoLuongTaiLieuTheoLoai);
            Console.WriteLine("{0}. Tim tac gia co viet bao khoa hoc, lam luan van nhưng khong viet sach", (int)ChucNang.TimTacGiaBaoKhoaHocLuanVanKhongVietSach);
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
                    danhSachTaiLieu = DuLieuNguon.TaoDanhSach();
                    break;
                case ChucNang.Xuat:
                    Console.WriteLine(danhSachTaiLieu);
                    break;
                case ChucNang.TimViTriTaiLieuTheoMaSoTaiLieu:
                    Console.Write("Nhap ma so tai lieu: ");
                    string maSoTL = Console.ReadLine();
                    int viTri = danhSachTaiLieu.TimViTriTaiLieu(maSoTL);
                    Console.WriteLine("Vi tri tai lieu: " + viTri);
                    break;
                case ChucNang.TimViTriTaiLieuTheoTaiLieu:
                    Console.WriteLine("Nhap thong tin tai lieu:");
                    TaiLieu taiLieu = NhapTaiLieu();
                    viTri = danhSachTaiLieu.TimViTriTaiLieu(taiLieu);
                    Console.WriteLine("Vị trí tài liệu: " + viTri);
                    break;
                case ChucNang.XoaTaiLieuTaiViTri:
                    Console.Write("Nhap vi tri tai lieu can xoa: ");
                    viTri = int.Parse(Console.ReadLine());
                    danhSachTaiLieu.XoaTaiLieu(viTri);
                    break;
                case ChucNang.XoaTaiLieuTheoMaSoTaiLieu:
                    Console.Write("Nhap ma so tai lieu can xoa: ");
                    maSoTL = Console.ReadLine();
                    danhSachTaiLieu.XoaTaiLieu(maSoTL);
                    break;
                case ChucNang.XoaTaiLieuTheoTaiLieu:
                    Console.WriteLine("Nhap thong tin tai lieu can xoa:");
                    taiLieu = NhapTaiLieu();
                    danhSachTaiLieu.XoaTaiLieu(taiLieu);
                    break;
                case ChucNang.TimTaiLieuTheoTacGia:
                    Console.Write("Nhap ten tac gia: ");
                    string tacGia = Console.ReadLine();
                    DanhSachTaiLieu danhSachTheoTacGia = danhSachTaiLieu.TimTaiLieuTheoTacGia(tacGia);
                    Console.WriteLine("Danh sach tai lieu cua tac gia " + tacGia + ":");
                    Console.WriteLine(danhSachTheoTacGia);
                    break;
                case ChucNang.TimSachTheoNhaXuatBan:
                    Console.Write("Nhap ten nha xuat ban: ");
                    string nhaXb = Console.ReadLine();
                    DanhSachTaiLieu danhSachTheoNhaXb = danhSachTaiLieu.TimSachTheoNhaXuatBan(nhaXb);
                    Console.WriteLine("Danh sach sach cua nha xuat ban " + nhaXb + ":");
                    Console.WriteLine(danhSachTheoNhaXb);
                    break;
                case ChucNang.XoaSachTheoNhaXuatBan:
                    Console.Write("Nhap ten nha xuat ban: ");
                    nhaXb = Console.ReadLine();
                    Console.Write("Nhap so nam cach day: ");
                    int k = int.Parse(Console.ReadLine());
                    danhSachTaiLieu.XoaSachTheoNhaXuatBan(nhaXb, k);
                    break;
                case ChucNang.LayDanhSachNhaXuatBan:
                    List<string> danhSachNhaXb = danhSachTaiLieu.LayDanhSachNhaXuatBan();
                    Console.WriteLine("Danh sach nha xuat ban:");
                    foreach (string tenNhaXb in danhSachNhaXb)
                    {
                        Console.WriteLine(tenNhaXb);
                    }
                    break;
                case ChucNang.TimNhieuSachNhat:
                    List<string> nhieuSachNhat = danhSachTaiLieu.TimNhieuSachNhat();
                    Console.WriteLine("Nha xuat ban co nhieu sach nhat:");
                    foreach (string tenNhaXb in nhieuSachNhat)
                    {
                        Console.WriteLine(tenNhaXb);
                    }
                    break;
                case ChucNang.LietKeSoSachTheoNhaXuatBan:
                    Dictionary<string, int> soSachTheoNhaXb = danhSachTaiLieu.LietKeSoSachTheoNhaXuatBan();
                    Console.WriteLine("So sach theo nha xuat ban:");
                    foreach (KeyValuePair<string, int> pair in soSachTheoNhaXb)
                    {
                        Console.WriteLine(pair.Key + ": " + pair.Value);
                    }
                    break;
                case ChucNang.SapXepSachVaBaoKhoaHocGiamTheoNamXuatBan:
                    danhSachTaiLieu.SapXepSachVaBaoKhoaHocGiamTheoNamXuatBan();
                    break;
                case ChucNang.SapXepDanhSachTangDanTheoNhanDe:
                    danhSachTaiLieu.SapXepDanhSachTangDanTheoNhanDe();
                    break;
                case ChucNang.TimBaiBaoTheoHoiNghiVaNam:
                    Console.Write("Nhap ten hoi nghi: ");
                    string hoiNghi = Console.ReadLine();
                    Console.Write("Nhap nam xuat ban: ");
                    int nam = int.Parse(Console.ReadLine());
                    List<BaoKhoaHoc> danhSachBaiBao = danhSachTaiLieu.TimBaiBaoTheoHoiNghiVaNam(hoiNghi, nam);
                    Console.WriteLine("Danh sach bai bao:");
                    foreach (BaoKhoaHoc baiBao in danhSachBaiBao)
                    {
                        Console.WriteLine(baiBao);
                    }
                    break;
                case ChucNang.TimBaiBaoKhoaHocMotTacGia:
                    List<BaoKhoaHoc> baiBaoMotTacGia = danhSachTaiLieu.TimBaiBaoKhoaHocMotTacGia();
                    Console.WriteLine("Danh sach bai bao khoa hoc co dung mot tac gia:");
                    foreach (BaoKhoaHoc baiBao in baiBaoMotTacGia)
                    {
                        Console.WriteLine(baiBao);
                    }
                    break;
                case ChucNang.TimBaiBaoKhoaHocNhieuTacGiaNhat:
                    List<BaoKhoaHoc> baiBaoNhieuTacGiaNhat = danhSachTaiLieu.TimBaiBaoKhoaHocNhieuTacGiaNhat();
                    Console.WriteLine("Danh sach bai bao khoa hoc co nhieu tac gia nhat:");
                    foreach (BaoKhoaHoc baiBao in baiBaoNhieuTacGiaNhat)
                    {
                        Console.WriteLine(baiBao);
                    }
                    break;
                case ChucNang.LietKeBaiBaoKhoaHocTheoTacGia:
                    Console.Write("Nhap ten tac gia: ");
                    tacGia = Console.ReadLine();
                    List<BaoKhoaHoc> danhSachBaiBaoTacGia = danhSachTaiLieu.LietKeBaiBaoKhoaHocTheoTacGia(tacGia);
                    Console.WriteLine("Danh sach bai bao khoa hoc cua tac gia " + tacGia + ":");
                    foreach (BaoKhoaHoc baiBao in danhSachBaiBaoTacGia)
                    {
                        Console.WriteLine(baiBao);
                    }
                    break;
                case ChucNang.SapXepBaiBaoKhoaHocGiamTheoNamXuatBan:
                    danhSachTaiLieu.SapXepBaiBaoKhoaHocGiamTheoNamXuatBan();
                    break;
                case ChucNang.LietKeBaiBaoKhoaHocTheoTacGiaSapTheoABC:
                    Console.Write("Nhap ten tac gia: ");
                    tacGia = Console.ReadLine();
                    List<BaoKhoaHoc> danhSachBaiBaoTacGiaABC = danhSachTaiLieu.LietKeBaiBaoKhoaHocTheoTacGiaSapTheoABC(tacGia);
                    Console.WriteLine("Danh sach bai bao khoa hoc cua tac gia " + tacGia + " sap theo ABC:");
                    foreach (BaoKhoaHoc baiBao in danhSachBaiBaoTacGiaABC)
                    {
                        Console.WriteLine(baiBao);
                    }
                    break;
                case ChucNang.XoaTaiLieuTheoTacGia:
                    Console.Write("Nhap ten tac gia: ");
                    tacGia = Console.ReadLine();
                    danhSachTaiLieu.XoaTaiLieuTheoTacGia(tacGia);
                    break;
                case ChucNang.TimTacGiaLuanVan:
                    List<string> tacGiaLuanVan = danhSachTaiLieu.TimTacGiaLuanVan();
                    Console.WriteLine("Danh sach tac gia lam luan van:");
                    foreach (string tenTacGia in tacGiaLuanVan)
                    {
                        Console.WriteLine(tenTacGia);
                    }
                    break;
                case ChucNang.TimTacGiaVietSachBaoKhoaHocLuanVan:
                    List<string> tacGiaVietSachBaoKhoaHocLuanVan = danhSachTaiLieu.TimTacGiaVietSachBaoKhoaHocLuanVan();
                    Console.WriteLine("Danh sach tac gia viet sach, bao khoa hoc, luan van:");
                    foreach (string tacGiaItem in tacGiaVietSachBaoKhoaHocLuanVan)
                    {
                        Console.WriteLine(tacGiaItem);
                    }
                    break;
                case ChucNang.LietKeTacGia:
                    List<string> danhSachTacGia = danhSachTaiLieu.LietKeTacGia();
                    Console.WriteLine("Danh sach tac gia:");
                    foreach (string tacGiaItem in danhSachTacGia)
                    {
                        Console.WriteLine(tacGiaItem);
                    }
                    break;
                case ChucNang.LietKeSoLuongTaiLieuTheoLoai:
                    Dictionary<string, int> soLuongTaiLieuTheoLoai = danhSachTaiLieu.LietKeSoLuongTaiLieuTheoLoai();
                    Console.WriteLine("So luong tai lieu theo loai:");
                    foreach (KeyValuePair<string, int> pair in soLuongTaiLieuTheoLoai)
                    {
                        Console.WriteLine("Tac gia: {0}, So luong tai lieu: {1}", pair.Key, pair.Value);
                    }
                    break;
                case ChucNang.TimTacGiaBaoKhoaHocLuanVanKhongVietSach:
                    List<string> tacGiaBaoKhoaHocLuanVanKhongVietSach = danhSachTaiLieu.TimTacGiaBaoKhoaHocLuanVanKhongVietSach();
                    Console.WriteLine("Danh sach tac gia bao khoa hoc, luan van khong viet sach:");
                    foreach (string tacGiaItem in tacGiaBaoKhoaHocLuanVanKhongVietSach)
                    {
                        Console.WriteLine(tacGiaItem);
                    }
                    break;
                case ChucNang.Thoat:
                    Console.WriteLine("Ket thuc chuong trinh");
                    break;
                default:
                    Console.WriteLine("Chuc nang khong hop le");
                    break;
            }
        }

        public TaiLieu NhapTaiLieu()
        {
            TaiLieu taiLieu = null;

            Console.WriteLine("Nhap ma tai lieu:");
            string maTaiLieu = Console.ReadLine();

            Console.WriteLine("Nhap ten tai lieu:");
            string nhanDe = Console.ReadLine();

            Console.WriteLine("Nhap nam xuat ban:");
            int namXB = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap ten hoi nghi:");
            string hoiNghi = Console.ReadLine();

            Console.WriteLine("Nhap nha xuat ban:");
            string nhaXB = Console.ReadLine();

            Console.WriteLine("Nhap ten tac gia:");
            string tacGia = Console.ReadLine();

            Console.WriteLine("Nhap loai tai lieu (1. BaoKhoaHoc, 2. Sach, 3. LuanVan):");
            int loaiTaiLieu = int.Parse(Console.ReadLine());
            LoaiTaiLieu phanLoai = (LoaiTaiLieu)loaiTaiLieu;

            switch (phanLoai)
            {
                case LoaiTaiLieu.BaoKhoaHoc:
                    taiLieu = new BaoKhoaHoc(maTaiLieu, nhanDe, namXB, hoiNghi, new string[] { tacGia });
                    break;
                case LoaiTaiLieu.Sach:
                    taiLieu = new Sach(maTaiLieu, nhanDe, namXB, nhaXB, new string[] { tacGia });
                    break;
                case LoaiTaiLieu.LuanVan:
                    taiLieu = new LuanVan(maTaiLieu, nhanDe, namXB, tacGia);
                    break;
                default:
                    Console.WriteLine("Loai tai lieu khong hop le!");
                    break;
            }

            return taiLieu;
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
