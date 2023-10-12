using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09_Bai01_DelegateDonGian
{
    public delegate int TinhToan(int x, int y);

    public class PhepToan
    {
        public int Cong(int x, int y) 
        {
            return x + y;
        }

        public int Tru(int x, int y)
        {
            return x - y;
        }

        public int Nhan(int x, int y)
        {
            return x * y;
        }

        public int Chia(int x, int y)
        {
            return x / y;
        }
    }
}
