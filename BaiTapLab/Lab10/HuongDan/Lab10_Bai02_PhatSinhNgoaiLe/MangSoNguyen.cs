using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Bai02_PhatSinhNgoaiLe
{
    public class MangSoNguyen
    {
        private int[] mang;
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
        }

        public int this[int index]
        {
            get 
            {
                if (index < 0 || index >= soLuong)
                {
                    throw new IndexOutOfRangeException("Chi so khong hop le");
                }
                return mang[index];
            }
            set 
            {
                if (index < 0 || index >= soLuong)
                {
                    throw new IndexOutOfRangeException("Chi so khong hop le");
                }

                if (value < -1000 || value > 1000)
                {
                    throw new LoiMienGiaTri();
                }

                mang[index] = value;
            }
        }

        public void Chen(int viTri, int phanTu)
        {
            if (viTri < 0 || viTri > soLuong)
            {
                throw new IndexOutOfRangeException();
            }

            if (viTri == soLuong)
            {
                Them(phanTu);
            }
            else
            {
                if (phanTu < -1000 || phanTu > 1000)
                {
                    throw new LoiMienGiaTri();
                }

                for (int i = soLuong; i > viTri; i--)
                {
                    mang[i] = mang[i - 1];
                }

                mang[viTri] = phanTu;
                soLuong++;
            }
        }

        public MangSoNguyen()
        {
            mang = new int[0];
            soLuong = 0;
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
            if (so < -1000 || so > 1000) 
            {
                throw new LoiMienGiaTri("Gia tri hop le phai tu -1000 den 1000");
            }
            mang[soLuong] = so;
            soLuong++;
        }

        public void XuatMang()
        {
            for (int i = 0; i < soLuong; i++)
            {
                Console.Write(mang[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
