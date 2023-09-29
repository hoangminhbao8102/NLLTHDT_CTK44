using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_Bai01_LopDonGian
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo x = new PhanSo();

            x.TuSo = 1;
            x.MauSo = 2;

            Console.WriteLine("{0}/{1}", x.TuSo, x.MauSo);

            PhanSo y = new PhanSo(3, 4);
            y = new PhanSo(3, 4);
            y = new PhanSo(5, 10);
            y = new PhanSo(6, 12);
            y = new PhanSo(14, 20);
            y = new PhanSo(25, 10);
            y = new PhanSo(60, 20);
            y = new PhanSo(90, 30);
            y = new PhanSo(100, 50);

            Console.WriteLine("{0}/{1}", y.TuSo, y.MauSo);

            double gtx = x.TinhGiaTri();

            Console.WriteLine("{0}/{1} = {2}", x.TuSo, x.MauSo, gtx);

            double gty = y.TinhGiaTri();

            Console.WriteLine("{0}/{1} = {2}", y.TuSo, y.MauSo, gty);

            PhanSo z = y.NghichDao();

            double gtz = y.TinhGiaTri();

            Console.WriteLine("{0}/{1} = {2}", z.TuSo, z.MauSo, gtz);

            PhanSo k = new PhanSo(6, 9);

            PhanSo g = k.RutGon();

            Console.WriteLine("{0}/{1} = {2}/{3} = {4}",
                              k.TuSo, k.MauSo,
                              g.TuSo, g.MauSo,
                              g.TinhGiaTri());

            Console.WriteLine(x.ToString());
            Console.WriteLine("{0} = {1}", y.ToString(), y.TinhGiaTri());

            Console.WriteLine(z);
            Console.WriteLine("{0} = {1} = {2}",
                              k, g, g.TinhGiaTri());

            PhanSo e = new PhanSo();
            e.TuSo = 2;
            e.MauSo = 0;

            double gte = e.TinhGiaTri();

            Console.WriteLine("{0} = {1}", e, gte);

            PhanSo a = new PhanSo();
            a.TuSo = 2;
            a.MauSo = 5;

            Console.WriteLine("{0} = {1}", a, a.GiaTri);

            PhanSo d = new PhanSo(6, 4);

            PhanSo Tich = d.Nhan(a);

            PhanSo NhanK = a.Nhan(3);

            Console.WriteLine("{0} * {1} = {2}", d, a, Tich);
            Console.WriteLine("{0} * {1} = {2}", a, 3, NhanK);

            Console.ReadKey();
        }
    }
}
