using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Bai03_ToanTuEpKieu
{
    class Program
    {
        static void Main(string[] args)
        {
            PhanSo k = new PhanSo();

            if (k) 
            {
                Console.WriteLine("Phan so có gia tri khac 0");
            }
            else
            {
                Console.WriteLine("Phan so co gia tri bang 0");
            }

            PhanSo HaiMot = 2;
            Console.WriteLine(HaiMot);

            PhanSo HaiBa = 2.345;
            Console.WriteLine(HaiBa);

            double x = (double)HaiMot;
            Console.WriteLine("{0} = {1}", HaiMot, x);

            x = (double)HaiBa;
            Console.WriteLine("{0} = {1}", HaiBa, x);

            Console.ReadKey();
        }
    }
}
