using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Bai04_TaoLopMenu
{
    class MangSoNguyen
    {
        private int[] mang;
        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
        }

        public int this[int viTri]
        {
            get { return mang[viTri]; }

            set { mang[viTri] = value; }
        }

        public MangSoNguyen()
        {
            mang = new int[1000];
            soLuong = 0;
        }

        public void Them(int so)
        {
            mang[soLuong] = so;
            soLuong++;
        }

        public void NhapMang()
        {
            Console.WriteLine("Nhap so luong phan tu cua mang:");
            int soPhanTu = int.Parse(Console.ReadLine());
            mang = new int[soPhanTu];
            Console.WriteLine("Nhap cac phan tu cua mang:");
            for (int i = 0; i < soPhanTu; i++)
            {
                Console.Write("Phan tu thu {0}: ", i + 1);
                mang[i] = int.Parse(Console.ReadLine());
            }
            soLuong = soPhanTu;
        }

        public void XuatMang()
        {
            Console.WriteLine("Cac phan tu cua mang:");
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine(mang[i]);
            }
        }

        public void NhapNgauNhien()
        {
            Console.WriteLine("Nhap so luong phan tu cua mang:");
            int soPhanTu = int.Parse(Console.ReadLine());
            mang = new int[soPhanTu];
            Random random = new Random();
            for (int i = 0; i < soPhanTu; i++)
            {
                mang[i] = random.Next(100); // Giới hạn giá trị từ 0 đến 100
            }
            soLuong = soPhanTu;
        }

        public int TinhTong()
        {
            int tong = 0;
            for (int i = 0; i < soLuong; i++)
            {
                tong += mang[i];
            }
            return tong;
        }

        public int TimSoLonNhat()
        {
            int max = mang[0];
            for (int i = 1; i < soLuong; i++)
            {
                if (mang[i] > max)
                {
                    max = mang[i];
                }
            }
            return max;
        }

        public int TimViTri(int x)
        {
            for (int i = 0; i < soLuong; i++)
            {
                if (mang[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        public int TimViTriMax()
        {
            int max = mang[0];
            int viTriMax = 0;
            for (int i = 1; i < soLuong; i++)
            {
                if (mang[i] > max)
                {
                    max = mang[i];
                    viTriMax = i;
                }
            }
            return viTriMax;
        }

        public void XoaTaiViTri(int viTri)
        {
            if (viTri >= 0 && viTri < soLuong)
            {
                for (int i = viTri; i < soLuong - 1; i++)
                {
                    mang[i] = mang[i + 1];
                }
                soLuong--;
            }
        }

        public bool XoaPhanTuX(int x)
        {
            int viTri = TimViTri(x);
            if (viTri != -1)
            {
                XoaTaiViTri(viTri);
                return true;
            }
            return false;
        }
    }
}
