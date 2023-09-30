using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04_Bai03_ToanTuEpKieu
{
    class ToanHoc
    {
        public static int UCLN(int x, int y)
        {
            if (x < 0)
            {
                x = -x;
            }
            if (y < 0)
            {
                y = -y;
            }

            if (x == 0 || y == 0)
            {
                return 1;
            }

            while (x != y)
            {
                if (x > y)
                {
                    x -= y;
                }
                else
                {
                    y -= x;
                }
            }

            return x;
        }
    }
}
