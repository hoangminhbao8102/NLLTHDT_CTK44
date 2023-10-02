using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_D_Bai2_Lab05_Bai02_KeThuaKhongDaHinh_P3__
{
    class DanhSachHinhHoc
    {
        private HinhHoc[] danhSach;
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
        }

        public HinhHoc this[int index]
        {
            get { return danhSach[index]; }
            set { danhSach[index] = value; }
        }

        public DanhSachHinhHoc()
        {
            danhSach = new HinhHoc[100];
            soLuong = 0;
        }

        public void Them(HinhHoc hinh)
        {
            danhSach[soLuong] = hinh;
            soLuong++;
        }

        public void NhapCoDinh()
        {
            Them(new HinhTron(123));
            Them(new HinhVuong(32.14));
            Them(new HinhVuong(65));
            Them(new HinhChuNhat(30, 14.5));
            Them(new HinhChuNhat(100.789, 23.4));
            Them(new HinhVuong(3.75));
            Them(new HinhTron(10.23));
            Them(new HinhTron(90));
            Them(new HinhChuNhat(12.5, 4.2));
            Them(new HinhTron(4.5));
        }

        public void Xuat()
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] is HinhTron)
                {
                    ((HinhTron)danhSach[i]).Xuat();
                }
                else if (danhSach[i] is HinhVuong)
                {
                    ((HinhVuong)danhSach[i]).Xuat();
                }
                else if (danhSach[i] is HinhChuNhat)
                {
                    ((HinhChuNhat)danhSach[i]).Xuat();
                }
            }
        }

        private LoaiHinh LayKieuHinh(HinhHoc hinh)
        {
            if (hinh is HinhTron)
            {
                return LoaiHinh.HinhTron;
            }
            else if (hinh is HinhVuong)
            {
                return LoaiHinh.HinhVuong;
            }
            else if (hinh is HinhChuNhat)
            {
                return LoaiHinh.HinhChuNhat;
            }
            else
            {
                return LoaiHinh.TatCa;
            }
        }

        private double LayDienTich(HinhHoc hinh)
        {
            double dienTich = 0;

            if (hinh is HinhTron)
            {
                dienTich = ((HinhTron)hinh).TinhDienTich();
            }
            else if (hinh is HinhVuong)
            {
                dienTich = ((HinhVuong)hinh).TinhDienTich();
            }
            else if (hinh is HinhChuNhat)
            {
                dienTich = ((HinhChuNhat)hinh).TinhDienTich();
            }
            return dienTich;
        }

        public DanhSachHinhHoc TimHinhTheoLoai(LoaiHinh kieuHinh)
        {
            DanhSachHinhHoc ketQua = new DanhSachHinhHoc();

            for (int i = 0; i < soLuong; i++)
            {
                if (LayKieuHinh(danhSach[i]) == kieuHinh)
                {
                    ketQua.Them(danhSach[i]);
                }
            }

            return ketQua;
        }

        public double TimDienTichLonNhat()
        {
            double max = 0, dtich;
            for (int i = 0; i < soLuong; i++)
            {
                dtich = LayDienTich(danhSach[i]);
                if (dtich > max)
                {
                    max = dtich;
                }
            }
            return max;
        }

        public DanhSachHinhHoc TimHinhCoDienTichLonNhat()
        {
            double dtmax = TimDienTichLonNhat();
            DanhSachHinhHoc ketQua = new DanhSachHinhHoc();
            for (int i = 0; i < soLuong; i++)
            {
                if (LayDienTich(danhSach[i]) == dtmax)
                {
                    ketQua.Them(danhSach[i]);
                }
            }
            return ketQua;
        }

        public void SapTangTheoDienTich()
        {
            for (int i = 0; i < soLuong; i++)
            {
                for (int j = i + 1; j < soLuong; j++)
                {
                    if (LayDienTich(danhSach[i]) > LayDienTich(danhSach[j]))
                    {
                        HinhHoc tam = danhSach[i];
                        danhSach[i] = danhSach[j];
                        danhSach[j] = tam;
                    }
                }
            }
        }

        public void HoanVi(ref HinhHoc x, ref HinhHoc y)
        {
            HinhHoc temp = x;
            x = y;
            y = temp;
        }

        public int SoSanh(HinhHoc x, HinhHoc y, KieuSapXep ksx)
        {
            switch (ksx)
            {
                case KieuSapXep.TangTheoDienTich:
                    if (x.TinhDienTich() == y.TinhDienTich())
                    {
                        return 0;
                    }
                    else if (x.TinhDienTich() < y.TinhDienTich())
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                case KieuSapXep.GiamTheoDienTich:
                    if (x.TinhDienTich() == y.TinhDienTich())
                    {
                        return 0;
                    }
                    else if (x.TinhDienTich() > y.TinhDienTich())
                    {
                        return -1;
                    }
                    else
                    {
                        return 1;
                    }
                case KieuSapXep.SapTheoHinhVuongTangTheoCanh:
                    if (x is HinhVuong && y is HinhVuong)
                    {
                        double canhX = ((HinhVuong)x).ChieuDai;
                        double canhY = ((HinhVuong)y).ChieuDai;
                        if (canhX < canhY)
                        {
                            return -1;
                        }
                        else if (canhX > canhY)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (x is HinhVuong)
                    {
                        return 1;
                    }
                    else if (y is HinhVuong)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                case KieuSapXep.SapTheoHinhVuongGiamTheoCanh:
                    if (x is HinhVuong && y is HinhVuong)
                    {
                        double canhX = ((HinhVuong)x).ChieuDai;
                        double canhY = ((HinhVuong)y).ChieuDai;
                        if (canhX > canhY)
                        {
                            return -1;
                        }
                        else if (canhX < canhY)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (x is HinhVuong)
                    {
                        return 1;
                    }
                    else if (y is HinhVuong)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                case KieuSapXep.SapTheoHinhVuongTangTheoDienTich:
                    if (x is HinhVuong && y is HinhVuong)
                    {
                        double dtichX = LayDienTich(x);
                        double dtichY = LayDienTich(y);
                        if (dtichX < dtichY)
                        {
                            return -1;
                        }
                        else if (dtichX > dtichY)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (x is HinhVuong)
                    {
                        return -1;
                    }
                    else if (y is HinhVuong)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                case KieuSapXep.SapTheoHinhVuongGiamTheoDienTich:
                    if (x is HinhVuong && y is HinhVuong)
                    {
                        double dtichX = LayDienTich(x);
                        double dtichY = LayDienTich(y);
                        if (dtichX > dtichY)
                        {
                            return -1;
                        }
                        else if (dtichX < dtichY)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (x is HinhVuong)
                    {
                        return -1;
                    }
                    else if (y is HinhVuong)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                case KieuSapXep.SapTheoHinhTronTangTheoBanKinh:
                    if (x is HinhTron && y is HinhTron)
                    {
                        double banKinhX = ((HinhTron)x).BanKinh;
                        double banKinhY = ((HinhTron)y).BanKinh;
                        if (banKinhX < banKinhY)
                        {
                            return -1;
                        }
                        else if (banKinhX > banKinhY)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (x is HinhTron)
                    {
                        return 1;
                    }
                    else if (y is HinhTron)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                case KieuSapXep.SapTheoHinhTronGiamTheoBanKinh:
                    if (x is HinhTron && y is HinhTron)
                    {
                        double banKinhX = ((HinhTron)x).BanKinh;
                        double banKinhY = ((HinhTron)y).BanKinh;
                        if (banKinhX > banKinhY)
                        {
                            return -1;
                        }
                        else if (banKinhX < banKinhY)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (x is HinhTron)
                    {
                        return 1;
                    }
                    else if (y is HinhTron)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                case KieuSapXep.SapTheoHinhTronTangTheoDienTich:
                    if (x is HinhTron && y is HinhTron)
                    {
                        double dtichX = LayDienTich(x);
                        double dtichY = LayDienTich(y);
                        if (dtichX < dtichY)
                        {
                            return -1;
                        }
                        else if (dtichX > dtichY)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (x is HinhTron)
                    {
                        return -1;
                    }
                    else if (y is HinhTron)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                case KieuSapXep.SapTheoHinhTronGiamTheoDienTich:
                    if (x is HinhTron && y is HinhTron)
                    {
                        double dtichX = LayDienTich(x);
                        double dtichY = LayDienTich(y);
                        if (dtichX > dtichY)
                        {
                            return -1;
                        }
                        else if (dtichX < dtichY)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (x is HinhTron)
                    {
                        return -1;
                    }
                    else if (y is HinhTron)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                case KieuSapXep.SapTheoHinhChuNhatTangTheoChieuDai:
                    if (x is HinhChuNhat && y is HinhChuNhat)
                    {
                        double chieuDaiX = ((HinhChuNhat)x).ChieuDai;
                        double chieuDaiY = ((HinhChuNhat)y).ChieuDai;
                        if (chieuDaiX < chieuDaiY)
                        {
                            return -1;
                        }
                        else if (chieuDaiX > chieuDaiY)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (x is HinhChuNhat)
                    {
                        return 1;
                    }
                    else if (y is HinhChuNhat)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                case KieuSapXep.SapTheoHinhChuNhatGiamTheoChieuDai:
                    if (x is HinhChuNhat && y is HinhChuNhat)
                    {
                        double chieuDaiX = ((HinhChuNhat)x).ChieuDai;
                        double chieuDaiY = ((HinhChuNhat)y).ChieuDai;
                        if (chieuDaiX > chieuDaiY)
                        {
                            return -1;
                        }
                        else if (chieuDaiX < chieuDaiY)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (x is HinhChuNhat)
                    {
                        return 1;
                    }
                    else if (y is HinhChuNhat)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                case KieuSapXep.SapTheoHinhChuNhatTangTheoChieuRong:
                    if (x is HinhChuNhat && y is HinhChuNhat)
                    {
                        double chieuRongX = ((HinhChuNhat)x).ChieuRong;
                        double chieuRongY = ((HinhChuNhat)y).ChieuRong;
                        if (chieuRongX < chieuRongY)
                        {
                            return -1;
                        }
                        else if (chieuRongX > chieuRongY)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (x is HinhChuNhat)
                    {
                        return 1;
                    }
                    else if (y is HinhChuNhat)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                case KieuSapXep.SapTheoHinhChuNhatGiamTheoChieuRong:
                    if (x is HinhChuNhat && y is HinhChuNhat)
                    {
                        double chieuRongX = ((HinhChuNhat)x).ChieuRong;
                        double chieuRongY = ((HinhChuNhat)y).ChieuRong;
                        if (chieuRongX > chieuRongY)
                        {
                            return -1;
                        }
                        else if (chieuRongX < chieuRongY)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (x is HinhChuNhat)
                    {
                        return 1;
                    }
                    else if (y is HinhChuNhat)
                    {
                        return -1;
                    }
                    else
                    {
                        return 0;
                    }
                case KieuSapXep.SapTheoHinhChuNhatTangTheoDienTich:
                    if (x is HinhChuNhat && y is HinhChuNhat)
                    {
                        double dtichX = LayDienTich(x);
                        double dtichY = LayDienTich(y);
                        if (dtichX < dtichY)
                        {
                            return -1;
                        }
                        else if (dtichX > dtichY)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (x is HinhChuNhat)
                    {
                        return -1;
                    }
                    else if (y is HinhChuNhat)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                case KieuSapXep.SapTheoHinhChuNhatGiamTheoDienTich:
                    if (x is HinhChuNhat && y is HinhChuNhat)
                    {
                        double dtichX = LayDienTich(x);
                        double dtichY = LayDienTich(y);
                        if (dtichX > dtichY)
                        {
                            return -1;
                        }
                        else if (dtichX < dtichY)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                    else if (x is HinhChuNhat)
                    {
                        return -1;
                    }
                    else if (y is HinhChuNhat)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                default:
                    return 0;
            }
        }

        public void SapXep(KieuSapXep ksx)
        {
            for (int i = 0; i < soLuong - 1; i++)
            {
                for (int j = i + 1; j < soLuong; j++)
                {
                    if (SoSanh(danhSach[i], danhSach[j], ksx) > 0)
                    {
                        HoanVi(ref danhSach[i], ref danhSach[j]);
                    }
                }
            }
        }

        public DanhSachHinhHoc TimHinhCoDienTichNhoNhat()
        {
            double min = double.MaxValue;
            foreach (HinhHoc hinh in danhSach)
            {
                double dienTich = LayDienTich(hinh);
                if (dienTich < min)
                {
                    min = dienTich;
                }
            }

            DanhSachHinhHoc ketQua = new DanhSachHinhHoc();
            foreach (HinhHoc hinh in danhSach)
            {
                if (LayDienTich(hinh) == min)
                {
                    ketQua.Them(hinh);
                }
            }

            return ketQua;
        }

        public DanhSachHinhHoc TimHinhTronNhoNhat()
        {
            double min = 0;
            foreach (HinhHoc hinh in danhSach)
            {
                if (hinh is HinhTron)
                {
                    double dienTich = LayDienTich(hinh);
                    if (dienTich < min)
                    {
                        min = dienTich;
                    }
                }
            }

            DanhSachHinhHoc ketQua = new DanhSachHinhHoc();
            foreach (HinhHoc hinh in danhSach)
            {
                if (hinh is HinhTron && LayDienTich(hinh) == min)
                {
                    ketQua.Them(hinh);
                }
            }

            return ketQua;
        }

        public void SapGiamTheoDienTich()
        {
            for (int i = 0; i < soLuong - 1; i++)
            {
                for (int j = i + 1; j < soLuong; j++)
                {
                    if (LayDienTich(danhSach[i]) < LayDienTich(danhSach[j]))
                    {
                        HoanVi(ref danhSach[i], ref danhSach[j]);
                    }
                }
            }
        }

        public int DemSoLuongHinh(LoaiHinh kieu)
        {
            int count = 0;
            foreach (HinhHoc hinh in danhSach)
            {
                if (LayKieuHinh(hinh) == kieu)
                {
                    count++;
                }
            }
            return count;
        }

        public double TinhTongDienTich()
        {
            double tong = 0;
            foreach (HinhHoc hinh in danhSach)
            {
                tong += LayDienTich(hinh);
            }
            return tong;
        }

        public DanhSachHinhHoc TimHinhCoDienTichLonNhat(LoaiHinh kieu)
        {
            double max = 0;
            foreach (HinhHoc hinh in danhSach)
            {
                if (LayKieuHinh(hinh) == kieu)
                {
                    double dienTich = LayDienTich(hinh);
                    if (dienTich > max)
                    {
                        max = dienTich;
                    }
                }
            }

            DanhSachHinhHoc ketQua = new DanhSachHinhHoc();
            foreach (HinhHoc hinh in danhSach)
            {
                if (LayKieuHinh(hinh) == kieu && LayDienTich(hinh) == max)
                {
                    ketQua.Them(hinh);
                }
            }

            return ketQua;
        }

        public int TimViTriCuaHinh(HinhHoc h)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] == h)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool XoaTaiViTri(int viTri)
        {
            if (viTri < 0 || viTri >= soLuong)
            {
                return false;
            }

            for (int i = viTri; i < soLuong - 1; i++)
            {
                danhSach[i] = danhSach[i + 1];
            }

            danhSach[soLuong - 1] = null;
            soLuong--;
            return true;
        }

        public DanhSachHinhHoc TimHinhTheoDTich(double dt)
        {
            DanhSachHinhHoc ketQua = new DanhSachHinhHoc();
            foreach (HinhHoc hinh in danhSach)
            {
                if (LayDienTich(hinh) == dt)
                {
                    ketQua.Them(hinh);
                }
            }
            return ketQua;
        }

        public bool XoaHinh(HinhHoc h)
        {
            int viTri = TimViTriCuaHinh(h);
            if (viTri == -1)
            {
                return false;
            }
            return XoaTaiViTri(viTri);
        }

        public void XoaHinhTheoLoai(LoaiHinh kieu)
        {
            for (int i = soLuong - 1; i >= 0; i--)
            {
                if (LayKieuHinh(danhSach[i]) == kieu)
                {
                    XoaTaiViTri(i);
                }
            }
        }

        public DanhSachHinhHoc TimHinhCoChuViNhoNhat()
        {
            double min = double.MaxValue;
            foreach (HinhHoc hinh in danhSach)
            {
                double chuVi = hinh.TinhChuVi();
                if (chuVi < min)
                {
                    min = chuVi;
                }
            }

            DanhSachHinhHoc ketQua = new DanhSachHinhHoc();
            foreach (HinhHoc hinh in danhSach)
            {
                if (hinh.TinhChuVi() == min)
                {
                    ketQua.Them(hinh);
                }
            }

            return ketQua;
        }

        public void XuatHinhTheoChieuTangGiam(LoaiHinh kieu, bool tang)
        {
            DanhSachHinhHoc ketQua = new DanhSachHinhHoc();
            foreach (HinhHoc hinh in danhSach)
            {
                if (LayKieuHinh(hinh) == kieu)
                {
                    ketQua.Them(hinh);
                }
            }

            ketQua.SapXep(tang ? KieuSapXep.TangTheoDienTich : KieuSapXep.GiamTheoDienTich);
            ketQua.Xuat();
        }

        public double TinhTongChuVi(LoaiHinh kieu)
        {
            double tong = 0;
            foreach (HinhHoc hinh in danhSach)
            {
                if (LayKieuHinh(hinh) == kieu)
                {
                    tong += hinh.TinhChuVi();
                }
            }
            return tong;
        }

        public DanhSachHinhHoc TimHinhCoDienTichBangBinhPhuongChuVi()
        {
            DanhSachHinhHoc ketQua = new DanhSachHinhHoc();

            for (int i = 0; i < soLuong; i++)
            {
                double dienTich = LayDienTich(danhSach[i]);
                double chuVi = danhSach[i].TinhChuVi();

                if (dienTich == Math.Pow(chuVi, 2))
                {
                    ketQua.Them(danhSach[i]);
                }
            }

            return ketQua;
        }
    }
}
