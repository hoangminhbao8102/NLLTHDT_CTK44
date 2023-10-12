using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Bai03_CacLopCollection
{
    class ViDuVeLopList
    {
        public void TaoMang()
        {
            List<string> mangChuoi = new List<string>();

            List<int> mangNguyen = new List<int>();

            double[] cacPt = new double[]
            {
                1, 10.03, 2.25
            };

            List<double> mangThuc = new List<double>();
        }

        public void XuatMangDungFor(List<int> danhSach)
        {
            for (int i = 0; i < danhSach.Count; i++)
            {
                Console.Write("{0}\t", danhSach[i]);
            }
        }

        public void XuatMangDungForEach(List<int> danhSach)
        {
            foreach (int phanTu in danhSach)
            {
                Console.Write("{0}\t", phanTu);
            }
        }

        public void CacHamChenThem()
        {
            List<int> danhSach = new List<int>();

            danhSach.Add(20);
            danhSach.Add(15);

            int[] cacPt = new int[] { 1, 298, 25, 122 };
            danhSach.AddRange(cacPt);

            danhSach.Insert(1, 40);
            danhSach.Insert(0, 27);

            XuatMangDungFor(danhSach);
        }

        public void CacHamXoa()
        {
            Random rd = new Random();
            List<int> danhSach = new List<int>();

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
            List<int> danhSach = new List<int>();

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
