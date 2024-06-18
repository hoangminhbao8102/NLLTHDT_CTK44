using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08_D_Bai2
{
    interface IInAn
    {
        int SoTrang { get; }

        void In();
        void In(int begin, int end);
    }
}
