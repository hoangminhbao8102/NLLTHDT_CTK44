using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDanhBa
{
    class DanhBa
    {
        ThueBao[] a = new ThueBao[100];
        int length = 0;
        public void Them(ThueBao tb)
        {
            a[length++] = tb;
        }
        public void NhapTuFile()
        {
            string path = @"data.txt";
            StreamReader sr = new StreamReader(path);
            string str = "";
            while ((str = sr.ReadLine()) != null) 
            {
                Them(new ThueBao(str));
            }
        }
        public override string ToString() 
        {
            string s = "";
            for (int i = 0; i < length; i++)
            {
                int k = i + 1;
                s += k.ToString() + ") " + a[i];
            }
            return s;
        }

        public int DemSoDTTheoThueBao(string CMND)
        {
            int dem = 0;
            for (int i = 0; i < length; i++)
            {
                if (a[i].SoCMND==CMND)
                {
                    dem++;
                }
            }
            return dem;
        }
        public int TimSoLanSoThueBaoXuatHienNhietNhat()
        {
            int max = -1;
            for (int i = 0; i < length; i++)
            {
                int dem = DemSoDTTheoThueBao(a[i].SoCMND);
                if (dem > max)
                    max = dem;
            }
            return max;
        }
        bool CoChua(ThueBao tb)
        {
            for (int i = 0; i < length; i++)
            {
                if (a[i].SoCMND == tb.SoCMND) 
                {
                    return true;
                }
            }
            return false;
        }
        public DanhBa TimThueBaoCoNhieuSDT()
        {
            DanhBa kq = new DanhBa();
            int max = TimSoLanSoThueBaoXuatHienNhietNhat();
            for (int i = 0; i < length; i++)
            {
                if (DemSoDTTheoThueBao(a[i].SoCMND) == max && !kq.CoChua(a[i])) 
                {
                    kq.Them(a[i]);
                }
            }
            return kq;
        }

        public enum KieuSapXep
        {
            TangTheoHoTen,
            GiamTheoHoTen,
            TangTheoNgaySinh,
            GiamTheoNgaySinh
        }
        public int KiemTraDieuKien(ThueBao tb1, ThueBao tb2, KieuSapXep k)
        {
            switch (k) 
            {
                case KieuSapXep.TangTheoHoTen:
                    return string.Compare(tb1.HoTen, tb2.HoTen);
                case KieuSapXep.GiamTheoHoTen:
                    return string.Compare(tb2.HoTen, tb1.HoTen);
                case KieuSapXep.TangTheoNgaySinh:
                    return tb1.NgaySinh.CompareTo(tb2.NgaySinh);
                case KieuSapXep.GiamTheoNgaySinh:
                    return tb2.NgaySinh.CompareTo(tb1.NgaySinh);
                default:
                    throw new ArgumentException("Kiểu sắp xếp không hợp lệ!");
            }
        }
        public void SapXep(KieuSapXep k)
        {
            for (int i = 0; i < length - 1; i++) 
            {
                for (int j = i + 1; j < length; j++) 
                {
                    if (KiemTraDieuKien(a[i], a[j], k) == 1) 
                    {
                        ThueBao tam = a[i];
                        a[i] = a[j];
                        a[j] = tam;
                    }
                }
            }
        }
    }
}
