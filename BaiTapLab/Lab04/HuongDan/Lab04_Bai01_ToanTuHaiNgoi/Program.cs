using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Bai01_ToanTuHaiNgoi
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo HaiBon = new PhanSo(2, 4);
            PhanSo MotBa = new PhanSo(1, 3);

            PhanSo ToiGian = HaiBon.RutGon();
            Console.WriteLine("{0} = {1}", HaiBon, ToiGian);

            PhanSo dao = MotBa.NghichDao();
            Console.WriteLine("{0} ==nghich dao==> {1}", MotBa, dao);

            PhanSo tong = HaiBon + MotBa;
            Console.WriteLine("{0} + {1} = {2}", HaiBon, MotBa, tong);

            tong = MotBa + 3;
            Console.WriteLine("{0} + 3 = {1}", MotBa, tong);

            PhanSo hieu = HaiBon + MotBa;

            Console.WriteLine("{0} - {1} = {2}", HaiBon, MotBa, hieu);

            hieu = MotBa - 3;
            Console.WriteLine("{0} - 3 = {1}", MotBa, hieu);

            PhanSo tich = HaiBon * MotBa;
            Console.WriteLine("{0} * {1} = {2}", HaiBon, MotBa, tich);

            tich = MotBa * 3;
            Console.WriteLine("{0} * 3 = {1}", MotBa, tich);

            PhanSo thuong = HaiBon / MotBa;

            Console.WriteLine("{0} / {1} = {2}", HaiBon, MotBa, thuong);

            thuong = MotBa / 3;
            Console.WriteLine("{0} / 3 = {1}", MotBa, thuong);

            if (ToiGian == MotBa)
            {
                Console.WriteLine("{0} == {1}", ToiGian, MotBa);
            }
            else 
            {
                Console.WriteLine("{0} != {1}", ToiGian, MotBa);
            }

            PhanSo BaNam = new PhanSo(3, 5);
            PhanSo BonBay = new PhanSo(4, 7);

            if (ToiGian != BaNam)
            {
                Console.WriteLine("{0} != {1}", ToiGian, BaNam);
            }
            else
            {
                Console.WriteLine("{0} == {1}", ToiGian, BaNam);
            }

            if(ToiGian != BonBay)
            {
                Console.WriteLine("{0} != {1}", ToiGian, BonBay);
            }
            else
            {
                Console.WriteLine("{0} == {1}", ToiGian, BonBay);
            }

            if (HaiBon > BonBay)
            {
                Console.WriteLine("{0} > {1}", HaiBon, BonBay);
            }
            else
            {
                Console.WriteLine("{0} < {1}", HaiBon, BonBay);
            }

            if (BaNam < BonBay)
            {
                Console.WriteLine("{0} < {1}", BaNam, BonBay);
            }
            else
            {
                Console.WriteLine("{0} > {1}", BaNam, BonBay);
            }

            if (MotBa >= BaNam)
            {
                Console.WriteLine("{0} >= {1}", ToiGian, BaNam);
            }
            else
            {
                Console.WriteLine("{0} <= {1}", ToiGian, BaNam);
            }

            if (MotBa <= BaNam)
            {
                Console.WriteLine("{0} <= {1}", ToiGian, BaNam);
            }
            else
            {
                Console.WriteLine("{0} >= {1}", ToiGian, BaNam);
            }

            PhanSo p = MotBa << 4;
            Console.WriteLine("{0} << 4 = {1}", MotBa, p);

            PhanSo q = MotBa >> 3;
            Console.WriteLine("{0} >> 3 = {1}", MotBa, q);

            Console.ReadKey();
        }
    }
}
