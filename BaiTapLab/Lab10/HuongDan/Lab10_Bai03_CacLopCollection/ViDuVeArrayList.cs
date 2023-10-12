using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab10_Bai03_CacLopCollection
{
    class ViDuVeArrayList
    {
        public void TaoMang()
        {
            ArrayList danhSach1 = new ArrayList();

            ArrayList danhSach2 = new ArrayList(100);

            object[] cacPt = new object[]
            {
                1, "abc", 2.25, new Random()
            };

            ArrayList danhSach3 = new ArrayList(cacPt);
        }

        public void XuatMangDungFor(ArrayList danhSach)
        {
            for (int i = 0; i < danhSach.Count; i++) 
            {
                Console.Write("{0}\t", danhSach[i]);
            }
        }

        public void XuatMangDungForEach(ArrayList danhSach)
        {
            foreach (object phanTu in danhSach)
            {
                Console.Write("{0}\t", phanTu);
            }
        }

        public void CacHamChenThem()
        {
            ArrayList danhSach = new ArrayList();

            danhSach.Add('@');
            danhSach.Add(15.75f);

            object[] cacPt = new object[]
            {
                1, "abc", 2.25, '$'
            };

            danhSach.AddRange(cacPt);

            danhSach.Insert(1, 40);
            danhSach.Insert(0, "Blah");

            XuatMangDungFor(danhSach);
        }

        public void CacHamXoa()
        {
            Random rd = new Random();
            ArrayList danhSach = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                danhSach.Add(rd.Next());
            }
            XuatMangDungFor(danhSach);

            danhSach.Remove(100);

            danhSach.RemoveAt(10);

            danhSach.RemoveRange(5, 12);

            XuatMangDungFor(danhSach);
        }

        public void TruyCapPhanTu()
        {
            Random rd = new Random();
            ArrayList danhSach = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                danhSach.Add(rd.Next());
            }
            XuatMangDungFor(danhSach);

            int tong = 0;
            for (int i = 0; i < 20; i++)
            {
                tong += (int)danhSach[i];
            }
            Console.WriteLine("Tong cac phan tu = {0}", tong);
        }
    }
}
