using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_D_Bai1_Lab06_Bai02__SuDungLopTruuTuong_P2__
{
    public class DanhSachHinhHoc
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
                danhSach[i].Xuat();
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
                dtich = danhSach[i].TinhDienTich();
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
                if (danhSach[i].TinhDienTich() == dtmax)
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
                    if (danhSach[i].TinhDienTich() > danhSach[j].TinhDienTich())
                    {
                        HinhHoc tam = danhSach[i];
                        danhSach[i] = danhSach[j];
                        danhSach[j] = tam;
                    }
                }
            }
        }

        public DanhSachHinhHoc TimHinhCoDienTichNhoNhat()
        {
            double min = double.MaxValue;
            DanhSachHinhHoc ketQua = new DanhSachHinhHoc();
            for (int i = 0; i < soLuong; i++)
            {
                double dtich = danhSach[i].TinhDienTich();
                if (dtich < min)
                {
                    min = dtich;
                    ketQua = new DanhSachHinhHoc();
                    ketQua.Them(danhSach[i]);
                }
                else if (dtich == min)
                {
                    ketQua.Them(danhSach[i]);
                }
            }
            return ketQua;
        }

        public DanhSachHinhHoc TimHinhTronNhoNhat()
        {
            double min = double.MaxValue;
            DanhSachHinhHoc ketQua = new DanhSachHinhHoc();
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i] is HinhTron)
                {
                    double dtich = danhSach[i].TinhDienTich();
                    if (dtich < min)
                    {
                        min = dtich;
                        ketQua = new DanhSachHinhHoc();
                        ketQua.Them(danhSach[i]);
                    }
                    else if (dtich == min)
                    {
                        ketQua.Them(danhSach[i]);
                    }
                }
            }
            return ketQua;
        }

        public void SapGiamTheoDienTich()
        {
            for (int i = 0; i < soLuong; i++)
            {
                for (int j = i + 1; j < soLuong; j++)
                {
                    if (danhSach[i].TinhDienTich() < danhSach[j].TinhDienTich())
                    {
                        HinhHoc tam = danhSach[i];
                        danhSach[i] = danhSach[j];
                        danhSach[j] = tam;
                    }
                }
            }
        }

        public int DemSoLuongHinh(LoaiHinh kieu)
        {
            int count = 0;
            for (int i = 0; i < soLuong; i++)
            {
                if (LayKieuHinh(danhSach[i]) == kieu)
                {
                    count++;
                }
            }
            return count;
        }

        public double TinhTongDienTich()
        {
            double tong = 0;
            for (int i = 0; i < soLuong; i++)
            {
                tong += danhSach[i].TinhDienTich();
            }
            return tong;
        }

        public DanhSachHinhHoc TimHinhCoDienTichLonNhat(LoaiHinh kieu)
        {
            double max = 0;
            DanhSachHinhHoc ketQua = new DanhSachHinhHoc();
            for (int i = 0; i < soLuong; i++)
            {
                if (LayKieuHinh(danhSach[i]) == kieu)
                {
                    double dtich = danhSach[i].TinhDienTich();
                    if (dtich > max)
                    {
                        max = dtich;
                        ketQua = new DanhSachHinhHoc();
                        ketQua.Them(danhSach[i]);
                    }
                    else if (dtich == max)
                    {
                        ketQua.Them(danhSach[i]);
                    }
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
            for (int i = 0; i < soLuong; i++)
            {
                if (danhSach[i].TinhDienTich() == dt)
                {
                    ketQua.Them(danhSach[i]);
                }
            }
            return ketQua;
        }

        public bool XoaHinh(HinhHoc h)
        {
            int viTri = TimViTriCuaHinh(h);
            if (viTri >= 0)
            {
                return XoaTaiViTri(viTri);
            }
            return false;
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
            DanhSachHinhHoc ketQua = new DanhSachHinhHoc();
            for (int i = 0; i < soLuong; i++)
            {
                double chuVi = danhSach[i].TinhChuVi();
                if (chuVi < min)
                {
                    min = chuVi;
                    ketQua = new DanhSachHinhHoc();
                    ketQua.Them(danhSach[i]);
                }
                else if (chuVi == min)
                {
                    ketQua.Them(danhSach[i]);
                }
            }
            return ketQua;
        }

        public void XuatHinhTheoChieuTangGiam(LoaiHinh kieu, bool tang)
        {
            DanhSachHinhHoc ketQua = TimHinhTheoLoai(kieu);
            if (tang)
            {
                ketQua.SapTangTheoDienTich();
            }
            else
            {
                ketQua.SapGiamTheoDienTich();
            }
            ketQua.Xuat();
        }

        public double TinhTongChuVi(LoaiHinh kieu)
        {
            double tong = 0;
            for (int i = 0; i < soLuong; i++)
            {
                if (LayKieuHinh(danhSach[i]) == kieu)
                {
                    tong += danhSach[i].TinhChuVi();
                }
            }
            return tong;
        }

        public DanhSachHinhHoc TimHinhCoDienTichBangBinhPhuongChuVi()
        {
            DanhSachHinhHoc ketQua = new DanhSachHinhHoc();
            for (int i = 0; i < soLuong; i++)
            {
                double dtich = danhSach[i].TinhDienTich();
                double chuVi = danhSach[i].TinhChuVi();
                if (dtich == chuVi * chuVi)
                {
                    ketQua.Them(danhSach[i]);
                }
            }
            return ketQua;
        }

        public void SapXep(KieuSapXep ksx)
        {
            switch (ksx)
            {
                case KieuSapXep.TangTheoDienTich:
                    SapTangTheoDienTich();
                    break;
                case KieuSapXep.GiamTheoDienTich:
                    SapGiamTheoDienTich();
                    break;
                case KieuSapXep.TangTheoChuVi:
                    SapTangTheoChuVi();
                    break;
                case KieuSapXep.GiamTheoChuVi:
                    SapGiamTheoChuVi();
                    break;
            }
        }

        private void SapTangTheoChuVi()
        {
            for (int i = 0; i < soLuong; i++)
            {
                for (int j = i + 1; j < soLuong; j++)
                {
                    if (danhSach[i].TinhChuVi() > danhSach[j].TinhChuVi())
                    {
                        HinhHoc tam = danhSach[i];
                        danhSach[i] = danhSach[j];
                        danhSach[j] = tam;
                    }
                }
            }
        }

        private void SapGiamTheoChuVi()
        {
            for (int i = 0; i < soLuong; i++)
            {
                for (int j = i + 1; j < soLuong; j++)
                {
                    if (danhSach[i].TinhChuVi() < danhSach[j].TinhChuVi())
                    {
                        HinhHoc tam = danhSach[i];
                        danhSach[i] = danhSach[j];
                        danhSach[j] = tam;
                    }
                }
            }
        }
    }
}
