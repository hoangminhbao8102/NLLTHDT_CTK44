using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_D_Bai6
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            DaThuc f = new DaThuc(new double[] { -1, -7, -2, 0, 3 });
            DaThuc g = new DaThuc(new double[] { -2, 5, 0, 0, 1 });

            DaThuc h = f + g;
            DaThuc l = f - g;
            DaThuc p = f * g;
            DaThuc q = f / g;
            DaThuc k = f % g;

            Console.WriteLine("Đa thức h (f + g): ");
            h.Xuat();

            Console.WriteLine("Đa thức l (f - g): ");
            l.Xuat();

            Console.WriteLine("Đa thức p (f * g): ");
            p.Xuat();

            Console.WriteLine("Đa thức q (f / g): ");
            q.Xuat();

            Console.WriteLine("Đa thức k (f % g): ");
            k.Xuat();

            Console.ReadKey();
        }
    }
}
