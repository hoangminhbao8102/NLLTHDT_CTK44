using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Bai02_KeThuaKhongDaHinh
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
    }
}
