using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab07_QuanLySachBao_Lab07_HuongDan_
{
    public class BoDocDuLieuTuBanPhim : BoDocDuLieu
    {
        private const char SEPERATOR = ',';

        private void XuatCacLuaChon()
        {
            Console.WriteLine("========CHON CHUC NANG=======");
            Console.WriteLine("1. Nhap sach");
            Console.WriteLine("2. Nhap luan van");
            Console.WriteLine("3. Nhap bao khoa hoc");
            Console.WriteLine("0. Dung viec nhap du lieu");
            Console.WriteLine("=============================");
            Console.WriteLine();
            Console.Write("Nhap mot so tu 0 den 3: ");
        }

        private int ChonChucNang()
        {
            int chon = 0;
            do
            {
                XuatCacLuaChon();
                chon = int.Parse(Console.ReadLine());
            } while (chon < 0 || chon > 3);
            return chon;
        }

        private Sach NhapSach()
        {
            Sach cuonSach = new Sach();

            Console.WriteLine();

            Console.Write("Nhap ma so sach   :");
            cuonSach.MaSo = Console.ReadLine();

            Console.Write("Nhap tua de       : ");
            cuonSach.NhanDe = Console.ReadLine();

            Console.Write("Nhap nam xuat ban : ");
            cuonSach.NamXB = int.Parse(Console.ReadLine());

            Console.Write("Nhap nha xuat ban :");
            cuonSach.NhaXB = Console.ReadLine();

            Console.WriteLine("Nhap danh sach tac gia (cach nhau boi dau phay) : ");
            string line = Console.ReadLine();
            string[] dsten = line.Split(SEPERATOR);

            for (int i = 0; i < dsten.Length; i++)
            {
                cuonSach.ThemTacGia(dsten[i]);
            }

            return cuonSach;
        }

        private BaoKhoaHoc NhapBao()
        {
            BaoKhoaHoc baiBao = new BaoKhoaHoc();

            Console.WriteLine();

            Console.Write("Nhap ma so bai bao   :");
            baiBao.MaSo = Console.ReadLine();
            
            Console.Write("Nhap tu de bai bao   :");
            baiBao.NhanDe = Console.ReadLine();
            
            Console.Write("Nhap nam xuat ban    :");
            baiBao.NamXB = int.Parse(Console.ReadLine());

            Console.Write("Nhap ten hoi nghi    :");
            baiBao.HoiNghi = Console.ReadLine();

            Console.WriteLine("Nhap danh sach tac gia (cach nhau boi dau phay) : ");
            string line = Console.ReadLine();
            string[] dsten = line.Split(SEPERATOR);

            for (int i = 0; i < dsten.Length; i++)
            {
                baiBao.ThemTacGia(dsten[i]);
            }

            return baiBao;
        }

        private LuanVan NhapLuanVan()
        {
            LuanVan baoCao = new LuanVan();

            Console.WriteLine();

            Console.Write("Nhap ma so luan van  :");
            baoCao.MaSo = Console.ReadLine();
            
            Console.Write("Nhap tua de luan van : ");
            baoCao.NhanDe = Console.ReadLine();

            Console.Write("Nhap nam xuat ban    : ");
            baoCao.NamXB = int.Parse(Console.ReadLine());
            
            Console.Write("Nhap ten tac gia     : ");
            baoCao.TacGia = Console.ReadLine();

            Console.WriteLine();

            return baoCao;
        }

        public override DanhSachTaiLieu DocDuLieu()
        {
            DanhSachTaiLieu danhSach = new DanhSachTaiLieu();

            while (true)
            {
                int chucNang = ChonChucNang();
                if (chucNang == 0)
                {
                    break;
                }

                switch (chucNang) 
                {
                    case 1: 
                        danhSach.Them(NhapSach());
                        break;
                    case 2: 
                        danhSach.Them(NhapLuanVan());
                        break;
                    case 3:
                        danhSach.Them(NhapBao());
                        break;
                }
            }
            return danhSach;
        }
    }
}
