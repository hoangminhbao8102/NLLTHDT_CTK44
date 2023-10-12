using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Bai03_SuKienDonGian
{
    public delegate bool KiemTraDieuKien(int x);
    public delegate void XuLyThem(int phanTu);

    public class MangSoNguyen
    {
        public event XuLyThem ThemThanhCong;

        protected virtual void PhatSinhSuKienThemThanhCong(int phanTu)
        {
            if (ThemThanhCong != null)
            {
                ThemThanhCong(phanTu);
            }
        }

        private int[] mang;
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
        }

        public int this[int index]
        {
            get { return mang[index]; }
            set { mang[index] = value; }
        }

        public MangSoNguyen()
        {
            mang = new int[0];
            soLuong = 0;
        }

        public MangSoNguyen(int soPt, int giaTri)
        {
            mang = new int[soPt];
            for (int i = 0; i < soPt; i++)
            {
                mang[i] = giaTri;
            }
            soLuong = soPt;
        }

        public void NhapNgauNhien(int soPt)
        {
            Random random = new Random();
            mang = new int[soPt];
            for (int i = 0; i < soPt; i++)
            {
                mang[i] = random.Next();
            }
            soLuong = soPt;
        }

        public void Them(int so)
        {
            mang[soLuong] = so;
            soLuong++;

            PhatSinhSuKienThemThanhCong(so);
        }

        public void XuatMang()
        {
            for (int i = 0; i < soLuong; i++)
            {
                Console.Write(mang[i] + " ");
            }
            Console.WriteLine();
        }

        public MangSoNguyen Tim(KiemTraDieuKien kiemTra)
        {
            MangSoNguyen ketQua = new MangSoNguyen();

            for (int i = 0; i < soLuong; i++)
            {
                if (kiemTra(mang[i]))
                {
                    ketQua.Them(mang[i]);
                }
            }

            return ketQua;
        }
    }
}
