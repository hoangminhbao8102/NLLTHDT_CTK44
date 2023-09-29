using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_Bai04_CacPhepToan
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 12, y = 5, KetQua;

            KetQua = x + y;
            Console.WriteLine("{0} + {1} = {2}", x, y, KetQua);

            KetQua = x - y;
            Console.WriteLine("{0} - {1} = {2}", x, y, KetQua);

            KetQua = x * y;
            Console.WriteLine("{0} * {1} = {2}", x, y, KetQua);

            KetQua = x / y;
            Console.WriteLine("{0} / {1} = {2}", x, y, KetQua);

            KetQua = x % y;
            Console.WriteLine("{0} % {1} = {2}", x, y, KetQua);

            KetQua = x++;
            Console.WriteLine("x = {0}, Ket qua = {1}", x, KetQua);

            KetQua = ++y;
            Console.WriteLine("y = {0}, Ket qua = {1}", x, KetQua);

            KetQua = x--;
            Console.WriteLine("x = {0}, Ket qua = {1}", x, KetQua);

            KetQua = --y;
            Console.WriteLine("y = {0}, Ket qua = {1}", x, KetQua);

            KetQua = ~x;
            Console.WriteLine("x = {0}, Ket qua = {1}", x, KetQua);

            KetQua = x | y;
            Console.WriteLine("{0} | {1} = {2}", x, y, KetQua);

            KetQua = x & y;
            Console.WriteLine("{0} & {1} = {2}", x, y, KetQua);

            KetQua = x << y;
            Console.WriteLine("{0} << {1} = {2}", x, y, KetQua);

            KetQua = x >> y;
            Console.WriteLine("{0} >> {1} = {2}", x, y, KetQua);

            bool logic = false;

            logic = x < y;
            Console.WriteLine("{0} < {1} : {2}", x, y, logic);

            logic = x <= y;
            Console.WriteLine("{0} <= {1} : {2}", x, y, logic);

            logic = x > y;
            Console.WriteLine("{0} > {1} : {2}", x, y, logic);

            logic = x >= y;
            Console.WriteLine("{0} >= {1} : {2}", x, y, logic);

            logic = x == y;
            Console.WriteLine("{0} == {1} : {2}", x, y, logic);

            logic = x != y;
            Console.WriteLine("{0} != {1} : {2}", x, y, logic);

            Console.WriteLine("x = {0}, y = {1}", x, y);

            x += y;
            Console.WriteLine("x = {0}, y = {1}", x, y);

            x -= y;
            Console.WriteLine("x = {0}, y = {1}", x, y);

            x *= y;
            Console.WriteLine("x = {0}, y = {1}", x, y);

            x /= y;
            Console.WriteLine("x = {0}, y = {1}", x, y);

            x %= y;
            Console.WriteLine("x = {0}, y = {1}", x, y);

            x <<= y;
            Console.WriteLine("x = {0}, y = {1}", x, y);

            bool p = true, q = false;

            logic != p;
            Console.WriteLine("!{0} = {1}", p, logic);

            logic = p && q;
            Console.WriteLine("{0} && {1} = {2}", p, q, logic);

            logic = p || q;
            Console.WriteLine("{0} || {1} = {2}", p, q, logic);

            Console.ReadKey();
        }
    }
}
