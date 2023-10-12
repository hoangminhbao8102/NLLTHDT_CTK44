using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Bai03_CacLopCollection
{
    class ViDuVeLopQueue
    {
        public uint DaoNguocSo(uint so) 
        { 
            Queue<uint> cacChuSo = new Queue<uint>();

            while (so > 0)
            {
                cacChuSo.Enqueue(so % 10);

                so /= 10;
            }

            return GhepSo(cacChuSo);
        }

        private uint GhepSo(Queue<uint> hangDoi)
        {
            uint soMoi = 0;

            while (hangDoi.Count > 0)
            {
                uint soDu = hangDoi.Dequeue();

                soMoi = soMoi * 10 + soDu;
            }
            return soMoi;
        }
    }
}
