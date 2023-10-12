using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10_Bai03_CacLopCollection
{
    class ViDuVeLopStack
    {
        public string DoiCoSo(uint so, uint coSo)
        {
            Stack<uint> cacSoDu = new Stack<uint>();

            while (so > 0)
            {
                cacSoDu.Push(so % coSo);

                so /= coSo;
            }
            return GhepSo(cacSoDu);
        }

        private string GhepSo(Stack<uint> nganXep) 
        {
            StringBuilder sb = new StringBuilder();

            while (nganXep.Count > 0)
            {
                uint soDu = nganXep.Pop();

                if (soDu < 10)
                {
                    sb.Append(soDu);
                }
                else
                {
                    sb.Append((char)(soDu + 55));
                }
            }
            return sb.ToString();
        }
    }
}
