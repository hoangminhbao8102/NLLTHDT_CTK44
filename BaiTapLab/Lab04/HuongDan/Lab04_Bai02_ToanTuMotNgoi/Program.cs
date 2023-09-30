using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Bai02_ToanTuMotNgoi
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo BaSau = new PhanSo(3, 6);

            PhanSo ToiGian = !BaSau;
            Console.WriteLine("{0} = {1}", BaSau, ToiGian);

            PhanSo dao = ~BaSau;
            Console.WriteLine("{0} ==nghich dao==> {1}", BaSau, dao);

            PhanSo am = dao;
            Console.WriteLine(am);

            ToiGian++;
            Console.WriteLine(ToiGian);

            --BaSau;
            Console.WriteLine(BaSau);

            Console.ReadKey();
        }
    }
}
