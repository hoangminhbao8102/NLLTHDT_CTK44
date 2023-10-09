using System;
using System.Collections.Generic;
using System.Linq;
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
                    
                    break;
                case ChucNang.TimViTriTaiLieuTheoTaiLieu:
                    
                    break;
                case ChucNang.XoaTaiLieuTaiViTri:
                    
                    break;
                case ChucNang.XoaTaiLieuTheoMaSoTaiLieu:
                    
                    break;
                case ChucNang.XoaTaiLieuTheoTaiLieu:
                    
                    break;
                case ChucNang.TimTaiLieuTheoTacGia:
                    
                    break;
                case ChucNang.TimSachTheoNhaXuatBan:
                    break;
                case ChucNang.XoaSachTheoNhaXuatBan:
                    break;
                case ChucNang.LayDanhSachNhaXuatBan:
                    break;
                case ChucNang.TimNhieuSachNhat:
                    break;
                case ChucNang.LietKeSoSachTheoNhaXuatBan:
                    break;
                case ChucNang.SapXepSachVaBaoKhoaHocGiamTheoNamXuatBan:
                    break;
                case ChucNang.SapXepDanhSachTangDanTheoNhanDe:
                    break;
                case ChucNang.TimBaiBaoTheoHoiNghiVaNam:
                    break;
                case ChucNang.TimBaiBaoKhoaHocMotTacGia:
                    break;
                case ChucNang.TimBaiBaoKhoaHocNhieuTacGiaNhat:
                    break;
                case ChucNang.LietKeBaiBaoKhoaHocTheoTacGia:
                    break;
                case ChucNang.SapXepBaiBaoKhoaHocGiamTheoNamXuatBan:
                    break;
                case ChucNang.LietKeBaiBaoKhoaHocTheoTacGiaSapTheoABC:
                    break;
                case ChucNang.XoaTaiLieuTheoTacGia:
                    break;
                case ChucNang.TimTacGiaLuanVan:
                    break;
                case ChucNang.TimTacGiaVietSachBaoKhoaHocLuanVan:
                    break;
                case ChucNang.LietKeTacGia:
                    break;
                case ChucNang.LietKeSoLuongTaiLieuTheoLoai:
                    break;
                case ChucNang.TimTacGiaBaoKhoaHocLuanVanKhongVietSach:
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
