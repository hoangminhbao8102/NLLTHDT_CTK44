using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05_Bai01_KeThuaVaEpKieu
{
    class Program
    {
        static void Main(string[] args)
        {
            HinhTron tron = new HinhTron(10);

            HinhTru tru = new HinhTru(10, 30);

            Console.WriteLine(tron.TinhChuVi());
            Console.WriteLine(tru.TinhChuVi());

            Console.WriteLine(tron.TinhDienTich());
            Console.WriteLine(tru.TinhDienTich());

            Console.WriteLine(tru.TinhTheTich());

            HinhTru con = new HinhTru(5, 20);
            HinhTron EpLen = con;

            Console.WriteLine("Con : {0}", con.TinhDienTich());
            Console.WriteLine("Cha : {0}", EpLen.TinhDienTich());

            HinhTru EpXuong = (HinhTru)EpLen;
            Console.WriteLine(EpXuong.TinhDienTich());

            HinhTron cha = new HinhTron(7);
            HinhTru error = (HinhTru)cha;

            if (EpLen is HinhTru)
            {
                HinhTru ong = (HinhTru)EpLen;
                Console.WriteLine(ong.TinhTheTich());
            }

            HinhTru que = EpLen as HinhTru;
            Console.WriteLine(que.TinhTheTich());

            HinhTru rong = cha as HinhTru;

            if (rong == null)
            {
                Console.WriteLine("Khong the ep hinh tron -> hinh tru");
            }

            Console.ReadKey();
        }
    }
}
